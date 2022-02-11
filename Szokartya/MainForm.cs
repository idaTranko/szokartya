using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;
using CsvHelper.Configuration;
using System.IO;
using CsvHelper;

namespace Szokartya
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string szotarDatasource = string.Empty;
        private List<SzotarRekord> szotar = new List<SzotarRekord>();
        private CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
        private int szotarSelectedItemIndex = -1;
        private readonly int SULY_MIN = 0;
        private readonly int SULY_MAX = 10;
        private int szotanulasMaradek = 0;

        public MainForm()
        {
            InitializeComponent();

            SetLastColumnWidthSzotar();
            mlvSzotar.Layout += delegate
            {
                SetLastColumnWidthSzotar();
            };

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = false;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple100, Accent.Teal200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange700, Primary.DeepOrange100, Accent.Teal200, TextShade.WHITE);

            // CsvHelper
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            //
            // Beállítások beolvasása
            //
            mswSotetTema.Checked = Convert.ToBoolean(GetConfig("sotetTema"));
            setTheme(mswSotetTema.Checked);
            mtbSzotarDatasource.Text = GetConfig("szotarDatasource");
            szotarDatasource = GetConfig("szotarDatasource");

            //
            //
            //

            // ezt atirni. akkorra amikor betoljuk a maximalis elemeket
            //tbarSzotanulasSzoismeretIsmeretlen.Maximum = tbarKivalasztottSzavakSzama.Value - tbarSzotanulasSzoismeretIsmeretlen.Value;
            //tbarSzotanulasSzoismeretBizonytalan.Maximum = tbarKivalasztottSzavakSzama.Value - tbarSzotanulasSzoismeretBizonytalan.Value;
            //tbarSzotanulasSzoismeretIsmert.Maximum = tbarKivalasztottSzavakSzama.Value - tbarSzotanulasSzoismeretIsmert.Value;


            //
            // DEBUG
            //
            //
            //
            //
        }

        public static void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private void msSotetTema_CheckedChanged(object sender, EventArgs e)
        {
            SetConfig("sotetTema", Convert.ToString(mswSotetTema.Checked));
            setTheme(mswSotetTema.Checked);
        }

        public void setTheme(bool useDark)
        {
            if (useDark)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void mbtnSzotarDatasource_Click(object sender, EventArgs e)
        {
            var result = ofdSzotarDatasource.ShowDialog();
            if (result == DialogResult.OK)
            {
                mtbSzotarDatasource.Text = ofdSzotarDatasource.FileName;
                SetConfig("szotarDatasource", ofdSzotarDatasource.FileName);
                szotarDatasource = ofdSzotarDatasource.FileName;
            }
            mlvSzotar.Items.Clear();
            mbtnSzotarUjSzopar.Enabled = false;
            mbtnSzotarMentes.Enabled = false;
            ClearSzotarInputFields();
            EnableSzotarInputFields(false);
        }

        private void mbtnSzotarFrissites_Click(object sender, EventArgs e)
        {
            ReadSzotarCsv();
            FillSzotarListview();
            mbtnSzotarUjSzopar.Enabled = true;
        }

        private void ReadSzotarCsv()
        {
            using (var reader = new StreamReader(szotarDatasource))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                csv.Context.RegisterClassMap<SzotarRekordMap>();
                szotar = (csv.GetRecords<SzotarRekord>()).ToList();
            }
        }

        private void WriteSzotarCsv()
        {
            using (var writer = new StreamWriter(szotarDatasource))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<SzotarRekordMap>();
                csv.WriteRecords(szotar);
            }
        }

        private void ClearSzotarInputFields()
        {
            mtbSzotarAnyanyelv.Clear();
            mtbSzotarIdegennyelv.Clear();
            mtbSzotarSuly.Clear();
            szotarSelectedItemIndex = -1;
        }

        private void EnableSzotarInputFields(bool enable)
        {
            mtbSzotarAnyanyelv.Enabled = enable;
            mtbSzotarIdegennyelv.Enabled = enable;
            mtbSzotarSuly.Enabled = enable;
        }

        private void FillSzotarListview()
        {
            mlvSzotar.Items.Clear();
            szotar.Reverse();
            foreach (SzotarRekord item in szotar)
            {
                var row = new ListViewItem(new[] {
                    UppercaseFirst(item.Anyanyelv),
                    UppercaseFirst(item.Idegennyelv),
                    Convert.ToString(item.Suly)
                });
                mlvSzotar.Items.Add(row);
            }
            mlSzotarSzoparokDarabszama.Text = "Szópárok darabszáma: " + szotar.Count;
        }

        private void SetLastColumnWidthSzotar()
        {
            mlvSzotar.Columns[mlvSzotar.Columns.Count - 1].Width = -2;
        }

        private string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        private void mtbSzotarSuly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mbtnSzotarMentes_Click(object sender, EventArgs e)
        {
            if (ValidateSzotarInputFields())
            {
                SzotarRekord rekord = new SzotarRekord();
                rekord.Anyanyelv = mtbSzotarAnyanyelv.Text;
                rekord.Idegennyelv = mtbSzotarIdegennyelv.Text;
                rekord.Suly = Convert.ToInt32(mtbSzotarSuly.Text);
                if (szotarSelectedItemIndex == szotar.Count)
                {
                    szotar.Add(rekord);
                }
                else
                {
                    szotar[szotarSelectedItemIndex] = rekord;
                    Console.WriteLine();
                }
                WriteSzotarCsv();
                FillSzotarListview();
            }
        }

        private bool ValidateSzotarInputFields()
        {
            int suly = 0;

            if (String.IsNullOrWhiteSpace(mtbSzotarAnyanyelv.Text))
            {
                ShowSnackbar("Az anyanyelv input nem lehet üres!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(mtbSzotarIdegennyelv.Text))
            {
                ShowSnackbar("Az idegennyelv input nem lehet üres!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(mtbSzotarSuly.Text))
            {
                ShowSnackbar("Az súly input nem lehet üres!");
                return false;
            }
            if (!int.TryParse(mtbSzotarSuly.Text, out suly))
            {
                ShowSnackbar("Az súly értéknek " + SULY_MIN + " és " + SULY_MAX + " között kell lennie!");
                return false;
            }
            else
            {
                if (suly < SULY_MIN || suly > SULY_MAX)
                {
                    ShowSnackbar("Az súly értéknek " + SULY_MIN + " és " + SULY_MAX + " között kell lennie!");
                    return false;
                }
            }

            return true;
        }

        private void ShowSnackbar(String message)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar(message, 5000, "OK", false);
            SnackBarMessage.Show(this);
        }

        private void mlvSzotar_ItemActivate(object sender, EventArgs e)
        {
            EnableSzotarInputFields(true);
            szotarSelectedItemIndex = mlvSzotar.FocusedItem.Index;
            mtbSzotarAnyanyelv.Text = szotar[szotarSelectedItemIndex].Anyanyelv;
            mtbSzotarIdegennyelv.Text = szotar[szotarSelectedItemIndex].Idegennyelv;
            mtbSzotarSuly.Text = Convert.ToString(szotar[szotarSelectedItemIndex].Suly);
            mbtnSzotarTorles.Enabled = true;
            mbtnSzotarMentes.Enabled = true;
        }

        private void mbtnSzotarTorles_Click(object sender, EventArgs e)
        {
            if (szotarSelectedItemIndex >= 0)
            {
                szotar.RemoveAt(szotarSelectedItemIndex);
            }
            ClearSzotarInputFields();
            EnableSzotarInputFields(false);
            WriteSzotarCsv();
            FillSzotarListview();
            mbtnSzotarTorles.Enabled = false;
            mbtnSzotarMentes.Enabled = false;
        }

        private void mbtnSzotarUjSzopar_Click(object sender, EventArgs e)
        {
            ClearSzotarInputFields();
            EnableSzotarInputFields(true);
            mbtnSzotarMentes.Enabled = true;
            szotarSelectedItemIndex = szotar.Count;
        }

        #region SzotanulasSzoismeretBeallitasok
        private void tbarKivalasztottSzavakSzama_Scroll(object sender, EventArgs e)
        {
            mlSzotanulasKivalasztottSzavakSzamaValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            tbarSzotanulasSzoismeretIsmeretlen.Maximum = tbarKivalasztottSzavakSzama.Value;
            tbarSzotanulasSzoismeretBizonytalan.Maximum = tbarKivalasztottSzavakSzama.Value;
            tbarSzotanulasSzoismeretIsmert.Maximum = tbarKivalasztottSzavakSzama.Value;
            mlSzotanulasSzoismeretIsmeretlenMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            mlSzotanulasSzoismeretBizonytalanMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            mlSzotanulasSzoismeretIsmertMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            tbarSzotanulasSzoismeretIsmeretlen.Value = 0;
            tbarSzotanulasSzoismeretBizonytalan.Value = 0;
            tbarSzotanulasSzoismeretIsmert.Value = 0;
        }

        private int[] GetSzotanulasScrollValuesFromRatios(int maxItems, string[] scrollRatios)
        {
            int[] v = { 0, 0, 0 };
            v[0] = Convert.ToInt32(
                Math.Floor(
                    (maxItems / 100.0) * Convert.ToInt32(scrollRatios[0])
                )
            );
            v[1] = Convert.ToInt32(
                Math.Floor(
                    (maxItems / 100.0) * Convert.ToInt32(scrollRatios[1])
                )
            );
            v[2] = Convert.ToInt32(
                Math.Floor(
                    (maxItems / 100.0) * Convert.ToInt32(scrollRatios[2])
                )
            );

            // Bizonytalan darabszam "kipotlasa".
            int vsum = v[0] + v[1] + v[2];
            if (vsum < maxItems)
            {
                v[1] = maxItems - (v[0] + v[2]);
            }

            return v;
        }

        private string[] GetSzotanulasRatiosFromScrollValues(int maxItems, string[] scrollRatios)
        {
            string[] v = { "0", "0", "0" };


            return v;
        }

        private void mcbSzotanulasTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (mcbSzotanulasTemplate.SelectedIndex == 0)
            {
                var ratiosString = GetConfig("szotanulasTemplateKonnyu").Split(',');
                MessageBox.Show("test: " + ratiosString[0] + "   " + ratiosString[1] + "  " + ratiosString[2]);
                int[] ratioValues = GetSzotanulasScrollValuesFromRatios(tbarKivalasztottSzavakSzama.Value, ratiosString);
                tbarSzotanulasSzoismeretIsmeretlen.Value = ratioValues[0];
                tbarSzotanulasSzoismeretBizonytalan.Value = ratioValues[1];
                tbarSzotanulasSzoismeretIsmert.Value = ratioValues[2];
                SetSzotanulasSzoismeretScrolls();
            }
            if (mcbSzotanulasTemplate.SelectedIndex == 1)
            {
                var ratiosString = GetConfig("szotanulasTemplateHalado").Split(',');
                MessageBox.Show("test: " + ratiosString[0] + "   " + ratiosString[1] + "  " + ratiosString[2]);
                int[] ratioValues = GetSzotanulasScrollValuesFromRatios(tbarKivalasztottSzavakSzama.Value, ratiosString);
                tbarSzotanulasSzoismeretIsmeretlen.Value = ratioValues[0];
                tbarSzotanulasSzoismeretBizonytalan.Value = ratioValues[1];
                tbarSzotanulasSzoismeretIsmert.Value = ratioValues[2];
                SetSzotanulasSzoismeretScrolls();
            }
            if (mcbSzotanulasTemplate.SelectedIndex == 2)
            {
                var ratiosString = GetConfig("szotanulasTemplateNehez").Split(',');
                MessageBox.Show("test: " + ratiosString[0] + "   " + ratiosString[1] + "  " + ratiosString[2]);
                int[] ratioValues = GetSzotanulasScrollValuesFromRatios(tbarKivalasztottSzavakSzama.Value, ratiosString);
                tbarSzotanulasSzoismeretIsmeretlen.Value = ratioValues[0];
                tbarSzotanulasSzoismeretBizonytalan.Value = ratioValues[1];
                tbarSzotanulasSzoismeretIsmert.Value = ratioValues[2];
                SetSzotanulasSzoismeretScrolls();
            }
        }

        private void SetSzotanulasSzoismeretScrolls()
        {
            mlSzotanulasSzoismeretIsmeretlenValue.Text = Convert.ToString(tbarSzotanulasSzoismeretIsmeretlen.Value);
            mlSzotanulasSzoismeretBizonytalanValue.Text = Convert.ToString(tbarSzotanulasSzoismeretBizonytalan.Value);
            mlSzotanulasSzoismeretIsmertValue.Text = Convert.ToString(tbarSzotanulasSzoismeretIsmert.Value);
        }

        private void tbarSzotanulasSzoismeretIsmeretlen_Scroll(object sender, EventArgs e)
        {
            int max = tbarKivalasztottSzavakSzama.Value - (tbarSzotanulasSzoismeretBizonytalan.Value + tbarSzotanulasSzoismeretIsmert.Value);
            if (tbarSzotanulasSzoismeretIsmeretlen.Value >= max)
            {
                tbarSzotanulasSzoismeretIsmeretlen.Value = max;
            }
            SetSzotanulasSzoismeretScrolls();
        }

        private void tbarSzotanulasSzoismeretBizonytalan_Scroll(object sender, EventArgs e)
        {
            int max = tbarKivalasztottSzavakSzama.Value - (tbarSzotanulasSzoismeretIsmeretlen.Value + tbarSzotanulasSzoismeretIsmert.Value);
            if (tbarSzotanulasSzoismeretBizonytalan.Value >= max)
            {
                tbarSzotanulasSzoismeretBizonytalan.Value = max;
            }
            SetSzotanulasSzoismeretScrolls();
        }

        private void tbarSzotanulasSzoismeretIsmert_Scroll(object sender, EventArgs e)
        {
            int max = tbarKivalasztottSzavakSzama.Value - (tbarSzotanulasSzoismeretIsmeretlen.Value + tbarSzotanulasSzoismeretBizonytalan.Value);
            if (tbarSzotanulasSzoismeretIsmert.Value >= max)
            {
                tbarSzotanulasSzoismeretIsmert.Value = max;
            }
            SetSzotanulasSzoismeretScrolls();
        }

        #endregion


        private void materialCard5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            //string header = @"
            //  <html>
            //    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
            //      <head>
            //      <style>
            //        body {
            //          background-color: rgb(65, 65, 65);
            //          color: white;
            //        }
            //        h2 {
            //            /* margin-left: 20px; */
            //        }
            //        p {
            //            /* margin-left: 40px; */
            //        }
            //        </style>
            //        </head>
            //    <body>";

            //string footer = "</body></html>";
            //wbSegitseg.DocumentText = "<htm><h1>Ez a szovet</h1> </html>";
            //string text = System.IO.File.ReadAllText(@"README.md");
            //string fullHtml = string.Concat(header, mdHtml, footer);
            //System.IO.File.WriteAllText(@"C:\Users\trank\source\repos\szokartya\Szokartya\README.html", fullHtml);
            //System.IO.File.WriteAllText(@"C:\Users\trank\source\repos\szokartya\Szokartya\README.html", mdHtml);

            string text = System.IO.File.ReadAllText(@"C:\Users\trank\source\repos\szokartya\Szokartya\README.md");
            string mdHtml = Markdig.Markdown.ToHtml(text);
            wbSegitseg.DocumentText = mdHtml;

        }

        private void pbHivatkozasokBBC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bbc.com/");
        }
        
        private void mtcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = mtcMenu.SelectedTab.Text;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            pbSzotanulasSpellcheck.Image = Szokartya.Properties.Resources.checkmarkx1;
            pbSzotanulasSpellcheck.Invalidate();
        }

        private void pbSzotanulasSpellcheck_Click(object sender, EventArgs e)
        {
            
        }

        private void pbHivatkozasokCNN_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://edition.cnn.com/");
        }

        private void pbHivatkozasokEuroNews_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.euronews.com/");
        }

        private void pbHivatkozasokVOALE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://learningenglish.voanews.com/");
        }

        private void pbHivatkozasokTuneIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tunein.com/");
        }

        private void pbHivatkozasokDW_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dw.com/de/themen/s-9077");
        }

        private void pbHivatkozasokDerSpiegel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.spiegel.de/");
        }

        private void pictureBox1pbHivatkozasokDieZeit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.zeit.de/index?utm_referrer=https%3A%2F%2Fwww.google.com%2F");
        }

        private void pictureBox1pbHivatkozasokDWradio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dw.com/en/radio/s-30604");
        }

        private void pictureBox1pbHivatkozasokDeutschlandFM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.deutschland.fm/");
        }

        private void mcHivatkozasok_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private List<SzotarRekord> SzavakKivalsztasaSulySzerint(List<SzotarRekord> szotar, int maxItems, int ismeretlenDarab, int bizonytalanDarab, int ismertDarab)
        {
            List<SzotarRekord> kivalasztottSzavak = new List<SzotarRekord>(); 
            int ismeretlenSzavakKivalasztvaDarab = 0;
            int bizonytalanSzavakKivalasztvaDarab = 0;
            int ismertSzavakKivalasztvaDarab = 0;

            // Osszekeverni a szotarban a SzotarRekord-okat
            szotar.Shuffle();

            foreach (SzotarRekord rekord in szotar)
            {
                if (ismeretlenSzavakKivalasztvaDarab + bizonytalanSzavakKivalasztvaDarab + ismertSzavakKivalasztvaDarab == maxItems)
                {
                    break;
                }
                if (rekord.Suly <= 3)
                {
                    if (ismeretlenSzavakKivalasztvaDarab < ismeretlenDarab)
                    {
                        kivalasztottSzavak.Add(rekord);
                        ismeretlenSzavakKivalasztvaDarab++;
                    }
                    continue;
                }
                if (rekord.Suly >= 4 && rekord.Suly <= 7)
                {
                    if (bizonytalanSzavakKivalasztvaDarab < bizonytalanDarab)
                    {
                        kivalasztottSzavak.Add(rekord);
                        bizonytalanSzavakKivalasztvaDarab++;
                    }
                    continue;
                }
                if (rekord.Suly >= 8)
                {
                    if (ismertSzavakKivalasztvaDarab < ismertDarab)
                    {
                        kivalasztottSzavak.Add(rekord);
                        ismertSzavakKivalasztvaDarab++;
                    }
                    continue;
                }
            }

            kivalasztottSzavak.Shuffle();

            return kivalasztottSzavak;
        }





    }
    
}


/*
 * 
    
    // egyik
    List<int> szotarKivalasztottIndexek = List<int>();
    mlSzotanulasSzo.Text = szotar[szotarKivalasztottIndexek[i]].Idegennyelv;
    szotar[szotarKivalasztottIndexek[i]].IncrementSuly(-1)


    // masik
    szotar<SzotarRekord> . Suly
    int kivalasztottSzavakDarabszama = 20; // List<int> aminek 20 eleme van
    2,3,3,3,3,3,3,3,5,5,5,5,5,5,5,
    2,67,4,78,9,4,3,

 * 
 * */
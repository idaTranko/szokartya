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
using CsvHelper;
using System.IO;

namespace Szokartya
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string szotarDatasource = string.Empty;
        private List<SzotarRekord> szotar = new List<SzotarRekord>();
        private List<SzotarRekord> kivalasztottSzavak = new List<SzotarRekord>();
        private CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
        private int szotarSelectedItemIndex = -1;
        private int kivalasztottSzavakIndex = 0;
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
            mtbSzotarDatasource.Text = GetConfig("szotarDatasource");
            szotarDatasource = GetConfig("szotarDatasource");
            
            tbarKivalasztottSzavakSzama.Value = Convert.ToInt32(GetConfig("szotanulasKivalasztottSzavakSzama"));
            mcbSzotanulasTemplate.SelectedIndex = Convert.ToInt32(GetConfig("szotanulasKivalasztottTemplateIndex"));
            //
            tbarSzotanulasSzoismeretIsmeretlen.Value = Convert.ToInt32(GetConfig("szotanulasIsmeretlenSzavakSzama"));
            tbarSzotanulasSzoismeretBizonytalan.Value = Convert.ToInt32(GetConfig("szotanulasBizonytalanSzavakSzama"));
            tbarSzotanulasSzoismeretIsmert.Value = Convert.ToInt32(GetConfig("szotanulasIsmertSzavakSzama"));
            //
            tbarSzotanulasSzoismeretIsmeretlen.Maximum = tbarKivalasztottSzavakSzama.Value;
            tbarSzotanulasSzoismeretBizonytalan.Maximum = tbarKivalasztottSzavakSzama.Value;
            tbarSzotanulasSzoismeretIsmert.Maximum = tbarKivalasztottSzavakSzama.Value;
            //
            mlSzotanulasKivalasztottSzavakSzamaValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            mlSzotanulasSzoismeretIsmeretlenValue.Text = GetConfig("szotanulasIsmeretlenSzavakSzama");
            mlSzotanulasSzoismeretBizonytalanValue.Text = GetConfig("szotanulasBizonytalanSzavakSzama");
            mlSzotanulasSzoismeretIsmertValue.Text = GetConfig("szotanulasIsmertSzavakSzama");
            //
            mlSzotanulasSzoismeretIsmeretlenMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            mlSzotanulasSzoismeretBizonytalanMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);
            mlSzotanulasSzoismeretIsmertMaxValue.Text = Convert.ToString(tbarKivalasztottSzavakSzama.Value);

            //
            //
            //
            mtcMenu.SelectedIndex = 1;
            //
            //
            //



            // Themes
            var allowedThemeColors = GetConfig("allowedThemeColors").Split(',');
            foreach (string allowedThemeColor in allowedThemeColors)
            {
                mcbThemeColor.Items.Add(allowedThemeColor);
            }
            var allowedThemeAccentColors = GetConfig("allowedThemeAccentColors").Split(',');
            foreach (string allowedThemeAccentColor in allowedThemeAccentColors)
            {
                mcbThemeAccentColor.Items.Add(allowedThemeAccentColor);
            }
            // Theme
            mswThemeDarkMode.Checked = Convert.ToBoolean(GetConfig("themeDarkMode"));
            mcbThemeColor.SelectedItem = GetConfig("themeColor");
            mcbThemeColor.MaxDropDownItems = 100;
            mcbThemeAccentColor.SelectedItem = GetConfig("themeAccentColor");
            mcbThemeAccentColor.MaxDropDownItems = 100;
            if (GetConfig("themeTextShade").Equals("white"))
            {
                mswThemeTextShade.Checked = true;
                mswThemeTextShade.Text = "Theme TextShade White";
            }
            else if (GetConfig("themeTextShade").Equals("black"))
            {
                mswThemeTextShade.Checked = false;
                mswThemeTextShade.Text = "Theme TextShade Black";
            }
            else
            {
                throw new Exception("Nem letezik ilyen TextShade! Csak black vagy white lehet.");
            }
            //
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

        void SetMaterialTheme()
        {
            // Config vars
            string themeColor = GetConfig("themeColor");
            string themeAccentColor = GetConfig("themeAccentColor");
            string themeTextShade = GetConfig("themeTextShade");
            bool themeDarkMode = Convert.ToBoolean(GetConfig("themeDarkMode"));

            // MaterialSkinManager vars
            TextShade textShade = TextShade.WHITE;
            Primary primary = Primary.DeepPurple500;
            Primary darkPrimary = Primary.DeepPurple700;
            Primary lightPrimary = Primary.DeepPurple100;
            Accent accent = Accent.Teal200;

            // Fill MaterialSkinManager vars
            if (themeTextShade.Equals("white"))
            {
                textShade = TextShade.WHITE;
            }
            else if (themeTextShade.Equals("black"))
            {
                textShade = TextShade.BLACK;
            }
            else
            {
                throw new Exception("Nem letezik ilyen TextShade! Csak black vagy white lehet.");
            }

            // themeColor
            if (themeColor.Equals("Red")) { primary = Primary.Red500; darkPrimary = Primary.Red700; lightPrimary = Primary.Red100; }
            else if (themeColor.Equals("Pink")) { primary = Primary.Pink500; darkPrimary = Primary.Pink700; lightPrimary = Primary.Pink100; }
            else if (themeColor.Equals("Purple")) { primary = Primary.Purple500; darkPrimary = Primary.Purple700; lightPrimary = Primary.Purple100; }
            else if (themeColor.Equals("DeepPurple")) { primary = Primary.DeepPurple500; darkPrimary = Primary.DeepPurple700; lightPrimary = Primary.DeepPurple100; }
            else if (themeColor.Equals("Indigo")) { primary = Primary.Indigo500; darkPrimary = Primary.Indigo700; lightPrimary = Primary.Indigo100; }
            else if (themeColor.Equals("Blue")) { primary = Primary.Blue500; darkPrimary = Primary.Blue700; lightPrimary = Primary.Blue100; }
            else if (themeColor.Equals("LightBlue")) { primary = Primary.LightBlue500; darkPrimary = Primary.LightBlue700; lightPrimary = Primary.LightBlue100; }
            else if (themeColor.Equals("Cyan")) { primary = Primary.Cyan500; darkPrimary = Primary.Cyan700; lightPrimary = Primary.Cyan100; }
            else if (themeColor.Equals("Teal")) { primary = Primary.Teal500; darkPrimary = Primary.Teal700; lightPrimary = Primary.Teal100; }
            else if (themeColor.Equals("Green")) { primary = Primary.Green500; darkPrimary = Primary.Green700; lightPrimary = Primary.Green100; }
            else if (themeColor.Equals("LightGreen")) { primary = Primary.LightGreen500; darkPrimary = Primary.LightGreen700; lightPrimary = Primary.LightGreen100; }
            else if (themeColor.Equals("Lime")) { primary = Primary.Lime500; darkPrimary = Primary.Lime700; lightPrimary = Primary.Lime100; }
            else if (themeColor.Equals("Yellow")) { primary = Primary.Yellow500; darkPrimary = Primary.Yellow700; lightPrimary = Primary.Yellow100; }
            else if (themeColor.Equals("Amber")) { primary = Primary.Amber500; darkPrimary = Primary.Amber700; lightPrimary = Primary.Amber100; }
            else if (themeColor.Equals("Orange")) { primary = Primary.Orange500; darkPrimary = Primary.Orange700; lightPrimary = Primary.Orange100; }
            else if (themeColor.Equals("DeepOrange")) { primary = Primary.DeepOrange500; darkPrimary = Primary.DeepOrange700; lightPrimary = Primary.DeepOrange100; }
            else if (themeColor.Equals("Brown")) { primary = Primary.Brown500; darkPrimary = Primary.Brown700; lightPrimary = Primary.Brown100; }
            else if (themeColor.Equals("Grey")) { primary = Primary.Grey500; darkPrimary = Primary.Grey700; lightPrimary = Primary.Grey100; }
            else if (themeColor.Equals("BlueGrey")) { primary = Primary.BlueGrey500; darkPrimary = Primary.BlueGrey700; lightPrimary = Primary.BlueGrey100; }

            // themeAccentColor
            if (themeAccentColor.Equals("Red")) { accent = Accent.Red200; }
            else if (themeAccentColor.Equals("Pink")) { accent = Accent.Pink200; }
            else if (themeAccentColor.Equals("Purple")) { accent = Accent.Purple200; }
            else if (themeAccentColor.Equals("DeepPurple")) { accent = Accent.DeepPurple200; }
            else if (themeAccentColor.Equals("Indigo")) { accent = Accent.Indigo200; }
            else if (themeAccentColor.Equals("Blue")) { accent = Accent.Blue200; }
            else if (themeAccentColor.Equals("LightBlue")) { accent = Accent.LightBlue200; }
            else if (themeAccentColor.Equals("Cyan")) { accent = Accent.Cyan200; }
            else if (themeAccentColor.Equals("Teal")) { accent = Accent.Teal200; }
            else if (themeAccentColor.Equals("Green")) { accent = Accent.Green200; }
            else if (themeAccentColor.Equals("LightGreen")) { accent = Accent.LightGreen200; }
            else if (themeAccentColor.Equals("Lime")) { accent = Accent.Lime200; }
            else if (themeAccentColor.Equals("Yellow")) { accent = Accent.Yellow200; }
            else if (themeAccentColor.Equals("Amber")) { accent = Accent.Amber200; }
            else if (themeAccentColor.Equals("Orange")) { accent = Accent.Orange200; }
            else if (themeAccentColor.Equals("DeepOrange")) { accent = Accent.DeepOrange200; }

            if (themeDarkMode)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            // Set the theme
            materialSkinManager.ColorScheme = new ColorScheme(primary, darkPrimary, lightPrimary, accent, textShade);
            Invalidate();
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
            EnableSzotanulasControls(true);
            mbtnSzotarUjSzopar.Enabled = true;
        }

        #region CSVHelper Methods
        private void ReadSzotarCsv()
        {
            using (var reader = new StreamReader(szotarDatasource, Encoding.UTF8))
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
        #endregion
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
            //szotar.Reverse();
            for (int i = szotar.Count - 1; i > 0; i--)
            {
                var row = new ListViewItem(new[] {
                    UppercaseFirst(szotar[i].Anyanyelv),
                    UppercaseFirst(szotar[i].Idegennyelv),
                    Convert.ToString(szotar[i].Suly)
                });
                mlvSzotar.Items.Add(row);
            }
            //foreach (SzotarRekord item in szotar)
            //{
            //    var row = new ListViewItem(new[] {
            //        UppercaseFirst(item.Anyanyelv),
            //        UppercaseFirst(item.Idegennyelv),
            //        Convert.ToString(item.Suly)
            //    });
            //    mlvSzotar.Items.Add(row);
            //}
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
                ShowMaterialSnackbar("Az anyanyelv input nem lehet üres!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(mtbSzotarIdegennyelv.Text))
            {
                ShowMaterialSnackbar("Az idegennyelv input nem lehet üres!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(mtbSzotarSuly.Text))
            {
                ShowMaterialSnackbar("Az súly input nem lehet üres!");
                return false;
            }
            if (!int.TryParse(mtbSzotarSuly.Text, out suly))
            {
                ShowMaterialSnackbar("Az súly értéknek " + SULY_MIN + " és " + SULY_MAX + " között kell lennie!");
                return false;
            }
            else
            {
                if (suly < SULY_MIN || suly > SULY_MAX)
                {
                    ShowMaterialSnackbar("Az súly értéknek " + SULY_MIN + " és " + SULY_MAX + " között kell lennie!");
                    return false;
                }
            }

            return true;
        }

        private void ShowMaterialSnackbar(String message)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar(message, 5000, "OK", false);
            SnackBarMessage.Show(this);
        }
        private DialogResult ShowMaterialDialogOK(String title, String message)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, title, message, "OK");
            return materialDialog.ShowDialog(this);
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
            mlSzotanulasSzoismeretIsmeretlenValue.Text = "0";
            mlSzotanulasSzoismeretBizonytalanValue.Text = "0";
            mlSzotanulasSzoismeretIsmertValue.Text = "0";
            SetConfig("szotanulasKivalasztottSzavakSzama", Convert.ToString(tbarKivalasztottSzavakSzama.Value));
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
            string[] ratiosString = {};

            if (mcbSzotanulasTemplate.SelectedIndex == 0)
            {
                ratiosString = GetConfig("szotanulasTemplateKonnyu").Split(',');

            }
            if (mcbSzotanulasTemplate.SelectedIndex == 1)
            {
                ratiosString = GetConfig("szotanulasTemplateHalado").Split(',');

            }
            if (mcbSzotanulasTemplate.SelectedIndex == 2)
            {
                ratiosString = GetConfig("szotanulasTemplateNehez").Split(',');
            }

            int[] ratioValues = GetSzotanulasScrollValuesFromRatios(tbarKivalasztottSzavakSzama.Value, ratiosString);
            tbarSzotanulasSzoismeretIsmeretlen.Value = ratioValues[0];
            tbarSzotanulasSzoismeretBizonytalan.Value = ratioValues[1];
            tbarSzotanulasSzoismeretIsmert.Value = ratioValues[2];
            SetSzotanulasSzoismeretScrolls();
            SetConfig("szotanulasKivalasztottTemplateIndex", Convert.ToString(mcbSzotanulasTemplate.SelectedIndex));
            SetConfig("szotanulasIsmeretlenSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretIsmeretlen.Value));
            SetConfig("szotanulasBizonytalanSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretBizonytalan.Value));
            SetConfig("szotanulasIsmertSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretIsmert.Value));

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
            SetConfig("szotanulasIsmeretlenSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretIsmeretlen.Value));
        }

        private void tbarSzotanulasSzoismeretBizonytalan_Scroll(object sender, EventArgs e)
        {
            int max = tbarKivalasztottSzavakSzama.Value - (tbarSzotanulasSzoismeretIsmeretlen.Value + tbarSzotanulasSzoismeretIsmert.Value);
            if (tbarSzotanulasSzoismeretBizonytalan.Value >= max)
            {
                tbarSzotanulasSzoismeretBizonytalan.Value = max;
            }
            SetSzotanulasSzoismeretScrolls();
            SetConfig("szotanulasBizonytalanSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretBizonytalan.Value));
        }

        private void tbarSzotanulasSzoismeretIsmert_Scroll(object sender, EventArgs e)
        {
            int max = tbarKivalasztottSzavakSzama.Value - (tbarSzotanulasSzoismeretIsmeretlen.Value + tbarSzotanulasSzoismeretBizonytalan.Value);
            if (tbarSzotanulasSzoismeretIsmert.Value >= max)
            {
                tbarSzotanulasSzoismeretIsmert.Value = max;
            }
            SetSzotanulasSzoismeretScrolls();
            SetConfig("szotanulasIsmertSzavakSzama", Convert.ToString(tbarSzotanulasSzoismeretIsmert.Value));
        }

        #endregion

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
            if (mtcMenu.SelectedIndex == 2)
            {
                if (szotar.Count == 0)
                {
                    ShowMaterialDialogOK("Hiba", "Szótanulás használatához, töltsd be egy szótárat!");
                    EnableSzotanulasControls(false);
                }
                else
                {
                    EnableSzotanulasControls(true);
                }
            }
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

        private List<SzotarRekord> SzavakKivalsztasaSulySzerint(List<SzotarRekord> szotarToShuffle, int maxItems, int ismeretlenDarab, int bizonytalanDarab, int ismertDarab)
        {
            List<SzotarRekord> kivalasztottSzavak = new List<SzotarRekord>(); 
            int ismeretlenSzavakKivalasztvaDarab = 0;
            int bizonytalanSzavakKivalasztvaDarab = 0;
            int ismertSzavakKivalasztvaDarab = 0;

            // Osszekeverni a szotarban a SzotarRekord-okat
            szotarToShuffle.Shuffle();

            foreach (SzotarRekord rekord in szotarToShuffle)
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

        private void szokartyaMinositoPozitivBtn_Click(object sender, EventArgs e)
        {
            //ismertDarab +1//
        }

        private void mtbThemeColor_SelectedValueChanged(object sender, EventArgs e)
        {
            SetConfig("themeColor", mcbThemeColor.SelectedItem.ToString());
            SetMaterialTheme();
        }

        private void mcbThemeAccentColor_SelectedValueChanged(object sender, EventArgs e)
        {
            SetConfig("themeAccentColor", mcbThemeAccentColor.SelectedItem.ToString());
            SetMaterialTheme();
        }

        private void mswThemeTextShade_CheckedChanged(object sender, EventArgs e)
        {
            if (mswThemeTextShade.Checked)
            {
                SetConfig("themeTextShade", "white");
                mswThemeTextShade.Text = "Theme TextShade White";
            }
            else
            {
                SetConfig("themeTextShade", "black");
                mswThemeTextShade.Text = "Theme TextShade Black";
            }
            SetMaterialTheme();
        }

        private void mswThemeDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (mswThemeDarkMode.Checked == true)
            {
                SetConfig("themeDarkMode", "true");
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                SetConfig("themeDarkMode", "false");
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void mbtnSzotanulasUjSzavakTanulasa_Click(object sender, EventArgs e)
        {
            var cloneSzotar = new List<SzotarRekord>(szotar);
            kivalasztottSzavak = SzavakKivalsztasaSulySzerint(
                cloneSzotar,
                tbarKivalasztottSzavakSzama.Value,
                tbarSzotanulasSzoismeretIsmeretlen.Value,
                tbarSzotanulasSzoismeretBizonytalan.Value,
                tbarSzotanulasSzoismeretIsmert.Value
            );

            if (kivalasztottSzavak.Count > 0)
            {
                kivalasztottSzavakIndex = 0;
                mlSzotanulasProgress.Text = Convert.ToString(kivalasztottSzavakIndex) + "/" + Convert.ToString(kivalasztottSzavak.Count);
                mlSzotanulasSzoIdegen.Text = kivalasztottSzavak[kivalasztottSzavakIndex].Idegennyelv;
                mlSzotanulasSzoSuly.Text = kivalasztottSzavak[kivalasztottSzavakIndex].Suly.ToString();
            }
            else
            {
                ShowMaterialDialogOK("Hiba", "Nem tudtam kivalasztani egy szot sem a megadott beallitasokkal, valtoztasdf meg a beallitasokban a szavak aranyat");
            }

            // var x = szotar.FindIndex(a => a.Anyanyelv == kivalasztottSzavak[kivalasztottSzavakIndex].Anyanyelv);
        }

        private void EnableSzotanulasControls(bool value)
        {
            mbtnSzotanulasUjSzavakTanulasa.Enabled = value;
            mbtnSzotanulasEddigiEredmenyekMentese.Enabled = value;
            mbtnSzotanulasElozo.Enabled = value;
            mbtnSzotanulasKovetkezo.Enabled = value;
            mbtnSzotanulasNemTudom.Enabled = value;
            mbtnSzotanulasBizonytalan.Enabled = value;
            mbtnSzotanulasTudom.Enabled = value;
            mlSzotanulasSzoIdegen.Enabled = value;
            mlSzotanulasSzoAnyanyelv.Enabled = value;
            mtbSzotanulasBetuzes.Enabled = value;
            pbSzotanulasBetuzesStatusz.Enabled = value;
        }

        /*private void szokartyaMinositoNullBtn_Click(object sender, EventArgs e)
        {
        bizonytalanDarab +1
        }*/

        /*private void szokartyaMinositoNegativBtn_Click(object sender, EventArgs e)
        {
        ismeretlenDarab +1
        }*/
    }

    }


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
        //private Collection<Szotar> szotar = new Collection<Szotar>();
        private string szotarDatasource = string.Empty;
        private List<SzotarRekord> szotar = new List<SzotarRekord>();
        private CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
        private int szotarSelectedItemIndex = -1;

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


            //
            // DEBUG
            //
            SzotarRekord item = new SzotarRekord();
            item.Anyanyelv = "Kutya";
            item.Idegennyelv = "Dog";
            item.Suly = 5;

            szotar.Add(item);



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
        }

        private void mbtnSzotarFrissites_Click(object sender, EventArgs e)
        {
            ReadSzotarCsv();
            FillSzotarListview();
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
            //SzotarRekord rekord = new SzotarRekord();
            //rekord.Anyanyelv = "eger";
            //rekord.Idegennyelv = "mouse";
            //szotar.Add(rekord);

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
            foreach (SzotarRekord item in szotar)
            {
                var row = new ListViewItem(new[] {
                    UppercaseFirst(item.Anyanyelv),
                    UppercaseFirst(item.Idegennyelv),
                    Convert.ToString(item.Suly)
                });
                mlvSzotar.Items.Add(row);
            }
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
            WriteSzotarCsv();
        }

        private void mlvSzotar_ItemActivate(object sender, EventArgs e)
        {
            EnableSzotarInputFields(true);
            szotarSelectedItemIndex = mlvSzotar.FocusedItem.Index;
            mtbSzotarAnyanyelv.Text = szotar[szotarSelectedItemIndex].Anyanyelv;
            mtbSzotarIdegennyelv.Text = szotar[szotarSelectedItemIndex].Idegennyelv;
            mtbSzotarSuly.Text = Convert.ToString(szotar[szotarSelectedItemIndex].Suly);
            mbtnSzotarTorles.Enabled = true;
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
        }
    }
}

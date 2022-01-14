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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Szokartya
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        //private Collection<Szotar> szotar = new Collection<Szotar>();
        private List<SzotarRekord> szotar = new List<SzotarRekord>();

        public MainForm()
        {
            InitializeComponent();

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


            //
            // Beállítások beolvasása
            //
            mswSotetTema.Checked = Convert.ToBoolean(GetConfig("sotetTema"));
            setTheme(mswSotetTema.Checked);
            mtbSzotarDatasource.Text = GetConfig("szotarDatasource");

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
            }
        }
    }
}

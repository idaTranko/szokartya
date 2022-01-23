namespace Szokartya
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpSzotar = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.mbtnSzotarUjSzopar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnSzotarTorles = new MaterialSkin.Controls.MaterialButton();
            this.mbtnSzotarMentes = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarSuly = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtbSzotarIdegennyelv = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtbSzotarAnyanyelv = new MaterialSkin.Controls.MaterialTextBox2();
            this.mlvSzotar = new MaterialSkin.Controls.MaterialListView();
            this.chAnyanyelv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdegenNyelv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSuly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mbtnSzotarFrissites = new MaterialSkin.Controls.MaterialButton();
            this.mbtnSzotarDatasource = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarDatasource = new MaterialSkin.Controls.MaterialTextBox2();
            this.tpSzotanulas = new System.Windows.Forms.TabPage();
            this.tpHivatkozasok = new System.Windows.Forms.TabPage();
            this.tpBeallitasok = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mswSotetTema = new MaterialSkin.Controls.MaterialSwitch();
            this.tpSegitseg = new System.Windows.Forms.TabPage();
            this.ilMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.ofdSzotarDatasource = new System.Windows.Forms.OpenFileDialog();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.mlSzotarSzerkesztes = new MaterialSkin.Controls.MaterialLabel();
            this.mtcMenu.SuspendLayout();
            this.tpSzotar.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tpBeallitasok.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcMenu
            // 
            this.mtcMenu.Controls.Add(this.tpSzotar);
            this.mtcMenu.Controls.Add(this.tpSzotanulas);
            this.mtcMenu.Controls.Add(this.tpHivatkozasok);
            this.mtcMenu.Controls.Add(this.tpBeallitasok);
            this.mtcMenu.Controls.Add(this.tpSegitseg);
            this.mtcMenu.Depth = 0;
            this.mtcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMenu.ImageList = this.ilMenuIcons;
            this.mtcMenu.Location = new System.Drawing.Point(3, 64);
            this.mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMenu.Multiline = true;
            this.mtcMenu.Name = "mtcMenu";
            this.mtcMenu.SelectedIndex = 0;
            this.mtcMenu.Size = new System.Drawing.Size(1274, 653);
            this.mtcMenu.TabIndex = 0;
            // 
            // tpSzotar
            // 
            this.tpSzotar.Controls.Add(this.materialCard4);
            this.tpSzotar.Controls.Add(this.materialCard2);
            this.tpSzotar.Controls.Add(this.materialCard1);
            this.tpSzotar.ImageKey = "dictionary_64.png";
            this.tpSzotar.Location = new System.Drawing.Point(4, 39);
            this.tpSzotar.Name = "tpSzotar";
            this.tpSzotar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSzotar.Size = new System.Drawing.Size(1266, 610);
            this.tpSzotar.TabIndex = 0;
            this.tpSzotar.Text = "Szótár";
            this.tpSzotar.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.mlvSzotar);
            this.materialCard2.Controls.Add(this.mbtnSzotarTorles);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 109);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard2.Size = new System.Drawing.Size(726, 487);
            this.materialCard2.TabIndex = 1;
            // 
            // mbtnSzotarUjSzopar
            // 
            this.mbtnSzotarUjSzopar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarUjSzopar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarUjSzopar.Depth = 0;
            this.mbtnSzotarUjSzopar.HighEmphasis = true;
            this.mbtnSzotarUjSzopar.Icon = null;
            this.mbtnSzotarUjSzopar.Location = new System.Drawing.Point(220, 214);
            this.mbtnSzotarUjSzopar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnSzotarUjSzopar.MaximumSize = new System.Drawing.Size(270, 0);
            this.mbtnSzotarUjSzopar.MinimumSize = new System.Drawing.Size(270, 0);
            this.mbtnSzotarUjSzopar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSzotarUjSzopar.Name = "mbtnSzotarUjSzopar";
            this.mbtnSzotarUjSzopar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSzotarUjSzopar.Size = new System.Drawing.Size(270, 36);
            this.mbtnSzotarUjSzopar.TabIndex = 6;
            this.mbtnSzotarUjSzopar.Text = "Új szópár létrehozása";
            this.mbtnSzotarUjSzopar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSzotarUjSzopar.UseAccentColor = false;
            this.mbtnSzotarUjSzopar.UseVisualStyleBackColor = true;
            // 
            // mbtnSzotarTorles
            // 
            this.mbtnSzotarTorles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarTorles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarTorles.Depth = 0;
            this.mbtnSzotarTorles.Enabled = false;
            this.mbtnSzotarTorles.HighEmphasis = true;
            this.mbtnSzotarTorles.Icon = null;
            this.mbtnSzotarTorles.Location = new System.Drawing.Point(529, 432);
            this.mbtnSzotarTorles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnSzotarTorles.MaximumSize = new System.Drawing.Size(180, 0);
            this.mbtnSzotarTorles.MinimumSize = new System.Drawing.Size(180, 0);
            this.mbtnSzotarTorles.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSzotarTorles.Name = "mbtnSzotarTorles";
            this.mbtnSzotarTorles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSzotarTorles.Size = new System.Drawing.Size(180, 36);
            this.mbtnSzotarTorles.TabIndex = 5;
            this.mbtnSzotarTorles.Text = "Kijelölt törlése";
            this.mbtnSzotarTorles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSzotarTorles.UseAccentColor = false;
            this.mbtnSzotarTorles.UseVisualStyleBackColor = true;
            this.mbtnSzotarTorles.Click += new System.EventHandler(this.mbtnSzotarTorles_Click);
            // 
            // mbtnSzotarMentes
            // 
            this.mbtnSzotarMentes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarMentes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarMentes.Depth = 0;
            this.mbtnSzotarMentes.HighEmphasis = true;
            this.mbtnSzotarMentes.Icon = null;
            this.mbtnSzotarMentes.Location = new System.Drawing.Point(16, 214);
            this.mbtnSzotarMentes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnSzotarMentes.MaximumSize = new System.Drawing.Size(180, 0);
            this.mbtnSzotarMentes.MinimumSize = new System.Drawing.Size(180, 0);
            this.mbtnSzotarMentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSzotarMentes.Name = "mbtnSzotarMentes";
            this.mbtnSzotarMentes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSzotarMentes.Size = new System.Drawing.Size(180, 36);
            this.mbtnSzotarMentes.TabIndex = 4;
            this.mbtnSzotarMentes.Text = "Mentés";
            this.mbtnSzotarMentes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSzotarMentes.UseAccentColor = false;
            this.mbtnSzotarMentes.UseVisualStyleBackColor = true;
            this.mbtnSzotarMentes.Click += new System.EventHandler(this.mbtnSzotarMentes_Click);
            // 
            // mtbSzotarSuly
            // 
            this.mtbSzotarSuly.AnimateReadOnly = false;
            this.mtbSzotarSuly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbSzotarSuly.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbSzotarSuly.Depth = 0;
            this.mtbSzotarSuly.Enabled = false;
            this.mtbSzotarSuly.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSzotarSuly.HideSelection = true;
            this.mtbSzotarSuly.Hint = "Súly";
            this.mtbSzotarSuly.LeadingIcon = null;
            this.mtbSzotarSuly.Location = new System.Drawing.Point(16, 159);
            this.mtbSzotarSuly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbSzotarSuly.MaxLength = 32767;
            this.mtbSzotarSuly.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSzotarSuly.Name = "mtbSzotarSuly";
            this.mtbSzotarSuly.PasswordChar = '\0';
            this.mtbSzotarSuly.PrefixSuffixText = null;
            this.mtbSzotarSuly.ReadOnly = false;
            this.mtbSzotarSuly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbSzotarSuly.SelectedText = "";
            this.mtbSzotarSuly.SelectionLength = 0;
            this.mtbSzotarSuly.SelectionStart = 0;
            this.mtbSzotarSuly.ShortcutsEnabled = true;
            this.mtbSzotarSuly.Size = new System.Drawing.Size(474, 48);
            this.mtbSzotarSuly.TabIndex = 3;
            this.mtbSzotarSuly.TabStop = false;
            this.mtbSzotarSuly.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbSzotarSuly.TrailingIcon = null;
            this.mtbSzotarSuly.UseSystemPasswordChar = false;
            this.mtbSzotarSuly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbSzotarSuly_KeyPress);
            // 
            // mtbSzotarIdegennyelv
            // 
            this.mtbSzotarIdegennyelv.AnimateReadOnly = false;
            this.mtbSzotarIdegennyelv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbSzotarIdegennyelv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbSzotarIdegennyelv.Depth = 0;
            this.mtbSzotarIdegennyelv.Enabled = false;
            this.mtbSzotarIdegennyelv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSzotarIdegennyelv.HideSelection = true;
            this.mtbSzotarIdegennyelv.Hint = "Idegennyelv";
            this.mtbSzotarIdegennyelv.LeadingIcon = null;
            this.mtbSzotarIdegennyelv.Location = new System.Drawing.Point(16, 107);
            this.mtbSzotarIdegennyelv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbSzotarIdegennyelv.MaxLength = 32767;
            this.mtbSzotarIdegennyelv.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSzotarIdegennyelv.Name = "mtbSzotarIdegennyelv";
            this.mtbSzotarIdegennyelv.PasswordChar = '\0';
            this.mtbSzotarIdegennyelv.PrefixSuffixText = null;
            this.mtbSzotarIdegennyelv.ReadOnly = false;
            this.mtbSzotarIdegennyelv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbSzotarIdegennyelv.SelectedText = "";
            this.mtbSzotarIdegennyelv.SelectionLength = 0;
            this.mtbSzotarIdegennyelv.SelectionStart = 0;
            this.mtbSzotarIdegennyelv.ShortcutsEnabled = true;
            this.mtbSzotarIdegennyelv.Size = new System.Drawing.Size(474, 48);
            this.mtbSzotarIdegennyelv.TabIndex = 2;
            this.mtbSzotarIdegennyelv.TabStop = false;
            this.mtbSzotarIdegennyelv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbSzotarIdegennyelv.TrailingIcon = null;
            this.mtbSzotarIdegennyelv.UseSystemPasswordChar = false;
            // 
            // mtbSzotarAnyanyelv
            // 
            this.mtbSzotarAnyanyelv.AnimateReadOnly = false;
            this.mtbSzotarAnyanyelv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbSzotarAnyanyelv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbSzotarAnyanyelv.Depth = 0;
            this.mtbSzotarAnyanyelv.Enabled = false;
            this.mtbSzotarAnyanyelv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSzotarAnyanyelv.HideSelection = true;
            this.mtbSzotarAnyanyelv.Hint = "Anyanyelv";
            this.mtbSzotarAnyanyelv.LeadingIcon = null;
            this.mtbSzotarAnyanyelv.Location = new System.Drawing.Point(16, 55);
            this.mtbSzotarAnyanyelv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbSzotarAnyanyelv.MaxLength = 32767;
            this.mtbSzotarAnyanyelv.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSzotarAnyanyelv.Name = "mtbSzotarAnyanyelv";
            this.mtbSzotarAnyanyelv.PasswordChar = '\0';
            this.mtbSzotarAnyanyelv.PrefixSuffixText = null;
            this.mtbSzotarAnyanyelv.ReadOnly = false;
            this.mtbSzotarAnyanyelv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbSzotarAnyanyelv.SelectedText = "";
            this.mtbSzotarAnyanyelv.SelectionLength = 0;
            this.mtbSzotarAnyanyelv.SelectionStart = 0;
            this.mtbSzotarAnyanyelv.ShortcutsEnabled = true;
            this.mtbSzotarAnyanyelv.Size = new System.Drawing.Size(474, 48);
            this.mtbSzotarAnyanyelv.TabIndex = 1;
            this.mtbSzotarAnyanyelv.TabStop = false;
            this.mtbSzotarAnyanyelv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbSzotarAnyanyelv.TrailingIcon = null;
            this.mtbSzotarAnyanyelv.UseSystemPasswordChar = false;
            // 
            // mlvSzotar
            // 
            this.mlvSzotar.AutoSizeTable = false;
            this.mlvSzotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvSzotar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSzotar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAnyanyelv,
            this.chIdegenNyelv,
            this.chSuly});
            this.mlvSzotar.Depth = 0;
            this.mlvSzotar.FullRowSelect = true;
            this.mlvSzotar.HideSelection = false;
            this.mlvSzotar.Location = new System.Drawing.Point(16, 16);
            this.mlvSzotar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mlvSzotar.MinimumSize = new System.Drawing.Size(150, 81);
            this.mlvSzotar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSzotar.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSzotar.MultiSelect = false;
            this.mlvSzotar.Name = "mlvSzotar";
            this.mlvSzotar.OwnerDraw = true;
            this.mlvSzotar.Size = new System.Drawing.Size(694, 398);
            this.mlvSzotar.TabIndex = 0;
            this.mlvSzotar.UseCompatibleStateImageBehavior = false;
            this.mlvSzotar.View = System.Windows.Forms.View.Details;
            this.mlvSzotar.ItemActivate += new System.EventHandler(this.mlvSzotar_ItemActivate);
            // 
            // chAnyanyelv
            // 
            this.chAnyanyelv.Text = "Anyanyelv";
            this.chAnyanyelv.Width = 250;
            // 
            // chIdegenNyelv
            // 
            this.chIdegenNyelv.Text = "Idegennyelv";
            this.chIdegenNyelv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chIdegenNyelv.Width = 250;
            // 
            // chSuly
            // 
            this.chSuly.Text = "Súly";
            this.chSuly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSuly.Width = 80;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mbtnSzotarFrissites);
            this.materialCard1.Controls.Add(this.mbtnSzotarDatasource);
            this.materialCard1.Controls.Add(this.mtbSzotarDatasource);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard1.Size = new System.Drawing.Size(1242, 81);
            this.materialCard1.TabIndex = 0;
            // 
            // mbtnSzotarFrissites
            // 
            this.mbtnSzotarFrissites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarFrissites.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarFrissites.Depth = 0;
            this.mbtnSzotarFrissites.HighEmphasis = true;
            this.mbtnSzotarFrissites.Icon = null;
            this.mbtnSzotarFrissites.Location = new System.Drawing.Point(1118, 22);
            this.mbtnSzotarFrissites.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnSzotarFrissites.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSzotarFrissites.Name = "mbtnSzotarFrissites";
            this.mbtnSzotarFrissites.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSzotarFrissites.Size = new System.Drawing.Size(91, 36);
            this.mbtnSzotarFrissites.TabIndex = 2;
            this.mbtnSzotarFrissites.Text = "Frissítés";
            this.mbtnSzotarFrissites.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSzotarFrissites.UseAccentColor = false;
            this.mbtnSzotarFrissites.UseVisualStyleBackColor = true;
            this.mbtnSzotarFrissites.Click += new System.EventHandler(this.mbtnSzotarFrissites_Click);
            // 
            // mbtnSzotarDatasource
            // 
            this.mbtnSzotarDatasource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarDatasource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarDatasource.Depth = 0;
            this.mbtnSzotarDatasource.HighEmphasis = true;
            this.mbtnSzotarDatasource.Icon = null;
            this.mbtnSzotarDatasource.Location = new System.Drawing.Point(1017, 22);
            this.mbtnSzotarDatasource.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSzotarDatasource.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSzotarDatasource.Name = "mbtnSzotarDatasource";
            this.mbtnSzotarDatasource.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSzotarDatasource.Size = new System.Drawing.Size(94, 36);
            this.mbtnSzotarDatasource.TabIndex = 1;
            this.mbtnSzotarDatasource.Text = "Tallózás";
            this.mbtnSzotarDatasource.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSzotarDatasource.UseAccentColor = false;
            this.mbtnSzotarDatasource.UseVisualStyleBackColor = true;
            this.mbtnSzotarDatasource.Click += new System.EventHandler(this.mbtnSzotarDatasource_Click);
            // 
            // mtbSzotarDatasource
            // 
            this.mtbSzotarDatasource.AnimateReadOnly = false;
            this.mtbSzotarDatasource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbSzotarDatasource.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbSzotarDatasource.Depth = 0;
            this.mtbSzotarDatasource.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSzotarDatasource.HideSelection = true;
            this.mtbSzotarDatasource.Hint = "Útvonal a szótár adatfájlhoz";
            this.mtbSzotarDatasource.LeadingIcon = null;
            this.mtbSzotarDatasource.Location = new System.Drawing.Point(17, 17);
            this.mtbSzotarDatasource.MaxLength = 32767;
            this.mtbSzotarDatasource.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSzotarDatasource.Name = "mtbSzotarDatasource";
            this.mtbSzotarDatasource.PasswordChar = '\0';
            this.mtbSzotarDatasource.PrefixSuffixText = null;
            this.mtbSzotarDatasource.ReadOnly = false;
            this.mtbSzotarDatasource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbSzotarDatasource.SelectedText = "";
            this.mtbSzotarDatasource.SelectionLength = 0;
            this.mtbSzotarDatasource.SelectionStart = 0;
            this.mtbSzotarDatasource.ShortcutsEnabled = true;
            this.mtbSzotarDatasource.Size = new System.Drawing.Size(993, 48);
            this.mtbSzotarDatasource.TabIndex = 0;
            this.mtbSzotarDatasource.TabStop = false;
            this.mtbSzotarDatasource.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbSzotarDatasource.TrailingIcon = null;
            this.mtbSzotarDatasource.UseSystemPasswordChar = false;
            // 
            // tpSzotanulas
            // 
            this.tpSzotanulas.ImageKey = "learning_64.png";
            this.tpSzotanulas.Location = new System.Drawing.Point(4, 39);
            this.tpSzotanulas.Name = "tpSzotanulas";
            this.tpSzotanulas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSzotanulas.Size = new System.Drawing.Size(1266, 609);
            this.tpSzotanulas.TabIndex = 1;
            this.tpSzotanulas.Text = "Szótanulás";
            this.tpSzotanulas.UseVisualStyleBackColor = true;
            // 
            // tpHivatkozasok
            // 
            this.tpHivatkozasok.ImageKey = "urls_64.png";
            this.tpHivatkozasok.Location = new System.Drawing.Point(4, 39);
            this.tpHivatkozasok.Name = "tpHivatkozasok";
            this.tpHivatkozasok.Size = new System.Drawing.Size(1266, 609);
            this.tpHivatkozasok.TabIndex = 2;
            this.tpHivatkozasok.Text = "Hivatkozások";
            this.tpHivatkozasok.UseVisualStyleBackColor = true;
            // 
            // tpBeallitasok
            // 
            this.tpBeallitasok.Controls.Add(this.materialCard3);
            this.tpBeallitasok.ImageKey = "gear.png";
            this.tpBeallitasok.Location = new System.Drawing.Point(4, 39);
            this.tpBeallitasok.Name = "tpBeallitasok";
            this.tpBeallitasok.Size = new System.Drawing.Size(1266, 609);
            this.tpBeallitasok.TabIndex = 3;
            this.tpBeallitasok.Text = "Beállítások";
            this.tpBeallitasok.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.mswSotetTema);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard3.Size = new System.Drawing.Size(586, 512);
            this.materialCard3.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(247, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Alkalmazás beállítások";
            // 
            // mswSotetTema
            // 
            this.mswSotetTema.AutoSize = true;
            this.mswSotetTema.Depth = 0;
            this.mswSotetTema.Location = new System.Drawing.Point(33, 57);
            this.mswSotetTema.Margin = new System.Windows.Forms.Padding(0);
            this.mswSotetTema.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mswSotetTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.mswSotetTema.Name = "mswSotetTema";
            this.mswSotetTema.Ripple = true;
            this.mswSotetTema.Size = new System.Drawing.Size(135, 37);
            this.mswSotetTema.TabIndex = 0;
            this.mswSotetTema.Text = "Sötét téma";
            this.mswSotetTema.UseVisualStyleBackColor = true;
            this.mswSotetTema.CheckedChanged += new System.EventHandler(this.msSotetTema_CheckedChanged);
            // 
            // tpSegitseg
            // 
            this.tpSegitseg.ImageKey = "help.png";
            this.tpSegitseg.Location = new System.Drawing.Point(4, 39);
            this.tpSegitseg.Name = "tpSegitseg";
            this.tpSegitseg.Size = new System.Drawing.Size(1266, 609);
            this.tpSegitseg.TabIndex = 4;
            this.tpSegitseg.Text = "Segítség";
            this.tpSegitseg.UseVisualStyleBackColor = true;
            // 
            // ilMenuIcons
            // 
            this.ilMenuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMenuIcons.ImageStream")));
            this.ilMenuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMenuIcons.Images.SetKeyName(0, "dictionary_64.png");
            this.ilMenuIcons.Images.SetKeyName(1, "learning_64.png");
            this.ilMenuIcons.Images.SetKeyName(2, "urls_64.png");
            this.ilMenuIcons.Images.SetKeyName(3, "gear.png");
            this.ilMenuIcons.Images.SetKeyName(4, "help.png");
            // 
            // ofdSzotarDatasource
            // 
            this.ofdSzotarDatasource.Filter = "CSV fájl (*.csv)|*.csv";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.mlSzotarSzerkesztes);
            this.materialCard4.Controls.Add(this.mbtnSzotarUjSzopar);
            this.materialCard4.Controls.Add(this.mtbSzotarAnyanyelv);
            this.materialCard4.Controls.Add(this.mtbSzotarIdegennyelv);
            this.materialCard4.Controls.Add(this.mbtnSzotarMentes);
            this.materialCard4.Controls.Add(this.mtbSzotarSuly);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(750, 109);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(506, 487);
            this.materialCard4.TabIndex = 7;
            // 
            // mlSzotarSzerkesztes
            // 
            this.mlSzotarSzerkesztes.AutoSize = true;
            this.mlSzotarSzerkesztes.Depth = 0;
            this.mlSzotarSzerkesztes.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotarSzerkesztes.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.mlSzotarSzerkesztes.Location = new System.Drawing.Point(13, 14);
            this.mlSzotarSzerkesztes.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotarSzerkesztes.Name = "mlSzotarSzerkesztes";
            this.mlSzotarSzerkesztes.Size = new System.Drawing.Size(130, 29);
            this.mlSzotarSzerkesztes.TabIndex = 7;
            this.mlSzotarSzerkesztes.Text = "Szerkesztés";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mtcMenu);
            this.DrawerTabControl = this.mtcMenu;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szókártya";
            this.mtcMenu.ResumeLayout(false);
            this.tpSzotar.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tpBeallitasok.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage tpSzotar;
        private System.Windows.Forms.TabPage tpSzotanulas;
        private System.Windows.Forms.TabPage tpHivatkozasok;
        private System.Windows.Forms.TabPage tpBeallitasok;
        private System.Windows.Forms.TabPage tpSegitseg;
        private System.Windows.Forms.ImageList ilMenuIcons;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton mbtnSzotarDatasource;
        private MaterialSkin.Controls.MaterialTextBox2 mtbSzotarDatasource;
        private System.Windows.Forms.OpenFileDialog ofdSzotarDatasource;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch mswSotetTema;
        private MaterialSkin.Controls.MaterialButton mbtnSzotarMentes;
        private MaterialSkin.Controls.MaterialTextBox2 mtbSzotarSuly;
        private MaterialSkin.Controls.MaterialTextBox2 mtbSzotarIdegennyelv;
        private MaterialSkin.Controls.MaterialTextBox2 mtbSzotarAnyanyelv;
        private MaterialSkin.Controls.MaterialListView mlvSzotar;
        private System.Windows.Forms.ColumnHeader chAnyanyelv;
        private System.Windows.Forms.ColumnHeader chIdegenNyelv;
        private System.Windows.Forms.ColumnHeader chSuly;
        private MaterialSkin.Controls.MaterialButton mbtnSzotarTorles;
        private MaterialSkin.Controls.MaterialButton mbtnSzotarUjSzopar;
        private MaterialSkin.Controls.MaterialButton mbtnSzotarFrissites;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel mlSzotarSzerkesztes;
    }
}


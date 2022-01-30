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
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.mlSzotarSzerkesztes = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnSzotarUjSzopar = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarAnyanyelv = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtbSzotarIdegennyelv = new MaterialSkin.Controls.MaterialTextBox2();
            this.mbtnSzotarMentes = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarSuly = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.mlSzotarSzoparokDarabszama = new MaterialSkin.Controls.MaterialLabel();
            this.mlvSzotar = new MaterialSkin.Controls.MaterialListView();
            this.chAnyanyelv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdegenNyelv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSuly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mbtnSzotarTorles = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mbtnSzotarFrissites = new MaterialSkin.Controls.MaterialButton();
            this.mbtnSzotarDatasource = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarDatasource = new MaterialSkin.Controls.MaterialTextBox2();
            this.tpSzotanulas = new System.Windows.Forms.TabPage();
            this.tpHivatkozasok = new System.Windows.Forms.TabPage();
            this.tpBeallitasok = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.mlSzotanulasKivalasztottSzavakSzamaValue = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasKivalasztottSzavakSzama = new MaterialSkin.Controls.MaterialLabel();
            this.tbarKivalasztottSzavakSzama = new System.Windows.Forms.TrackBar();
            this.mlSzotanulasSzoismeretIsmertValue = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasSzoismeretBizonytalanValue = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasSzoismeretIsmeretlenValue = new MaterialSkin.Controls.MaterialLabel();
            this.tbarSzotanulasSzoismeretIsmert = new System.Windows.Forms.TrackBar();
            this.tbarSzotanulasSzoismeretBizonytalan = new System.Windows.Forms.TrackBar();
            this.tbarSzotanulasSzoismeretIsmeretlen = new System.Windows.Forms.TrackBar();
            this.mlSzotanulasSzoismeretBizonytalan = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasSzoismeretIsmeretlen = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasSzoismeretIsmert = new MaterialSkin.Controls.MaterialLabel();
            this.mlBeallitasokSzotanulas = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.mlBeallitasokAlkalmazas = new MaterialSkin.Controls.MaterialLabel();
            this.mswSotetTema = new MaterialSkin.Controls.MaterialSwitch();
            this.tpSegitseg = new System.Windows.Forms.TabPage();
            this.ilMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.ofdSzotarDatasource = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue = new MaterialSkin.Controls.MaterialLabel();
            this.mtcMenu.SuspendLayout();
            this.tpSzotar.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tpBeallitasok.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarKivalasztottSzavakSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretIsmert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretBizonytalan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretIsmeretlen)).BeginInit();
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
            this.tpSzotar.Padding = new System.Windows.Forms.Padding(3);
            this.tpSzotar.Size = new System.Drawing.Size(1266, 610);
            this.tpSzotar.TabIndex = 0;
            this.tpSzotar.Text = "Szótár";
            this.tpSzotar.UseVisualStyleBackColor = true;
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
            // mbtnSzotarUjSzopar
            // 
            this.mbtnSzotarUjSzopar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarUjSzopar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarUjSzopar.Depth = 0;
            this.mbtnSzotarUjSzopar.Enabled = false;
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
            this.mbtnSzotarUjSzopar.Click += new System.EventHandler(this.mbtnSzotarUjSzopar_Click);
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
            this.mtbSzotarAnyanyelv.Margin = new System.Windows.Forms.Padding(2);
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
            this.mtbSzotarIdegennyelv.Margin = new System.Windows.Forms.Padding(2);
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
            // mbtnSzotarMentes
            // 
            this.mbtnSzotarMentes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarMentes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarMentes.Depth = 0;
            this.mbtnSzotarMentes.Enabled = false;
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
            this.mtbSzotarSuly.Margin = new System.Windows.Forms.Padding(2);
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.mlSzotarSzoparokDarabszama);
            this.materialCard2.Controls.Add(this.mlvSzotar);
            this.materialCard2.Controls.Add(this.mbtnSzotarTorles);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 109);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(726, 487);
            this.materialCard2.TabIndex = 1;
            // 
            // mlSzotarSzoparokDarabszama
            // 
            this.mlSzotarSzoparokDarabszama.AutoSize = true;
            this.mlSzotarSzoparokDarabszama.Depth = 0;
            this.mlSzotarSzoparokDarabszama.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotarSzoparokDarabszama.Location = new System.Drawing.Point(17, 442);
            this.mlSzotarSzoparokDarabszama.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotarSzoparokDarabszama.Name = "mlSzotarSzoparokDarabszama";
            this.mlSzotarSzoparokDarabszama.Size = new System.Drawing.Size(1, 0);
            this.mlSzotarSzoparokDarabszama.TabIndex = 6;
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
            this.mlvSzotar.Margin = new System.Windows.Forms.Padding(2);
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mbtnSzotarFrissites);
            this.materialCard1.Controls.Add(this.mbtnSzotarDatasource);
            this.materialCard1.Controls.Add(this.mtbSzotarDatasource);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
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
            this.tpSzotanulas.Padding = new System.Windows.Forms.Padding(3);
            this.tpSzotanulas.Size = new System.Drawing.Size(1266, 610);
            this.tpSzotanulas.TabIndex = 1;
            this.tpSzotanulas.Text = "Szótanulás";
            this.tpSzotanulas.UseVisualStyleBackColor = true;
            // 
            // tpHivatkozasok
            // 
            this.tpHivatkozasok.ImageKey = "urls_64.png";
            this.tpHivatkozasok.Location = new System.Drawing.Point(4, 39);
            this.tpHivatkozasok.Name = "tpHivatkozasok";
            this.tpHivatkozasok.Size = new System.Drawing.Size(1266, 610);
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
            this.tpBeallitasok.Size = new System.Drawing.Size(1266, 610);
            this.tpBeallitasok.TabIndex = 3;
            this.tpBeallitasok.Text = "Beállítások";
            this.tpBeallitasok.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretIsmeretlenMaxValue);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.mlSzotanulasKivalasztottSzavakSzamaValue);
            this.materialCard3.Controls.Add(this.mlSzotanulasKivalasztottSzavakSzama);
            this.materialCard3.Controls.Add(this.tbarKivalasztottSzavakSzama);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretIsmertValue);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretBizonytalanValue);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretIsmeretlenValue);
            this.materialCard3.Controls.Add(this.tbarSzotanulasSzoismeretIsmert);
            this.materialCard3.Controls.Add(this.tbarSzotanulasSzoismeretBizonytalan);
            this.materialCard3.Controls.Add(this.tbarSzotanulasSzoismeretIsmeretlen);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretBizonytalan);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretIsmeretlen);
            this.materialCard3.Controls.Add(this.mlSzotanulasSzoismeretIsmert);
            this.materialCard3.Controls.Add(this.mlBeallitasokSzotanulas);
            this.materialCard3.Controls.Add(this.materialComboBox1);
            this.materialCard3.Controls.Add(this.mlBeallitasokAlkalmazas);
            this.materialCard3.Controls.Add(this.mswSotetTema);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(587, 586);
            this.materialCard3.TabIndex = 0;
            // 
            // mlSzotanulasKivalasztottSzavakSzamaValue
            // 
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Depth = 0;
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Location = new System.Drawing.Point(501, 177);
            this.mlSzotanulasKivalasztottSzavakSzamaValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Name = "mlSzotanulasKivalasztottSzavakSzamaValue";
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Size = new System.Drawing.Size(48, 23);
            this.mlSzotanulasKivalasztottSzavakSzamaValue.TabIndex = 14;
            this.mlSzotanulasKivalasztottSzavakSzamaValue.Text = "20";
            // 
            // mlSzotanulasKivalasztottSzavakSzama
            // 
            this.mlSzotanulasKivalasztottSzavakSzama.AutoSize = true;
            this.mlSzotanulasKivalasztottSzavakSzama.Depth = 0;
            this.mlSzotanulasKivalasztottSzavakSzama.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasKivalasztottSzavakSzama.Location = new System.Drawing.Point(40, 177);
            this.mlSzotanulasKivalasztottSzavakSzama.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasKivalasztottSzavakSzama.Name = "mlSzotanulasKivalasztottSzavakSzama";
            this.mlSzotanulasKivalasztottSzavakSzama.Size = new System.Drawing.Size(191, 19);
            this.mlSzotanulasKivalasztottSzavakSzama.TabIndex = 9;
            this.mlSzotanulasKivalasztottSzavakSzama.Text = "Kiválasztott szavak száma";
            // 
            // tbarKivalasztottSzavakSzama
            // 
            this.tbarKivalasztottSzavakSzama.Location = new System.Drawing.Point(237, 166);
            this.tbarKivalasztottSzavakSzama.Maximum = 100;
            this.tbarKivalasztottSzavakSzama.Name = "tbarKivalasztottSzavakSzama";
            this.tbarKivalasztottSzavakSzama.Size = new System.Drawing.Size(258, 45);
            this.tbarKivalasztottSzavakSzama.TabIndex = 16;
            this.tbarKivalasztottSzavakSzama.TickFrequency = 10;
            this.tbarKivalasztottSzavakSzama.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarKivalasztottSzavakSzama.Value = 20;
            this.tbarKivalasztottSzavakSzama.Scroll += new System.EventHandler(this.tbarKivalasztottSzavakSzama_Scroll);
            // 
            // mlSzotanulasSzoismeretIsmertValue
            // 
            this.mlSzotanulasSzoismeretIsmertValue.Depth = 0;
            this.mlSzotanulasSzoismeretIsmertValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretIsmertValue.Location = new System.Drawing.Point(502, 386);
            this.mlSzotanulasSzoismeretIsmertValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretIsmertValue.Name = "mlSzotanulasSzoismeretIsmertValue";
            this.mlSzotanulasSzoismeretIsmertValue.Size = new System.Drawing.Size(48, 23);
            this.mlSzotanulasSzoismeretIsmertValue.TabIndex = 15;
            this.mlSzotanulasSzoismeretIsmertValue.Text = "000";
            // 
            // mlSzotanulasSzoismeretBizonytalanValue
            // 
            this.mlSzotanulasSzoismeretBizonytalanValue.Depth = 0;
            this.mlSzotanulasSzoismeretBizonytalanValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretBizonytalanValue.Location = new System.Drawing.Point(502, 335);
            this.mlSzotanulasSzoismeretBizonytalanValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretBizonytalanValue.Name = "mlSzotanulasSzoismeretBizonytalanValue";
            this.mlSzotanulasSzoismeretBizonytalanValue.Size = new System.Drawing.Size(48, 23);
            this.mlSzotanulasSzoismeretBizonytalanValue.TabIndex = 14;
            this.mlSzotanulasSzoismeretBizonytalanValue.Text = "000";
            // 
            // mlSzotanulasSzoismeretIsmeretlenValue
            // 
            this.mlSzotanulasSzoismeretIsmeretlenValue.Depth = 0;
            this.mlSzotanulasSzoismeretIsmeretlenValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretIsmeretlenValue.Location = new System.Drawing.Point(40, 283);
            this.mlSzotanulasSzoismeretIsmeretlenValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretIsmeretlenValue.Name = "mlSzotanulasSzoismeretIsmeretlenValue";
            this.mlSzotanulasSzoismeretIsmeretlenValue.Size = new System.Drawing.Size(48, 23);
            this.mlSzotanulasSzoismeretIsmeretlenValue.TabIndex = 13;
            this.mlSzotanulasSzoismeretIsmeretlenValue.Text = "000";
            // 
            // tbarSzotanulasSzoismeretIsmert
            // 
            this.tbarSzotanulasSzoismeretIsmert.Location = new System.Drawing.Point(256, 374);
            this.tbarSzotanulasSzoismeretIsmert.Maximum = 0;
            this.tbarSzotanulasSzoismeretIsmert.Name = "tbarSzotanulasSzoismeretIsmert";
            this.tbarSzotanulasSzoismeretIsmert.Size = new System.Drawing.Size(239, 45);
            this.tbarSzotanulasSzoismeretIsmert.TabIndex = 12;
            this.tbarSzotanulasSzoismeretIsmert.TickFrequency = 0;
            this.tbarSzotanulasSzoismeretIsmert.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarSzotanulasSzoismeretIsmert.Scroll += new System.EventHandler(this.tbarSzotanulasSzoismeretIsmert_Scroll);
            // 
            // tbarSzotanulasSzoismeretBizonytalan
            // 
            this.tbarSzotanulasSzoismeretBizonytalan.Location = new System.Drawing.Point(256, 323);
            this.tbarSzotanulasSzoismeretBizonytalan.Maximum = 0;
            this.tbarSzotanulasSzoismeretBizonytalan.Name = "tbarSzotanulasSzoismeretBizonytalan";
            this.tbarSzotanulasSzoismeretBizonytalan.Size = new System.Drawing.Size(239, 45);
            this.tbarSzotanulasSzoismeretBizonytalan.TabIndex = 11;
            this.tbarSzotanulasSzoismeretBizonytalan.TickFrequency = 0;
            this.tbarSzotanulasSzoismeretBizonytalan.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarSzotanulasSzoismeretBizonytalan.Scroll += new System.EventHandler(this.tbarSzotanulasSzoismeretBizonytalan_Scroll);
            // 
            // tbarSzotanulasSzoismeretIsmeretlen
            // 
            this.tbarSzotanulasSzoismeretIsmeretlen.Location = new System.Drawing.Point(256, 272);
            this.tbarSzotanulasSzoismeretIsmeretlen.Maximum = 0;
            this.tbarSzotanulasSzoismeretIsmeretlen.Name = "tbarSzotanulasSzoismeretIsmeretlen";
            this.tbarSzotanulasSzoismeretIsmeretlen.Size = new System.Drawing.Size(239, 45);
            this.tbarSzotanulasSzoismeretIsmeretlen.TabIndex = 10;
            this.tbarSzotanulasSzoismeretIsmeretlen.TickFrequency = 0;
            this.tbarSzotanulasSzoismeretIsmeretlen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarSzotanulasSzoismeretIsmeretlen.Scroll += new System.EventHandler(this.tbarSzotanulasSzoismeretIsmeretlen_Scroll);
            // 
            // mlSzotanulasSzoismeretBizonytalan
            // 
            this.mlSzotanulasSzoismeretBizonytalan.AutoSize = true;
            this.mlSzotanulasSzoismeretBizonytalan.Depth = 0;
            this.mlSzotanulasSzoismeretBizonytalan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretBizonytalan.Location = new System.Drawing.Point(68, 334);
            this.mlSzotanulasSzoismeretBizonytalan.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretBizonytalan.Name = "mlSzotanulasSzoismeretBizonytalan";
            this.mlSzotanulasSzoismeretBizonytalan.Size = new System.Drawing.Size(139, 19);
            this.mlSzotanulasSzoismeretBizonytalan.TabIndex = 9;
            this.mlSzotanulasSzoismeretBizonytalan.Text = "Bizonytalan szavak";
            // 
            // mlSzotanulasSzoismeretIsmeretlen
            // 
            this.mlSzotanulasSzoismeretIsmeretlen.AutoSize = true;
            this.mlSzotanulasSzoismeretIsmeretlen.Depth = 0;
            this.mlSzotanulasSzoismeretIsmeretlen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretIsmeretlen.Location = new System.Drawing.Point(79, 283);
            this.mlSzotanulasSzoismeretIsmeretlen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretIsmeretlen.Name = "mlSzotanulasSzoismeretIsmeretlen";
            this.mlSzotanulasSzoismeretIsmeretlen.Size = new System.Drawing.Size(128, 19);
            this.mlSzotanulasSzoismeretIsmeretlen.TabIndex = 8;
            this.mlSzotanulasSzoismeretIsmeretlen.Text = "Ismeretlen szavak";
            // 
            // mlSzotanulasSzoismeretIsmert
            // 
            this.mlSzotanulasSzoismeretIsmert.AutoSize = true;
            this.mlSzotanulasSzoismeretIsmert.Depth = 0;
            this.mlSzotanulasSzoismeretIsmert.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretIsmert.Location = new System.Drawing.Point(108, 386);
            this.mlSzotanulasSzoismeretIsmert.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretIsmert.Name = "mlSzotanulasSzoismeretIsmert";
            this.mlSzotanulasSzoismeretIsmert.Size = new System.Drawing.Size(99, 19);
            this.mlSzotanulasSzoismeretIsmert.TabIndex = 7;
            this.mlSzotanulasSzoismeretIsmert.Text = "Ismert szavak";
            // 
            // mlBeallitasokSzotanulas
            // 
            this.mlBeallitasokSzotanulas.AutoSize = true;
            this.mlBeallitasokSzotanulas.Depth = 0;
            this.mlBeallitasokSzotanulas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlBeallitasokSzotanulas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.mlBeallitasokSzotanulas.Location = new System.Drawing.Point(17, 115);
            this.mlBeallitasokSzotanulas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlBeallitasokSzotanulas.Name = "mlBeallitasokSzotanulas";
            this.mlBeallitasokSzotanulas.Size = new System.Drawing.Size(119, 29);
            this.mlBeallitasokSzotanulas.TabIndex = 6;
            this.mlBeallitasokSzotanulas.Text = "Szótanulás";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Szótanulás Sablon";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Egyszerű",
            "Normál",
            "Haladó",
            "Nehéz"});
            this.materialComboBox1.Location = new System.Drawing.Point(33, 217);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(516, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // mlBeallitasokAlkalmazas
            // 
            this.mlBeallitasokAlkalmazas.AutoSize = true;
            this.mlBeallitasokAlkalmazas.Depth = 0;
            this.mlBeallitasokAlkalmazas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlBeallitasokAlkalmazas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.mlBeallitasokAlkalmazas.Location = new System.Drawing.Point(17, 14);
            this.mlBeallitasokAlkalmazas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlBeallitasokAlkalmazas.Name = "mlBeallitasokAlkalmazas";
            this.mlBeallitasokAlkalmazas.Size = new System.Drawing.Size(125, 29);
            this.mlBeallitasokAlkalmazas.TabIndex = 1;
            this.mlBeallitasokAlkalmazas.Text = "Alkalmazás";
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
            this.tpSegitseg.Size = new System.Drawing.Size(1266, 610);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(240, 283);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(10, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "0";
            // 
            // mlSzotanulasSzoismeretIsmeretlenMaxValue
            // 
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.AutoSize = true;
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Depth = 0;
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Location = new System.Drawing.Point(501, 283);
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Name = "mlSzotanulasSzoismeretIsmeretlenMaxValue";
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Size = new System.Drawing.Size(10, 19);
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.TabIndex = 18;
            this.mlSzotanulasSzoismeretIsmeretlenMaxValue.Text = "0";
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
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tpBeallitasok.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarKivalasztottSzavakSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretIsmert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretBizonytalan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSzotanulasSzoismeretIsmeretlen)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel mlBeallitasokAlkalmazas;
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
        private MaterialSkin.Controls.MaterialLabel mlSzotarSzoparokDarabszama;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel mlBeallitasokSzotanulas;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretBizonytalan;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretIsmeretlen;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretIsmert;
        private System.Windows.Forms.TrackBar tbarSzotanulasSzoismeretIsmeretlen;
        private System.Windows.Forms.TrackBar tbarSzotanulasSzoismeretIsmert;
        private System.Windows.Forms.TrackBar tbarSzotanulasSzoismeretBizonytalan;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretIsmertValue;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretBizonytalanValue;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretIsmeretlenValue;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasKivalasztottSzavakSzama;
        private System.Windows.Forms.TrackBar tbarKivalasztottSzavakSzama;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasKivalasztottSzavakSzamaValue;
        private MaterialSkin.Controls.MaterialLabel mlSzotanulasSzoismeretIsmeretlenMaxValue;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}


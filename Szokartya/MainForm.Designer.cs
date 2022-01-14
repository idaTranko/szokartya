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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mbtnSzotarDatasource = new MaterialSkin.Controls.MaterialButton();
            this.mtbSzotarDatasource = new MaterialSkin.Controls.MaterialTextBox2();
            this.tpSzotanulas = new System.Windows.Forms.TabPage();
            this.tpHivatkozasok = new System.Windows.Forms.TabPage();
            this.tpBeallitasok = new System.Windows.Forms.TabPage();
            this.tpSegitseg = new System.Windows.Forms.TabPage();
            this.ilMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.ofdSzotarDatasource = new System.Windows.Forms.OpenFileDialog();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.mswSotetTema = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtcMenu.SuspendLayout();
            this.tpSzotar.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tpBeallitasok.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 109);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1242, 487);
            this.materialCard2.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // mbtnSzotarDatasource
            // 
            this.mbtnSzotarDatasource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSzotarDatasource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSzotarDatasource.Depth = 0;
            this.mbtnSzotarDatasource.HighEmphasis = true;
            this.mbtnSzotarDatasource.Icon = null;
            this.mbtnSzotarDatasource.Location = new System.Drawing.Point(1130, 23);
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
            this.mtbSzotarDatasource.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.mtbSzotarDatasource.Size = new System.Drawing.Size(1096, 48);
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
            this.ofdSzotarDatasource.Filter = "Excel dokumentum (*.xls)|*.xlsx";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.mswSotetTema);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(586, 512);
            this.materialCard3.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1207, 453);
            this.dataGridView1.TabIndex = 0;
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
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tpBeallitasok.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


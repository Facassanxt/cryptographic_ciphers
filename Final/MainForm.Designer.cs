
namespace Final
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageMenuCiphers = new System.Windows.Forms.TabPage();
            this.tab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageCiphers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel = new System.Windows.Forms.Panel();
            this.Bu_GOST_R_34_10_94 = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Kuznyechik = new MaterialSkin.Controls.MaterialButton();
            this.Bu_AES_128 = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Magma_Simple = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Magma_Gamm = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Caesar = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Atbash = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Polybius = new MaterialSkin.Controls.MaterialButton();
            this.Bu_ECC = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Trithemius = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Elgamal = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Belazo = new MaterialSkin.Controls.MaterialButton();
            this.Bu_RSA = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Vigenère = new MaterialSkin.Controls.MaterialButton();
            this.Bu_A5_2 = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Matrix_cipher = new MaterialSkin.Controls.MaterialButton();
            this.Bu_А5_1 = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Playfer = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Magma = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Vertical_permutation = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Shannon = new MaterialSkin.Controls.MaterialButton();
            this.Bu_Cardano_grille = new MaterialSkin.Controls.MaterialButton();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCheck = new MaterialSkin.Controls.MaterialLabel();
            this.LabelEncryptedMessage = new MaterialSkin.Controls.MaterialLabel();
            this.LabelMessages = new MaterialSkin.Controls.MaterialLabel();
            this.panelKeys = new System.Windows.Forms.Panel();
            this.Elgamal_X = new MaterialSkin.Controls.MaterialTextBox();
            this.Elgamal_G = new MaterialSkin.Controls.MaterialTextBox();
            this.Elgamal_P = new MaterialSkin.Controls.MaterialTextBox();
            this.BuTest = new MaterialSkin.Controls.MaterialButton();
            this.BuClear = new MaterialSkin.Controls.MaterialButton();
            this.LabelError = new MaterialSkin.Controls.MaterialLabel();
            this.LabelKeys = new MaterialSkin.Controls.MaterialTextBox();
            this.BuText = new MaterialSkin.Controls.MaterialButton();
            this.DividerMessages = new MaterialSkin.Controls.MaterialDivider();
            this.TextBoxCheck = new System.Windows.Forms.RichTextBox();
            this.DividerEncryptedMessage = new MaterialSkin.Controls.MaterialDivider();
            this.TextBoxEncryptedMessage = new System.Windows.Forms.RichTextBox();
            this.TextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.DividerCheck = new MaterialSkin.Controls.MaterialDivider();
            this.tabPageDigitalSignature = new System.Windows.Forms.TabPage();
            this.tabPageDiffieHellman = new System.Windows.Forms.TabPage();
            this.KeyN = new MaterialSkin.Controls.MaterialTextBox();
            this.KeyA = new MaterialSkin.Controls.MaterialTextBox();
            this.BuCheck = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelError_Hellman = new MaterialSkin.Controls.MaterialLabel();
            this.BuRandom = new MaterialSkin.Controls.MaterialButton();
            this.SecretKeyB = new MaterialSkin.Controls.MaterialTextBox();
            this.SecretKeyA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.KeyYB = new MaterialSkin.Controls.MaterialTextBox();
            this.KeyYA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.KeyKB = new MaterialSkin.Controls.MaterialTextBox();
            this.KeyKA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageRSA = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelError_RSA = new MaterialSkin.Controls.MaterialLabel();
            this.Key_Q = new MaterialSkin.Controls.MaterialTextBox();
            this.Key_P = new MaterialSkin.Controls.MaterialTextBox();
            this.BuCheckRSA = new MaterialSkin.Controls.MaterialButton();
            this.BuRandomRSA = new MaterialSkin.Controls.MaterialButton();
            this.Key_D = new MaterialSkin.Controls.MaterialTextBox();
            this.Public_key = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.labelPublic_key = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.Key_φ = new MaterialSkin.Controls.MaterialTextBox();
            this.Key_N = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.Private_key = new MaterialSkin.Controls.MaterialTextBox();
            this.Key_E = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageElgamal = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPageMenuSettings = new System.Windows.Forms.TabPage();
            this.Switch_Change_Theme = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Language = new MaterialSkin.Controls.MaterialSwitch();
            this.Label1 = new MaterialSkin.Controls.MaterialLabel();
            this.Switch_Display_Icons_when_hidden = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Background_with_Accent = new MaterialSkin.Controls.MaterialSwitch();
            this.Bu_Change_Colors = new MaterialSkin.Controls.MaterialButton();
            this.Switch_Highlight_with_Accent = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Use_menu_colors = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.button1 = new System.Windows.Forms.Button();
            this.Bu_GOST_R_34_10_2012 = new MaterialSkin.Controls.MaterialButton();
            this.tabPageMenuCiphers.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPageCiphers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelKeys.SuspendLayout();
            this.tabPageDiffieHellman.SuspendLayout();
            this.tabPageRSA.SuspendLayout();
            this.tabPageMenuSettings.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            // 
            // tabPageMenuCiphers
            // 
            this.tabPageMenuCiphers.BackColor = System.Drawing.Color.White;
            this.tabPageMenuCiphers.Controls.Add(this.tab);
            this.tabPageMenuCiphers.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPageMenuCiphers.Location = new System.Drawing.Point(4, 31);
            this.tabPageMenuCiphers.Name = "tabPageMenuCiphers";
            this.tabPageMenuCiphers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenuCiphers.Size = new System.Drawing.Size(1260, 557);
            this.tabPageMenuCiphers.TabIndex = 6;
            this.tabPageMenuCiphers.Text = "Ciphers";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPageCiphers);
            this.tab.Controls.Add(this.tabPageDigitalSignature);
            this.tab.Controls.Add(this.tabPageDiffieHellman);
            this.tab.Controls.Add(this.tabPageRSA);
            this.tab.Controls.Add(this.tabPageElgamal);
            this.tab.Depth = 0;
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Margin = new System.Windows.Forms.Padding(0);
            this.tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1254, 551);
            this.tab.TabIndex = 250;
            // 
            // tabPageCiphers
            // 
            this.tabPageCiphers.BackColor = System.Drawing.Color.White;
            this.tabPageCiphers.Controls.Add(this.tableLayoutPanel2);
            this.tabPageCiphers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCiphers.Name = "tabPageCiphers";
            this.tabPageCiphers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCiphers.Size = new System.Drawing.Size(1246, 525);
            this.tabPageCiphers.TabIndex = 0;
            this.tabPageCiphers.Text = "ciphers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.Panel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Divider, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1240, 519);
            this.tableLayoutPanel2.TabIndex = 81;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.Bu_GOST_R_34_10_2012);
            this.Panel.Controls.Add(this.Bu_GOST_R_34_10_94);
            this.Panel.Controls.Add(this.Bu_Kuznyechik);
            this.Panel.Controls.Add(this.Bu_AES_128);
            this.Panel.Controls.Add(this.Bu_Magma_Simple);
            this.Panel.Controls.Add(this.Bu_Magma_Gamm);
            this.Panel.Controls.Add(this.Bu_Caesar);
            this.Panel.Controls.Add(this.Bu_Atbash);
            this.Panel.Controls.Add(this.Bu_Polybius);
            this.Panel.Controls.Add(this.Bu_ECC);
            this.Panel.Controls.Add(this.Bu_Trithemius);
            this.Panel.Controls.Add(this.Bu_Elgamal);
            this.Panel.Controls.Add(this.Bu_Belazo);
            this.Panel.Controls.Add(this.Bu_RSA);
            this.Panel.Controls.Add(this.Bu_Vigenère);
            this.Panel.Controls.Add(this.Bu_A5_2);
            this.Panel.Controls.Add(this.Bu_Matrix_cipher);
            this.Panel.Controls.Add(this.Bu_А5_1);
            this.Panel.Controls.Add(this.Bu_Playfer);
            this.Panel.Controls.Add(this.Bu_Magma);
            this.Panel.Controls.Add(this.Bu_Vertical_permutation);
            this.Panel.Controls.Add(this.Bu_Shannon);
            this.Panel.Controls.Add(this.Bu_Cardano_grille);
            this.Panel.Location = new System.Drawing.Point(3, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(238, 506);
            this.Panel.TabIndex = 35;
            // 
            // Bu_GOST_R_34_10_94
            // 
            this.Bu_GOST_R_34_10_94.AutoSize = false;
            this.Bu_GOST_R_34_10_94.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_GOST_R_34_10_94.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_GOST_R_34_10_94.Depth = 0;
            this.Bu_GOST_R_34_10_94.DrawShadows = true;
            this.Bu_GOST_R_34_10_94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_GOST_R_34_10_94.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_GOST_R_34_10_94.HighEmphasis = true;
            this.Bu_GOST_R_34_10_94.Icon = null;
            this.Bu_GOST_R_34_10_94.Location = new System.Drawing.Point(4, 426);
            this.Bu_GOST_R_34_10_94.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_GOST_R_34_10_94.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_GOST_R_34_10_94.Name = "Bu_GOST_R_34_10_94";
            this.Bu_GOST_R_34_10_94.Size = new System.Drawing.Size(230, 20);
            this.Bu_GOST_R_34_10_94.TabIndex = 57;
            this.Bu_GOST_R_34_10_94.Text = "GOST R 34.10-94";
            this.Bu_GOST_R_34_10_94.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_GOST_R_34_10_94.UseAccentColor = true;
            this.Bu_GOST_R_34_10_94.UseVisualStyleBackColor = false;
            // 
            // Bu_Kuznyechik
            // 
            this.Bu_Kuznyechik.AutoSize = false;
            this.Bu_Kuznyechik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Kuznyechik.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Kuznyechik.Depth = 0;
            this.Bu_Kuznyechik.DrawShadows = true;
            this.Bu_Kuznyechik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Kuznyechik.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Kuznyechik.HighEmphasis = true;
            this.Bu_Kuznyechik.Icon = null;
            this.Bu_Kuznyechik.Location = new System.Drawing.Point(4, 346);
            this.Bu_Kuznyechik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Kuznyechik.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Kuznyechik.Name = "Bu_Kuznyechik";
            this.Bu_Kuznyechik.Size = new System.Drawing.Size(230, 20);
            this.Bu_Kuznyechik.TabIndex = 55;
            this.Bu_Kuznyechik.Text = "Kuznyechik";
            this.Bu_Kuznyechik.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Kuznyechik.UseAccentColor = true;
            this.Bu_Kuznyechik.UseVisualStyleBackColor = false;
            this.Bu_Kuznyechik.Click += new System.EventHandler(this.Bu_Kuznyechik_Click);
            // 
            // Bu_AES_128
            // 
            this.Bu_AES_128.AutoSize = false;
            this.Bu_AES_128.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_AES_128.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_AES_128.Depth = 0;
            this.Bu_AES_128.DrawShadows = true;
            this.Bu_AES_128.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_AES_128.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_AES_128.HighEmphasis = true;
            this.Bu_AES_128.Icon = null;
            this.Bu_AES_128.Location = new System.Drawing.Point(4, 326);
            this.Bu_AES_128.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_AES_128.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_AES_128.Name = "Bu_AES_128";
            this.Bu_AES_128.Size = new System.Drawing.Size(230, 20);
            this.Bu_AES_128.TabIndex = 54;
            this.Bu_AES_128.Text = "AES 128";
            this.Bu_AES_128.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_AES_128.UseAccentColor = true;
            this.Bu_AES_128.UseVisualStyleBackColor = false;
            this.Bu_AES_128.Click += new System.EventHandler(this.Bu_AES_128_Click);
            // 
            // Bu_Magma_Simple
            // 
            this.Bu_Magma_Simple.AutoSize = false;
            this.Bu_Magma_Simple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Magma_Simple.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Magma_Simple.Depth = 0;
            this.Bu_Magma_Simple.DrawShadows = true;
            this.Bu_Magma_Simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Magma_Simple.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Magma_Simple.HighEmphasis = true;
            this.Bu_Magma_Simple.Icon = null;
            this.Bu_Magma_Simple.Location = new System.Drawing.Point(4, 306);
            this.Bu_Magma_Simple.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Magma_Simple.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Magma_Simple.Name = "Bu_Magma_Simple";
            this.Bu_Magma_Simple.Size = new System.Drawing.Size(230, 20);
            this.Bu_Magma_Simple.TabIndex = 53;
            this.Bu_Magma_Simple.Text = "Magma Simple";
            this.Bu_Magma_Simple.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Magma_Simple.UseAccentColor = true;
            this.Bu_Magma_Simple.UseVisualStyleBackColor = false;
            this.Bu_Magma_Simple.Click += new System.EventHandler(this.Bu_Magma_Simple_Click);
            // 
            // Bu_Magma_Gamm
            // 
            this.Bu_Magma_Gamm.AutoSize = false;
            this.Bu_Magma_Gamm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Magma_Gamm.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Magma_Gamm.Depth = 0;
            this.Bu_Magma_Gamm.DrawShadows = true;
            this.Bu_Magma_Gamm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Magma_Gamm.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Magma_Gamm.HighEmphasis = true;
            this.Bu_Magma_Gamm.Icon = null;
            this.Bu_Magma_Gamm.Location = new System.Drawing.Point(4, 226);
            this.Bu_Magma_Gamm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Magma_Gamm.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Magma_Gamm.Name = "Bu_Magma_Gamm";
            this.Bu_Magma_Gamm.Size = new System.Drawing.Size(230, 20);
            this.Bu_Magma_Gamm.TabIndex = 52;
            this.Bu_Magma_Gamm.Text = "Magma gamma";
            this.Bu_Magma_Gamm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Magma_Gamm.UseAccentColor = true;
            this.Bu_Magma_Gamm.UseVisualStyleBackColor = false;
            this.Bu_Magma_Gamm.Click += new System.EventHandler(this.Bu_Magma_Gamm_Click);
            // 
            // Bu_Caesar
            // 
            this.Bu_Caesar.AutoSize = false;
            this.Bu_Caesar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Caesar.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Caesar.Depth = 0;
            this.Bu_Caesar.DrawShadows = true;
            this.Bu_Caesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Caesar.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Caesar.HighEmphasis = true;
            this.Bu_Caesar.Icon = null;
            this.Bu_Caesar.Location = new System.Drawing.Point(4, 6);
            this.Bu_Caesar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Caesar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Caesar.Name = "Bu_Caesar";
            this.Bu_Caesar.Size = new System.Drawing.Size(230, 20);
            this.Bu_Caesar.TabIndex = 4;
            this.Bu_Caesar.Text = "Caesar";
            this.Bu_Caesar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Caesar.UseAccentColor = true;
            this.Bu_Caesar.UseVisualStyleBackColor = false;
            this.Bu_Caesar.Click += new System.EventHandler(this.Bu_Caesar_Click);
            // 
            // Bu_Atbash
            // 
            this.Bu_Atbash.AutoSize = false;
            this.Bu_Atbash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Atbash.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Atbash.Depth = 0;
            this.Bu_Atbash.DrawShadows = true;
            this.Bu_Atbash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Atbash.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Atbash.HighEmphasis = true;
            this.Bu_Atbash.Icon = null;
            this.Bu_Atbash.Location = new System.Drawing.Point(4, 26);
            this.Bu_Atbash.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Atbash.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Atbash.Name = "Bu_Atbash";
            this.Bu_Atbash.Size = new System.Drawing.Size(230, 20);
            this.Bu_Atbash.TabIndex = 36;
            this.Bu_Atbash.Text = "Atbash";
            this.Bu_Atbash.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Atbash.UseAccentColor = true;
            this.Bu_Atbash.UseVisualStyleBackColor = false;
            this.Bu_Atbash.Click += new System.EventHandler(this.Bu_Atbash_Click);
            // 
            // Bu_Polybius
            // 
            this.Bu_Polybius.AutoSize = false;
            this.Bu_Polybius.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Polybius.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Polybius.Depth = 0;
            this.Bu_Polybius.DrawShadows = true;
            this.Bu_Polybius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Polybius.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Polybius.HighEmphasis = true;
            this.Bu_Polybius.Icon = null;
            this.Bu_Polybius.Location = new System.Drawing.Point(4, 46);
            this.Bu_Polybius.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Polybius.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Polybius.Name = "Bu_Polybius";
            this.Bu_Polybius.Size = new System.Drawing.Size(230, 20);
            this.Bu_Polybius.TabIndex = 37;
            this.Bu_Polybius.Text = "Polybius";
            this.Bu_Polybius.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Polybius.UseAccentColor = true;
            this.Bu_Polybius.UseVisualStyleBackColor = false;
            this.Bu_Polybius.Click += new System.EventHandler(this.Bu_Polybius_Click);
            // 
            // Bu_ECC
            // 
            this.Bu_ECC.AutoSize = false;
            this.Bu_ECC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_ECC.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_ECC.Depth = 0;
            this.Bu_ECC.DrawShadows = true;
            this.Bu_ECC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_ECC.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_ECC.HighEmphasis = true;
            this.Bu_ECC.Icon = null;
            this.Bu_ECC.Location = new System.Drawing.Point(4, 406);
            this.Bu_ECC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_ECC.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_ECC.Name = "Bu_ECC";
            this.Bu_ECC.Size = new System.Drawing.Size(230, 20);
            this.Bu_ECC.TabIndex = 51;
            this.Bu_ECC.Text = "ECC";
            this.Bu_ECC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_ECC.UseAccentColor = true;
            this.Bu_ECC.UseVisualStyleBackColor = false;
            this.Bu_ECC.Click += new System.EventHandler(this.Bu_ECC_Click);
            // 
            // Bu_Trithemius
            // 
            this.Bu_Trithemius.AutoSize = false;
            this.Bu_Trithemius.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Trithemius.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Trithemius.Depth = 0;
            this.Bu_Trithemius.DrawShadows = true;
            this.Bu_Trithemius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Trithemius.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Trithemius.HighEmphasis = true;
            this.Bu_Trithemius.Icon = null;
            this.Bu_Trithemius.Location = new System.Drawing.Point(4, 66);
            this.Bu_Trithemius.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Trithemius.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Trithemius.Name = "Bu_Trithemius";
            this.Bu_Trithemius.Size = new System.Drawing.Size(230, 20);
            this.Bu_Trithemius.TabIndex = 38;
            this.Bu_Trithemius.Text = "Trithemius";
            this.Bu_Trithemius.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Trithemius.UseAccentColor = true;
            this.Bu_Trithemius.UseVisualStyleBackColor = false;
            this.Bu_Trithemius.Click += new System.EventHandler(this.Bu_Trithemius_Click);
            // 
            // Bu_Elgamal
            // 
            this.Bu_Elgamal.AutoSize = false;
            this.Bu_Elgamal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Elgamal.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Elgamal.Depth = 0;
            this.Bu_Elgamal.DrawShadows = true;
            this.Bu_Elgamal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Elgamal.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Elgamal.HighEmphasis = true;
            this.Bu_Elgamal.Icon = null;
            this.Bu_Elgamal.Location = new System.Drawing.Point(4, 386);
            this.Bu_Elgamal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Elgamal.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Elgamal.Name = "Bu_Elgamal";
            this.Bu_Elgamal.Size = new System.Drawing.Size(230, 20);
            this.Bu_Elgamal.TabIndex = 50;
            this.Bu_Elgamal.Text = "Elgamal";
            this.Bu_Elgamal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Elgamal.UseAccentColor = true;
            this.Bu_Elgamal.UseVisualStyleBackColor = false;
            this.Bu_Elgamal.Click += new System.EventHandler(this.Bu_Elgamal_Click);
            // 
            // Bu_Belazo
            // 
            this.Bu_Belazo.AutoSize = false;
            this.Bu_Belazo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Belazo.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Belazo.Depth = 0;
            this.Bu_Belazo.DrawShadows = true;
            this.Bu_Belazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Belazo.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Belazo.HighEmphasis = true;
            this.Bu_Belazo.Icon = null;
            this.Bu_Belazo.Location = new System.Drawing.Point(4, 86);
            this.Bu_Belazo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Belazo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Belazo.Name = "Bu_Belazo";
            this.Bu_Belazo.Size = new System.Drawing.Size(230, 20);
            this.Bu_Belazo.TabIndex = 39;
            this.Bu_Belazo.Text = "Belazo";
            this.Bu_Belazo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Belazo.UseAccentColor = true;
            this.Bu_Belazo.UseVisualStyleBackColor = false;
            this.Bu_Belazo.Click += new System.EventHandler(this.Bu_Belazo_Click);
            // 
            // Bu_RSA
            // 
            this.Bu_RSA.AutoSize = false;
            this.Bu_RSA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_RSA.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_RSA.Depth = 0;
            this.Bu_RSA.DrawShadows = true;
            this.Bu_RSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_RSA.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_RSA.HighEmphasis = true;
            this.Bu_RSA.Icon = null;
            this.Bu_RSA.Location = new System.Drawing.Point(4, 366);
            this.Bu_RSA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_RSA.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_RSA.Name = "Bu_RSA";
            this.Bu_RSA.Size = new System.Drawing.Size(230, 20);
            this.Bu_RSA.TabIndex = 49;
            this.Bu_RSA.Text = "RSA";
            this.Bu_RSA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_RSA.UseAccentColor = true;
            this.Bu_RSA.UseVisualStyleBackColor = false;
            this.Bu_RSA.Click += new System.EventHandler(this.Bu_RSA_Click);
            // 
            // Bu_Vigenère
            // 
            this.Bu_Vigenère.AutoSize = false;
            this.Bu_Vigenère.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Vigenère.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Vigenère.Depth = 0;
            this.Bu_Vigenère.DrawShadows = true;
            this.Bu_Vigenère.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Vigenère.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Vigenère.HighEmphasis = true;
            this.Bu_Vigenère.Icon = null;
            this.Bu_Vigenère.Location = new System.Drawing.Point(4, 106);
            this.Bu_Vigenère.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Vigenère.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Vigenère.Name = "Bu_Vigenère";
            this.Bu_Vigenère.Size = new System.Drawing.Size(230, 20);
            this.Bu_Vigenère.TabIndex = 40;
            this.Bu_Vigenère.Text = "Vigenère";
            this.Bu_Vigenère.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Vigenère.UseAccentColor = true;
            this.Bu_Vigenère.UseVisualStyleBackColor = false;
            this.Bu_Vigenère.Click += new System.EventHandler(this.Bu_Vigenère_Click);
            // 
            // Bu_A5_2
            // 
            this.Bu_A5_2.AutoSize = false;
            this.Bu_A5_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_A5_2.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_A5_2.Depth = 0;
            this.Bu_A5_2.DrawShadows = true;
            this.Bu_A5_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_A5_2.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_A5_2.HighEmphasis = true;
            this.Bu_A5_2.Icon = null;
            this.Bu_A5_2.Location = new System.Drawing.Point(4, 286);
            this.Bu_A5_2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_A5_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_A5_2.Name = "Bu_A5_2";
            this.Bu_A5_2.Size = new System.Drawing.Size(230, 20);
            this.Bu_A5_2.TabIndex = 48;
            this.Bu_A5_2.Text = "А5 /2";
            this.Bu_A5_2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_A5_2.UseAccentColor = true;
            this.Bu_A5_2.UseVisualStyleBackColor = false;
            this.Bu_A5_2.Click += new System.EventHandler(this.Bu_A5_2_Click);
            // 
            // Bu_Matrix_cipher
            // 
            this.Bu_Matrix_cipher.AutoSize = false;
            this.Bu_Matrix_cipher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Matrix_cipher.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Matrix_cipher.Depth = 0;
            this.Bu_Matrix_cipher.DrawShadows = true;
            this.Bu_Matrix_cipher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Matrix_cipher.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Matrix_cipher.HighEmphasis = true;
            this.Bu_Matrix_cipher.Icon = null;
            this.Bu_Matrix_cipher.Location = new System.Drawing.Point(4, 126);
            this.Bu_Matrix_cipher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Matrix_cipher.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Matrix_cipher.Name = "Bu_Matrix_cipher";
            this.Bu_Matrix_cipher.Size = new System.Drawing.Size(230, 20);
            this.Bu_Matrix_cipher.TabIndex = 41;
            this.Bu_Matrix_cipher.Text = "Matrix cipher";
            this.Bu_Matrix_cipher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Matrix_cipher.UseAccentColor = true;
            this.Bu_Matrix_cipher.UseVisualStyleBackColor = false;
            this.Bu_Matrix_cipher.Click += new System.EventHandler(this.Bu_Matrix_cipher_Click);
            // 
            // Bu_А5_1
            // 
            this.Bu_А5_1.AutoSize = false;
            this.Bu_А5_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_А5_1.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_А5_1.Depth = 0;
            this.Bu_А5_1.DrawShadows = true;
            this.Bu_А5_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_А5_1.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_А5_1.HighEmphasis = true;
            this.Bu_А5_1.Icon = null;
            this.Bu_А5_1.Location = new System.Drawing.Point(4, 266);
            this.Bu_А5_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_А5_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_А5_1.Name = "Bu_А5_1";
            this.Bu_А5_1.Size = new System.Drawing.Size(230, 20);
            this.Bu_А5_1.TabIndex = 47;
            this.Bu_А5_1.Text = "А5 /1";
            this.Bu_А5_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_А5_1.UseAccentColor = true;
            this.Bu_А5_1.UseVisualStyleBackColor = false;
            this.Bu_А5_1.Click += new System.EventHandler(this.Bu_А5_1_Click);
            // 
            // Bu_Playfer
            // 
            this.Bu_Playfer.AutoSize = false;
            this.Bu_Playfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Playfer.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Playfer.Depth = 0;
            this.Bu_Playfer.DrawShadows = true;
            this.Bu_Playfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Playfer.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Playfer.HighEmphasis = true;
            this.Bu_Playfer.Icon = null;
            this.Bu_Playfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bu_Playfer.Location = new System.Drawing.Point(4, 146);
            this.Bu_Playfer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Playfer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Playfer.Name = "Bu_Playfer";
            this.Bu_Playfer.Size = new System.Drawing.Size(230, 20);
            this.Bu_Playfer.TabIndex = 42;
            this.Bu_Playfer.Text = "Playfer";
            this.Bu_Playfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Playfer.UseAccentColor = true;
            this.Bu_Playfer.UseVisualStyleBackColor = false;
            this.Bu_Playfer.Click += new System.EventHandler(this.Bu_Playfer_Click);
            // 
            // Bu_Magma
            // 
            this.Bu_Magma.AutoSize = false;
            this.Bu_Magma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Magma.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Magma.Depth = 0;
            this.Bu_Magma.DrawShadows = true;
            this.Bu_Magma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Magma.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Magma.HighEmphasis = true;
            this.Bu_Magma.Icon = null;
            this.Bu_Magma.Location = new System.Drawing.Point(4, 246);
            this.Bu_Magma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Magma.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Magma.Name = "Bu_Magma";
            this.Bu_Magma.Size = new System.Drawing.Size(230, 20);
            this.Bu_Magma.TabIndex = 46;
            this.Bu_Magma.Text = "Magma";
            this.Bu_Magma.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Magma.UseAccentColor = true;
            this.Bu_Magma.UseVisualStyleBackColor = false;
            this.Bu_Magma.Click += new System.EventHandler(this.Bu_Magma_Click);
            // 
            // Bu_Vertical_permutation
            // 
            this.Bu_Vertical_permutation.AutoSize = false;
            this.Bu_Vertical_permutation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Vertical_permutation.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Vertical_permutation.Depth = 0;
            this.Bu_Vertical_permutation.DrawShadows = true;
            this.Bu_Vertical_permutation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Vertical_permutation.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Vertical_permutation.HighEmphasis = true;
            this.Bu_Vertical_permutation.Icon = null;
            this.Bu_Vertical_permutation.Location = new System.Drawing.Point(4, 166);
            this.Bu_Vertical_permutation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Vertical_permutation.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Vertical_permutation.Name = "Bu_Vertical_permutation";
            this.Bu_Vertical_permutation.Size = new System.Drawing.Size(230, 20);
            this.Bu_Vertical_permutation.TabIndex = 43;
            this.Bu_Vertical_permutation.Text = "Vertical permutation";
            this.Bu_Vertical_permutation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Vertical_permutation.UseAccentColor = true;
            this.Bu_Vertical_permutation.UseVisualStyleBackColor = false;
            this.Bu_Vertical_permutation.Click += new System.EventHandler(this.Bu_Vertical_permutation_Click);
            // 
            // Bu_Shannon
            // 
            this.Bu_Shannon.AutoSize = false;
            this.Bu_Shannon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Shannon.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Shannon.Depth = 0;
            this.Bu_Shannon.DrawShadows = true;
            this.Bu_Shannon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Shannon.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Shannon.HighEmphasis = true;
            this.Bu_Shannon.Icon = null;
            this.Bu_Shannon.Location = new System.Drawing.Point(4, 206);
            this.Bu_Shannon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Shannon.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Shannon.Name = "Bu_Shannon";
            this.Bu_Shannon.Size = new System.Drawing.Size(230, 20);
            this.Bu_Shannon.TabIndex = 45;
            this.Bu_Shannon.Text = "Shannon";
            this.Bu_Shannon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Shannon.UseAccentColor = true;
            this.Bu_Shannon.UseVisualStyleBackColor = false;
            this.Bu_Shannon.Click += new System.EventHandler(this.Bu_Shannon_Click);
            // 
            // Bu_Cardano_grille
            // 
            this.Bu_Cardano_grille.AutoSize = false;
            this.Bu_Cardano_grille.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Cardano_grille.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_Cardano_grille.Depth = 0;
            this.Bu_Cardano_grille.DrawShadows = true;
            this.Bu_Cardano_grille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_Cardano_grille.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_Cardano_grille.HighEmphasis = true;
            this.Bu_Cardano_grille.Icon = null;
            this.Bu_Cardano_grille.Location = new System.Drawing.Point(4, 186);
            this.Bu_Cardano_grille.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Cardano_grille.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Cardano_grille.Name = "Bu_Cardano_grille";
            this.Bu_Cardano_grille.Size = new System.Drawing.Size(230, 20);
            this.Bu_Cardano_grille.TabIndex = 44;
            this.Bu_Cardano_grille.Text = "Cardano grille";
            this.Bu_Cardano_grille.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_Cardano_grille.UseAccentColor = true;
            this.Bu_Cardano_grille.UseVisualStyleBackColor = false;
            this.Bu_Cardano_grille.Click += new System.EventHandler(this.Bu_Cardano_grille_Click);
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(247, 3);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(10, 513);
            this.Divider.TabIndex = 36;
            this.Divider.Text = "materialDivider1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LabelCheck);
            this.panel1.Controls.Add(this.LabelEncryptedMessage);
            this.panel1.Controls.Add(this.LabelMessages);
            this.panel1.Controls.Add(this.panelKeys);
            this.panel1.Controls.Add(this.DividerMessages);
            this.panel1.Controls.Add(this.TextBoxCheck);
            this.panel1.Controls.Add(this.DividerEncryptedMessage);
            this.panel1.Controls.Add(this.TextBoxEncryptedMessage);
            this.panel1.Controls.Add(this.TextBoxMessages);
            this.panel1.Controls.Add(this.DividerCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(263, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 513);
            this.panel1.TabIndex = 78;
            // 
            // LabelCheck
            // 
            this.LabelCheck.AutoSize = true;
            this.LabelCheck.Depth = 0;
            this.LabelCheck.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCheck.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCheck.HighEmphasis = true;
            this.LabelCheck.Location = new System.Drawing.Point(282, 350);
            this.LabelCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCheck.Name = "LabelCheck";
            this.LabelCheck.Size = new System.Drawing.Size(40, 17);
            this.LabelCheck.TabIndex = 79;
            this.LabelCheck.Text = "Check";
            this.LabelCheck.UseAccent = true;
            // 
            // LabelEncryptedMessage
            // 
            this.LabelEncryptedMessage.AutoSize = true;
            this.LabelEncryptedMessage.Depth = 0;
            this.LabelEncryptedMessage.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelEncryptedMessage.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelEncryptedMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelEncryptedMessage.HighEmphasis = true;
            this.LabelEncryptedMessage.Location = new System.Drawing.Point(244, 171);
            this.LabelEncryptedMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelEncryptedMessage.Name = "LabelEncryptedMessage";
            this.LabelEncryptedMessage.Size = new System.Drawing.Size(126, 17);
            this.LabelEncryptedMessage.TabIndex = 75;
            this.LabelEncryptedMessage.Text = "Encrypted Message";
            this.LabelEncryptedMessage.UseAccent = true;
            // 
            // LabelMessages
            // 
            this.LabelMessages.AutoSize = true;
            this.LabelMessages.Depth = 0;
            this.LabelMessages.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMessages.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelMessages.HighEmphasis = true;
            this.LabelMessages.Location = new System.Drawing.Point(244, 95);
            this.LabelMessages.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMessages.Name = "LabelMessages";
            this.LabelMessages.Size = new System.Drawing.Size(66, 17);
            this.LabelMessages.TabIndex = 76;
            this.LabelMessages.Text = "Messages";
            this.LabelMessages.UseAccent = true;
            // 
            // panelKeys
            // 
            this.panelKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelKeys.Controls.Add(this.Elgamal_X);
            this.panelKeys.Controls.Add(this.Elgamal_G);
            this.panelKeys.Controls.Add(this.Elgamal_P);
            this.panelKeys.Controls.Add(this.BuTest);
            this.panelKeys.Controls.Add(this.BuClear);
            this.panelKeys.Controls.Add(this.LabelError);
            this.panelKeys.Controls.Add(this.LabelKeys);
            this.panelKeys.Controls.Add(this.BuText);
            this.panelKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKeys.Location = new System.Drawing.Point(0, 0);
            this.panelKeys.Name = "panelKeys";
            this.panelKeys.Size = new System.Drawing.Size(760, 90);
            this.panelKeys.TabIndex = 20;
            // 
            // Elgamal_X
            // 
            this.Elgamal_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Elgamal_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Elgamal_X.Depth = 0;
            this.Elgamal_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Elgamal_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Elgamal_X.Hint = "X";
            this.Elgamal_X.Location = new System.Drawing.Point(172, 0);
            this.Elgamal_X.MaxLength = 50000;
            this.Elgamal_X.MouseState = MaterialSkin.MouseState.OUT;
            this.Elgamal_X.Multiline = false;
            this.Elgamal_X.Name = "Elgamal_X";
            this.Elgamal_X.Size = new System.Drawing.Size(80, 50);
            this.Elgamal_X.TabIndex = 118;
            this.Elgamal_X.Text = "20";
            this.Elgamal_X.Visible = false;
            // 
            // Elgamal_G
            // 
            this.Elgamal_G.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Elgamal_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Elgamal_G.Depth = 0;
            this.Elgamal_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Elgamal_G.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Elgamal_G.Hint = "G";
            this.Elgamal_G.Location = new System.Drawing.Point(86, 0);
            this.Elgamal_G.MaxLength = 50000;
            this.Elgamal_G.MouseState = MaterialSkin.MouseState.OUT;
            this.Elgamal_G.Multiline = false;
            this.Elgamal_G.Name = "Elgamal_G";
            this.Elgamal_G.Size = new System.Drawing.Size(80, 50);
            this.Elgamal_G.TabIndex = 117;
            this.Elgamal_G.Text = "13";
            this.Elgamal_G.Visible = false;
            // 
            // Elgamal_P
            // 
            this.Elgamal_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Elgamal_P.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Elgamal_P.Depth = 0;
            this.Elgamal_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Elgamal_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Elgamal_P.Hint = "P";
            this.Elgamal_P.Location = new System.Drawing.Point(0, 0);
            this.Elgamal_P.MaxLength = 50000;
            this.Elgamal_P.MouseState = MaterialSkin.MouseState.OUT;
            this.Elgamal_P.Multiline = false;
            this.Elgamal_P.Name = "Elgamal_P";
            this.Elgamal_P.Size = new System.Drawing.Size(80, 50);
            this.Elgamal_P.TabIndex = 116;
            this.Elgamal_P.Text = "47";
            this.Elgamal_P.Visible = false;
            // 
            // BuTest
            // 
            this.BuTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuTest.Depth = 0;
            this.BuTest.DrawShadows = true;
            this.BuTest.HighEmphasis = true;
            this.BuTest.Icon = null;
            this.BuTest.Location = new System.Drawing.Point(142, 51);
            this.BuTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuTest.Name = "BuTest";
            this.BuTest.Size = new System.Drawing.Size(56, 36);
            this.BuTest.TabIndex = 86;
            this.BuTest.Text = "Test";
            this.BuTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuTest.UseAccentColor = false;
            this.BuTest.UseVisualStyleBackColor = true;
            this.BuTest.Click += new System.EventHandler(this.BuTest_Click);
            // 
            // BuClear
            // 
            this.BuClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuClear.Depth = 0;
            this.BuClear.DrawShadows = true;
            this.BuClear.HighEmphasis = true;
            this.BuClear.Icon = null;
            this.BuClear.Location = new System.Drawing.Point(68, 51);
            this.BuClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuClear.Name = "BuClear";
            this.BuClear.Size = new System.Drawing.Size(66, 36);
            this.BuClear.TabIndex = 85;
            this.BuClear.Text = "Clear";
            this.BuClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuClear.UseAccentColor = false;
            this.BuClear.UseVisualStyleBackColor = true;
            this.BuClear.Click += new System.EventHandler(this.BuClear_Click);
            // 
            // LabelError
            // 
            this.LabelError.Depth = 0;
            this.LabelError.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelError.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelError.HighEmphasis = true;
            this.LabelError.Location = new System.Drawing.Point(376, 2);
            this.LabelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(384, 84);
            this.LabelError.TabIndex = 84;
            this.LabelError.Text = "Messages";
            this.LabelError.UseAccent = true;
            // 
            // LabelKeys
            // 
            this.LabelKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LabelKeys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelKeys.Depth = 0;
            this.LabelKeys.Font = new System.Drawing.Font("Roboto", 12F);
            this.LabelKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelKeys.Hint = "Type here key";
            this.LabelKeys.Location = new System.Drawing.Point(0, 0);
            this.LabelKeys.MaxLength = 50000;
            this.LabelKeys.MouseState = MaterialSkin.MouseState.OUT;
            this.LabelKeys.Multiline = false;
            this.LabelKeys.Name = "LabelKeys";
            this.LabelKeys.Size = new System.Drawing.Size(370, 50);
            this.LabelKeys.TabIndex = 82;
            this.LabelKeys.Text = "";
            this.LabelKeys.Visible = false;
            this.LabelKeys.TextChanged += new System.EventHandler(this.LabelKeys_TextChanged);
            // 
            // BuText
            // 
            this.BuText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuText.Depth = 0;
            this.BuText.DrawShadows = true;
            this.BuText.HighEmphasis = true;
            this.BuText.Icon = null;
            this.BuText.Location = new System.Drawing.Point(4, 51);
            this.BuText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuText.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuText.Name = "BuText";
            this.BuText.Size = new System.Drawing.Size(57, 36);
            this.BuText.TabIndex = 81;
            this.BuText.Text = "Text";
            this.BuText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuText.UseAccentColor = false;
            this.BuText.UseVisualStyleBackColor = true;
            this.BuText.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // DividerMessages
            // 
            this.DividerMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DividerMessages.Depth = 0;
            this.DividerMessages.Location = new System.Drawing.Point(-12, 115);
            this.DividerMessages.MouseState = MaterialSkin.MouseState.HOVER;
            this.DividerMessages.Name = "DividerMessages";
            this.DividerMessages.Size = new System.Drawing.Size(941, 10);
            this.DividerMessages.TabIndex = 73;
            this.DividerMessages.Text = "materialDivider3";
            // 
            // TextBoxCheck
            // 
            this.TextBoxCheck.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextBoxCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCheck.Location = new System.Drawing.Point(-1, 366);
            this.TextBoxCheck.Name = "TextBoxCheck";
            this.TextBoxCheck.ReadOnly = true;
            this.TextBoxCheck.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBoxCheck.Size = new System.Drawing.Size(608, 140);
            this.TextBoxCheck.TabIndex = 77;
            this.TextBoxCheck.Text = "";
            // 
            // DividerEncryptedMessage
            // 
            this.DividerEncryptedMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DividerEncryptedMessage.Depth = 0;
            this.DividerEncryptedMessage.Location = new System.Drawing.Point(-1, 158);
            this.DividerEncryptedMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.DividerEncryptedMessage.Name = "DividerEncryptedMessage";
            this.DividerEncryptedMessage.Size = new System.Drawing.Size(915, 10);
            this.DividerEncryptedMessage.TabIndex = 71;
            this.DividerEncryptedMessage.Text = "materialDivider2";
            // 
            // TextBoxEncryptedMessage
            // 
            this.TextBoxEncryptedMessage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextBoxEncryptedMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEncryptedMessage.Location = new System.Drawing.Point(-1, 191);
            this.TextBoxEncryptedMessage.Name = "TextBoxEncryptedMessage";
            this.TextBoxEncryptedMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBoxEncryptedMessage.Size = new System.Drawing.Size(626, 140);
            this.TextBoxEncryptedMessage.TabIndex = 70;
            this.TextBoxEncryptedMessage.Text = "";
            this.TextBoxEncryptedMessage.TextChanged += new System.EventHandler(this.TextBoxEncryptedMessage_TextChanged);
            // 
            // TextBoxMessages
            // 
            this.TextBoxMessages.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMessages.Location = new System.Drawing.Point(-2, 78);
            this.TextBoxMessages.Name = "TextBoxMessages";
            this.TextBoxMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBoxMessages.Size = new System.Drawing.Size(627, 83);
            this.TextBoxMessages.TabIndex = 72;
            this.TextBoxMessages.Text = "";
            this.TextBoxMessages.TextChanged += new System.EventHandler(this.TextBoxMessages_TextChanged);
            // 
            // DividerCheck
            // 
            this.DividerCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DividerCheck.Depth = 0;
            this.DividerCheck.Location = new System.Drawing.Point(-1, 337);
            this.DividerCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.DividerCheck.Name = "DividerCheck";
            this.DividerCheck.Size = new System.Drawing.Size(917, 10);
            this.DividerCheck.TabIndex = 78;
            this.DividerCheck.Text = "materialDivider2";
            // 
            // tabPageDigitalSignature
            // 
            this.tabPageDigitalSignature.BackColor = System.Drawing.Color.White;
            this.tabPageDigitalSignature.Location = new System.Drawing.Point(4, 22);
            this.tabPageDigitalSignature.Name = "tabPageDigitalSignature";
            this.tabPageDigitalSignature.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDigitalSignature.Size = new System.Drawing.Size(1246, 525);
            this.tabPageDigitalSignature.TabIndex = 1;
            this.tabPageDigitalSignature.Text = "Digital signature";
            // 
            // tabPageDiffieHellman
            // 
            this.tabPageDiffieHellman.Controls.Add(this.KeyN);
            this.tabPageDiffieHellman.Controls.Add(this.KeyA);
            this.tabPageDiffieHellman.Controls.Add(this.BuCheck);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel9);
            this.tabPageDiffieHellman.Controls.Add(this.LabelError_Hellman);
            this.tabPageDiffieHellman.Controls.Add(this.BuRandom);
            this.tabPageDiffieHellman.Controls.Add(this.SecretKeyB);
            this.tabPageDiffieHellman.Controls.Add(this.SecretKeyA);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel7);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel6);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel5);
            this.tabPageDiffieHellman.Controls.Add(this.KeyYB);
            this.tabPageDiffieHellman.Controls.Add(this.KeyYA);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel4);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel3);
            this.tabPageDiffieHellman.Controls.Add(this.KeyKB);
            this.tabPageDiffieHellman.Controls.Add(this.KeyKA);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel2);
            this.tabPageDiffieHellman.Controls.Add(this.materialLabel1);
            this.tabPageDiffieHellman.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiffieHellman.Name = "tabPageDiffieHellman";
            this.tabPageDiffieHellman.Size = new System.Drawing.Size(1246, 525);
            this.tabPageDiffieHellman.TabIndex = 2;
            this.tabPageDiffieHellman.Text = "Diffie–Hellman";
            this.tabPageDiffieHellman.UseVisualStyleBackColor = true;
            // 
            // KeyN
            // 
            this.KeyN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyN.Depth = 0;
            this.KeyN.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyN.Hint = "Type here key N";
            this.KeyN.Location = new System.Drawing.Point(159, 20);
            this.KeyN.MaxLength = 50000;
            this.KeyN.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyN.Multiline = false;
            this.KeyN.Name = "KeyN";
            this.KeyN.Size = new System.Drawing.Size(150, 50);
            this.KeyN.TabIndex = 103;
            this.KeyN.Text = "";
            // 
            // KeyA
            // 
            this.KeyA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyA.Depth = 0;
            this.KeyA.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyA.Hint = "Type here key A";
            this.KeyA.Location = new System.Drawing.Point(3, 20);
            this.KeyA.MaxLength = 50000;
            this.KeyA.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyA.Multiline = false;
            this.KeyA.Name = "KeyA";
            this.KeyA.Size = new System.Drawing.Size(150, 50);
            this.KeyA.TabIndex = 102;
            this.KeyA.Text = "";
            // 
            // BuCheck
            // 
            this.BuCheck.AutoSize = false;
            this.BuCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuCheck.Depth = 0;
            this.BuCheck.DrawShadows = true;
            this.BuCheck.HighEmphasis = true;
            this.BuCheck.Icon = null;
            this.BuCheck.Location = new System.Drawing.Point(3, 315);
            this.BuCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuCheck.Name = "BuCheck";
            this.BuCheck.Size = new System.Drawing.Size(150, 36);
            this.BuCheck.TabIndex = 101;
            this.BuCheck.Text = "Проверить";
            this.BuCheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuCheck.UseAccentColor = false;
            this.BuCheck.UseVisualStyleBackColor = true;
            this.BuCheck.Click += new System.EventHandler(this.BuCheck_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.HighEmphasis = true;
            this.materialLabel9.Location = new System.Drawing.Point(3, 357);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(104, 17);
            this.materialLabel9.TabIndex = 100;
            this.materialLabel9.Text = "Вывод ошибок:";
            this.materialLabel9.UseAccent = true;
            // 
            // LabelError_Hellman
            // 
            this.LabelError_Hellman.Depth = 0;
            this.LabelError_Hellman.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelError_Hellman.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelError_Hellman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelError_Hellman.HighEmphasis = true;
            this.LabelError_Hellman.Location = new System.Drawing.Point(3, 374);
            this.LabelError_Hellman.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelError_Hellman.Name = "LabelError_Hellman";
            this.LabelError_Hellman.Size = new System.Drawing.Size(1240, 151);
            this.LabelError_Hellman.TabIndex = 99;
            this.LabelError_Hellman.UseAccent = true;
            // 
            // BuRandom
            // 
            this.BuRandom.AutoSize = false;
            this.BuRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuRandom.Depth = 0;
            this.BuRandom.DrawShadows = true;
            this.BuRandom.HighEmphasis = true;
            this.BuRandom.Icon = null;
            this.BuRandom.Location = new System.Drawing.Point(159, 315);
            this.BuRandom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuRandom.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuRandom.Name = "BuRandom";
            this.BuRandom.Size = new System.Drawing.Size(150, 36);
            this.BuRandom.TabIndex = 98;
            this.BuRandom.Text = "Сгенерировать";
            this.BuRandom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuRandom.UseAccentColor = false;
            this.BuRandom.UseVisualStyleBackColor = true;
            this.BuRandom.Click += new System.EventHandler(this.BuRandom_Click);
            // 
            // SecretKeyB
            // 
            this.SecretKeyB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretKeyB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecretKeyB.Depth = 0;
            this.SecretKeyB.Enabled = false;
            this.SecretKeyB.Font = new System.Drawing.Font("Roboto", 12F);
            this.SecretKeyB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SecretKeyB.Hint = "Secret key";
            this.SecretKeyB.Location = new System.Drawing.Point(159, 256);
            this.SecretKeyB.MaxLength = 50000;
            this.SecretKeyB.MouseState = MaterialSkin.MouseState.OUT;
            this.SecretKeyB.Multiline = false;
            this.SecretKeyB.Name = "SecretKeyB";
            this.SecretKeyB.Size = new System.Drawing.Size(150, 50);
            this.SecretKeyB.TabIndex = 97;
            this.SecretKeyB.Text = "";
            // 
            // SecretKeyA
            // 
            this.SecretKeyA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecretKeyA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecretKeyA.Depth = 0;
            this.SecretKeyA.Enabled = false;
            this.SecretKeyA.Font = new System.Drawing.Font("Roboto", 12F);
            this.SecretKeyA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SecretKeyA.Hint = "Secret key";
            this.SecretKeyA.Location = new System.Drawing.Point(3, 256);
            this.SecretKeyA.MaxLength = 50000;
            this.SecretKeyA.MouseState = MaterialSkin.MouseState.OUT;
            this.SecretKeyA.Multiline = false;
            this.SecretKeyA.Name = "SecretKeyA";
            this.SecretKeyA.Size = new System.Drawing.Size(150, 50);
            this.SecretKeyA.TabIndex = 96;
            this.SecretKeyA.Text = "";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.HighEmphasis = true;
            this.materialLabel7.Location = new System.Drawing.Point(3, 236);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(644, 17);
            this.materialLabel7.TabIndex = 95;
            this.materialLabel7.Text = "5) Независимо для каждого пользователя определить общий секретный ключ К: K=Y^KA " +
    "mod n\r\n";
            this.materialLabel7.UseAccent = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(318, 183);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(176, 17);
            this.materialLabel6.TabIndex = 94;
            this.materialLabel6.Text = "- Отдаем YA, получаем YB";
            this.materialLabel6.UseAccent = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(3, 219);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(406, 17);
            this.materialLabel5.TabIndex = 93;
            this.materialLabel5.Text = "4) Обменяться ключами YA и YB по открытому каналу связи";
            this.materialLabel5.UseAccent = true;
            // 
            // KeyYB
            // 
            this.KeyYB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyYB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyYB.Depth = 0;
            this.KeyYB.Enabled = false;
            this.KeyYB.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyYB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyYB.Hint = "YB";
            this.KeyYB.Location = new System.Drawing.Point(159, 166);
            this.KeyYB.MaxLength = 50000;
            this.KeyYB.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyYB.Multiline = false;
            this.KeyYB.Name = "KeyYB";
            this.KeyYB.Size = new System.Drawing.Size(150, 50);
            this.KeyYB.TabIndex = 92;
            this.KeyYB.Text = "";
            // 
            // KeyYA
            // 
            this.KeyYA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyYA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyYA.Depth = 0;
            this.KeyYA.Enabled = false;
            this.KeyYA.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyYA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyYA.Hint = "YA";
            this.KeyYA.Location = new System.Drawing.Point(3, 166);
            this.KeyYA.MaxLength = 50000;
            this.KeyYA.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyYA.Multiline = false;
            this.KeyYA.Name = "KeyYA";
            this.KeyYA.Size = new System.Drawing.Size(150, 50);
            this.KeyYA.TabIndex = 91;
            this.KeyYA.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(3, 146);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(462, 17);
            this.materialLabel4.TabIndex = 90;
            this.materialLabel4.Text = "3) Вычислить открытые ключи пользователей YA и YB: Y = a^k mod n;";
            this.materialLabel4.UseAccent = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(315, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(223, 17);
            this.materialLabel3.TabIndex = 89;
            this.materialLabel3.Text = "- KB считаем что нам неизвестен";
            this.materialLabel3.UseAccent = true;
            // 
            // KeyKB
            // 
            this.KeyKB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyKB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyKB.Depth = 0;
            this.KeyKB.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyKB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyKB.Hint = "Type here key KB";
            this.KeyKB.Location = new System.Drawing.Point(159, 93);
            this.KeyKB.MaxLength = 50000;
            this.KeyKB.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyKB.Multiline = false;
            this.KeyKB.Name = "KeyKB";
            this.KeyKB.Size = new System.Drawing.Size(150, 50);
            this.KeyKB.TabIndex = 88;
            this.KeyKB.Text = "";
            // 
            // KeyKA
            // 
            this.KeyKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyKA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyKA.Depth = 0;
            this.KeyKA.Font = new System.Drawing.Font("Roboto", 12F);
            this.KeyKA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyKA.Hint = "Type here key KA";
            this.KeyKA.Location = new System.Drawing.Point(3, 93);
            this.KeyKA.MaxLength = 50000;
            this.KeyKA.MouseState = MaterialSkin.MouseState.OUT;
            this.KeyKA.Multiline = false;
            this.KeyKA.Name = "KeyKA";
            this.KeyKA.Size = new System.Drawing.Size(150, 50);
            this.KeyKA.TabIndex = 87;
            this.KeyKA.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(3, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(816, 17);
            this.materialLabel2.TabIndex = 86;
            this.materialLabel2.Text = "2) Определить секретные ключи пользователей А и В - соответственно КА и КВ - случ" +
    "айные числа из интервала (2,..., n-1)\r\n";
            this.materialLabel2.UseAccent = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(276, 17);
            this.materialLabel1.TabIndex = 85;
            this.materialLabel1.Text = "1) Задать общие параметры n и a (1<a<n)";
            this.materialLabel1.UseAccent = true;
            // 
            // tabPageRSA
            // 
            this.tabPageRSA.Controls.Add(this.materialLabel8);
            this.tabPageRSA.Controls.Add(this.LabelError_RSA);
            this.tabPageRSA.Controls.Add(this.Key_Q);
            this.tabPageRSA.Controls.Add(this.Key_P);
            this.tabPageRSA.Controls.Add(this.BuCheckRSA);
            this.tabPageRSA.Controls.Add(this.BuRandomRSA);
            this.tabPageRSA.Controls.Add(this.Key_D);
            this.tabPageRSA.Controls.Add(this.Public_key);
            this.tabPageRSA.Controls.Add(this.materialLabel10);
            this.tabPageRSA.Controls.Add(this.labelPublic_key);
            this.tabPageRSA.Controls.Add(this.materialLabel12);
            this.tabPageRSA.Controls.Add(this.Key_φ);
            this.tabPageRSA.Controls.Add(this.Key_N);
            this.tabPageRSA.Controls.Add(this.materialLabel13);
            this.tabPageRSA.Controls.Add(this.materialLabel14);
            this.tabPageRSA.Controls.Add(this.Private_key);
            this.tabPageRSA.Controls.Add(this.Key_E);
            this.tabPageRSA.Controls.Add(this.materialLabel15);
            this.tabPageRSA.Controls.Add(this.materialLabel16);
            this.tabPageRSA.Location = new System.Drawing.Point(4, 22);
            this.tabPageRSA.Name = "tabPageRSA";
            this.tabPageRSA.Size = new System.Drawing.Size(1246, 525);
            this.tabPageRSA.TabIndex = 3;
            this.tabPageRSA.Text = "RSA";
            this.tabPageRSA.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(394, 3);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 17);
            this.materialLabel8.TabIndex = 123;
            this.materialLabel8.Text = "Вывод ошибок:";
            this.materialLabel8.UseAccent = true;
            // 
            // LabelError_RSA
            // 
            this.LabelError_RSA.Depth = 0;
            this.LabelError_RSA.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelError_RSA.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LabelError_RSA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelError_RSA.HighEmphasis = true;
            this.LabelError_RSA.Location = new System.Drawing.Point(394, 20);
            this.LabelError_RSA.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelError_RSA.Name = "LabelError_RSA";
            this.LabelError_RSA.Size = new System.Drawing.Size(849, 505);
            this.LabelError_RSA.TabIndex = 122;
            this.LabelError_RSA.UseAccent = true;
            // 
            // Key_Q
            // 
            this.Key_Q.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_Q.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_Q.Depth = 0;
            this.Key_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Key_Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_Q.Hint = "Type here key Q";
            this.Key_Q.Location = new System.Drawing.Point(195, 20);
            this.Key_Q.MaxLength = 50000;
            this.Key_Q.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_Q.Multiline = false;
            this.Key_Q.Name = "Key_Q";
            this.Key_Q.Size = new System.Drawing.Size(150, 50);
            this.Key_Q.TabIndex = 121;
            this.Key_Q.Text = "17";
            // 
            // Key_P
            // 
            this.Key_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_P.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_P.Depth = 0;
            this.Key_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Key_P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_P.Hint = "Type here key P";
            this.Key_P.Location = new System.Drawing.Point(3, 20);
            this.Key_P.MaxLength = 50000;
            this.Key_P.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_P.Multiline = false;
            this.Key_P.Name = "Key_P";
            this.Key_P.Size = new System.Drawing.Size(150, 50);
            this.Key_P.TabIndex = 120;
            this.Key_P.Text = "5";
            // 
            // BuCheckRSA
            // 
            this.BuCheckRSA.AutoSize = false;
            this.BuCheckRSA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuCheckRSA.Depth = 0;
            this.BuCheckRSA.DrawShadows = true;
            this.BuCheckRSA.HighEmphasis = true;
            this.BuCheckRSA.Icon = null;
            this.BuCheckRSA.Location = new System.Drawing.Point(3, 371);
            this.BuCheckRSA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuCheckRSA.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuCheckRSA.Name = "BuCheckRSA";
            this.BuCheckRSA.Size = new System.Drawing.Size(150, 36);
            this.BuCheckRSA.TabIndex = 119;
            this.BuCheckRSA.Text = "Проверить";
            this.BuCheckRSA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuCheckRSA.UseAccentColor = false;
            this.BuCheckRSA.UseVisualStyleBackColor = true;
            this.BuCheckRSA.Click += new System.EventHandler(this.BuCheckRSA_Click);
            // 
            // BuRandomRSA
            // 
            this.BuRandomRSA.AutoSize = false;
            this.BuRandomRSA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuRandomRSA.Depth = 0;
            this.BuRandomRSA.DrawShadows = true;
            this.BuRandomRSA.HighEmphasis = true;
            this.BuRandomRSA.Icon = null;
            this.BuRandomRSA.Location = new System.Drawing.Point(168, 371);
            this.BuRandomRSA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuRandomRSA.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuRandomRSA.Name = "BuRandomRSA";
            this.BuRandomRSA.Size = new System.Drawing.Size(150, 36);
            this.BuRandomRSA.TabIndex = 117;
            this.BuRandomRSA.Text = "Сгенерировать";
            this.BuRandomRSA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuRandomRSA.UseAccentColor = false;
            this.BuRandomRSA.UseVisualStyleBackColor = true;
            this.BuRandomRSA.Click += new System.EventHandler(this.BuRandomRSA_Click);
            // 
            // Key_D
            // 
            this.Key_D.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_D.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_D.Depth = 0;
            this.Key_D.Enabled = false;
            this.Key_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Key_D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_D.Hint = "Secret key";
            this.Key_D.Location = new System.Drawing.Point(3, 239);
            this.Key_D.MaxLength = 50000;
            this.Key_D.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_D.Multiline = false;
            this.Key_D.Name = "Key_D";
            this.Key_D.Size = new System.Drawing.Size(150, 50);
            this.Key_D.TabIndex = 116;
            this.Key_D.Text = "D";
            // 
            // Public_key
            // 
            this.Public_key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Public_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Public_key.Depth = 0;
            this.Public_key.Font = new System.Drawing.Font("Roboto", 12F);
            this.Public_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Public_key.Hint = "Public key";
            this.Public_key.Location = new System.Drawing.Point(3, 312);
            this.Public_key.MaxLength = 50000;
            this.Public_key.MouseState = MaterialSkin.MouseState.OUT;
            this.Public_key.Multiline = false;
            this.Public_key.Name = "Public_key";
            this.Public_key.Size = new System.Drawing.Size(150, 50);
            this.Public_key.TabIndex = 115;
            this.Public_key.Text = "";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.HighEmphasis = true;
            this.materialLabel10.Location = new System.Drawing.Point(3, 219);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(107, 17);
            this.materialLabel10.TabIndex = 114;
            this.materialLabel10.Text = "5) Вычисляем D";
            this.materialLabel10.UseAccent = true;
            // 
            // labelPublic_key
            // 
            this.labelPublic_key.AutoSize = true;
            this.labelPublic_key.Depth = 0;
            this.labelPublic_key.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPublic_key.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labelPublic_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPublic_key.HighEmphasis = true;
            this.labelPublic_key.Location = new System.Drawing.Point(44, 292);
            this.labelPublic_key.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPublic_key.Name = "labelPublic_key";
            this.labelPublic_key.Size = new System.Drawing.Size(109, 17);
            this.labelPublic_key.TabIndex = 113;
            this.labelPublic_key.Text = "Открытый ключ";
            this.labelPublic_key.UseAccent = true;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.HighEmphasis = true;
            this.materialLabel12.Location = new System.Drawing.Point(210, 292);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(108, 17);
            this.materialLabel12.TabIndex = 112;
            this.materialLabel12.Text = "Закрытый ключ";
            this.materialLabel12.UseAccent = true;
            // 
            // Key_φ
            // 
            this.Key_φ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_φ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_φ.Depth = 0;
            this.Key_φ.Enabled = false;
            this.Key_φ.Font = new System.Drawing.Font("Roboto", 12F);
            this.Key_φ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_φ.Hint = "φ";
            this.Key_φ.Location = new System.Drawing.Point(195, 93);
            this.Key_φ.MaxLength = 50000;
            this.Key_φ.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_φ.Multiline = false;
            this.Key_φ.Name = "Key_φ";
            this.Key_φ.Size = new System.Drawing.Size(150, 50);
            this.Key_φ.TabIndex = 111;
            this.Key_φ.Text = "";
            // 
            // Key_N
            // 
            this.Key_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_N.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_N.Depth = 0;
            this.Key_N.Enabled = false;
            this.Key_N.Font = new System.Drawing.Font("Roboto", 12F);
            this.Key_N.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_N.Hint = "N";
            this.Key_N.Location = new System.Drawing.Point(3, 93);
            this.Key_N.MaxLength = 50000;
            this.Key_N.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_N.Multiline = false;
            this.Key_N.Name = "Key_N";
            this.Key_N.Size = new System.Drawing.Size(150, 50);
            this.Key_N.TabIndex = 110;
            this.Key_N.Text = "";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.HighEmphasis = true;
            this.materialLabel13.Location = new System.Drawing.Point(156, 73);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(207, 17);
            this.materialLabel13.TabIndex = 109;
            this.materialLabel13.Text = "3) Вычислить φ(N)=(P-1)*(Q-1).";
            this.materialLabel13.UseAccent = true;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.HighEmphasis = true;
            this.materialLabel14.Location = new System.Drawing.Point(3, 146);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(315, 17);
            this.materialLabel14.TabIndex = 108;
            this.materialLabel14.Text = "4) Задать E (Простое, < φ, взаимно простое с φ)";
            this.materialLabel14.UseAccent = true;
            // 
            // Private_key
            // 
            this.Private_key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Private_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Private_key.Depth = 0;
            this.Private_key.Font = new System.Drawing.Font("Roboto", 12F);
            this.Private_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Private_key.Hint = "Private key";
            this.Private_key.Location = new System.Drawing.Point(168, 312);
            this.Private_key.MaxLength = 50000;
            this.Private_key.MouseState = MaterialSkin.MouseState.OUT;
            this.Private_key.Multiline = false;
            this.Private_key.Name = "Private_key";
            this.Private_key.Size = new System.Drawing.Size(150, 50);
            this.Private_key.TabIndex = 107;
            this.Private_key.Text = "";
            // 
            // Key_E
            // 
            this.Key_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_E.Depth = 0;
            this.Key_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Key_E.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Key_E.Hint = "Type here key E";
            this.Key_E.Location = new System.Drawing.Point(3, 166);
            this.Key_E.MaxLength = 50000;
            this.Key_E.MouseState = MaterialSkin.MouseState.OUT;
            this.Key_E.Multiline = false;
            this.Key_E.Name = "Key_E";
            this.Key_E.Size = new System.Drawing.Size(150, 50);
            this.Key_E.TabIndex = 106;
            this.Key_E.Text = "7";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.HighEmphasis = true;
            this.materialLabel15.Location = new System.Drawing.Point(0, 73);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(153, 17);
            this.materialLabel15.TabIndex = 105;
            this.materialLabel15.Text = "2) Вычисляем N = P * Q";
            this.materialLabel15.UseAccent = true;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.HighEmphasis = true;
            this.materialLabel16.Location = new System.Drawing.Point(3, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(342, 17);
            this.materialLabel16.TabIndex = 104;
            this.materialLabel16.Text = "1) Задать общие параметры P и Q (Простые числа)";
            this.materialLabel16.UseAccent = true;
            // 
            // tabPageElgamal
            // 
            this.tabPageElgamal.Location = new System.Drawing.Point(4, 22);
            this.tabPageElgamal.Name = "tabPageElgamal";
            this.tabPageElgamal.Size = new System.Drawing.Size(1246, 525);
            this.tabPageElgamal.TabIndex = 4;
            this.tabPageElgamal.Text = "Elgamal";
            this.tabPageElgamal.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1274, 55);
            this.materialTabSelector1.TabIndex = 71;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPageMenuSettings
            // 
            this.tabPageMenuSettings.BackColor = System.Drawing.Color.White;
            this.tabPageMenuSettings.Controls.Add(this.Switch_Change_Theme);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Language);
            this.tabPageMenuSettings.Controls.Add(this.Label1);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Display_Icons_when_hidden);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Background_with_Accent);
            this.tabPageMenuSettings.Controls.Add(this.Bu_Change_Colors);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Highlight_with_Accent);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Use_menu_colors);
            this.tabPageMenuSettings.ImageKey = "round_build_white_24dp.png";
            this.tabPageMenuSettings.Location = new System.Drawing.Point(4, 31);
            this.tabPageMenuSettings.Name = "tabPageMenuSettings";
            this.tabPageMenuSettings.Size = new System.Drawing.Size(1260, 557);
            this.tabPageMenuSettings.TabIndex = 0;
            this.tabPageMenuSettings.Text = "Settings";
            // 
            // Switch_Change_Theme
            // 
            this.Switch_Change_Theme.AutoSize = true;
            this.Switch_Change_Theme.Checked = true;
            this.Switch_Change_Theme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Change_Theme.Depth = 0;
            this.Switch_Change_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Change_Theme.Location = new System.Drawing.Point(14, 129);
            this.Switch_Change_Theme.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Change_Theme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Change_Theme.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Change_Theme.Name = "Switch_Change_Theme";
            this.Switch_Change_Theme.Ripple = true;
            this.Switch_Change_Theme.Size = new System.Drawing.Size(286, 37);
            this.Switch_Change_Theme.TabIndex = 41;
            this.Switch_Change_Theme.Text = "Change Theme - LIGHT ⮀ DARK\r\n";
            this.Switch_Change_Theme.UseVisualStyleBackColor = true;
            this.Switch_Change_Theme.CheckedChanged += new System.EventHandler(this.Switch_Change_Theme_CheckedChanged);
            // 
            // Switch_Language
            // 
            this.Switch_Language.AutoSize = true;
            this.Switch_Language.Checked = true;
            this.Switch_Language.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Language.Depth = 0;
            this.Switch_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Language.Location = new System.Drawing.Point(14, 166);
            this.Switch_Language.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Language.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Language.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Language.Name = "Switch_Language";
            this.Switch_Language.Ripple = true;
            this.Switch_Language.Size = new System.Drawing.Size(211, 37);
            this.Switch_Language.TabIndex = 40;
            this.Switch_Language.Text = "Language - RU ⮀ ENG";
            this.Switch_Language.UseVisualStyleBackColor = true;
            this.Switch_Language.CheckedChanged += new System.EventHandler(this.Switch_Language_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Label1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.Label1.Location = new System.Drawing.Point(14, 12);
            this.Label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(426, 58);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Application settings";
            // 
            // Switch_Display_Icons_when_hidden
            // 
            this.Switch_Display_Icons_when_hidden.AutoSize = true;
            this.Switch_Display_Icons_when_hidden.Checked = true;
            this.Switch_Display_Icons_when_hidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Display_Icons_when_hidden.Depth = 0;
            this.Switch_Display_Icons_when_hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Display_Icons_when_hidden.Location = new System.Drawing.Point(14, 314);
            this.Switch_Display_Icons_when_hidden.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Display_Icons_when_hidden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Display_Icons_when_hidden.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Display_Icons_when_hidden.Name = "Switch_Display_Icons_when_hidden";
            this.Switch_Display_Icons_when_hidden.Ripple = true;
            this.Switch_Display_Icons_when_hidden.Size = new System.Drawing.Size(309, 37);
            this.Switch_Display_Icons_when_hidden.TabIndex = 37;
            this.Switch_Display_Icons_when_hidden.Text = "Drawer - Display Icons when hidden";
            this.Switch_Display_Icons_when_hidden.UseVisualStyleBackColor = true;
            this.Switch_Display_Icons_when_hidden.CheckedChanged += new System.EventHandler(this.Switch_Display_Icons_when_hidden_CheckedChanged);
            // 
            // Switch_Background_with_Accent
            // 
            this.Switch_Background_with_Accent.AutoSize = true;
            this.Switch_Background_with_Accent.Checked = true;
            this.Switch_Background_with_Accent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Background_with_Accent.Depth = 0;
            this.Switch_Background_with_Accent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Background_with_Accent.Location = new System.Drawing.Point(14, 277);
            this.Switch_Background_with_Accent.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Background_with_Accent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Background_with_Accent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Background_with_Accent.Name = "Switch_Background_with_Accent";
            this.Switch_Background_with_Accent.Ripple = true;
            this.Switch_Background_with_Accent.Size = new System.Drawing.Size(291, 37);
            this.Switch_Background_with_Accent.TabIndex = 31;
            this.Switch_Background_with_Accent.Text = "Drawer - Background with Accent";
            this.Switch_Background_with_Accent.UseVisualStyleBackColor = true;
            this.Switch_Background_with_Accent.CheckedChanged += new System.EventHandler(this.Switch_Background_with_Accent_CheckedChanged);
            // 
            // Bu_Change_Colors
            // 
            this.Bu_Change_Colors.AutoSize = false;
            this.Bu_Change_Colors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Change_Colors.Depth = 0;
            this.Bu_Change_Colors.DrawShadows = true;
            this.Bu_Change_Colors.HighEmphasis = true;
            this.Bu_Change_Colors.Icon = null;
            this.Bu_Change_Colors.Location = new System.Drawing.Point(14, 87);
            this.Bu_Change_Colors.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Change_Colors.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Change_Colors.Name = "Bu_Change_Colors";
            this.Bu_Change_Colors.Size = new System.Drawing.Size(140, 36);
            this.Bu_Change_Colors.TabIndex = 22;
            this.Bu_Change_Colors.Text = "Change Colors";
            this.Bu_Change_Colors.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Bu_Change_Colors.UseAccentColor = false;
            this.Bu_Change_Colors.UseVisualStyleBackColor = true;
            this.Bu_Change_Colors.Click += new System.EventHandler(this.Bu_Change_Colors_Click);
            // 
            // Switch_Highlight_with_Accent
            // 
            this.Switch_Highlight_with_Accent.AutoSize = true;
            this.Switch_Highlight_with_Accent.Checked = true;
            this.Switch_Highlight_with_Accent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Highlight_with_Accent.Depth = 0;
            this.Switch_Highlight_with_Accent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Highlight_with_Accent.Location = new System.Drawing.Point(14, 240);
            this.Switch_Highlight_with_Accent.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Highlight_with_Accent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Highlight_with_Accent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Highlight_with_Accent.Name = "Switch_Highlight_with_Accent";
            this.Switch_Highlight_with_Accent.Ripple = true;
            this.Switch_Highlight_with_Accent.Size = new System.Drawing.Size(270, 37);
            this.Switch_Highlight_with_Accent.TabIndex = 30;
            this.Switch_Highlight_with_Accent.Text = "Drawer - Highlight with Accent";
            this.Switch_Highlight_with_Accent.UseVisualStyleBackColor = true;
            this.Switch_Highlight_with_Accent.CheckedChanged += new System.EventHandler(this.Switch_Highlight_with_Accent_CheckedChanged);
            // 
            // Switch_Use_menu_colors
            // 
            this.Switch_Use_menu_colors.AutoSize = true;
            this.Switch_Use_menu_colors.Depth = 0;
            this.Switch_Use_menu_colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Use_menu_colors.Location = new System.Drawing.Point(14, 203);
            this.Switch_Use_menu_colors.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Use_menu_colors.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Use_menu_colors.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Use_menu_colors.Name = "Switch_Use_menu_colors";
            this.Switch_Use_menu_colors.Ripple = true;
            this.Switch_Use_menu_colors.Size = new System.Drawing.Size(237, 37);
            this.Switch_Use_menu_colors.TabIndex = 29;
            this.Switch_Use_menu_colors.Text = "Drawer - Use menu colors";
            this.Switch_Use_menu_colors.UseVisualStyleBackColor = true;
            this.Switch_Use_menu_colors.CheckedChanged += new System.EventHandler(this.Switch_Use_menu_colors_CheckedChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageMenuCiphers);
            this.materialTabControl1.Controls.Add(this.tabPageMenuSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 58);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1268, 592);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.materialTabSelector1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialTabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1274, 653);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(1175, 35);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(156, 84);
            this.materialTabSelector2.TabIndex = 20;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = null;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(-8, 52);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(20, 67);
            this.materialTabSelector3.TabIndex = 21;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Bu_GOST_R_34_10_2012
            // 
            this.Bu_GOST_R_34_10_2012.AutoSize = false;
            this.Bu_GOST_R_34_10_2012.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_GOST_R_34_10_2012.BackColor = System.Drawing.SystemColors.Control;
            this.Bu_GOST_R_34_10_2012.Depth = 0;
            this.Bu_GOST_R_34_10_2012.DrawShadows = true;
            this.Bu_GOST_R_34_10_2012.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bu_GOST_R_34_10_2012.ForeColor = System.Drawing.Color.Transparent;
            this.Bu_GOST_R_34_10_2012.HighEmphasis = true;
            this.Bu_GOST_R_34_10_2012.Icon = null;
            this.Bu_GOST_R_34_10_2012.Location = new System.Drawing.Point(4, 446);
            this.Bu_GOST_R_34_10_2012.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_GOST_R_34_10_2012.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_GOST_R_34_10_2012.Name = "Bu_GOST_R_34_10_2012";
            this.Bu_GOST_R_34_10_2012.Size = new System.Drawing.Size(230, 20);
            this.Bu_GOST_R_34_10_2012.TabIndex = 58;
            this.Bu_GOST_R_34_10_2012.Text = "GOST R 34.10-2012";
            this.Bu_GOST_R_34_10_2012.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Bu_GOST_R_34_10_2012.UseAccentColor = true;
            this.Bu_GOST_R_34_10_2012.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialTabSelector3);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Cryptography";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabPageMenuCiphers.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabPageCiphers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelKeys.ResumeLayout(false);
            this.panelKeys.PerformLayout();
            this.tabPageDiffieHellman.ResumeLayout(false);
            this.tabPageDiffieHellman.PerformLayout();
            this.tabPageRSA.ResumeLayout(false);
            this.tabPageRSA.PerformLayout();
            this.tabPageMenuSettings.ResumeLayout(false);
            this.tabPageMenuSettings.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList menuIconList;
        private System.Windows.Forms.TabPage tabPageMenuCiphers;
        private System.Windows.Forms.TabPage tabPageMenuSettings;
        private MaterialSkin.Controls.MaterialSwitch Switch_Display_Icons_when_hidden;
        private MaterialSkin.Controls.MaterialSwitch Switch_Background_with_Accent;
        private MaterialSkin.Controls.MaterialButton Bu_Change_Colors;
        private MaterialSkin.Controls.MaterialSwitch Switch_Highlight_with_Accent;
        private MaterialSkin.Controls.MaterialSwitch Switch_Use_menu_colors;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialSwitch Switch_Language;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private MaterialSkin.Controls.MaterialSwitch Switch_Change_Theme;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tab;
        private System.Windows.Forms.TabPage tabPageCiphers;
        private System.Windows.Forms.TabPage tabPageDigitalSignature;
        private System.Windows.Forms.Panel Panel;
        private MaterialSkin.Controls.MaterialButton Bu_Caesar;
        private MaterialSkin.Controls.MaterialButton Bu_Atbash;
        private MaterialSkin.Controls.MaterialButton Bu_Polybius;
        private MaterialSkin.Controls.MaterialButton Bu_ECC;
        private MaterialSkin.Controls.MaterialButton Bu_Trithemius;
        private MaterialSkin.Controls.MaterialButton Bu_Elgamal;
        private MaterialSkin.Controls.MaterialButton Bu_Belazo;
        private MaterialSkin.Controls.MaterialButton Bu_RSA;
        private MaterialSkin.Controls.MaterialButton Bu_Vigenère;
        private MaterialSkin.Controls.MaterialButton Bu_A5_2;
        private MaterialSkin.Controls.MaterialButton Bu_Matrix_cipher;
        private MaterialSkin.Controls.MaterialButton Bu_А5_1;
        private MaterialSkin.Controls.MaterialButton Bu_Playfer;
        private MaterialSkin.Controls.MaterialButton Bu_Magma;
        private MaterialSkin.Controls.MaterialButton Bu_Vertical_permutation;
        private MaterialSkin.Controls.MaterialButton Bu_Shannon;
        private MaterialSkin.Controls.MaterialButton Bu_Cardano_grille;
        private MaterialSkin.Controls.MaterialDivider Divider;
        private System.Windows.Forms.TabPage tabPageDiffieHellman;
        private System.Windows.Forms.RichTextBox TextBoxEncryptedMessage;
        private MaterialSkin.Controls.MaterialDivider DividerEncryptedMessage;
        private System.Windows.Forms.RichTextBox TextBoxMessages;
        private MaterialSkin.Controls.MaterialDivider DividerMessages;
        private MaterialSkin.Controls.MaterialLabel LabelEncryptedMessage;
        private MaterialSkin.Controls.MaterialLabel LabelMessages;
        private MaterialSkin.Controls.MaterialLabel LabelCheck;
        private MaterialSkin.Controls.MaterialDivider DividerCheck;
        private System.Windows.Forms.RichTextBox TextBoxCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelKeys;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialButton BuText;
        private MaterialSkin.Controls.MaterialTextBox LabelKeys;
        private MaterialSkin.Controls.MaterialLabel LabelError;
        private MaterialSkin.Controls.MaterialButton BuClear;
        private MaterialSkin.Controls.MaterialButton BuTest;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox KeyKB;
        private MaterialSkin.Controls.MaterialTextBox KeyKA;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox KeyYB;
        private MaterialSkin.Controls.MaterialTextBox KeyYA;
        private MaterialSkin.Controls.MaterialTextBox SecretKeyB;
        private MaterialSkin.Controls.MaterialTextBox SecretKeyA;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton BuRandom;
        private MaterialSkin.Controls.MaterialLabel LabelError_Hellman;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton BuCheck;
        private MaterialSkin.Controls.MaterialTextBox KeyN;
        private MaterialSkin.Controls.MaterialTextBox KeyA;
        private System.Windows.Forms.TabPage tabPageRSA;
        private MaterialSkin.Controls.MaterialTextBox Key_Q;
        private MaterialSkin.Controls.MaterialTextBox Key_P;
        private MaterialSkin.Controls.MaterialButton BuCheckRSA;
        private MaterialSkin.Controls.MaterialButton BuRandomRSA;
        private MaterialSkin.Controls.MaterialTextBox Key_D;
        private MaterialSkin.Controls.MaterialTextBox Public_key;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel labelPublic_key;
        private MaterialSkin.Controls.MaterialTextBox Key_φ;
        private MaterialSkin.Controls.MaterialTextBox Key_N;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox Key_E;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.TabPage tabPageElgamal;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox Private_key;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel LabelError_RSA;
        private MaterialSkin.Controls.MaterialTextBox Elgamal_X;
        private MaterialSkin.Controls.MaterialTextBox Elgamal_G;
        private MaterialSkin.Controls.MaterialTextBox Elgamal_P;
        private MaterialSkin.Controls.MaterialButton Bu_Magma_Gamm;
        private MaterialSkin.Controls.MaterialButton Bu_Magma_Simple;
        private MaterialSkin.Controls.MaterialButton Bu_AES_128;
        private MaterialSkin.Controls.MaterialButton Bu_Kuznyechik;
        private MaterialSkin.Controls.MaterialButton Bu_GOST_R_34_10_94;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialButton Bu_GOST_R_34_10_2012;
    }
}


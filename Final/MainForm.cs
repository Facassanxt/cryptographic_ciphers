                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Final
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex;
        readonly List<MaterialButton> listBtn = new List<MaterialButton>();
        private string active_cipher = "";
        static readonly string alph = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private readonly Caesar caesar = new Caesar();
        private readonly Atbash atbash = new Atbash();
        private readonly Polybius_square polybius_square = new Polybius_square();
        private readonly Trithemius trithemius = new Trithemius(alph);
        private readonly Belazo belazo = new Belazo(alph);
        private readonly Vigenère vigenère = new Vigenère(alph);
        private readonly Magma magma = new Magma();
        private readonly Diffie_Hellman diffie_Hellman = new Diffie_Hellman();
        private readonly Vertical_permutation vertical_permutation = new Vertical_permutation();
        private readonly Cardano_grille cardano_Grille = new Cardano_grille();
        private readonly GammaGost28147 _GammaGost28147 = new GammaGost28147();
        private readonly Magma_Simple _Magma_Simple = new Magma_Simple();
        private readonly AES_128 aes = new AES_128();
        private readonly A5_1 a5_1 = new A5_1();
        private readonly Kuznyechik kuz = new Kuznyechik();

        public MainForm()
        {
            InitializeComponent();
            this.Width = 1280;
            this.Height = 720;

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.EnforceBackcolorOnAllComponents = true; 

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange300, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            colorSchemeIndex = 4;
            UpdateColor();

            listBtn.Add(Bu_Caesar);
            listBtn.Add(Bu_Atbash);
            listBtn.Add(Bu_Polybius);
            listBtn.Add(Bu_Trithemius);
            listBtn.Add(Bu_Belazo);
            listBtn.Add(Bu_Vigenère);
            listBtn.Add(Bu_Matrix_cipher);
            listBtn.Add(Bu_Playfer);
            listBtn.Add(Bu_Vertical_permutation);
            listBtn.Add(Bu_Cardano_grille);
            listBtn.Add(Bu_Shannon);
            listBtn.Add(Bu_Magma);
            listBtn.Add(Bu_А5_1);
            listBtn.Add(Bu_A5_2);
            listBtn.Add(Bu_Magma_Simple);
            listBtn.Add(Bu_AES_128);
            listBtn.Add(Bu_Kuznyechik);
            listBtn.Add(Bu_RSA);
            listBtn.Add(Bu_Elgamal);
            listBtn.Add(Bu_ECC);
            Panel.HorizontalScroll.Maximum = 0;
            Panel.AutoScroll = false;
            Panel.VerticalScroll.Visible = false;
            Panel.AutoScroll = true;
            Divider.Width = 1;

            panel1.Height = 572;

            DividerMessages.Height = DividerEncryptedMessage.Height = DividerCheck.Height = 1;
            DividerCheck.Width = DividerEncryptedMessage.Width = DividerMessages.Width = TextBoxCheck.Width = TextBoxMessages.Width = TextBoxEncryptedMessage.Width = panelKeys.Width;
            TextBoxMessages.Height = TextBoxEncryptedMessage.Height = TextBoxCheck.Height = (panel1.Height - panelKeys.Height - LabelMessages.Height - DividerMessages.Height - LabelEncryptedMessage.Height - DividerEncryptedMessage.Height - LabelCheck.Height - DividerCheck.Height)/3;


            DividerMessages.Location = new Point(panelKeys.Location.X, panelKeys.Location.Y + panelKeys.Height);
            LabelMessages.Location = new Point(panelKeys.Location.X + TextBoxMessages.Width / 2 - LabelMessages.Width / 2, DividerMessages.Location.Y + DividerMessages.Height);
            TextBoxMessages.Location = new Point(panelKeys.Location.X, LabelMessages.Location.Y + LabelMessages.Height);

            DividerEncryptedMessage.Location = new Point(panelKeys.Location.X, TextBoxMessages.Location.Y + TextBoxMessages.Height);
            LabelEncryptedMessage.Location = new Point(panelKeys.Location.X + TextBoxEncryptedMessage.Width / 2 - LabelEncryptedMessage.Width / 2, DividerEncryptedMessage.Location.Y + DividerEncryptedMessage.Height);
            TextBoxEncryptedMessage.Location = new Point(panelKeys.Location.X, LabelEncryptedMessage.Location.Y + LabelEncryptedMessage.Height);

            DividerCheck.Location = new Point(panelKeys.Location.X, TextBoxEncryptedMessage.Location.Y + TextBoxEncryptedMessage.Height);
            LabelCheck.Location = new Point(panelKeys.Location.X + TextBoxCheck.Width / 2 - LabelCheck.Width / 2, DividerCheck.Location.Y + DividerCheck.Height);
            TextBoxCheck.Location = new Point(panelKeys.Location.X, LabelCheck.Location.Y + LabelCheck.Height);

            panel1.Visible = false;
            Switch_Language.Checked = false;
            Console.OutputEncoding = Encoding.Unicode;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            panel1.Width = tableLayoutPanel2.Width - 236;
            DividerCheck.Width = DividerEncryptedMessage.Width = DividerMessages.Width = TextBoxCheck.Width = TextBoxMessages.Width = TextBoxEncryptedMessage.Width = panelKeys.Width;
            TextBoxMessages.Height = TextBoxEncryptedMessage.Height = TextBoxCheck.Height = (panel1.Height - panelKeys.Height - LabelMessages.Height - DividerMessages.Height - LabelEncryptedMessage.Height - DividerEncryptedMessage.Height - LabelCheck.Height - DividerCheck.Height) / 3;


            DividerMessages.Location = new Point(panelKeys.Location.X, panelKeys.Location.Y + panelKeys.Height);
            LabelMessages.Location = new Point(panelKeys.Location.X + TextBoxMessages.Width / 2 - LabelMessages.Width / 2, DividerMessages.Location.Y + DividerMessages.Height);
            TextBoxMessages.Location = new Point(panelKeys.Location.X, LabelMessages.Location.Y + LabelMessages.Height);

            DividerEncryptedMessage.Location = new Point(panelKeys.Location.X, TextBoxMessages.Location.Y + TextBoxMessages.Height);
            LabelEncryptedMessage.Location = new Point(panelKeys.Location.X + TextBoxEncryptedMessage.Width / 2 - LabelEncryptedMessage.Width / 2, DividerEncryptedMessage.Location.Y + DividerEncryptedMessage.Height);
            TextBoxEncryptedMessage.Location = new Point(panelKeys.Location.X, LabelEncryptedMessage.Location.Y + LabelEncryptedMessage.Height);

            DividerCheck.Location = new Point(panelKeys.Location.X, TextBoxEncryptedMessage.Location.Y + TextBoxEncryptedMessage.Height);
            LabelCheck.Location = new Point(panelKeys.Location.X + TextBoxCheck.Width / 2 - LabelCheck.Width / 2, DividerCheck.Location.Y + DividerCheck.Height);
            TextBoxCheck.Location = new Point(panelKeys.Location.X, LabelCheck.Location.Y + LabelCheck.Height);
            Invalidate();
        }
        private void UpdateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                //ColorScheme(primary, darkPrimary, lightPrimary, accent, textShade)
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.DeepOrange300 : Primary.DeepOrange300,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.BlueGrey900 : Primary.DeepOrange900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.BlueGrey500 : Primary.DeepOrange100,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepPurple700,
                        Primary.DeepPurple900,
                        Primary.DeepPurple500,
                        Accent.Green400,
                        TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Refresh();
        }

        private void Bu_Change_Colors_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 4)
                colorSchemeIndex = 0;
            UpdateColor();
        }
        private void Switch_Use_menu_colors_CheckedChanged(object sender, EventArgs e)
        {
            DrawerUseColors = Switch_Use_menu_colors.Checked;
        }
        private void Switch_Highlight_with_Accent_CheckedChanged(object sender, EventArgs e)
        {
            DrawerHighlightWithAccent = Switch_Highlight_with_Accent.Checked;
        }
        private void Switch_Background_with_Accent_CheckedChanged(object sender, EventArgs e)
        {
            DrawerBackgroundWithAccent = Switch_Background_with_Accent.Checked;
        }
        private void Switch_Display_Icons_when_hidden_CheckedChanged(object sender, EventArgs e)
        {
            DrawerShowIconsWhenHidden = Switch_Display_Icons_when_hidden.Checked;
            panel1.Visible = false;
        }
        private void Switch_Language_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch_Language.Checked == true)
            {
                Text = "Cryptography";
                /*                  Settings page                   */
                Label1.Text = "Application settings";
                Bu_Change_Colors.Text = "Change Colors";
                Switch_Change_Theme.Text = "Change Theme - LIGHT ⮀ DARK";
                Switch_Use_menu_colors.Text = "Drawer - Use menu colors";
                Switch_Highlight_with_Accent.Text = "Drawer - Highlight with Accent";
                Switch_Background_with_Accent.Text = "Drawer - Background with Accent";
                Switch_Display_Icons_when_hidden.Text = "Drawer - Display Icons when hidden";
                Switch_Language.Text = "Language - RU ⮀ ENG";
                //////////////////////////////////////////////////////


                /*                  Menu                    */
                tabPageMenuCiphers.Text = "Ciphers";
                tabPageMenuSettings.Text = "Settings";
                //////////////////////////////////////////////

                /*                  Ciphers menu                    */
                tabPageCiphers.Text = "ciphers";
                tabPageDigitalSignature.Text = "Digital signature";
                tabPageDiffieHellman.Text = "Diffie–Hellman";
                //////////////////////////////////////////////////////

                /*                  Ciphers                    */
                Bu_Caesar.Text = "Caesar";
                Bu_Atbash.Text = "Atbash";
                Bu_Polybius.Text = "Polybius";
                Bu_Trithemius.Text = "Trithemius";
                Bu_Belazo.Text = "Belazo";
                Bu_Vigenère.Text = "Vigenère";
                Bu_Matrix_cipher.Text = "Matrix cipher";
                Bu_Playfer.Text = "Playfer";
                Bu_Vertical_permutation.Text = "Vertical permutation";
                Bu_Cardano_grille.Text = "Cardano grille";
                Bu_Shannon.Text = "Shannon";
                Bu_Magma_Gamm.Text = "Magma gamma";
                Bu_Magma.Text = "Magma";
                Bu_А5_1.Text = "А5/1";
                Bu_A5_2.Text = "A5/2";
                Bu_RSA.Text = "RSA";
                Bu_Elgamal.Text = "Elgamal";
                Bu_ECC.Text = "ECC";
                /////////////////////////////////////////////////


                LabelMessages.Text = "Messages";
                LabelEncryptedMessage.Text = "Encrypted Message";
                LabelCheck.Text = "Check";

            }
            else 
            {
                Text = "Криптография";
                /*                  Страница настроек                   */
                Label1.Text = "Настройки приложения";
                Bu_Change_Colors.Text = "Изменить цвет";
                Switch_Change_Theme.Text = "Сменить тему - СВЕТЛАЯ ⮀ ТЕМНАЯ";
                Switch_Use_menu_colors.Text = "Отрисовка - Использовать цвета меню";
                Switch_Highlight_with_Accent.Text = "Отрисовка - Выделить с акцентом";
                Switch_Background_with_Accent.Text = "Отрисовка - Фон с акцентом";
                Switch_Display_Icons_when_hidden.Text = "Отрисовка - Отображать значки, когда они скрыты";
                Switch_Language.Text = "Язык - RU ⮀ ENG";
                //////////////////////////////////////////////////////////

                /*                  Меню                    */
                tabPageMenuCiphers.Text = "Шифры";
                tabPageMenuSettings.Text = "Настройки";
                //////////////////////////////////////////////

                /*                  Меню шифров                    */
                tabPageCiphers.Text = "Шифры";
                tabPageDigitalSignature.Text = "Цифровые подписи";
                tabPageDiffieHellman.Text = "Ди́ффи — Хе́ллман";
                /////////////////////////////////////////////////////

                /*                  Шифры                    */
                Bu_Caesar.Text = "Цезарь";
                Bu_Atbash.Text = "Атбаш";
                Bu_Polybius.Text = "Квадрат Полибия";
                Bu_Trithemius.Text = "Тритемий";
                Bu_Belazo.Text = "Белазо";
                Bu_Vigenère.Text = "Виженер";
                Bu_Matrix_cipher.Text = "Матричный шифр";
                Bu_Playfer.Text = "Плэйфер";
                Bu_Vertical_permutation.Text = "Вертикальная перестановка";
                Bu_Cardano_grille.Text = "Решетка Кардано";
                Bu_Shannon.Text = "Шеннон";
                Bu_Magma_Gamm.Text = "Магма гаммирование";
                Bu_Magma.Text = "Магма";
                Bu_А5_1.Text = "А5/1";
                Bu_A5_2.Text = "A5/2";
                Bu_RSA.Text = "RSA";
                Bu_Elgamal.Text = "Эль-Гамаль";
                Bu_ECC.Text = "ECC";
                ///////////////////////////////////////////////

                LabelMessages.Text = "Сообщение";
                LabelEncryptedMessage.Text = "Зашифрованное сообщение";
                LabelCheck.Text = "Проверка";
            }
            LabelMessages.Location = new Point(TextBoxCheck.Location.X + TextBoxMessages.Width / 2 - LabelMessages.Width / 2, TextBoxMessages.Location.Y - LabelMessages.Height);
            LabelEncryptedMessage.Location = new Point(TextBoxCheck.Location.X + TextBoxEncryptedMessage.Width / 2 - LabelEncryptedMessage.Width / 2, TextBoxEncryptedMessage.Location.Y - LabelEncryptedMessage.Height);
            LabelCheck.Location = new Point(TextBoxCheck.Location.X + TextBoxCheck.Width / 2 - LabelCheck.Width / 2, TextBoxCheck.Location.Y - LabelCheck.Height);
            Refresh();
        }
        private void Switch_Change_Theme_CheckedChanged(object sender, EventArgs e)
        {
            Visible = false;
            materialSkinManager.Theme = Switch_Change_Theme.Checked  == true ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            UpdateColor();
            Visible = true;
        }
        private void Bu_Caesar_Click(object sender, EventArgs e)
        {
            active_cipher = "Caesar";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Atbash_Click(object sender, EventArgs e)
        {
            active_cipher = "Atbash";
            General_button_action(sender, e);
        }

        private void Bu_Polybius_Click(object sender, EventArgs e)
        {
            active_cipher = "Polybius";
            General_button_action(sender, e);
        }

        private void Bu_Trithemius_Click(object sender, EventArgs e)
        {
            active_cipher = "Trithemius";
            General_button_action(sender, e);
        }

        private void Bu_Belazo_Click(object sender, EventArgs e)
        {
            active_cipher = "Belazo";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Vigenère_Click(object sender, EventArgs e)
        {
            active_cipher = "Vigenère";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Matrix_cipher_Click(object sender, EventArgs e)
        {
            active_cipher = "Matrix cipher";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Playfer_Click(object sender, EventArgs e)
        {
            active_cipher = "Playfer";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Vertical_permutation_Click(object sender, EventArgs e)
        {
            active_cipher = "Vertical permutation";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Cardano_grille_Click(object sender, EventArgs e)
        {
            active_cipher = "Cardano grille";
            General_button_action(sender, e);
        }

        private void Bu_Shannon_Click(object sender, EventArgs e)
        {
            active_cipher = "Shannon";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }
        private void Bu_Magma_Gamm_Click(object sender, EventArgs e)
        {
            active_cipher = "Magma Gamm";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Magma_Click(object sender, EventArgs e)
        {
            active_cipher = "Magma";
            General_button_action(sender, e);
        }

        private void Bu_А5_1_Click(object sender, EventArgs e)
        {
            active_cipher = "А5/1";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_A5_2_Click(object sender, EventArgs e)
        {
            active_cipher = "А5/2";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Magma_Simple_Click(object sender, EventArgs e)
        {
            active_cipher = "Magma Simple";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_AES_128_Click(object sender, EventArgs e)
        {
            active_cipher = "AES 128";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_Kuznyechik_Click(object sender, EventArgs e)
        {
            active_cipher = "Kuznyechik";
            LabelKeys.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            LabelKeys.Visible = true;
        }

        private void Bu_RSA_Click(object sender, EventArgs e)
        {
            active_cipher = "RSA";
            General_button_action(sender, e);
        }

        private void Bu_Elgamal_Click(object sender, EventArgs e)
        {
            active_cipher = "Elgamal";
            Elgamal_P.Text = "";
            Elgamal_G.Text = "";
            Elgamal_X.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
            General_button_action(sender, e);
            Elgamal_P.Visible = true;
            Elgamal_G.Visible = true;
            Elgamal_X.Visible = true;
        }

        private void Bu_ECC_Click(object sender, EventArgs e)
        {
            active_cipher = "ECC";
            General_button_action(sender, e);
        }

        private void General_button_action(object sender, EventArgs e)
        {
            for (int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].Type = MaterialButton.MaterialButtonType.Text;
            }
            ((MaterialButton)sender).Type = MaterialButton.MaterialButtonType.Contained;
            panel1.Visible = true;
            TextBoxMessages.Text = "";
            LabelKeys.Visible = false;
            Elgamal_P.Visible = false;
            Elgamal_G.Visible = false;
            Elgamal_X.Visible = false;
            LabelError.Text = "";
            Upref();
        }
        private void TextBoxMessages_TextChanged(object sender, EventArgs e)
        {
            var message = TextBoxMessages.Text;
            message = message.Replace("-", "тире").Replace(".", "тчк").Replace(",", "зпт").Replace(" ", "").ToUpper();

            if (active_cipher == "Caesar")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = Int32.Parse(LabelKeys.Text);
                        var encryptedText = caesar.Encrypt(message, secretKey);
                        TextBoxEncryptedMessage.Text = encryptedText.ToLower();
                        var decryptedMessage = caesar.Decrypt(encryptedText, secretKey);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Atbash")
            {
                try
                {
                    var encryptedMessage = atbash.EncryptText(message);
                    TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                    var decryptedMessage = atbash.DecryptText(encryptedMessage);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Polybius")
            {
                message = message.Replace("Ъ", "Ь").Replace("Й", "И");
                Regex regex = new Regex(@"[0-9]");
                MatchCollection matches = regex.Matches(message);
                if (matches.Count > 0)
                {
                    LabelError.Text = "В тексте не должны присутствовать цифры.";
                }
                else
                {
                    try
                    {
                        var encryptedText = polybius_square.EncryptText(message);
                        TextBoxEncryptedMessage.Text = encryptedText.ToLower();
                        var decryptedMessage = polybius_square.DecryptText(encryptedText);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Trithemius")
            {
                try
                {
                    var encryptedMessage = trithemius.Encrypt(message);
                    TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                    var decryptedMessage = trithemius.Decrypt(encryptedMessage.ToUpper());
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Belazo")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    Regex regex = new Regex(@"[0-9]");
                    MatchCollection matches = regex.Matches(LabelKeys.Text);
                    if (matches.Count > 0)
                    {
                        LabelError.Text = "В ключе не должны присутствовать цифры.";
                    }
                    else
                    {
                        try
                        {
                            var secretKey = LabelKeys.Text.ToUpper();
                            var encryptedMessage = belazo.Encrypt(message, secretKey);
                            TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                            var decryptedMessage = belazo.Decrypt(encryptedMessage, secretKey);
                            TextBoxCheck.Text = decryptedMessage.ToLower();
                            LabelError.Text = "";
                        }
                        catch (Exception ex)
                        {
                            LabelError.Text = ex.Message;
                        }
                    }
                }
            }
            else if (active_cipher == "Vigenère")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text.ToUpper();
                        var encryptedMessage = vigenère.Encrypt(message, secretKey);
                        TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                        var decryptedMessage = vigenère.Decrypt(encryptedMessage, secretKey);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Matrix cipher")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    var secretKey = LabelKeys.Text;
                    try
                    {
                        Matrix_cipher matrix_cipher = new Matrix_cipher(secretKey, alph + "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                        var encryptedMessage = matrix_cipher.Encrypt(message);
                        TextBoxEncryptedMessage.Text = encryptedMessage;
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Playfer")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text;
                        Playfer playfer = new Playfer("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", secretKey);
                        var encryptedMessage = playfer.Encrypt(message);
                        Console.WriteLine("\nРезультат: " + encryptedMessage);
                        TextBoxEncryptedMessage.Text = encryptedMessage;
                        var decryptedMessage = playfer.Decrypt(encryptedMessage);
                        Console.WriteLine("Проверка: " + decryptedMessage);
                        TextBoxCheck.Text = decryptedMessage;
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Vertical permutation")
            {
                if (LabelKeys.Text.Length > 2)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text;
                        vertical_permutation.SetKey(secretKey);
                        var encryptedMessage = vertical_permutation.Encrypt(message);
                        TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Cardano grille")
            {
                try
                {
                    var encryptedMessage = cardano_Grille.EN_De_crypt(message, true);
                    TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Shannon")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    Shannon shannon = new Shannon(secretKey, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToUpper());
                    var encryptedMessage = shannon.Encrypt(message);
                    TextBoxEncryptedMessage.Text = encryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher  == "Magma Gamm")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    byte[] key = Encoding.Unicode.GetBytes(secretKey);
                    string syn = "1234567800000000";

                    //key = Split("ffeeddccbbaa99887766554433221100f0f1f2f3f4f5f6f7f8f9fafbfcfdfeff");
                    byte[] s = Split(syn);

                    var rez = _Magma_Simple.Encrypt(message, key, s, "gamma");
                    string str = Encoding.Unicode.GetString(rez);
                    TextBoxEncryptedMessage.Text = str;
                    TextBoxCheck.Text = _Magma_Simple.Decrypt(rez, key, s, "gamma");
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Magma")
            {
                try
                {
                    var encryptedMessage = magma.encryptText(message);
                    TextBoxEncryptedMessage.Text = encryptedMessage;
                    var decryptedMessage = magma.decryptText(encryptedMessage);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "А5/1")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    byte[] key = Encoding.Unicode.GetBytes(secretKey);
                    byte[] msg = Encoding.Unicode.GetBytes(message);
                    var a = a5_1.A5Encyptor(msg, key);
                    string str = Encoding.Unicode.GetString(a);
                    Console.WriteLine(str);
                    TextBoxEncryptedMessage.Text = str;
                    string x = Encoding.Unicode.GetString(a5_1.A5Encyptor(a, key));
                    Console.WriteLine(x);
                    TextBoxCheck.Text = x.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "А5/2")
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.FileName = ".\\A5_2.exe";
                    var secretKey = LabelKeys.Text;
                    if (message.Length > 0 & secretKey.Length >= 4)
                    {
                        p.StartInfo.Arguments = message + " " + secretKey;
                        p.Start();
                        string output = p.StandardOutput.ReadLine();
                        string output_2 = p.StandardOutput.ReadLine();
                        Console.WriteLine(output);
                        Console.WriteLine(output_2);
                        p.WaitForExit();

                        TextBoxEncryptedMessage.Text = output.ToLower();
                        TextBoxCheck.Text = output_2.ToLower();
                        LabelError.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Magma Simple")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    byte[] key = Encoding.Unicode.GetBytes(secretKey);

                    var rez = _Magma_Simple.Encrypt(message, key, null, "simple");
                    string str = Encoding.Unicode.GetString(rez);
                    TextBoxEncryptedMessage.Text = str;
                    TextBoxCheck.Text = _Magma_Simple.Decrypt(rez, key, null, "simple");
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "AES 128")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    byte[] key = Encoding.Unicode.GetBytes(secretKey);
                    //key = Split("000102030405060708090a0b0c0d0e0f");
                    //Console.WriteLine("key - " + BitConverter.ToString(key));
                    byte[] text = Encoding.Unicode.GetBytes(message);
                    //text = Split("00112233445566778899aabbccddeeff");
                    //Console.WriteLine("text - " + BitConverter.ToString(text));
                    //Console.WriteLine(Encoding.Unicode.GetString(text));
                    byte[] rez = aes.Encrypt(text, key);
                    //Console.WriteLine("rez - " + BitConverter.ToString(rez));
                    TextBoxEncryptedMessage.Text = Encoding.Unicode.GetString(rez);
                    //Console.WriteLine(TextBoxEncryptedMessage.Text);
                    TextBoxCheck.Text = Encoding.Unicode.GetString(aes.Decrypt(rez, key));
                    //Console.WriteLine(TextBoxCheck.Text);
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Kuznyechik")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    var bytes = new byte[secretKey.Length >> 1];
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bytes[i] = Convert.ToByte(secretKey.Substring(i << 1, 2), 16);
                    }
                    byte[] key = bytes;
                    Console.WriteLine("Ключ - " + BitConverter.ToString(key));
                    byte[] text = Encoding.Unicode.GetBytes(message);
                    byte[] rez = kuz.Encrypt(text, key);
                    TextBoxEncryptedMessage.Text = Encoding.Unicode.GetString(rez);
                    TextBoxCheck.Text = Encoding.Unicode.GetString(kuz.Decrypt(rez, key));
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "RSA")
            {
                try
                {
                    RSA rsa = new RSA(alph);
                    var encryptedMessage = rsa.Encrypt(message, Public_key.Text);
                    TextBoxEncryptedMessage.Text = encryptedMessage;
                    var decryptedMessage = rsa.Decrypt(encryptedMessage, Private_key.Text);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Elgamal")
            {
                try
                {
                    Elgamal elgamal = new Elgamal(alph);
                    var encryptedMessage = elgamal.Encrypt(message, Int32.Parse(Elgamal_P.Text), Int32.Parse(Elgamal_G.Text), Int32.Parse(Elgamal_X.Text));
                    TextBoxEncryptedMessage.Text = encryptedMessage.Replace(",", "");
                    var decryptedMessage = elgamal.Decrypt(encryptedMessage, Int32.Parse(Elgamal_P.Text), Int32.Parse(Elgamal_G.Text), Int32.Parse(Elgamal_X.Text));
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "ECC")
            {

            }
            else
            {

            }
        }
        private void Upref()
        {
            Width += 1;
            Width -= 1;
            Refresh();
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            TextBoxMessages.ScrollBars = RichTextBoxScrollBars.None;
            TextBoxEncryptedMessage.ScrollBars = RichTextBoxScrollBars.None;
            TextBoxCheck.ScrollBars = RichTextBoxScrollBars.None;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            TextBoxMessages.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            TextBoxEncryptedMessage.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            TextBoxCheck.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
        }

        private static byte[] Split(string plaintext)
        {
            string[] rez = new string[plaintext.Length / 2];
            int j = 0;
            for (int i = 0; i < plaintext.Length; i += 2)
                rez[j++] = plaintext.Substring(i, 2);

            return rez.Select(i => Convert.ToByte(i, 16)).ToArray();
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            string test = "Что, может быть, высшая доблесть в жизни - именно уметь держать себя в кулаке. Именно умение владеть собой есть признак недюжинной, уверенной в себе натуры. Вера в здравый смысл коллектива и ответственность за судьбы людей - вот что стоит сегодня за спокойствием Юрия Викентьевича. Хотя где-то про себя он, конечно, волнуется и переживает. Он переживает, конечно. Витька размышлял и об этом наспех и раздерганно, мысли его пришли в смятение, голос Юрия Викентьевича доходил до сознания уж заторможенно, приглушенно, сквозила в нем дружеская доверительность. Давайте так, будто вам тридцать шесть, а мне восемнадцать. Нет, давайте лучше отойдем от возраста вообще и посмотрим на вещи одними глазами, с одним и тем же, образно говоря, фокусным расстоянием. Так вот. Станислав обладает завидными познаниями - правда, он их почему-то не успел в жизни пристроить к делу, но это разговор другой. Он и опытней нас просто-напросто. Жизнеспособней. Наконец, чистосердечно посчитайте, сколько Станислав сделал нам хорошего...";
            TextBoxMessages.Text = test;
        }

        private void LabelKeys_TextChanged(object sender, EventArgs e)
        {
            TextBoxMessages.Text = TextBoxMessages.Text;
            TextBoxEncryptedMessage.Text = TextBoxEncryptedMessage.Text;
        }

        private void TextBoxEncryptedMessage_TextChanged(object sender, EventArgs e)
        {
            var message = TextBoxEncryptedMessage.Text;
            message = message.Replace(" ", "").ToUpper();

            if (active_cipher == "Caesar")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = Int32.Parse(LabelKeys.Text);
                        var decryptedMessage = caesar.Decrypt(message, secretKey);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Atbash")
            {
                try
                {
                    var decryptedMessage = atbash.DecryptText(message);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Polybius")
            {
                try
                {
                    var decryptedMessage = polybius_square.DecryptText(message);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Trithemius")
            {
                try
                {
                    var decryptedMessage = trithemius.Decrypt(message.ToUpper());
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Belazo")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    Regex regex = new Regex(@"[0-9]");
                    MatchCollection matches = regex.Matches(LabelKeys.Text);
                    if (matches.Count > 0)
                    {
                        LabelError.Text = "В ключе не должны присутствовать цифры.";
                    }
                    else
                    {
                        try
                        {
                            var secretKey = LabelKeys.Text.ToUpper();
                            var decryptedMessage = belazo.Decrypt(message, secretKey);
                            TextBoxCheck.Text = decryptedMessage.ToLower();
                            LabelError.Text = "";
                        }
                        catch (Exception ex)
                        {
                            LabelError.Text = ex.Message;
                        }
                    }
                }
            }
            else if (active_cipher == "Vigenère")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text.ToUpper();
                        var decryptedMessage = vigenère.Decrypt(message, secretKey);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Matrix cipher")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    var secretKey = LabelKeys.Text;
                    try
                    {
                        Matrix_cipher matrix_cipher = new Matrix_cipher(secretKey, alph + "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                        var decryptedMessage = matrix_cipher.Decrypt(message);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Playfer")
            {
                if (LabelKeys.Text.Length > 0)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text;
                        Playfer playfer = new Playfer("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", secretKey);
                        var decryptedMessage = playfer.Decrypt(message);
                        Console.WriteLine("Проверка: " + decryptedMessage);
                        TextBoxCheck.Text = decryptedMessage;
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Vertical permutation")
            {
                if (LabelKeys.Text.Length > 2)
                {
                    try
                    {
                        var secretKey = LabelKeys.Text;
                        vertical_permutation.SetKey(secretKey);
                        var decryptedMessage = vertical_permutation.Decrypt(message);
                        TextBoxCheck.Text = decryptedMessage.ToLower();
                        LabelError.Text = "";
                    }
                    catch (Exception ex)
                    {
                        LabelError.Text = ex.Message;
                    }
                }
            }
            else if (active_cipher == "Cardano grille")
            {
                try
                {
                    var decryptedMessage = cardano_Grille.EN_De_crypt(message, false);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Shannon")
            {
                try
                {
                    var secretKey = LabelKeys.Text;
                    Shannon shannon = new Shannon(secretKey, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToUpper());
                    var decryptedMessage = shannon.Decrypt(message);
                    TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "Magma")
            {
                try
                {
                    //var decryptedMessage = magma.decryptText(message);
                    //TextBoxCheck.Text = decryptedMessage.ToLower();
                    LabelError.Text = "";
                }
                catch (Exception ex)
                {
                    LabelError.Text = ex.Message;
                }
            }
            else if (active_cipher == "А5/1")
            {

            }
            else if (active_cipher == "А5/2")
            {

            }
            else if (active_cipher == "RSA")
            {

            }
            else if (active_cipher == "Elgamal")
            {

            }
            else if (active_cipher == "ECC")
            {

            }
            else
            {

            }
        }

        private void BuClear_Click(object sender, EventArgs e)
        {
            TextBoxMessages.Text = "";
            TextBoxEncryptedMessage.Text = "";
            TextBoxCheck.Text = "";
        }

        private void BuCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(KeyA.Text);
                int n = Int32.Parse(KeyN.Text);
                int Ka = Int32.Parse(KeyKA.Text);
                int Kb = Int32.Parse(KeyKB.Text);
                var args =  diffie_Hellman.Check_Random(false, a, n, Ka, Kb);
                Console.WriteLine(args);
                Hellman(args);
                LabelError_Hellman.Text = "";
            }
            catch (Exception ex)
            {
                LabelError_Hellman.Text = ex.Message;
                KeyYA.Text = "";
                KeyYB.Text = "";
                SecretKeyA.Text = "";
                SecretKeyB.Text = "";
            }
        }

        private void BuRandom_Click(object sender, EventArgs e)
        {
            try
            {
                var args = diffie_Hellman.Check_Random(true);
                Console.WriteLine(args);
                Hellman(args);
                LabelError_Hellman.Text = "";
            }
            catch (Exception)
            {
                KeyYA.Text = "";
                KeyYB.Text = "";
                SecretKeyA.Text = "";
                SecretKeyB.Text = "";
            }
        }

        private void Hellman(string args) 
        {
            string[] values = args.Split(',');
            KeyA.Text = values[0];
            KeyN.Text = values[1];
            KeyKA.Text = values[2];
            KeyKB.Text = values[3];
            KeyYA.Text = values[4];
            KeyYB.Text = values[5];
            SecretKeyA.Text = values[6];
            SecretKeyB.Text = values[7];
        }

        private void BuCheckRSA_Click(object sender, EventArgs e)
        {
            try
            {
                int P = Int32.Parse(Key_P.Text);
                int Q = Int32.Parse(Key_Q.Text);
                int N = P * Q;
                Key_N.Text = N.ToString();
                int φ = (P - 1) * (Q - 1);
                Key_φ.Text = φ.ToString();
                int E = Int32.Parse(Key_E.Text);
                int D = 0;
                for (int i = 0; i < 99999; i++)
                    if ((i * E) % φ == 1)
                    {
                        D = i;
                        break;
                    }
                Key_D.Text = D.ToString();
                Public_key.Text = $"{E},{N}";
                Private_key.Text = $"{D},{N}";
                LabelError_RSA.Text = "";
                Refresh();
            }
            catch (Exception ex)
            {
                LabelError_RSA.Text = ex.Message;
            }
        }

        private void BuRandomRSA_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string a = "05";
            int b = Int32.Parse(a);
            Console.WriteLine(b);
        }

        private void BuTest_Click(object sender, EventArgs e)
        {
            TextBoxMessages.Text = "Не бойся собаки брехливой, а бойся молчаливой.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var a = Encoding.Unicode.GetBytes("Н");
            Console.WriteLine(a);
            foreach (var item in a)
            {
                Console.WriteLine(Convert.ToString(item, 2));
            }

        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
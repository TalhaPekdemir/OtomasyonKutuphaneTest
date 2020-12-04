using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonTest
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            pbxClose.BackColor = Color.Red;
            pbxMinimize.BackColor = Color.Coral;
        }
        
        //---------Test Statik değerleri---------
            String _id = "Admin";
            String _password = "cshavalıdır";
        //--------------Saat Kontrol--------------
            private int _t1 = DateTime.Now.Hour;
        //------------Borderless Drag-------------
            private bool _dragging = false;
            private Point _dragCursorPoint;
            private Point _dragFormPoint;
        //----------------Tooltip-----------------
            private ToolTip toolTipClose = new ToolTip();
            private ToolTip toolTipMinimize = new ToolTip();
        //----------------Darkmode----------------
            private bool isDarkMode;
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            DarkModeChecker();
            FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
            Width = 250;
            Height = 300;

            
            pbxClose.Size = new Size(30, 20);
            pbxClose.Location = new Point(220, 0);
            pbxMinimize.Size = new Size(30, 20);
            pbxMinimize.Location = new Point(190, 0);
            pbxClose.Image = Properties.Resources.icoClose;//Image.FromFile("C:\\Users\\GOLD\\Desktop\\CSharpVS\\CSharpLearning\\OtomasyonTest\\Resources\\icoClose.png");
            pbxMinimize.Image = Properties.Resources.icoMinimize;//Image.FromFile("C:\\Users\\GOLD\\Desktop\\CSharpVS\\CSharpLearning\\OtomasyonTest\\Resources\\icoMinimize.png");
            pbxClose.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxMinimize.SizeMode = PictureBoxSizeMode.CenterImage;

            lblGorevliLogin.Text = "Görevli Giriş";
            lblId.Text = "Kullanıcı Adı";
            lblPassword.Text = "Şifre";
            btnLoginGorevli.Text = "Giriş";
            lblMisc.Text = "Kütüphane";

            //lblId.TextAlign = ContentAlignment.MiddleRight;
            //lblId.AutoSize = false;
            //lblPassword.TextAlign = ContentAlignment.MiddleRight;
            //lblPassword.AutoSize = false;

            tbxId.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.PasswordChar = '\u25CF';
            
        }

        private void DarkModeChecker()//Karanlık mod entegrasyonu
        {
            if (true/*_t1 > 18|| _t1 < 6*/)//Test için comment alındı
            {
                String warn = "Akşam saatlerinde göz yorgunluğunu azaltmak amacıyla otomatik olarak karanlık moda " +
                    "geçirildiniz. Varsayılana dönmek ister misiniz?";
                String header = "Karanlık Mod Uyarısı";
                //MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                DialogResult DialogResult = MessageBox.Show(warn, header, MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No)
                {
                    isDarkMode = true;
                    BackColor = Color.FromArgb(30, 30, 30);
                    lblGorevliLogin.ForeColor = Color.White;
                    lblId.ForeColor = Color.White;
                    lblPassword.ForeColor = Color.White;
                    tbxId.ForeColor = Color.White;
                    tbxPassword.ForeColor = Color.White;
                    tbxId.BackColor = Color.FromArgb(50, 50, 50);
                    tbxPassword.BackColor = Color.FromArgb(50, 50, 50);
                    lblMisc.ForeColor = Color.White;
                    btnLoginGorevli.BackColor = Color.FromArgb(50, 50, 50);
                    btnLoginGorevli.ForeColor = Color.White;
                    pbxClose.BackColor = Color.FromArgb(40, 40, 72);
                    pbxMinimize.BackColor = Color.FromArgb(79, 79, 140);
                }
                else
                {
                    isDarkMode = false;
                    pbxClose.BackColor = Color.Red;
                    pbxMinimize.BackColor = Color.Coral;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)//Giriş kontrol
        {
            /*Görevli girişi - isim sonradan değişti <--Öğrenci girişi neden olsun ki?? Belki olabilir.-->
             * ÖKBS - Öğrenci Kütüphane Bilgilendirme Sistemi
             */
            if (tbxId.Text == _id && tbxPassword.Text == _password)
            {
                MessageBox.Show("Giriş başarılı.");
                Visible = false;
                UserInterface userInterface = new UserInterface();
                userInterface.Visible = true;
            }
            else if (String.IsNullOrWhiteSpace(tbxId.Text))
            {
                MessageBox.Show("Lütfen geçerli bir kimlik giriniz.");
            }
            else if (String.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                MessageBox.Show("Lütfen şifrenizi giriniz.");
            }
            else
            {
                MessageBox.Show("Kimlik veya şifre hatalı!");
            }
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)//Şifreyi enter ile girebilmek için ancak prop'tan "AcceptsEnter" = true yapılabilir
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginGorevli.PerformClick();
            }
        }

        private void LoginScreen_MouseDown(object sender, MouseEventArgs e)//Kenarlıksız Form Mouse Aşağı kontrol
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void LoginScreen_MouseUp(object sender, MouseEventArgs e)//Kenarlıksız Form Mouse yukarı kontrol
        {
            _dragging = false;
        }

        private void LoginScreen_MouseMove(object sender, MouseEventArgs e)//Kenarlıksız formu ekranda sürükleme
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)//Çıkış isteği onaylama
        {
            String warn = "Çıkmak istediğinize emin misiniz?";
            String header = "Çıkış";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult DialogResult = MessageBox.Show(warn, header, messageBoxButtons);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pbxMinimize_Click(object sender, EventArgs e)//Formu Aşağı alma - Borderless da tuşlar yoktur.
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbxClose_MouseHover(object sender, EventArgs e)//TODO Elden geçirilecek
        {
            toolTipClose.SetToolTip(pbxClose, "Kapat");
            //isDarkMode ? pbxClose.BackColor = Color.FromArgb(45, 45, 81) : pbxClose.BackColor = Color.Red;
            if (isDarkMode)
            {
                pbxClose.BackColor = Color.FromArgb(45, 45, 81);
            }
            else
            {
                pbxClose.BackColor = Color.DarkRed;
            }
        }

        private void pbxMinimize_MouseHover(object sender, EventArgs e)//TODO Elden geçirilecek
        {
            toolTipMinimize.SetToolTip(pbxMinimize, "Aşağı Al");
            
            if (isDarkMode)
            {
                pbxMinimize.BackColor = Color.FromArgb(20, 255, 255, 255/*82, 82, 145*/);
            }
            else
            {
                pbxMinimize.BackColor = Color.DarkOrchid;
            }
        }

        private void pbxClose_MouseLeave(object sender, EventArgs e)//TODO Elden geçirilecek
        {
            if (isDarkMode)
            {
                pbxClose.BackColor = Color.FromArgb(40, 40, 72);
            }
            else
            {
                pbxClose.BackColor = Color.Red;
            }
        }

        private void pbxMinimize_MouseLeave(object sender, EventArgs e)//TODO Elden geçirilecek
        {
            if (isDarkMode)
            {
                pbxMinimize.BackColor = Color.FromArgb(79, 79, 140);
            }
            else
            {
                pbxMinimize.BackColor = Color.Coral;
            }
        }
    }
}
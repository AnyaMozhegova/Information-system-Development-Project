using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsFormsApp1
{
    public partial class MenuClientcs : Form
    {
        public MenuClientcs()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);
            WindowState = FormWindowState.Maximized;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            IbITitle.Text = childForm.Text;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.RosyBrown;
                currentBtn.ForeColor = Color.LemonChiffon;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.LemonChiffon;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.Aquamarine;
            IbITitle.Text = "Домой";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Thistle;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CrudProductForClient());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AboutOur());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imageHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}

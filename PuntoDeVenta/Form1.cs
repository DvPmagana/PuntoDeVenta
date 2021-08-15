using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        //Campos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();

            random = new Random(); 
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metodos
        //Metodo para cambio de colores en Index
        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            //Si se el color seleccionado ya esta utilizado, se vuelve a seleccionar otro color
            while (tempIndex == index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        //Cammbio de colores al tener un boton activo
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor= Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));        
                    btnCloseChildForm.Visible = true;
                }   
            }
        }
        private void DisableButton()
        {
            foreach (Control previuosBtn in panelMenu.Controls)
            {
                if (previuosBtn.GetType() == typeof(Button))
                {
                   previuosBtn.BackColor = Color.FromArgb(51, 51, 76);
                   previuosBtn.ForeColor = Color.Gainsboro;
                   previuosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbtTitle.Text = childForm.Text;
        }
        private void panelMenu_Paint(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormsProduct(), sender);


        }

        private void btnServ_Click(object sender, EventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lbtTitle.Text = "MENU PRINCIPAL";
            panelTitleBar.BackColor = Color.DarkOrange;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbtTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInventario(), sender);

        }

 

        private void lblHour_Click(object sender, EventArgs e)
        {

        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }
    }
}

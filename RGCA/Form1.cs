using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGCA
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int EtkilenenKayitSayisi= BLL.SystemUserSystemEntryControl(txt_userName.Text, txt_userSifre.Text);
            if (EtkilenenKayitSayisi>0)
            {
                AnaForm AnaForm1 = new AnaForm();
                AnaForm1.Show();
                
            }
            else if (EtkilenenKayitSayisi == -100)
            {
                MessageBox.Show("Please fill in the form fields.");
            }
            else
            {
                MessageBox.Show("You have logged in incorrectly, check your details.");
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

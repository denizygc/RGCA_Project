using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RGCA
{
    public partial class AnaForm : Form
    {
        BusinessLogicLayer BLL;

        SqlConnection connect = new SqlConnection();
        
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
            GarbageDoldur();
            datagridviewgöster11("execute SP_BIN_Getir");
            datagridviewgöster("execute SP_Employee_Getir");
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }
        private void GarbageTypeDoldur()
        {
            List<GarbageType> garbageTypeList = BLL.Garbage_Type_Getir();
            lst_display.DataSource = garbageTypeList;
            
        }
        private void GarbageDoldur()
        {
            List<Garbage> garbageTypeList = BLL.Garbage_Getir();
            lst_displayBın.DataSource = garbageTypeList;

        }
        private void TrashTypeDoldur()
        {
            List<TrashType> trashTypeList = BLL.Trash_Type_Getir();
            lst_display.DataSource = trashTypeList;

        }
        private void LocationTypeDoldur()
        {
            List<Locations> locationTypeList = BLL.Locations_Getir();
            lst_display.DataSource = locationTypeList;

        }
        private void WasteTypeDoldur()
        {
            List<WasteDisposalPointType> wasteTypeList = BLL.Waste_Disposal_Point_Getir();
            lst_display.DataSource = wasteTypeList;

        }
        public void BinTypeDoldur()
        {
            List<BINGetir> binTypeList = BLL.BIN_Getir();
            lst_display.DataSource = binTypeList;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            GarbageTypeDoldur();
            datagridviewgöster11("Execute SP_Garbage_Getir");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrashTypeDoldur();
            datagridviewgöster11("Execute SP_Trash_Type_Getir");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LocationTypeDoldur();
            datagridviewgöster11("Execute SP_Location_Getir");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WasteTypeDoldur();
            datagridviewgöster11("Execute SP_Waste_Disposal_Point_Getir");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            GarbageDoldur();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int EtkilenenKayitSayisi = BLL.New_Bin(txt_binId11.Text,txt_binName11.Text,
                txt_garbageType11.Text,txt_location11.Text,txt_trashType11.Text,txt_wasteDPId11.Text);

            if (EtkilenenKayitSayisi > 0)
            {
                MessageBox.Show("Record Added.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else if (EtkilenenKayitSayisi == -100)
            {
                MessageBox.Show("All Gaps are required fields.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Failed to retrieve new record, see your system administrator", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void EmployeeGetir()
        {
            List<Employee> employeeList = BLL.Employee_Getir();
            lst_display.DataSource = employeeList;

        }
        private void BinEmployeeGetir()
        {
            List<BIMemployeGetir> binEmployeeList = BLL.Garbage_Employee_Getir();
            lst_display.DataSource = binEmployeeList;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmployeeGetir();
            datagridviewgöster("execute SP_Employee_Getir");
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BinEmployeeGetir();
            datagridviewgöster("execute SP_Garbage_Employee_Getir");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int EtkilenenKayitSayisi = BLL.New_Employee(txt_employeeId11.Text, txt_empName11.Text, txt_empSurname11.Text, DateTime.Now);

            if (EtkilenenKayitSayisi > 0)
            {
                MessageBox.Show("Record Added.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else if (EtkilenenKayitSayisi == -100)
            {
                MessageBox.Show("All Gaps are required fields.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Failed to retrieve new record, see your system administrator", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            int EtkilenenKayitSayisi = BLL.New_Bin_Employee(txt_Bin_emp_ID.Text, txt_binID_employee.Text, txt_binEmpId.Text);

            if (EtkilenenKayitSayisi > 0)
            {
                MessageBox.Show("Record Added.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else if (EtkilenenKayitSayisi == -100)
            {
                MessageBox.Show("All Gaps are required fields.", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Failed to retrieve new record, see your system administrator", "Information",
                     MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            BinTypeDoldur();
            datagridviewgöster("execute SP_BIN_Getir");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmployeeGetir();
            datagridviewgöster("execute SP_Employee_Getir");
        }

        private void AnaForm_Load_1(object sender, EventArgs e)
        {

        }
     
        private void button8_Click(object sender, EventArgs e)
        {

            string ID = ((Garbage)lst_displayBın.SelectedItem).BIN_ID;

            int etiklenSayi = BLL.Kayit_Guncelle
                (txt_binId11.Text, 
                txt_binName11.Text, 
                txt_garbageType11.Text, 
                txt_trashType11.Text,
                txt_location11.Text,
                txt_wasteDPId11.Text);
               
                if (etiklenSayi >0)
            {
                GarbageDoldur();
            }
                else
            {
                MessageBox.Show("Please try again");
            }
        }

        private void lst_display_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BinTypeDoldur();

            datagridviewgöster11("execute SP_BIN_Getir");

        }

        private void button16_Click(object sender, EventArgs e)
        {
         
          
            Application.Exit();
        }

        private void lst_displayBın_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Garbage lstgarbage = (Garbage)lst.SelectedItem;
            Garbage dbgarbage = BLL.Kayit_Getir(lstgarbage.BIN_ID);
            if (dbgarbage != null)
            {
                txt_binId11.Text = dbgarbage.BIN_ID;
                txt_binName11.Text = dbgarbage.BIN_Name;
                txt_garbageType11.Text = dbgarbage.Garbage_Type_ID;
                txt_trashType11.Text = dbgarbage.Trash_Type_ID;
                txt_location11.Text = dbgarbage.Location_ID;
                txt_wasteDPId11.Text = dbgarbage.Waste_DP_ID;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you sure you want to delete the record?", "Information",
                    MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);
            if (result== DialogResult.OK)
            {
                Garbage garbage2 = (Garbage)lst_displayBın.SelectedItem;
                int etkilenenSayi = BLL.Delete_BIN(garbage2.BIN_ID);
                if (etkilenenSayi > 0)
                {
                    GarbageDoldur();
                }

            }
            else
            {
                MessageBox.Show("Canceled", "Information",
                  MessageBoxButtons.OKCancel,
             MessageBoxIcon.Warning);
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void datagridviewgöster(string veriler)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter(veriler,connect);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }

        public void datagridviewgöster11(string veriler)
        {
           
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter(veriler, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            datagridviewgöster("Select*from Employee");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}

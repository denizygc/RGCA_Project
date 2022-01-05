using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace RGCA
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int sonuc = 0;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }
        internal void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                connect.Close();
            }

        }

        internal int SystemEntryControl(SystemUsers S)
        {
            try
            {
                command = new SqlCommand("SP_System_Users_Control", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = S.User_Name;
                command.Parameters.Add("@User_Sifre", SqlDbType.NVarChar).Value = S.User_Sifre;
                BaglantiAyarla();
                sonuc = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;


        }
        internal SqlDataReader Garbage_Type_Getir()
        {
            command = new SqlCommand("SP_Garbage_Type_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        internal SqlDataReader Garbage_Getir()
        {
            command = new SqlCommand("SP_Garbage_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        internal SqlDataReader Trash_Type_Getir()
        {
            command = new SqlCommand("SP_Trash_Type_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader Locations_Getir()
        {
            command = new SqlCommand("SP_Location_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader Waste_Disposal_Point_Getir()
        {
            command = new SqlCommand("SP_Waste_Disposal_Point_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader BIN_Getir()
        {
            command = new SqlCommand("SP_BIN_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        internal int New_Bin(Garbage G)
        {
            try
            {
                command = new SqlCommand("SP_Garbage_Ekle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@BIN_ID", SqlDbType.NVarChar).Value = G.BIN_ID;
                command.Parameters.Add("@BIN_Name", SqlDbType.NVarChar).Value = G.BIN_Name;
                command.Parameters.Add("@Garbage_Type_ID", SqlDbType.NVarChar).Value = G.Garbage_Type_ID;
                command.Parameters.Add("@Trash_Type_ID", SqlDbType.NVarChar).Value = G.Trash_Type_ID;
                command.Parameters.Add("@Location_ID", SqlDbType.NVarChar).Value = G.Location_ID;
                command.Parameters.Add("@Waste_DP_ID", SqlDbType.NVarChar).Value = G.Waste_DP_ID;
                BaglantiAyarla();
                sonuc = (int)command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;

        }
        internal SqlDataReader Garbage_Employee_Getir()
        {
            command = new SqlCommand("SP_Garbage_Employee_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader Employee_Getir()
        {
            command = new SqlCommand("SP_Employee_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal int New_Employee(Employee E)
        {
            try
            {
                command = new SqlCommand("SP_Employee_Ekle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Employee_ID", SqlDbType.NVarChar).Value = E.Employee_ID;
                command.Parameters.Add("@Employee_Name", SqlDbType.NVarChar).Value = E.Employee_Name;
                command.Parameters.Add("@Employee_Surname", SqlDbType.NVarChar).Value = E.Employee_Surname;
                command.Parameters.Add("@Giris_Tarihi", SqlDbType.Date).Value = E.Giris_Tarihi;

                BaglantiAyarla();
                sonuc = (int)command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;

        }
        internal int New_Bin_Employee(BINEmployee BE)
        {
            try
            {
                command = new SqlCommand("SP_Garbage_Employee_Ekle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Garbage_Employee_ID", SqlDbType.NVarChar).Value = BE.Garbage_Employee_ID;
                command.Parameters.Add("@BIN_ID", SqlDbType.NVarChar).Value = BE.BIN_ID;
                command.Parameters.Add("@Employee_ID", SqlDbType.NVarChar).Value = BE.Employee_ID;

                BaglantiAyarla();
                sonuc = (int)command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;

        }
        internal int Kayit_Guncelle(Garbage G)
        {
            try
            {
                command = new SqlCommand("SP_Garbage_Guncelle", connect);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@BIN_ID", SqlDbType.NVarChar).Value = G.BIN_ID;
                command.Parameters.Add("@BIN_Name", SqlDbType.NVarChar).Value = G.BIN_Name;
                command.Parameters.Add("@Garbage_Type_ID", SqlDbType.NVarChar).Value = G.Garbage_Type_ID;
                command.Parameters.Add("@Trash_Type_ID", SqlDbType.NVarChar).Value = G.Trash_Type_ID;
                command.Parameters.Add("@Location_ID", SqlDbType.NVarChar).Value = G.Location_ID;
                command.Parameters.Add("@Waste_DP_ID", SqlDbType.NVarChar).Value = G.Waste_DP_ID;
                BaglantiAyarla();
                sonuc = (int)command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;

        }

        internal SqlDataReader Kayit_Getir(string ID)
        {
            command = new SqlCommand("SP_Kayit_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BIN_ID", SqlDbType.NVarChar).Value = ID;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        internal int Delete_BIN(string ID)
        {
            try
            {
                command = new SqlCommand("SP_Garbage_Sil", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@BIN_ID", SqlDbType.NVarChar).Value = ID;
                BaglantiAyarla();

                sonuc = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }

        

        
        



    }


}

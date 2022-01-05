using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RGCA
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL;
        SqlDataReader reader;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();

        }

        internal int SystemUserSystemEntryControl(string user_name, string user_sifre)
        {
            if (!string.IsNullOrEmpty(user_name) && !string.IsNullOrEmpty(user_sifre))
            {
                SystemUsers S = new SystemUsers();
                S.User_Name = user_name;
                S.User_Sifre = user_sifre;
                return DAL.SystemEntryControl(S);
            }
            else
                return -100;

        }
        internal List<GarbageType> Garbage_Type_Getir()
        {
            List<GarbageType> garbageType = new List<GarbageType>();

            try
            {
                reader = DAL.Garbage_Type_Getir();
                while (reader.Read())
                {
                    garbageType.Add(new GarbageType()
                    {
                        Garbage_Type_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Garbage_Type_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Garbage_Type_Definition = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),

                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return garbageType;
        }
        internal List<Garbage> Garbage_Getir()
        {
            List<Garbage> garbage1 = new List<Garbage>();

            try
            {
                reader = DAL.Garbage_Getir();
                while (reader.Read())
                {
                    garbage1.Add(new Garbage()
                    {
                        BIN_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        BIN_Name=reader.IsDBNull(1)? string.Empty: reader.GetString(1),
                        Garbage_Type_ID= reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Trash_Type_ID = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Location_ID = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Waste_DP_ID = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                       
                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return garbage1;
        }
        internal List<TrashType> Trash_Type_Getir()
        {
            List<TrashType> trashType = new List<TrashType>();

            try
            {
                reader = DAL.Trash_Type_Getir();
                while (reader.Read())
                {
                    trashType.Add(new TrashType()
                    {
                        Trash_Type_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Trash_Type_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Capacity_Amount = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),

                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return trashType;
        }
        internal List<Locations> Locations_Getir()
        {
            List<Locations> locationType = new List<Locations>();

            try
            {
                reader = DAL.Locations_Getir();
                while (reader.Read())
                {
                    locationType.Add(new Locations()
                    {
                        Location_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Location_name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Region_Name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Building_Name = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Storey_Name = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)

                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return locationType;
        }
        internal List<WasteDisposalPointType> Waste_Disposal_Point_Getir()
        {
            List<WasteDisposalPointType> wasteType = new List<WasteDisposalPointType>();

            try
            {
                reader = DAL.Waste_Disposal_Point_Getir();
                while (reader.Read())
                {
                    wasteType.Add(new WasteDisposalPointType()
                    {
                        Waste_DP_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Garbage_Type_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Capacity_Amount = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Region_Name = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),


                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return wasteType;
        }
        internal List<BINGetir> BIN_Getir()
        {
            List<BINGetir> binType = new List<BINGetir>();

            try
            {
                reader = DAL.BIN_Getir();
                while (reader.Read())
                {
                    binType.Add(new BINGetir()
                    {
                        BIN_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Garbage_Type_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Garbage_Type_Definition = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Trash_Type_ID = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Waste_DP_ID = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Location_ID = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)


                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return binType;
        }
        internal int New_Bin(string binId, string binName, string garbageTypeId, string
            trashTypeId, string locationId, string wasteDPId)
        {
            if (!string.IsNullOrEmpty(binId) && !string.IsNullOrEmpty(binName) &&
                !string.IsNullOrEmpty(garbageTypeId)
                && !string.IsNullOrEmpty(trashTypeId) && !string.IsNullOrEmpty(locationId) &&
                !string.IsNullOrEmpty(wasteDPId))
            {

                Garbage G1 = new Garbage();
                G1.BIN_ID = binId;
                G1.BIN_Name = binName;
                G1.Garbage_Type_ID = garbageTypeId;
                G1.Trash_Type_ID = trashTypeId;
                G1.Location_ID = locationId;
                G1.Waste_DP_ID = wasteDPId;

                return DAL.New_Bin(G1);
            }
            else
            {
                return -100;
            }

        }

        internal List<Employee> Employee_Getir()
        {
            List<Employee> employeType = new List<Employee>();

            try
            {
                reader = DAL.Employee_Getir();
                while (reader.Read())
                {
                    employeType.Add(new Employee()
                    {
                        Employee_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Employee_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Employee_Surname = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Giris_Tarihi = reader.GetDateTime(3)

                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return employeType;
        }
        internal List<BIMemployeGetir> Garbage_Employee_Getir()
        {
            List<BIMemployeGetir> binEmployeeType = new List<BIMemployeGetir>();

            try
            {
                reader = DAL.Garbage_Employee_Getir();
                while (reader.Read())
                {
                    binEmployeeType.Add(new BIMemployeGetir()
                    {
                        BIN_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        Garbage_Employee_ID = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Employee_Name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Employee_Surname = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    
                    });
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return binEmployeeType;
        }
        internal int New_Employee(string employeeID, string employeeName, string employeeSurname, DateTime giristarihi)
        {
            if (!string.IsNullOrEmpty(employeeID) && !string.IsNullOrEmpty(employeeID) &&
                !string.IsNullOrEmpty(employeeSurname))
            {

                Employee E1 = new Employee();
                E1.Employee_ID = employeeID;
                E1.Employee_Name = employeeName;
                E1.Employee_Surname = employeeSurname;
                E1.Giris_Tarihi = giristarihi;
              

                return DAL.New_Employee(E1);
            }
            else
            {
                return -100;
            }

        }
        internal int New_Bin_Employee(string binEmployeeId, string binID, string employeeId)
        {
            if (!string.IsNullOrEmpty(binEmployeeId) && !string.IsNullOrEmpty(binID) &&
                !string.IsNullOrEmpty(employeeId))
            {

                BINEmployee BE1 = new BINEmployee();
                BE1.Garbage_Employee_ID = binEmployeeId;
                BE1.BIN_ID = binID;   
                BE1.Employee_ID= employeeId;
             
                return DAL.New_Bin_Employee(BE1);
            }
            else
            {
                return -100;
            }

        }

        internal int Kayit_Guncelle(string binId, string binName, string garbageTypeId, string
            trashTypeId, string locationId, string wasteDPId)
        {
            Garbage G2 = new Garbage()
            {

                BIN_ID = binId,
                BIN_Name = binName,
                Garbage_Type_ID = garbageTypeId,
                Trash_Type_ID = trashTypeId,
                Location_ID = locationId,
                Waste_DP_ID = wasteDPId
            };
            return DAL.Kayit_Guncelle(G2);
        }

        internal Garbage Kayit_Getir(string ID)
        {
            Garbage G = new Garbage();
            try
            {
                reader = DAL.Kayit_Getir(ID);
                while (reader.Read())
                {
                    G.BIN_ID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    G.BIN_Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    G.Garbage_Type_ID = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    G.Trash_Type_ID = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    G.Location_ID = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    G.Waste_DP_ID = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                }

            }
            catch
            {

            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return G;
        }
        internal int Delete_BIN(String ID)
        {
            return DAL.Delete_BIN(ID);
        }
     
    }

}

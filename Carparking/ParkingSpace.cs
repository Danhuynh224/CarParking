using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carparking
{
    public class ParkingSpace
    {
        private int iD;
        private string status;
        private float price;
        private string iDCar;
        private string area;
        private int parkedDays;

        public ParkingSpace(int iD, string status, float price, string iDCar, string area, int parkedDays)
        {
            this.ID = iD;
            this.Status = status;
            this.Price = price;
            this.IDCar = iDCar;
            this.Area = area;
            this.ParkedDays = parkedDays;
        }

        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public float Price { get => price; set => price = value; }
        public string IDCar { get => iDCar; set => iDCar = value; }
        public string Area { get => area; set => area = value; }
        public int ParkedDays { get => parkedDays; set => parkedDays = value; }
        public float getMoney()
        {
            return price*parkedDays;
        }

        public string getDetailInf()
        {
            return "\n----------------------------\n" + 
                "\nIDSlot: " + iD + "\nArea: " + area + "\nStatus: " + status + "\nPrice: " 
                + price + "\nIDCar: " + iDCar + "\nParkedDays: " + parkedDays 
                + "\n\n----------------------------\n";
        }


        public void xuatFile()
        {
            //string path = "ParkingSpace.txt";

            //TextWriter wrt = new StreamWriter(path, true);
            //dataGridView1.AllowUserToAddRows = false;
            //wrt.WriteLine("   ID\t\t  Status\tOutCome\t\tLoiNhuan");
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        wrt.Write("|" + "\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //    wrt.WriteLine("");
            //    wrt.WriteLine("================================================");
            //}
            //wrt.Close();
        }


    }
}
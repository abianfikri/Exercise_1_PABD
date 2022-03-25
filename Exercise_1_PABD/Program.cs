using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise_1_PABD
{
    class Program
    {
        public void insertTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-91VJ4BQG;database=Toko_bakery;Integrated Security=TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand(

                    "insert into Pembeli (Kode_Pembeli, nama_Pembeli, Tgl_Pembelian, No_hp) values('Pb1','Asep','01-11-2022','081122334455')" +
                    "insert into Pembeli (Kode_Pembeli, nama_Pembeli, Tgl_Pembelian, No_hp) values('Pb2','Andi','01-12-2022','081232334455')" +
                    "insert into Pembeli (Kode_Pembeli, nama_Pembeli, Tgl_Pembelian, No_hp) values('Pb3','Ana','01-13-2022','081234334455')" +
                    "insert into Pembeli (Kode_Pembeli, nama_Pembeli, Tgl_Pembelian, No_hp) values('Pb4','Ani','01-14-2022','08123454455')" +
                    "insert into Pembeli (Kode_Pembeli, nama_Pembeli, Tgl_Pembelian, No_hp) values('Pb5','Beni','01-15-2022','081234564455')" +

                    "insert into Kue (Kode_Kue, jenis_Kue, Harga, Tgl_Pembuatan) values('Ku1','Cake', '10000','01-01-2022')" +
                    "insert into Kue (Kode_Kue, jenis_Kue, Harga, Tgl_Pembuatan) values('Ku2','Brownies', '15000','01-02-2022')" +
                    "insert into Kue (Kode_Kue, jenis_Kue, Harga, Tgl_Pembuatan) values('Ku3','Kue Basah', '10500','01-03-2022')" +
                    "insert into Kue (Kode_Kue, jenis_Kue, Harga, Tgl_Pembuatan) values('Ku4','Kue Kering', '12000','01-04-2022')" +
                    "insert into Kue (Kode_Kue, jenis_Kue, Harga, Tgl_Pembuatan) values('Ku5','Kue Tradisional', '8000','01-05-2022')"+
                    
                    "Insert into Pemesanan (Kode_Pemesanan, Kode_Pembeli, Kode_Kue, Qty, Harga, Total_Harga, Tgl_Pemesanan) values('Pm1','Pb1','Ku1', '2', '10000', '20000', '01-10-2022')" +
                    "Insert into Pemesanan (Kode_Pemesanan, Kode_Pembeli, Kode_Kue, Qty, Harga, Total_Harga, Tgl_Pemesanan) values('Pm2','Pb2','Ku2', '1', '15000', '15000', '01-11-2022')" +
                    "Insert into Pemesanan (Kode_Pemesanan, Kode_Pembeli, Kode_Kue, Qty, Harga, Total_Harga, Tgl_Pemesanan) values('Pm3','Pb3','Ku3', '2', '10500', '21000', '01-12-2022')" +
                    "Insert into Pemesanan (Kode_Pemesanan, Kode_Pembeli, Kode_Kue, Qty, Harga, Total_Harga, Tgl_Pemesanan) values('Pm4','Pb4','Ku4', '3', '12000', '36000', '01-13-2022')" +
                    "Insert into Pemesanan (Kode_Pemesanan, Kode_Pembeli, Kode_Kue, Qty, Harga, Total_Harga, Tgl_Pemesanan) values('Pm5','Pb5','Ku5', '2', '8000', '16000', '01-14-2022')" +
                    
                    "Insert into Kasir (Kode_Kasir, nama_Kasir, No_hp, Alamat) values ('Kr1', 'Tono', '082211445566', 'Jakarta')" +
                    "Insert into Kasir (Kode_Kasir, nama_Kasir, No_hp, Alamat) values ('Kr2', 'Nani', '081122445566', 'Bandung')" +
                    "Insert into Kasir (Kode_Kasir, nama_Kasir, No_hp, Alamat) values ('Kr3', 'Wini', '083322445566', 'Bogor')" +
                    "Insert into Kasir (Kode_Kasir, nama_Kasir, No_hp, Alamat) values ('Kr4', 'Joko', '084455334455', 'Depok')" +
                    "Insert into Kasir (Kode_Kasir, nama_Kasir, No_hp, Alamat) values ('Kr5', 'Wahyu', '085533445566', 'Bekasi')" +

                    "Insert into Transaksi (Kode_Transaksi, Kode_Kasir, Kode_Pemesanan, Tgl_Transaksi, Qty, Harga, SubTotal, Pembayaran, Kembalian) Values ('Kt1', 'Kr1', 'Pm1', '01-11-2022', '2', '10000', '20000', '50000', '30000')" +
                    "Insert into Transaksi (Kode_Transaksi, Kode_Kasir, Kode_Pemesanan, Tgl_Transaksi, Qty, Harga, SubTotal, Pembayaran, Kembalian) Values ('Kt2', 'Kr2', 'Pm2', '01-12-2022', '1', '15000', '15000', '20000', '5000')" +
                    "Insert into Transaksi (Kode_Transaksi, Kode_Kasir, Kode_Pemesanan, Tgl_Transaksi, Qty, Harga, SubTotal, Pembayaran, Kembalian) Values ('Kt3', 'Kr3', 'Pm3', '01-13-2022', '2', '10500', '21000', '50000', '29000')" +
                    "Insert into Transaksi (Kode_Transaksi, Kode_Kasir, Kode_Pemesanan, Tgl_Transaksi, Qty, Harga, SubTotal, Pembayaran, Kembalian) Values ('Kt4', 'Kr4', 'Pm4', '01-14-2022', '3', '12000', '36000', '50000', '14000')" +
                    "Insert into Transaksi (Kode_Transaksi, Kode_Kasir, Kode_Pemesanan, Tgl_Transaksi, Qty, Harga, SubTotal, Pembayaran, Kembalian) Values ('Kt5', 'Kr5', 'Pm5', '01-15-2022', '2', '8000', '16000', '20000', '4000')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data Sukses Ditambahkan!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data Gagal Ditambahkan. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().insertTable();
        }
    }
}

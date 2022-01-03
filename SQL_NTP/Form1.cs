using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_NTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region btnKaydet
            //SqlConnection cn = null;
            //try
            //{
            //    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);//User="",Password="";

            //    if (cn != null)//Null Check
            //    {
            //        cn.Open();
            //    }

            //    SqlCommand cmd = new SqlCommand($"Insert into Ogrenci (Ad,Soyad,Numara,TC_No,Sinif_ID) values ('{txtAd.Text}','{txtSoyad.Text}','{txtNumara.Text}','{txtTC.Text}','{cmbSiniflar.SelectedValue}')", cn);

            //    int sonuc = cmd.ExecuteNonQuery();

            //    MessageBox.Show(sonuc > 0 ? "Ekleme Başarılı" : "Başarısız");
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (cn != null && cn.State != ConnectionState.Closed)//Null Check
            //    {
            //        cn.Close();
            //    }
            //} 
            #endregion

            OgrenciBL obl = new OgrenciBL();
            obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text, Numara = txtNumara.Text, Sinif_ID = (int)cmbSiniflar.SelectedValue, TC_No = txtTC.Text });                        

        }
        //DON'T Repeat Yourself
        private void btnSfrla_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            txtTC.Clear();

            txtBul.Clear();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);//User="",Password="";

                if (cn != null)//Null Check
                {
                    cn.Open();
                }

                SqlCommand cmd = new SqlCommand($"Select * from Ogrenci where Numara = {txtBul.Text}", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtAd.Text = dr["Ad"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();
                    txtNumara.Text = dr["Numara"].ToString();
                    txtTC.Text = dr["TC_No"].ToString();

                }
                dr.Close();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)//Null Check
                {
                    cn.Close();
                }
            }
        }

        /*
         Garbage Collector:
         çöp toplayıcısı; işi biten nesneleri toplar.(Başka yerlere ulaşan nesneler hariç)
         base interface'lerinden bir tanesi Idisposable olanı toplamaz.
         */
        //Interfaceler classları zorlar.
        //bir classın base interface'lerinde Idisposable varsa class türetilirken using kullanmalıyız.



        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    if (cn != null)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand($"Select Sinif_ID,SinifAd,Kontenjan from Sinif", cn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    List<Sinif> siniflar = new List<Sinif>();

                    foreach (Sinif item in siniflar)
                    {
                        MessageBox.Show(item.SinifAd);
                    }

                    while (dr.Read())
                    {
                        siniflar.Add(new Sinif { Kontenjan = Convert.ToInt32(dr["Kontenjan"]), SinifAd = dr["SinifAd"].ToString(), Sinif_ID = Convert.ToInt32(dr["Sinif_ID"]) });
                    }

                    dr.Close();

                    cmbSiniflar.DisplayMember = "SinifAd";
                    cmbSiniflar.ValueMember = "Sinif_ID";
                    cmbSiniflar.DataSource = siniflar;
                }      
                 
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {//nullcheck
                    cn.Close();
                    cn.Dispose();
                }
            }
        }
    }    
}

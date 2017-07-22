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
namespace Kullanıcı_Girişi
{
    public partial class yarisma : Form
    {
        public yarisma()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data Source=192.168.1.34;Initial Catalog=bilgiyarısması;User ID=yigidolar; Password=Semih.0637");
        int i = 0;
        int kelimesayisi = 0;
       
        private void butonrenkleri()
        {
            button1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            button2.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            button3.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            button4.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
        }


         private void say()
        {
   
            string id;
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select *From kelimeler", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                id = oku["id"].ToString();

                kelimesayisi++; 

            }
            bağlan.Close();
            label2.Text = kelimesayisi.ToString();
        }
        int doğruluk = 0,cevap=0;
        int butons;
        int süre=0,s=0;
       private void doğruyak()
      {
            
      if(butons==1 && (süre %2==0 || süre%2==1  || süre==0))
      {
                button1.BackColor = Color.DarkGreen;
                
                if(s==1)
                {
                    s = 0;
                    button1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
                }
                s = 1;
            }
            if (butons == 2 && (süre % 2 == 0 || süre == 0))
            {
                button2.BackColor = Color.DarkGreen;
            }
            if (butons == 3 && (süre % 2 == 0 || süre == 0))
            {
                button3.BackColor = Color.DarkGreen;
            }
            if (butons == 4 && (süre % 2 == 0 || süre == 0))
            {
                button4.BackColor = Color.DarkGreen;
            }
            süre++;
        }

        private void buttonkilitoff()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void buttonkiliton()
        {
            button1.Enabled =true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }
        private void soruyaz()
        {
            
            Random rastgele = new Random();
            i = rastgele.Next(1, kelimesayisi);
            Random buton = new Random();
            butons = buton.Next(1, 5);


            int k = 1;
            // string id;
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select *From kelimeler", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            //label2.Text = oku["turkce"].ToString();
            while (oku.Read())
            {
                if (k == i)
                {
                    label1.Text = oku["turkce"].ToString();
                   
                }
                if (butons == 1)
                {
                    button1.Text = oku["ingilizce"].ToString();
                }
                if (butons == 2)
                {
                    button2.Text = oku["ingilizce"].ToString();
                }
                if (butons == 3)
                {
                    button3.Text = oku["ingilizce"].ToString();
                }
                if (butons == 4)
                {
                    button4.Text = oku["ingilizce"].ToString();
                }
               if(k==i)
               {
                    break;
               }
                k++;
            }bağlan.Close();

        }
        private void cevapla()
        {
       
        }
        int secim = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            secim = 1;
            buttonkilitoff();
            if(secim==butons)
            {
                doğruluk = 1;
                
            }
            if(doğruluk==0)
            {
                button1.BackColor = Color.DarkRed;
                button2.BackColor = Color.DarkRed;
                button3.BackColor = Color.DarkRed;
                button4.BackColor = Color.DarkRed;
            }
            timer1.Enabled = true; //doğruyak();
            cevapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secim = 2;
            buttonkilitoff();


            if (secim == butons)
            {
                doğruluk = 1;
                            }
            if (doğruluk == 0)
            {
               button2.BackColor = Color.DarkRed;
                button1.BackColor = Color.DarkRed;
                button3.BackColor = Color.DarkRed;
                button4.BackColor = Color.DarkRed;
            }
            timer1.Enabled = true;//doğruyak();
            cevapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secim = 3;
            buttonkilitoff();
           
             if (secim == butons)
            {
                doğruluk = 1;
                            }
            if (doğruluk == 0)
            {
                button3.BackColor = Color.DarkRed;
                button2.BackColor = Color.DarkRed;
                button1.BackColor = Color.DarkRed;
                button4.BackColor = Color.DarkRed;
            }
            timer1.Enabled = true;//    doğruyak();
            cevapla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secim = 4;
            buttonkilitoff();
            if (secim == butons)
            {
                doğruluk = 1;
            }
            if(doğruluk==0)
            {
                if (doğruluk == 0)
                {
                   
                 button4.BackColor = Color.DarkRed;
                    button2.BackColor = Color.DarkRed;
                    button3.BackColor = Color.DarkRed;
                    button1.BackColor = Color.DarkRed;
                }
            }
            timer1.Enabled = true;//    doğruyak();
            cevapla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (butons == 1 && (süre % 2 == 0 || süre % 2 == 1 || süre == 0))
            {
                

                if (süre%2 == 1)
                {
                    
                    button1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
                }
                else {
                    button1.BackColor = Color.DarkGreen;
                }
               
            }
            if (butons == 2 && (süre % 2 == 0 || süre % 2 == 1 || süre == 0))
            {
                if (süre % 2 == 1)
                {

                    button2.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
                }
                else
                {
                    button2.BackColor = Color.DarkGreen;
                }
            }
            if (butons == 3 && (süre % 2 == 0 || süre % 2 == 1 || süre == 0))
            {
                if (süre % 2 == 1)
                {

                    button3.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
                }
                else
                {
                    button3.BackColor = Color.DarkGreen;
                }
            }
            if (butons == 4 && (süre % 2 == 0 || süre % 2 == 1 || süre == 0))
            {
                if (süre % 2 == 1)
                {

                    button4.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
                }
                else
                {
                    button4.BackColor = Color.DarkGreen;
                }
            }
            süre++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            butonrenkleri();
            doğruluk = 0;
            soruyaz();
            buttonkiliton();
        }


        
        

        private void yarisma_Load(object sender, EventArgs e)
        {
           say();
          soruyaz();
          
            /*while (doğruluk == 1)
            {
                if (cevap == 1)
                {
                    soruyaz();
                }
                }*/
    }
}
}

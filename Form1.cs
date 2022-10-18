using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Ba_Zara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string select1 = ("select name_clothing from clothing where id_cloth = 1;");
            MySqlConnection conn = Dbuntils.GetDBConnection();
            MySqlCommand temp = new MySqlCommand(select1, conn);
            MySqlDataReader itemname;

            conn.Open();

            itemname = temp.ExecuteReader();
            if (itemname.HasRows)
            {
                itemname.Read();
                lablegosha.Text = Convert.ToString(itemname.GetString(0));
            }
            conn.Close();


        }

        private void lablegosha_Click(object sender, EventArgs e)
        {
            try
            {
                string addcart = ("insert into cort(id_cloth) values((select id_cloth from clothing where id_cloth = 1));");
                MySqlConnection conn = Dbuntils.GetDBConnection();                
                MySqlCommand temp = new MySqlCommand(addcart, conn);
                conn.Open();
                temp.ExecuteReader();

                string aut = "select *from cort";
                MySqlCommand aut1 = new MySqlCommand(aut, conn);
                MySqlDataReader inp = aut1.ExecuteReader();
                if (inp.HasRows)
                {
                    inp.Read();
                    lablegosha.Text = Convert.ToString(inp.GetString(0));
                }

                MessageBox.Show(Convert.ToString(inp));
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cort Win = new cort(); 
            Win.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = Dbuntils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("insert into cort value(1, 1);", conn);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

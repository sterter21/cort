using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Ba_Zara
{
    public partial class cort : Form
    {
        public cort()
        {
            InitializeComponent();
            getInfo("select cort.id_cloth,  clothing.name_clothing from cort join clothing on cort.id_cloth = clothing.id_cloth;");
            
        }
        public void getInfo(string query)
        {
            try
            {
                MySqlConnection conn = Dbuntils.GetDBConnection();
                MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                conn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}

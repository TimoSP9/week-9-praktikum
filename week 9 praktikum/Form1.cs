using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace week_9_praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable MnChome = new DataTable();
            sqlQuery = "SELECT m.manager_name as `Manager Name`, p.player_name as `Captain` FROM manager m, player p, team t WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id and t.team_id = '" + cBox_home.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(MnChome);
            lbl_namamanager1.Text = MnChome.Rows[0]["Manager Name"].ToString();
            lbl_namacaptain1.Text = MnChome.Rows[0]["Captain"].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataTable dtPlayerAway = new DataTable();
            DataTable dtPlayerHome = new DataTable();
            sqlQuery = "SELECT * FROM TEAM  ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlQuery = "SELECT * FROM TEAM  ";
            sqlAdapter.Fill(dtPlayerAway);
            sqlAdapter.Fill(dtPlayerHome);
            cBox_home.DataSource = dtPlayerHome;
            cBox_home.DisplayMember = "team_name";
            cBox_home.ValueMember = "team_id";

            cBox_away.DisplayMember = "team_name";
            cBox_away.ValueMember = "team_id";
            cBox_away.DataSource = dtPlayerAway;
        
            
        }

        private void lbl_namamanager1_Click(object sender, EventArgs e)
        {
           
        }

        private void cBox_away_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable MnCAway = new DataTable();
            sqlQuery = "SELECT m.manager_name as `Manager Name`, p.player_name as `Captain` FROM manager m, player p, TEAM t WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id and t.team_id = '" + cBox_away.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(MnCAway);
            lbl_namamanager2.Text = MnCAway.Rows[0]["Manager Name"].ToString();
            lbl_namacaptain2.Text = MnCAway.Rows[0]["Captain"].ToString();
            DataTable SnC = new DataTable();
            sqlQuery = "SELECT CONCAT(t.home_stadium, ', ', t.city) as `Stadium`, t.capacity as `Capacity` FROM TEAM t WHERE t.team_id = '" + cBox_home.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(SnC);
            lbl_namastadium.Text = SnC.Rows[0]["Stadium"].ToString();
            lbl_namacapacity.Text = SnC.Rows[0]["Capacity"].ToString();
        }
    }
}

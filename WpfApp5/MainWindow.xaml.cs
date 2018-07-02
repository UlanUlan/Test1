using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using WpfApp5.Classes;
using System.ComponentModel;
using System.IO;


namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string connectionString = @"Data Source=(LocalDB)\LocalDBQ;Initial Catalog=CRCMS_new; User ID=sa;Password=Qwerty123";

        public List<GroupCs> listGroup = new List<GroupCs>();
        public MainWindow()
        {
            InitializeComponent();


            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from dic_Group";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);

            ListViewItem groupID = new ListViewItem() { Content = "Id" };

            //GroupListView.Items.Add("Id");
            //GroupListView.Items.Add("Name");


            //GroupListView.Items.Add(new ListViewItem { Content = "Id" });
            //GroupListView.Items.Add(new ListViewItem { Content = "Name" });




            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listGroup.Add(new GroupCs { Id = Int32.Parse(row["GroupId"].ToString()), Name = row["Name"].ToString() });
            }

            GroupListView.ItemsSource = listGroup;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

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
using System.Data.Linq;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            dataContext = new DataContext(@"Data Source=(LocalDB)\LocalDBQ;Initial Catalog=CRCMS_new; User ID=sa;Password=Qwerty123");

            Table<dic_Group> groups = dataContext.GetTable<dic_Group>();
            GroupListView.ItemsSource = groups.ToList();

            Table<dic_Model> models = dataContext.GetTable<dic_Model>();
            ModelListView.ItemsSource = models.ToList();

            Table<dic_Pavilion> pavilions = dataContext.GetTable<dic_Pavilion>();
            PavilionListView.ItemsSource = pavilions.ToList();

            Table<dic_Status> statuses = dataContext.GetTable<dic_Status>();
            StatusListView.ItemsSource = statuses.ToList();
        }

    }
}

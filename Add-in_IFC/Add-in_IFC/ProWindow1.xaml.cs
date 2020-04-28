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

namespace Add_in_IFC
{
    /// <summary>
    /// Interaction logic for ProWindow1.xaml
    /// </summary>
    public partial class ProWindow1 : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        public ProWindow1()
        {
            InitializeComponent();
            cb_MLA.SelectedIndex = 1;
            cb_MLA.Items.Add("Hierarchical Fusion");
            cb_MLA.Items.Add("Neural Network");
            cb_0.IsChecked = true;
            cb_1.IsChecked = true;
            cb_2.IsChecked = true;
        
        }

    }
}

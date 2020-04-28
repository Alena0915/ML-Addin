using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace Add_in_IFC
{
    internal class ShowProWindow1 : Button
    {

        private ProWindow1 _prowindow1 = null;

        protected override void OnClick()
        {
            //already open?
            if (_prowindow1 != null)
                return;
            _prowindow1 = new ProWindow1();
            _prowindow1.Owner = FrameworkApplication.Current.MainWindow;
            _prowindow1.Closed += (o, e) => { _prowindow1 = null; };
            _prowindow1.Show();
            //uncomment for modal
            //_prowindow1.ShowDialog();
        }

    }
}

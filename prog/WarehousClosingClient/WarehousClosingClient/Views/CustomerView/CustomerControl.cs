using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehousClosingClient.Views.CustomerView
{
    public partial class CustomerControl : UserControl
    {

        private readonly HttpClient _httpClient;


        public CustomerControl()
        {
            _httpClient = new HttpClient();

            InitializeComponent();
        }

    }
}

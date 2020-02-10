using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;

namespace PrintToSend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGetConnections_Click(object sender, EventArgs e)
        {
            List<AccessPoint> lsAP = new List<AccessPoint>();
            Wifi wifi = new Wifi();
            SimpleWifi.Win32.WlanClient wlanClient = new SimpleWifi.Win32.WlanClient();
            int count = wlanClient.Interfaces.Length;
            lsAP = wifi.GetAccessPoints();
            foreach (AccessPoint item in lsAP)
            {
                lstBxConnections.Items.Add(item.Name);
            }
        }

        private void btnGetUsers_Click(object sender, EventArgs e)
        {
        //    if (whatsApp.ConnectionStatus == ApiBase.CONNECTION_STATUS.CONNECTED)
        //    {
        //        AccountInfo accountInfo = whatsApp.GetAccountInfo();
                
        //    }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WhatsAppLinking whatsAppLinking = new WhatsAppLinking();
            whatsAppLinking.selectCustmor("");
            whatsAppLinking.sendToCustomer("Test from Desktop");
        }
    }
}
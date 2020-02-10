using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppApi;
using WhatsAppApi.Helper;
using NLog;
namespace PrintToSend
{
    class WhatsAppLinking
    {
        //NLog recommends using a static variable for the logger object
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger(); 
        
        WhatsApp whatsApp;
        AppCustomer selectedCustomer;
        AppOwner appOwner;

        public WhatsAppLinking()
        {
            appOwner = new AppOwner();
            selectedCustomer = new AppCustomer();
            getAppOwnerDetails();
            Connect();
        }
        public void Connect()
        {
            if (!string.IsNullOrEmpty(appOwner.Number) && !string.IsNullOrEmpty(appOwner.IMEI) && !string.IsNullOrEmpty(appOwner.Name))
            {
                whatsApp = new WhatsApp(appOwner.Number, appOwner.IMEI, appOwner.Name, true, false);
                //whatsApp.Connect();
            }
        }
        private void getAppOwnerDetails()
        {
            appOwner.Number = "61411027060";
            appOwner.IMEI = "352988099410649";
            appOwner.Name= "Sushil Nikhare";
        }
        public List<string> GetFreindsList()
        {
            List<string> frList = new List<string>();
            return frList;
        }
        public void selectCustmor(string Number)
        {
            selectedCustomer.Number = "61411027042";//Number;
        }
        public void sendToCustomer(string msg)
        {
            try
            {
                //Do something
            
                whatsApp.OnConnectSuccess += () =>
                {
                    //whatsApp.OnLoginSuccess += (phoneNumber, data) =>
                    //{
                        logger.Debug(whatsApp);
                        whatsApp.SendMessage(selectedCustomer.Number, msg);
                        whatsApp.SendClose();

                        //TODO: gravar log
                    //};

                    //whatsApp.OnLoginFailed += (data) =>
                   // {
                        //TODO: gravar log
                     //   logger.Debug(data);
                    //};
                    //logger.Debug(whatsApp);
                    //whatsApp.Login();
                };

                //whatsApp.OnConnectFailed += whatsApp_OnConnectFailed;

                whatsApp.Connect();
            }
            catch (Exception ex)
            {
                //Exceptions are typically logged at the ERROR level
                logger.Error(ex, "Something bad happened");
            }
        }
    }
}

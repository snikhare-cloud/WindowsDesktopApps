using System;
using System.Collections.Generic;
using WhatsAppApi;
using WhatsAppApi.Helper;
using NLog;
namespace PrintToSend
{
    class WhatsAppLinking
    {
        //NLog recommends using a static variable for the logger object
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        
        WhatsApp whatsApp;
        AppCustomer selectedCustomer;
        AppOwner appOwner;

        public WhatsAppLinking()
        {
            appOwner = new AppOwner();
            selectedCustomer = new AppCustomer();
            getAppOwnerDetails();
            //InitWhatsApp();
            logger.Debug("In WhatsAppLinking");
        }
        public void InitWhatsApp()
        {
            if (!string.IsNullOrEmpty(appOwner.Number) && !string.IsNullOrEmpty(appOwner.IMEI) && !string.IsNullOrEmpty(appOwner.Name))
            {
                whatsApp = new WhatsApp(appOwner.Number, appOwner.IMEI, appOwner.Name, true, true);
                
                whatsApp.Connect();
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
                whatsApp = new WhatsApp(appOwner.Number, appOwner.IMEI, appOwner.Name, true, true);

                whatsApp.OnConnectSuccess += () =>
                {
                    logger.Debug(whatsApp.ConnectionStatus.ToString());
                    try
                    {
                        whatsApp.OnLoginSuccess += (phoneNumber, data) =>
                        {
                            logger.Debug("Logged In", whatsApp);
                            whatsApp.SendMessage(selectedCustomer.Number, msg);
                            whatsApp.SendClose();
                            //TODO: gravar log
                        };
                        whatsApp.OnLoginFailed += (data) =>
                        {
                            //TODO: gravar log
                            logger.Debug("Login Failed", data.Length);
                            //};
                        };
                        logger.Debug("Message sent: {0} to {1}", msg, selectedCustomer.Number);
                        whatsApp.Login();
                    }
                    catch (Exception ex)
                    {
                        //Exceptions are typically logged at the ERROR level
                        logger.Error(ex, "Something bad happened");
                    }
                    //whatsApp.OnConnectFailed += whatsApp_OnConnectFailed;
                };
                whatsApp.OnConnectFailed += (ex) =>
                {
                    logger.Debug(ex.StackTrace);
                };
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

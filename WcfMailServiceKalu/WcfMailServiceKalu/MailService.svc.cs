using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMailServiceKalu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MailService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MailService.svc or MailService.svc.cs at the Solution Explorer and start debugging.
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class MailService : IMailService
    {
        private static Dictionary<string, IMailCallback> _callbacks;


        private static Dictionary<string, IMailCallback> Callbacks
        {
            get
            {
                if (_callbacks == null)
                    _callbacks = new Dictionary<string, IMailCallback>();
                return _callbacks;
            }
        }
        public void Register(string nickname)
        {
            if(!Callbacks.ContainsKey(nickname))
            {
                Callbacks[nickname] = OperationContext.Current.GetCallbackChannel<IMailCallback>();
            }

        }


        public void SendMail(Email mail)
        {
            
            foreach(string name in mail.For)
            {
                if(Callbacks.ContainsKey(name))
                {
                    Callbacks[name].Receive(mail);
                }
            }
            
        }

        
    }
}

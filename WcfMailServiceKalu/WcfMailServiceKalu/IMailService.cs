using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMailServiceKalu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMailService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IMailCallback), SessionMode = SessionMode.Required)]
    public interface IMailService
    {
        [OperationContract(IsOneWay = true)] /*<< !!!!!!*/
        void SendMail(Email mail);

        [OperationContract(IsOneWay = true)] /*<< !!!!!!*/
        void Register(string nickname);


    }

/*
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Email> RecvEmails { get; set; }


    }
*/

    [DataContract]
    public class Email
    {
        [DataMember]
        public string Topic { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public string From { get; set; }

        [DataMember]
        public List<string> For { get; set; }

        public Email()
        {
            For = new List<string>();
        }


    }

    
}

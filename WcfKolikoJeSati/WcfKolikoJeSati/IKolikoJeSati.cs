using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfKolikoJeSati
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IKolikoJeSati
    {

        [OperationContract]
        DateTime VratiVreme();

        [OperationContract]
        PristupLog KadJeBioZadnjiPristup();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PristupLog
    {
        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        public string HostName { get; set; }
    }
}

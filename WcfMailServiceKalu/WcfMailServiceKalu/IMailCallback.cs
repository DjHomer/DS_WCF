using System.ServiceModel;

namespace WcfMailServiceKalu
{
    public interface IMailCallback
    {
        /*!!!!!!!!*/
        [OperationContract(IsOneWay = true)]
        void Receive(Email e);
    }
}
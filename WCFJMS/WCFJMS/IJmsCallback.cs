using System.ServiceModel;

namespace WCFJMS
{
    public interface IJmsCallback
    {
        [OperationContract(IsOneWay = true)]
        void sendTopic(string message, string username);
    }
}
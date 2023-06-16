using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFJMS
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IJmsCallback))]
    public interface IJmsService
    {
       

        [OperationContract(IsOneWay = true)]
        void CreateTopic(string topicName);

        [OperationContract(IsOneWay = true)]
        void Register(string username);

        [OperationContract(IsOneWay = true)]
        void ConnectToTopic(string topicName);

        [OperationContract(IsOneWay = true)]
        void SendMessageTopic(string topicName, string msg);
    }
}

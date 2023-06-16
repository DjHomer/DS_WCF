using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFJMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JmsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JmsService.svc or JmsService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class JmsService : IJmsService
    {
        private static Dictionary<string, IJmsCallback> _users;
        private static Dictionary<string, List<string>> _topics;
        //pravio bih dict i za queue, ali kod slanja samo jednom stize, i to nek bude random ili po round-robin principu, ne znam kako queue funkcionise u jms-u :(


        private String Username { get; set; }

        JmsService()
        {
            Username = null;
        }

        private static Dictionary<string, IJmsCallback> Users
        {
            get
            {
                if (_users == null)
                    _users = new Dictionary<string, IJmsCallback>();
                return _users;
            }
        }

        private static Dictionary<string, List<string>> Topics
        {
            get
            {
                if (_topics == null)
                    _topics = new Dictionary<string, List<string>>();
                return _topics;
            }
        }
        public void Register(string username)
        {
            if (!Users.ContainsKey(username))
            {
                Users[username] = OperationContext.Current.GetCallbackChannel<IJmsCallback>();
                Username = username;

            }

        }
        public void CreateTopic(string topicName)
        {
            if (!Topics.ContainsKey(topicName))
                Topics[topicName] = new List<string>();
        }

        public void ConnectToTopic(string topicName)
        {
            if(!Topics[topicName].Contains(Username))
                Topics[topicName].Add(Username);
          
        }

    

        public void SendMessageTopic(string topicName, string msg)
        {
           if(Topics.ContainsKey(topicName) && Topics[topicName].Contains(Username))         
                foreach(string user in Topics[topicName])
                    if(user != Username)
                        Users[user].sendTopic(msg, Username);
            
        }

      
    }
}

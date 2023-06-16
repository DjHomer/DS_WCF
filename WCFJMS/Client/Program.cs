using Client.JmsServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program : IJmsServiceCallback//!!!!!!!!!!!
    {
        protected JmsServiceClient proxy;

        
        public Program()
        {
            proxy = new JmsServiceClient(new System.ServiceModel.InstanceContext(this)); //!!!!!!!!!!!
        }
        public void Register(string usern)
        {
            proxy.Register(usern);
        }
        public void crTopic(string v)
        {
            proxy.CreateTopic(v);
        }

        public void sendTopic(string message, string username) //MessageListener je ovde callback sa parametrima...
        {
            Console.Out.WriteLine("***************");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Primljena Poruka!!!!");
            Console.Out.WriteLine("poruka: " + message + "od korisnika " + username);
            Console.Out.WriteLine("");
            Console.Out.WriteLine("***************");

        }

        public void connTopic(string topName)
        {
            proxy.ConnectToTopic(topName);
        }

        public void sndMsgTop(string topicName, string msg)
        {
            proxy.SendMessageTopic(topicName, msg);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.Out.WriteLine("Unesite username:");
            String tmp = Console.ReadLine();
            p.Register(tmp);

            p.crTopic("topic1"); //hard coded, na serveru provera ako topic sa ovim imenom
            p.crTopic("topic2"); //postoji da ne napravi duplikat, moglo je i drugacije al jbg

            Console.Out.WriteLine("Unesite na koliko topica hocete da se connectujete!");
            int numTop = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < numTop; i++)
            {
                Console.Out.WriteLine("Unesite ime topica: ");
                tmp = Console.ReadLine();
                p.connTopic(tmp);

            }

            Console.Out.WriteLine("Unesite ime topica kom saljete i poruku respektivno: "); //na serveru proverava da li je ovaj user povezan na topic
            String topTmp = Console.ReadLine();                                         //znam da ovo nije bas priroda JMS-a ali bar pokazuje osnovu
            String msgTmp = Console.ReadLine();                                         //kako treba odraditi slanje poruka na serveru..
            p.sndMsgTop(topTmp, msgTmp);


            Console.WriteLine("Press Enter for exit...");
            Console.ReadLine();



        }


    }
}

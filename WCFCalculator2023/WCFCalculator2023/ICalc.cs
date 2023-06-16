using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator2023
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalc" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(ICalcCallback), SessionMode = SessionMode.Required)]
    public interface ICalc
    {


        [OperationContract(IsOneWay = true)]
        void Dodaj(decimal a);

        [OperationContract]
        Rezultat DodajBezKolbeka(decimal a);

        [OperationContract(IsOneWay = true)]
        void Oduzmi(decimal a);

        [OperationContract(IsOneWay = true)]
        void Pomnozi(decimal a);

        [OperationContract(IsOneWay = true)]
        void Podeli(decimal a);

        [OperationContract(IsOneWay = true)]
        void Register();


        
    }

    [DataContract]
    public class Rezultat
    {

        [DataMember]
        public decimal Res { get; set; } = 0.0M;
        [DataMember]
        public string Izraz { get; set; } = "";

    }
}

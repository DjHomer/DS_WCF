using System.ServiceModel;


namespace WCFCalculator2023
{
    public interface ICalcCallback
    {
        [OperationContract(IsOneWay = true)]
        void Rezultat(Rezultat r);
    }
}
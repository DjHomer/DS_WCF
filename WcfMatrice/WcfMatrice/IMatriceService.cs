using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMatrice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMatriceService" in both code and config file together.
    [ServiceContract]
    public interface IMatriceService
    {

        [OperationContract]
        void SetMatrix(Matrica m);

        [OperationContract]
        Matrica getMatrix();

        [OperationContract]
        Matrica additionMatrix(Matrica m);

        [OperationContract]
        Matrica mutiplyScalar(int s);

        [OperationContract]
        Matrica mutiplyMatrix(Matrica m);

        [OperationContract]
        Matrica transposeMatrix();
    }

    [DataContract]
    public class Matrica
    {
      
        [DataMember]
        public int BrojVrsta { get; set; }

        [DataMember]
        public int BrojKolona { get; set; }

        [DataMember]
        public bool Err { get; set; }

        [DataMember]
        public List<List<int>> Mat { get; set; }

        public Matrica()
        {
            Mat = new List<List<int>>();
        }

    }
    
}



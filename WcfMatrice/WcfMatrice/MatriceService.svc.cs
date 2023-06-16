using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMatrice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MatriceService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MatriceService.svc or MatriceService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MatriceService : IMatriceService
    {
        static Matrica mat;



        public Matrica getMatrix()
        {
            return mat;
        }
        public void SetMatrix(Matrica m)
        {
            mat = m;
        }
        public Matrica additionMatrix(Matrica m)
        {
            if (m.BrojVrsta != mat.BrojVrsta || m.BrojKolona != mat.BrojKolona)
                return new Matrica()
                {
                    BrojKolona = 0,
                    BrojVrsta = 0,
                    Err = true

                };

            for (int i = 0; i < m.Mat.Count(); i++)
                for (int j = 0; j < m.Mat[0].Count(); j++)
                    mat.Mat[i][j] += m.Mat[i][j];

            return mat;
        }

        public Matrica mutiplyScalar(int s)
        {
            throw new NotImplementedException();
        }

        public Matrica mutiplyMatrix(Matrica m)
        {
            throw new NotImplementedException();
        }

        public Matrica transposeMatrix()
        {
            throw new NotImplementedException();

        }





    }
}

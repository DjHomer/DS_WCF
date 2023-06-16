using Client.MatriceServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MatriceServiceClient proxy = new MatriceServiceClient();
            Console.Out.WriteLine("Unesite dimenzije matrica respektivno vrstu i kol");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            List<List<int>> mat = new List<List<int>>();

            for(int i = 0; i < rows; i++)
            {
                List<int> tmpList = new List<int>();
                for(int j = 0; j < cols; j++)
                {
                    Console.Out.Write("Unesite el " + i + " vrste i " + j + " kolone: ");
                    tmpList.Add(int.Parse(Console.ReadLine()));
                }
                mat.Add(tmpList);
            }
            proxy.SetMatrix(new Matrica()
            {
                BrojVrsta = rows,
                BrojKolona = cols,
                Mat = mat

            });

            Matrica retMat = proxy.getMatrix();
            Console.Out.WriteLine("Broj vrsta je " + retMat.BrojVrsta + " a broj kolona je " + retMat.BrojKolona);

            foreach(List<int> rowsTmp in retMat.Mat)
            {

                foreach(int el in rowsTmp)
                {
                    Console.Out.Write(el + " ");
                }
                Console.Out.WriteLine("");
            }

            retMat = proxy.additionMatrix(new Matrica() { 
                BrojVrsta = 3,
                BrojKolona = 3,
                Mat = new List<List<int>> {
                    new List<int> {1, 2, 3},
                    new List<int> {4, 5, 6},
                    new List<int> {7, 8, 9}
                       }
             });

            foreach (List<int> rowsTmp in retMat.Mat)
            {

                foreach (int el in rowsTmp)
                {
                    Console.Out.Write(el + " ");
                }
                Console.Out.WriteLine("");
            }


            Console.Read();

        }
    }
}

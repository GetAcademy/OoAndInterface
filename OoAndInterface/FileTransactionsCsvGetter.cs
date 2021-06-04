using System.IO;

namespace OoAndInterface
{
    class FileTransactionsCsvGetter : ITransactionsCsvGetter
    {
        public string[] Get()
        {
            return File.ReadAllLines("transactions.txt");

            //return new string[]
            //{
            //    "2021-01-01,deposit,10000",
            //    "2021-01-02,buy,ABC,34,200",
            //    "2021-01-03,sell,ABC,17,240",
            //    "2021-01-04,buy,DEF,10,500",
            //    "2021-01-05,withdraw,100"
            //};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serv
{
    class MainClass
    {
        static void Main(string[] args)
        {
            LandMgr landMgr = new LandMgr();
            DataMgr dataMgr = new DataMgr();
            ServNet servNet = new ServNet();
            servNet.proto = new ProtocolBytes();
            servNet.Start("192.168.1.107", 1234);

            while (true)
            {
                string str = Console.ReadLine();
                switch (str)
                {
                    case "quit":
                        servNet.Close();
                        return;
                    case "print":
                        servNet.Print();
                        break;
                }
            }
        }

    }
}

//Extra references added which are commenly used for interacting with CE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Tooling.Connector;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Configuration;

namespace ConsoletoConnecttoDynamics365CRMv9.x
{
    class Program
    {
        private static CrmServiceClient _crmServiceClient;
        static void Main(string[] args)
        {
            //Change the connection string name in next line to use Office365/ClientSecret connection string as per your requirement
            using (_crmServiceClient = new CrmServiceClient(ConfigurationManager.ConnectionStrings["D365ConnectionStringClientSecret"].ConnectionString))
            {
                if (_crmServiceClient.IsReady)
                {
                    Console.WriteLine("Authenticated To D365.");
                    //Write your code here


                }
                else
                {
                    Console.WriteLine("Authentication Failed.");
                    throw _crmServiceClient.LastCrmException;
                }
            }
        }
    }
}

using System;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
namespace LusidCsharpTools
{
    class Program
    {

        public static string[] MyArgs = Environment.GetCommandLineArgs();

        public static string Secrets = MyArgs.GetValue(3).ToString();
        static ILusidApiFactory _apiFactory = LusidApiFactoryBuilder.Build(Secrets);
        static public string GetMyPortfolios(string Scope, string PortCode)
        {
            var GetPortfolioRequest = _apiFactory.Api<PortfoliosApi>().GetPortfolio(Scope, PortCode);
            return GetPortfolioRequest.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nThe portfolio you requested is: " + args[0] + "\n");
            Console.WriteLine("The scope you requested is: " + args[1] + "\n");
            Console.WriteLine("Fetching portfolio details....\n");
            string MyPortfolio = GetMyPortfolios(args[0], args[1]);
            Console.WriteLine(MyPortfolio);
        }
    }
}


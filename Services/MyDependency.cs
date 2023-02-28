
using fundamentals_dotnet.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace fundamentals_dotnet.Services
{
    #region snippet1
   public class MyDependecy : IMyDependecy {

        public void WriteMessage(string message){
            Console.WriteLine($"MyDependency.WriteMessage Message:{ message }");
        }
   } 
   #endregion

   #region snippet2

    public class MyDependency2 : IMyDependecy  {

        private readonly ILogger<MyDependency2> _logger;
        public MyDependency2(ILogger<MyDependency2> logger){
            _logger = logger;
        }

        public void WriteMessage(string message){
            _logger.LogInformation($"MyDependency2.WriteMessage Message: { message }");
        }
    }

   #endregion

}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using fundamentals_dotnet.Interfaces;


namespace fundamentals_dotnet.Pages;

    public class DependecyModel:PageModel{
        private readonly ILogger _logger;

        public string Message {get; set;} = string.Empty;
        
        public DependecyModel( ILogger<DependecyModel> logger){
            _logger = logger;
        }

        public void OnGet(){
            Message = $"Dependency page visited at { DateTime.UtcNow.ToLongDateString() }";

            _logger.LogInformation(Message);
        }


    }

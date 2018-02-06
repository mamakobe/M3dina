using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using M3dina.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using M3dina.Services;
namespace M3dina.ViewComponents
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PatientListViewComponent:ViewComponent
    {
        

        public async Task<IViewComponentResult> InvokeAsync()
        {
            PatientsSvc _patients =  new PatientsSvc();
           var results = await _patients.PatientListAsync();
            return View(results); 

        }
        
    }
}

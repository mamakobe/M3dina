using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using M3dina.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M3dina.ViewComponents
{
    public class SystemActivityViewComponent : ViewComponent
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost:3000/api/system/historian";

        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public SystemActivityViewComponent()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

               // var sysActivity = JsonConvert.DeserializeObject<List<Transaction>>(responseData);
                List<Transaction> sysActivity = JsonConvert.DeserializeObject<List<Transaction>>(responseData);



                return View(sysActivity.Take(6));
            }
            return View("Error");
        }


    }
}

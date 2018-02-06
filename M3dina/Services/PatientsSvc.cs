using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using M3dina.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using M3dina.Helpers;
namespace M3dina.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PatientsSvc
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost:3000/api/Patient";
        public PatientsSvc()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Patient>> PatientListAsync()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                List<Patient> patients = JsonConvert.DeserializeObject<List<Patient>>(responseData);
                HelperClasses.TotalNumberofPatients = patients.Count();
                return patients;
            }
            return null;
        }

    }
}

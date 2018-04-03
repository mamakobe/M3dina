using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using M3dina.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M3dina.Controllers
{
    [BreadCrumb(Title = "Patient", UseDefaultRouteUrl = true, Order = 0)]
    public class PatientController : Controller
    {
        HttpClient client;
        //The URL of the WEB API Service


        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public PatientController()
        {
            
        }


        // GET: PatientInfo
        [BreadCrumb(Title = "View Patients", Order = 1)]
        public async Task<ActionResult> Index()
        {
           
            string url = "http://localhost:3000/api/Patient";
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(url);
             if (responseMessage.IsSuccessStatusCode)
             {
                 var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                 var Patients = JsonConvert.DeserializeObject<List<PatientDetails>>(responseData);

                 return View(Patients);
             }
             return View("Error");

        }



        public async Task<ActionResult> PatientProfile(string ID)
        {
            string url = "http://localhost:3000/api/Patient/"+ ID;
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Patient = JsonConvert.DeserializeObject<PatientDetails>(responseData);
                ViewData["Patient"] = Patient;

                return View(Patient);
            }
            return View("Error");

        }



        public ActionResult Create()
        {
            return View(new Patient());
        }

        //The Post method
    /*    [HttpPost]
        public async Task<ActionResult> Create(Patient patient)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url, patient);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Employee = JsonConvert.DeserializeObject<Patient>(responseData);

                return View(Employee);
            }
            return View("Error");
        }




        //The PUT Method
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Patient Emp)
        {

            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + "/" + id, Emp);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Employee = JsonConvert.DeserializeObject<Patient>(responseData);

                return View(Employee);
            }
            return View("Error");
        }

        //The DELETE method
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Patient Emp)
        {

            HttpResponseMessage responseMessage = await client.DeleteAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
        */

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using M3dina.Helpers;
namespace M3dina.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Transaction
    {
    public string hyperledgerclass { get; set; }
    public string transactionId { get; set; }
    public string transactionType { get; set; }
    public string transactionInvoked { get; set; }
    public string identityUsed { get; set; }
    public List<object> eventsEmitted { get; set; }
    public DateTime transactionTimestamp { get; set; }
   
    
        public string transactionDescription
        {
            get { return RemoveNamespace(); }
        }

        public string RemoveNamespace()
        {
           
            String description = transactionType;
            description = description.Replace("org.hyperledger.composer.system.", "");
            description = HelperClasses.SplitCamelCase(description);
            return description;
        }

       

    
    }

   




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebÖvn_101116.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace WebÖvn_101116.Controllers
{
    public class HomeController : Controller
    {
        //Preppa för att koppla oss mot Azure och vår table
        private CloudStorageAccount storageAccount;
        private CloudTableClient tableClient;
        private CloudTable table;

        public HomeController()
        {
            storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol = https; AccountName = t41617; AccountKey = 7p7rsLTT + wLdMnS / 1yHZDCVETOIoXpAQjyrkKutLbK7KVNq8f1HtRMl4vyQpiZv8jQyq5aa4o17PfXiC2OUU0Q ==");
            tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("dbwashbears");
            table.CreateIfNotExist();

            //Vi testar att skapa ett nytt objekt till tabellen
            Customer c = new Customer()
            {
                Id = new Guid(),
                FirstName = "Kalle",
                LastName = "Anka"
            };

            TableOperation insertOperation = TableOperation.Insert(c);
            table.Execute(insertOperation);

        }



        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
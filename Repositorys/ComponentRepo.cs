using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;
using Newtonsoft.Json;

namespace ComponentProcessingMS.Repositorys
{
    public class ComponentRepo : IComponentRepo
    {

        public ProcessResponse GetProcessRequestRepo(ProcessRequest req)
        {
            RequestDatabase requestDatabase = new RequestDatabase();
            Random randomNumber = new Random();

            ProcessResponse resultResponse = new ProcessResponse();
            resultResponse.RequestId = randomNumber.Next();

            var a = requestDatabase.Master.Single(a => a.ComponenType == req.ComponentType);
            if(a.ComponenType == req.ComponentType && req.IsPriorityRequest == true)
            {
                resultResponse.DateOfDelivery = a.PriorDelverivery;
                resultResponse.ProcessingCharge = a.ProcessingCh + a.PriorReqCharge;
            }
            else if(a.ComponenType == req.ComponentType && req.IsPriorityRequest == false)
            {
                resultResponse.DateOfDelivery = a.NormalDelivery;

                resultResponse.ProcessingCharge = a.ProcessingCh;
            }
            else if(a.ComponenType == req.ComponentType && req.IsPriorityRequest == true)
            {
                resultResponse.DateOfDelivery = a.PriorDelverivery;
                resultResponse.ProcessingCharge = a.ProcessingCh + a.PriorReqCharge;
            }
            else
            {
                resultResponse.DateOfDelivery = a.NormalDelivery;
                resultResponse.ProcessingCharge = a.ProcessingCh;

            }
            resultResponse.CreditLimits = req.CreditLimit;


            using (HttpClient client = new HttpClient())
            {
                var jsonData = JsonConvert.SerializeObject(req);
                var requestData = new StringContent(jsonData, Encoding.UTF8, "application/json");
                client.BaseAddress = new Uri("https://localhost:44328/api/");
                var responseTask = client.PostAsync("PackageandDelivery", requestData);
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    string responseData = result.Content.ReadAsStringAsync().Result;
                    resultResponse.PackagingAndDeliveryCharge = double.Parse(responseData);
                }
            
            }
            resultResponse.TotalCharge = resultResponse.PackagingAndDeliveryCharge + resultResponse.ProcessingCharge;
            RequestDataHelper.responseObj = resultResponse;
            return resultResponse;


        }

        public string CompleteProcess()
        {
            return ("Sucess");
        }


    }
}

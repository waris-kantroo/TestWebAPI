using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using TestWebAPI.Models;


namespace TestWebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// IEnumerable will work just fine
        public IQueryable<string> Get()

        {
            var tuple = (10, "bird", new string[] { "waris","kantroo"}); // installed System.ValueTuple from nuget

            // Consume Web API here for GET call various approaches

        
            HttpClient consumeAPI = new HttpClient();

            // for Yodlee account get call

            var yodleeAPI = consumeAPI.GetYodleeHttpClient(@"https://developer.api.yodlee.com/ysl/");
            var YodleeRespnseJSON = yodleeAPI.Content.ReadAsStringAsync().Result;

            // for Yodlee account post call
            RootObject rootObject = new RootObject();
            rootObject.cobrand.cobrandLogin = "sbCobd33902b0ea6500e0d6d35e47a9266377da";
            rootObject.cobrand.cobrandPassword = "f5617bed-1a39-49ea-a555-f9b30931bc56";
            HttpContent httpContentYodlee = new StringContent(JsonConvert.SerializeObject(rootObject), Encoding.UTF8,
                    "application/json");
            var yodleeAPIPost = consumeAPI.PostYodleeHttpClient(@"https://developer.api.yodlee.com/cobrand/login", httpContentYodlee);
            var YodleeRespnsePostJSON = yodleeAPIPost.Content.ReadAsStringAsync().Result;


            var APIResult =  consumeAPI.GetHttpClient("api/AllEmployees").Result;   // via async
            List<string> employees = JsonConvert.DeserializeObject<List<string>>(APIResult.Content.ReadAsStringAsync().Result);

            var APIResult2 = consumeAPI.GetHttpClientWithoutAsync("api/AllEmployees");  // normal
            List<string> employees2 = JsonConvert.DeserializeObject<List<string>>(APIResult2.Content.ReadAsStringAsync().Result);

            var APIResult3 = consumeAPI.GetHttpClientWithoutAsync("api/Employees");  // normal
            var employees3 = JsonConvert.DeserializeObject<List<EmployeeJSON>>(APIResult3.Content.ReadAsStringAsync().Result);


           var testResultJSON =   APIResult3.Content.ReadAsStringAsync().Result; // will give us JSON representation ****** IMP
            var employees4 = JsonConvert.DeserializeObject<List<EmployeeJSON>>(testResultJSON);

            var APIResult4JSON = consumeAPI.GetHttpClientWithoutAsync2("api/Employees");  // normal
            var employees5 = JsonConvert.DeserializeObject<List<EmployeeJSON>>(APIResult4JSON);

            // till here
            // Consume Web API here for POST call various approaches

            // post call

            EmployeeJSON newEmployee = new EmployeeJSON();
            newEmployee.Id = 111;
            newEmployee.Name = "Waris Kantroo";
            newEmployee.Town = "Tral";

            var data = JsonConvert.SerializeObject(newEmployee);
            var postJSON2 = consumeAPI.PostHttpclient("api/add", data);
            var employeesPostResult2 = JsonConvert.DeserializeObject<EmployeeJSON>(postJSON2.Content.ReadAsStringAsync().Result);

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(newEmployee), Encoding.UTF8,
                    "application/json");
            var postJSON = consumeAPI.PostHttpclient2("api/add", httpContent);
            var employeesPostResult = JsonConvert.DeserializeObject<EmployeeJSON>(postJSON.Content.ReadAsStringAsync().Result);        
            // till here


            TupleUsage(tuple);
            var res = TupleWithoutParam();
            var res1 = res.Item1;
            var res2 = res.Item2;

            int result = NormalResult();
            var tupleResult = TupleWithParam(10,"10",20);
            var finaltupleResult1 = tupleResult.Item1;
            var finaltupleResult2 = tupleResult.Item2;
            var finaltupleResult3 = tupleResult.Item3;

            return new string[] { finaltupleResult1.ToString(), finaltupleResult2, finaltupleResult3.ToString() }.AsQueryable();
        }

        private int NormalResult()
        {
            return 10;
        }

        //public static string ContentToString(this HttpContent httpContent)
        //{
        //    var readAsStringAsync = httpContent.ReadAsStringAsync();
        //    return readAsStringAsync.Result;
        //}

        private Tuple<int, string, int> TupleWithParam(int input,string input2, int input3)
            {
            return new Tuple<int, string,int>(input+10, input2+"10", input3+10);
            }

        private Tuple<string, int> TupleWithoutParam()
        {
            return new Tuple<string, int>("Waris Kantroo", 1);
        }

        public void TupleUsage((int,string,string[]) tuple)
        {
            var newTuple = new Tuple<string, string>("1","2");

            var item1 = tuple.Item2;

        }

        [HttpGet]
        // GET api/values/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("FetchId/{id}")]
        public string FetchId(string id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="userId"></param>
        // POST api/values
        [Route("api/values/{userId}")]
        public void Post([FromBody] Employee employee, int userId)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public class EmployeeJSON
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Town { get; set; }
        }
    }

    public class Cobrand
    {
        public string cobrandLogin { get; set; }
        public string cobrandPassword { get; set; }
    }

    public class RootObject
    {
        public Cobrand cobrand { get; set; }
        public RootObject()
        {
            cobrand = new Cobrand();
        }
    }
}

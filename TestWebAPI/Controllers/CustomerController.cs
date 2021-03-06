﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace TestWebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        ILog log = log4net.LogManager.GetLogger(typeof(CustomerController));
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/customers")] 
        public List<Customer> Get()
        {

            // connect to DB here
            using (EmployeesEntities dbContext = new EmployeesEntities())
            {
                // fetch all employees
                var employees = dbContext.Employees.ToList();
                List<Customer> custList = new List<Customer>();
                bool employeeExist = false;
                foreach (var emp in  employees)
                {
                    employeeExist = true;
                    Customer cust = new Customer();
                    cust.Id = emp.EmployeeId;
                    cust.FullName = emp.EmployeeName;
                    cust.DOB =  DateTime.Parse(emp.EmployeeDOB.ToString());
                    cust.address = InitializeAddress();
                    custList.Add(cust);
                }
                // adding new employees

                Employee newCust = new Employee();
                newCust.EmployeeName = "Kantroo";
                newCust.EmployeeDesignation = "Creator";
                newCust.EmployeeDOB = DateTime.Parse("01/01/1976");
                dbContext.Employees.Add(newCust);
                if(!employeeExist)  // add employee if only it is not there
                dbContext.SaveChanges();

                return custList;

                // till here
                // bubble sort
                List<int> a = new List<int> { 3, 1, 5, 3, 8, 0, 4, 7 };
            int temp;
            // foreach(int i in a)
            for (int i = 1; i <= a.Count; i++)
                for (int j = 0; j < a.Count - i; j++)
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            List<int> sortedList = a.Distinct().ToList();
            // till here

            // Modify the list
            var fakeList = CustomerList();
            foreach(Customer i in fakeList)
            {
                i.Id = 100;
            }
            var newModifiedList1 = fakeList;
            var newModifiedList2 = fakeList.ToList();

            string firstName = "Test";
            StringBuilder sb = new StringBuilder();
            sb.Append("1234");
            var testing = sb.Append(firstName);

            log.Debug("Hello Debug from Web API");
            var repeatedValues = new StringBuilder("AAABBCCDDEEEFFF");
            log.Info("calling get method");
            foreach(char b in repeatedValues.ToString())
            {

                repeatedValues.Replace(b.ToString(), "").Append(b.ToString());
            }
            var unique = repeatedValues.ToString();



            return new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
                //gets all customer logic
            }
        }

        [HttpGet]
        [Route("api/customers/currentMonth")]
        public List<Customer> GetCustomerByCurrentMonth()
        {
            return new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
        }


        // id as part of URL not as querystring
        [HttpGet]
        [Route("api/customers1/{id}")]
        public Customer GetCustomerById(string id)
        {
            var cus = new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
            return cus.Where(i => i.Id == int.Parse(id)).FirstOrDefault();
        }

        // id as part of Querystring
        // http://localhost:63701/api/customers/?identity=1
        // http://localhost:63701/api/customers/?identity=2
        [HttpGet]
        [Route("api/customers1")]
        public Customer GetCustomerByCurrentId(string identity)
        {
            var cus = new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
            return cus.Where(i => i.Id == int.Parse(identity)).FirstOrDefault();
        }

        // id as part of body  
        [HttpPost]
        [Route("api/customers/CurrentIdBody")]
        public Customer GetCustomerByCurrentIdBody([FromBody]string idFromBody)
        {
            var cus = new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
            return cus.Where(i => i.Id == int.Parse(idFromBody)).FirstOrDefault();
        }

        // id as part of body  
        [HttpPost]
        [Route("api/customers/CurrentFullBody")]
        public Customer GetCustomerByCurrentIdFullBody(string idFromBody, [FromBody]Customer customer)
        {

            if (customer != null)
                return customer;
            else return new Customer();
        }

        [HttpGet]
        [Route("api/customers/customerByUsername/{username}")]
        public Customer GetCustomerByUsername(string username)
        {
            var cus = new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
            return cus.Where(i => i.FullName == username).FirstOrDefault();

        }

        private static Address1 InitializeAddress()
        {
            var address = new Address1
            {
                telephone = 1111111,
                city = "Banaglore",
                pincode = "192123Tral"
            };
            address.subAddress = new SubAddress();
            address.subAddress.city = "BTM City";
            address.subAddress.pincode = "560076BTM";
            address.subAddress.telephone = 9999999;
            return address;
        }
        private static Address1 InitializeSecondAddress()
        {
            var address = new Address1
            {
                telephone = 22222222,
                city = "Switzerland",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "Swiss City",
                pincode = "560076Swiss",
                telephone = 88888888
            };
            return address;
        }

        private static Address1 InitializeThirdAddress()
        {
            var address = new Address1
            {
                telephone = 444444444,
                city = "England",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "England City",
                pincode = "560076Swiss",
                telephone = 66666666
            };
            return address;
        }

        private static Address1 InitializeFourthAddress()
        {
            var address = new Address1
            {
                telephone = 3333333,
                city = "Serbia",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "Serbia City",
                pincode = "560076Swiss",
                telephone = 777777777
            };
            return address;
        }

        public IEnumerable<Customer> CustomerList()
        {
            var cus = new List<Customer>()
            {
               new Customer {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Customer {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Customer {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Customer {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };
            return cus;
        }
    }


   
}

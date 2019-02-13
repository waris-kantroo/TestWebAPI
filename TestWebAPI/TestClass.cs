using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI
{


    public class Data
    {
        public string swagger { get; set; }
        public Info info { get; set; }
        public string host { get; set; }
        public string[] schemes { get; set; }
        public Paths paths { get; set; }
        public Definitions definitions { get; set; }
    }

    public class Info
    {
        public string version { get; set; }
        public string title { get; set; }
    }

    public class Paths
    {
        public ApiValues apiValues { get; set; }
        public ApiValuesId apiValuesid { get; set; }
    }

    public class ApiValues
    {
        public Get get { get; set; }
        public Post post { get; set; }
    }

    public class Get
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public object[] consumes { get; set; }
        public string[] produces { get; set; }
        public Responses responses { get; set; }
    }

    public class Responses
    {
        public _200 _200 { get; set; }
    }

    public class _200
    {
        public string description { get; set; }
        public Schema schema { get; set; }
    }

    public class Schema
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
    }

    public class Post
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public string[] consumes { get; set; }
        public object[] produces { get; set; }
        public Parameter[] parameters { get; set; }
        public Responses1 responses { get; set; }
    }

    public class Responses1
    {
        public _204 _204 { get; set; }
    }

    public class _204
    {
        public string description { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public Schema1 schema { get; set; }
    }

    public class Schema1
    {
        public string type { get; set; }
    }

    public class ApiValuesId
    {
        public Get1 get { get; set; }
        public Put put { get; set; }
        public Delete delete { get; set; }
    }

    public class Get1
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public object[] consumes { get; set; }
        public string[] produces { get; set; }
        public Parameter1[] parameters { get; set; }
        public Responses2 responses { get; set; }
    }

    public class Responses2
    {
        public _2001 _200 { get; set; }
    }

    public class _2001
    {
        public string description { get; set; }
        public Schema2 schema { get; set; }
    }

    public class Schema2
    {
        public string type { get; set; }
    }

    public class Parameter1
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Put
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public string[] consumes { get; set; }
        public object[] produces { get; set; }
        public Parameter2[] parameters { get; set; }
        public Responses3 responses { get; set; }
    }

    public class Responses3
    {
        public _2041 _204 { get; set; }
    }

    public class _2041
    {
        public string description { get; set; }
    }

    public class Parameter2
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Schema3 schema { get; set; }
    }

    public class Schema3
    {
        public string type { get; set; }
    }

    public class Delete
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public object[] consumes { get; set; }
        public object[] produces { get; set; }
        public Parameter3[] parameters { get; set; }
        public Responses4 responses { get; set; }
    }

    public class Responses4
    {
        public _2042 _204 { get; set; }
    }

    public class _2042
    {
        public string description { get; set; }
    }

    public class Parameter3
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Definitions
    {
    }
}

    

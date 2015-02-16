using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        //public Dictionary<int,string> Sort(Dictionary<int,string> inputList)
        //{
        //    Dictionary<int, string> returnList = new Dictionary<int, string>();

        //    List<int> keys = inputList.Keys.ToList();
        //    keys.Sort();

        //    for (int i = 0; i < keys.Count; i++)
        //    {
        //        int key = keys[i];
        //        var value = inputList.SingleOrDefault(r=> r.Key == key);
        //        returnList.Add(value.Key, value.Value);
        //    }
        //    return returnList;
        //}

        //public Dictionary<int, string> Sort2(Dictionary<int, string> inputList)
        //{
        //    Dictionary<int, string> returnList = new Dictionary<int, string>();

        //    List<int> keys = inputList.Keys.ToList();
        //    //keys.Sort();

        //    for (int i = 0; i < keys.Count; i++)
        //    {
        //        var temp = keys[i];
        //        for (int j = i; j >= 0; j--)
        //        {
        //            if (temp > keys[i + 1])
        //            {
        //                keys[i] = keys[i + 1];
        //                keys[i + 1] = temp;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < keys.Count; i++)
        //    {
        //        int key = keys[i];
        //        var value = inputList.SingleOrDefault(r => r.Key == key);
        //        returnList.Add(value.Key, value.Value);
        //    }
        //    return returnList;
        //}

        //public Hashtable Sort3(Hashtable input)
        //{
        //    var orderedKeys = input.Keys.Cast<string>().OrderBy(c => c); // supposing you're using string keys
        //    var result = from x in orderedKeys select new { key = x, value = input[x] };

        //    return (Hashtable)result;
        //}

        //static void Main(string[] args)
        //{
        //    Program p = new Program();

        //    Dictionary<int, string> inputList = new Dictionary<int, string>();
        //    Hashtable input = new Hashtable();

        //    inputList.Add(10, "bob");
        //    input.Add(10, "bob");
        //    inputList.Add(8, "sally");
        //    input.Add(8, "sally");
        //    inputList.Add(2, "suzy");
        //    input.Add(2, "suzy");
        //    inputList.Add(3, "billy");
        //    input.Add(3, "billy");
        //    inputList.Add(5, "joey");
        //    input.Add(5, "joey"); ;

        //    Dictionary<int, string> sortedList = p.Sort(inputList);
        //    Dictionary<int, string> sortedList2 = p.Sort2(inputList);

        //    Hashtable sortedList3 = p.Sort3(input);
        //}
        //}

        public static void Main(string[] args)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            var result = client.GetAllProducers();
        }
    }
}

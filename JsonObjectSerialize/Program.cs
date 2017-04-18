using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonObjectSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.object_ = new List<object>();
            people.object_.Add(new Employee { firstName_ = "kim", lastName_ = "jg" });
            people.object_.Add(new Boss { employeeId_ = 1, name_ = "you" });
            people.object_.Add(new List<int>() { 1, 2 });
            people.object_.Add(new Dictionary<string, int>() { { "aa", 1 }, { "bb", 2 } });

            var jsonSerializeSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };

            var jsonStr = JsonConvert.SerializeObject(people, jsonSerializeSettings);

            People what = JsonConvert.DeserializeObject<People>(jsonStr, jsonSerializeSettings);
            var intlist = what.object_[2] as List<int>;
            var dic = what.object_[3] as Dictionary<string, int>;

            Console.WriteLine(intlist);
            Console.WriteLine(dic);

        }
    }
}

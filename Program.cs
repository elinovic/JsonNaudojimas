using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


class Program
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    static void Main()
    {
        string failas = File.ReadAllText("user.json");

        List<User> zmones = JsonConvert.DeserializeObject<List<User>>(failas); //reikia list kad kelis zmones nuskaityt

        foreach (var zmogus in zmones)
        {
            Console.WriteLine($"Name: {zmogus.Name}, Age: {zmogus.Age}, City: {zmogus.City}");
        }
    }
}
using Newtonsoft.Json.Linq;
using System;
namespace WeatherAPI
{
    class program
    {
        public static  void Main(string[] args)
        {
            var client = new HttpClient();

            Console.WriteLine("Please Enter API Key");
            var api_key = Console.ReadLine();

            while (true)
            {
       
                Console.WriteLine("Enter the city: ");
                var city = Console.ReadLine();

              var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={api_key}";


                var response = client.GetStringAsync(weatherURL).Result;
                var clearRespone = JObject.Parse(response).GetValue("main").ToString();

                Console.WriteLine(response);
                Console.WriteLine(clearRespone);



            }
        }
    }
}

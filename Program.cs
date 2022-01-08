using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using RestSharp;
using RestSharp.Portable;
using System.Threading.Tasks;

namespace ClientApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Register
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost:5000/api/user/Register"))
                {
                    request.Content = new StringContent("{\n    \"username\": \"Youname\",\n    \"password\": \"youpassword\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

                    var response = await httpClient.SendAsync(request);

                    Console.WriteLine(response);
                }
            }
            
            //login
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost:5000/api/user/login"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJNdWhhbW1hZEBnbWFpbC5jb20iLCJqdGkiOiI1ZDdiZDlmMS0wMzViLTQyYWMtYjkxZS04YjE4MjY2MjliM2QiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTYzNjYyNjQ4MSwiYXVkIjoiVXNlciJ9.PBHHIjubqpmp9CzkEBz8IWDd2xaWhdutdqCJZiDsrNk"); 

                    request.Content = new StringContent("{\n    \"username\": \"Youname\",\n    \"password\": \"youpasword\"\n   \n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

                    var response = await httpClient.SendAsync(request);
                    Console.WriteLine(response);
                }
            }
            
            //GetTodo
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://localhost:5001/api/todo/2"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IkFkbWluIiwibmJmIjoxNjQxNTY3ODE0LCJleHAiOjE2NDE1NzUwMTQsImlhdCI6MTY0MTU2NzgxNH0.rdfRwURqWb7aJDyf3_ea5jjTYceRiDaD5YAuTlwZLAc"); 

                    request.Content = new StringContent("{\n  \"Name\": \"Temp\"\n\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

                    var response = await httpClient.SendAsync(request);
                    Console.WriteLine(response);
                }
            }
            
            //DeleteTodo
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://localhost:5001/api/todo/5"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IkFkbWluIiwibmJmIjoxNjQxNTY3ODE0LCJleHAiOjE2NDE1NzUwMTQsImlhdCI6MTY0MTU2NzgxNH0.rdfRwURqWb7aJDyf3_ea5jjTYceRiDaD5YAuTlwZLAc"); 

                    request.Content = new StringContent("{\n    \"Name\": \"bear\"\n\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json"); 

                    var response = await httpClient.SendAsync(request);
                    Console.WriteLine(response);
                }
            }

        }
    }
}

using JXTApp.Data.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace JXTApp.Data.Services
{
    public class BaseService : IBaseService
    {
        public List<T> ListAll<T>(string url) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                string data = string.Empty;

                try
                {
                    // Attempt to download JSON data as a string
                    data = client.DownloadString(url);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                // If string with JSON data is not empty, deserialize it to class and return its instance 
                return
                    !string.IsNullOrEmpty(data) ? JsonConvert.DeserializeObject<List<T>>(data) : new List<T>();
            }
        }
    }
}
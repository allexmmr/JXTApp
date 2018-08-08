using JXTApp.Data.Models;
using System.Collections.Generic;

namespace JXTApp.Data.Services
{
    public class JobsService : BaseService
    {
        public static List<Jobs> ListAll()
        {
            const string url = "https://www.jxt.solutions/jobsfeed.aspx";

            List<Jobs> list = new BaseService().ListAll<Jobs>(url);

            return list;
        }
    }
}
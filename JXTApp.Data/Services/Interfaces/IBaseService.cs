using System.Collections.Generic;

namespace JXTApp.Data.Services.Interfaces
{
    public interface IBaseService
    {
        List<T> ListAll<T>(string url) where T : new();
    }
}
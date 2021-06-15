using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace TrinhNgocVan.Services
{
    class FileHandleService
    {
        public  async void WriteFile(string fileName)
        {
            String content = "{[{'name':'perterParker','role':'develpoer','birthYear':1990}]}";
            var storage = Windows.Storage.ApplicationData.Current.LocalFolder; // tim den noi luu tru file trong may tinh (temp)
            var demoFile = await storage.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(demoFile, content);
        }

        public  async Task<string> ReadFile(string fileName)
        {
            var storage = Windows.Storage.ApplicationData.Current.LocalFolder;
            var demoFile = await storage.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.OpenIfExists);
            return await FileIO.ReadTextAsync(demoFile);
        }
    }
}

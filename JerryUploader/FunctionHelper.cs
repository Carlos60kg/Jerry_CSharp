using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using PlayFab;
using PlayFab.AdminModels;
using PlayFab.Json;
namespace JerryUploader
{
    class FunctionHelper
    {
        //#region Helper Functions -- these functions help the main uploading functions
        // static void LogToFile(string content, ConsoleColor color = ConsoleColor.White)
        //{
        //    Console.ForegroundColor = color;
        //    Console.WriteLine(content);
        //    logStream.WriteLine(content);

        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        //static void OutputPlayFabError(string context, PlayFabError err)
        //{
        //    hitErrors = true;
        //    LogToFile("\tAn error occurred during: " + context, ConsoleColor.Red);

        //    var details = string.Empty;
        //    if (err.ErrorDetails != null)
        //    {
        //        foreach (var kvp in err.ErrorDetails)
        //        {
        //            details += (kvp.Key + ": ");
        //            foreach (var eachIssue in kvp.Value)
        //                details += (eachIssue + ", ");
        //            details += "\n";
        //        }
        //    }

        //    LogToFile(string.Format("\t\t[{0}] -- {1}: {2} ", err.Error, err.ErrorMessage, details), ConsoleColor.Red);
        //}

        //static string ParseFile(string path)
        //{
        //    var s = File.OpenText(path);
        //    var contents = s.ReadToEnd();
        //    s.Close();
        //    return contents;
        //}

        //static CatalogItem CloneCatalogItemAndStripTables(CatalogItem strip)
        //{
        //    if (strip == null)
        //        return null;

        //    return new CatalogItem
        //    {
        //        ItemId = strip.ItemId,
        //        ItemClass = strip.ItemClass,
        //        CatalogVersion = strip.CatalogVersion,
        //        DisplayName = strip.DisplayName,
        //        Description = strip.Description,
        //        VirtualCurrencyPrices = strip.VirtualCurrencyPrices,
        //        RealCurrencyPrices = strip.RealCurrencyPrices,
        //        Tags = strip.Tags,
        //        CustomData = strip.CustomData,
        //        Consumable = strip.Consumable,
        //        Container = null,//strip.Container, // Clearing this is the point
        //        Bundle = null,//strip.Bundle, // Clearing this is the point
        //        CanBecomeCharacter = strip.CanBecomeCharacter,
        //        IsStackable = strip.CanBecomeCharacter,
        //        IsTradable = strip.IsTradable,
        //        ItemImageUrl = strip.ItemImageUrl
        //    };
        //}

        //private static bool UpdateCatalog(List<CatalogItem> catalog)
        //{
        //    var request = new UpdateCatalogItemsRequest
        //    {
        //        CatalogVersion = defaultCatalog,
        //        Catalog = catalog
        //    };

        //    var updateCatalogItemsTask = PlayFabAdminAPI.UpdateCatalogItemsAsync(request);
        //    updateCatalogItemsTask.Wait();

        //    if (updateCatalogItemsTask.Result.Error != null)
        //    {
        //        OutputPlayFabError("\tCatalog Upload Error: ", updateCatalogItemsTask.Result.Error);
        //        return false;
        //    }

        //    LogToFile("\tUploaded Catalog!", ConsoleColor.Green);
        //    return true;
        //}

        //private static bool UploadAsset(string key, string path)
        //{
        //    var request = new GetContentUploadUrlRequest()
        //    {
        //        Key = key,
        //        ContentType = "application/x-gzip"
        //    };

        //    LogToFile("\tFetching CDN endpoint for " + key);
        //    var getContentUploadTask = PlayFabAdminAPI.GetContentUploadUrlAsync(request);
        //    getContentUploadTask.Wait();

        //    if (getContentUploadTask.Result.Error != null)
        //    {
        //        OutputPlayFabError("\t\tAcquire CDN URL Error: ", getContentUploadTask.Result.Error);
        //        return false;
        //    }

        //    var destUrl = getContentUploadTask.Result.Result.URL;
        //    LogToFile("\t\tAcquired CDN Address: " + key, ConsoleColor.Green);

        //    byte[] fileContents = File.ReadAllBytes(path);

        //    return PutFile(key, destUrl, fileContents);
        //}

        //private static bool PutFile(string key, string url, byte[] payload)
        //{
        //    LogToFile("\t\tStarting HTTP PUT for: " + key);

        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "PUT";
        //    request.ContentType = "application/x-gzip";

        //    if (payload != null)
        //    {
        //        var dataStream = request.GetRequestStream();
        //        dataStream.Write(payload, 0, payload.Length);
        //        dataStream.Close();
        //    }
        //    else
        //    {
        //        LogToFile("\t\t\tERROR: Byte array was empty or null", ConsoleColor.Red);
        //        return false;
        //    }

        //    var response = (HttpWebResponse)request.GetResponse();

        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        LogToFile("\t\t\tHTTP PUT Successful:" + key, ConsoleColor.Green);
        //        return true;
        //    }
        //    else
        //    {
        //        LogToFile(string.Format("\t\t\tERROR: Asset:{0} -- Code:[{1}] -- Msg:{2}", url, response.StatusCode, response.StatusDescription), ConsoleColor.Red);
        //        return false;
        //    }
        //}
        //#endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using PlayFab;
using PlayFab.AdminModels;
using PlayFab.Json;
namespace JerryUploader
{
    /// <summary>
    /// Interaction logic for FileShowWindow.xaml
    /// </summary>
    public partial class FileShowWindow : Window
    {
        #region ** Const Path
        private const string currencyPath = "./PlayFabData/Currency.json";
        private const string titleSettingsPath = "./PlayFabData/TitleSettings.json";
        private const string titleDataPath = "./PlayFabData/TitleData.json";
        private const string catalogPath = "./PlayFabData/Catalog.json";
        private const string dropTablesPath = "./PlayFabData/DropTables.json";
        private const string cloudScriptPath = "./PlayFabData/CloudScript.js";
        private const string titleNewsPath = "./PlayFabData/TitleNews.json";
        private const string statsDefPath = "./PlayFabData/StatisticsDefinitions.json";
        private const string storesPath = "./PlayFabData/Stores.json";
        private const string cdnAssetsPath = "./PlayFabData/CdnData.json";
        #endregion

        public FileShowWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void TextBoxAssetFolder_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBoxTitleSstting_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_ShowProgress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Browse(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_AssetFolder.Text = folderBrowserDialog.SelectedPath;
                ShowAllofTheFilesUnderPath(textBox_AssetFolder.Text);
            }
        }
        private void Button_Click_GO(object sender, RoutedEventArgs e)
        {
            if (textBox_AssetFolder.Text != null && new DirectoryInfo(textBox_AssetFolder.Text).Exists)
            {
                ShowAllofTheFilesUnderPath(textBox_AssetFolder.Text);
            }
            //there is a problem is that when the following code runs, the program will crash!
            //if (textBox_AssetFolder.Text == null || new DirectoryInfo(textBox_AssetFolder.Text).Exists == false)
            //{
            //    System.Windows.Forms.MessageBox.Show("Be care of ambiguity !");
            //}
        }

        #region ** Small Functions Encapsulated **
        /// <summary>
        /// Display all the files under the folder
        /// </summary>
        /// <param name="path">folder path</param>
        private void ShowAllofTheFilesUnderPath(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++)
            {
                if (fileInfos[i].Name == "Currency.json")
                {
                    textBoxCurrency.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "TitleData.json")
                {
                    textBoxTitleData.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "Catalog.json")
                {
                    textBoxCatalog.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "DropTables.json")
                {
                    textBoxDropTables.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "CloudScript.js")
                {
                    textBoxCloudScripts.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "TitleNews.json")
                {
                    textBoxTitleNews.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "StatisticsDefinitions.json")
                {
                    textBoxStatistics.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "Stores.json")
                {
                    textBoxStore.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
                if (fileInfos[i].Name == "CdnData.json")
                {
                    textBoxCDNAssets.Text = textBox_AssetFolder.Text + "\\" + fileInfos[i].Name;
                }
            }
        }
        private void ClearTheContentOfTextBox(System.Windows.Controls.TextBox textBoxName)
        {
            textBoxName.Text = null;
        }
        private void SingleFileSelect(System.Windows.Controls.TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }
        #endregion

        #region  ** All Clear Buttons **
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    ClearTheContentOfTextBox(textBoxTitleSstting);
        //}
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxCurrency);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxCatalog);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxTitleData);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxDropTables);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxCloudScripts);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxTitleNews);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxStatistics);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxStore);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxCDNAssets);
        }

        #endregion

        #region ** All Select Button **
        //private void Button_Click_12(object sender, RoutedEventArgs e)
        //{
        //    SingleFileSelect(textBoxTitleSstting);
        //}

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxCurrency);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxCatalog);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxTitleData);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxDropTables);
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxCloudScripts);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxTitleNews);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxStatistics);
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxStore);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxCDNAssets);
        }
        #endregion

        // shared variables
        private static string defaultCatalog = null; // Determined by TitleSettings.json
        private static bool hitErrors;

        private static FileInfo logFile;
        private static StreamWriter logStream;

        //CDN
        public enum CdnPlatform { Desktop, iOS, Android }
        public static readonly Dictionary<CdnPlatform, string> cdnPlatformSubfolder = new Dictionary<CdnPlatform, string> {
            { CdnPlatform.Desktop, "" },
            { CdnPlatform.iOS, "iOS/" },
            { CdnPlatform.Android, "Android/" },
        };
        public static string cdnPath = "./PlayFabData/AssetBundles/";

        /// <summary>
        /// i dont know if it is feasible to add the async modifier to this method ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Button_Click_Upload(object sender, RoutedEventArgs e)
        {
            await UploadFilesAsync();
        }
        private async Task UploadFilesAsync()
        {
            try
            {
                // setup the log file
                logFile = new FileInfo("PreviousUploadLog.txt");
                logStream = logFile.CreateText();

                // get the destination title settings
                if (!GetTitleSettings())
                    throw new Exception("\tFailed to load Title Settings");
                //await UploadTitleData();
                //await UploadEconomyData();
                //await UploadCloudScript();
                //await UploadTitleNews();
                //await UploadStatisticDefinitions();
                //await UploadCdnAssets();
                // start uploading
                if (!await UploadTitleData())
                    throw new Exception("\tFailed to upload TitleData.");
                if (!await UploadEconomyData())
                    throw new Exception("\tFailed to upload Economy Data.");
                if (!await UploadCloudScript())
                    throw new Exception("\tFailed to upload CloudScript.");
                if (!await UploadTitleNews())
                    throw new Exception("\tFailed to upload TitleNews.");
                if (!await UploadStatisticDefinitions())
                    throw new Exception("\tFailed to upload Statistics Definitions.");
                if (!await UploadCdnAssets())
                    throw new Exception("\tFailed to upload CDN Assets.");
            }
            catch (Exception ex)
            {
                hitErrors = true;
                LogToFile("\tAn unexpected error occurred: " + ex.Message);
            }
            finally
            {
                var status = hitErrors ? "ended with errors. See PreviousUploadLog.txt for details" : "ended successfully!";

                LogToFile("UB_Uploader.exe " + status);
                logStream.Close();
                Console.WriteLine("Press return to exit.");
                Console.ReadLine();
            }
        }

        private bool GetTitleSettings()
        {
            var parsedFile = ParseFile(titleSettingsPath);
            var titleSettings = JsonWrapper.DeserializeObject<Dictionary<string, string>>(parsedFile);

            if (titleSettings != null &&
                titleSettings.TryGetValue("TitleId", out PlayFabSettings.TitleId) && !string.IsNullOrEmpty(PlayFabSettings.TitleId) &&
                titleSettings.TryGetValue("DeveloperSecretKey", out PlayFabSettings.DeveloperSecretKey) && !string.IsNullOrEmpty(PlayFabSettings.DeveloperSecretKey) &&
                titleSettings.TryGetValue("CatalogName", out defaultCatalog))
            {
                LogToFile("Setting Destination TitleId to: " + PlayFabSettings.TitleId);
                LogToFile("Setting DeveloperSecretKey to: " + PlayFabSettings.DeveloperSecretKey);
                LogToFile("Setting defaultCatalog name to: " + defaultCatalog);
                return true;
            }

            LogToFile("An error occurred when trying to parse TitleSettings.json");
            return false;
        }

        #region Uploading Functions -- these are straightforward calls that push the data to the backend
        private async Task<bool> UploadEconomyData()
        {
            ////MUST upload these in this order so that the economy data is properly imported: VC -> Catalogs -> DropTables -> Stores
            if (!await UploadVc())
                return false;

            //var reUploadList = new List<CatalogItem>();
            ListCatalogItemData listCatalogItemData = new ListCatalogItemData();
            var reUploadList = listCatalogItemData.CataLogItems;
            if (!await UploadCatalog())
                return false;

            if (!await UploadDropTables())
                return false;

            if (!await UploadStores())
                return false;

            // workaround for the DropTable conflict
            if (reUploadList.Count > 0)
            {
                LogToFile("Re-uploading [" + reUploadList.Count + "] CatalogItems due to DropTable conflicts...");
                await UpdateCatalog(reUploadList);
            }
            return true;
        }

        private async Task<bool> UploadStatisticDefinitions()
        {
            if (string.IsNullOrEmpty(statsDefPath))
                return false;

            LogToFile("Updating Player Statistics Definitions ...");
            var parsedFile = ParseFile(statsDefPath);

            var statisticDefinitions = JsonWrapper.DeserializeObject<List<PlayerStatisticDefinition>>(parsedFile);

            foreach (var item in statisticDefinitions)
            {
                LogToFile("\tUploading: " + item.StatisticName);

                var request = new CreatePlayerStatisticDefinitionRequest()
                {
                    StatisticName = item.StatisticName,
                    VersionChangeInterval = item.VersionChangeInterval,
                    AggregationMethod = item.AggregationMethod
                };

                var createStatTask = await PlayFabAdminAPI.CreatePlayerStatisticDefinitionAsync(request);


                if (createStatTask.Error != null)
                {
                    if (createStatTask.Error.Error == PlayFabErrorCode.StatisticNameConflict)
                    {
                        LogToFile("\tStatistic Already Exists, Updating values: " + item.StatisticName);
                        var updateRequest = new UpdatePlayerStatisticDefinitionRequest()
                        {
                            StatisticName = item.StatisticName,
                            VersionChangeInterval = item.VersionChangeInterval,
                            AggregationMethod = item.AggregationMethod
                        };

                        var updateStatTask = await PlayFabAdminAPI.UpdatePlayerStatisticDefinitionAsync(updateRequest);

                        if (updateStatTask.Error != null)
                            OutputPlayFabError("\t\tStatistics Definition Error: " + item.StatisticName, updateStatTask.Error);
                        else
                            LogToFile("\t\tStatistics Definition:" + item.StatisticName + " Updated");
                    }
                    else
                    {
                        OutputPlayFabError("\t\tStatistics Definition Error: " + item.StatisticName, createStatTask.Error);
                    }
                }
                else
                {
                    LogToFile("\t\tStatistics Definition: " + item.StatisticName + " Created");
                }
            }
            return true;
        }

        private async Task<bool> UploadTitleNews()
        {
            if (string.IsNullOrEmpty(titleNewsPath))
                return false;

            LogToFile("Uploading TitleNews...");
            var parsedFile = ParseFile(titleNewsPath);

            var titleNewsItems = JsonWrapper.DeserializeObject<List<PlayFab.ServerModels.TitleNewsItem>>(parsedFile);

            foreach (var item in titleNewsItems)
            {
                LogToFile("\tUploading: " + item.Title);

                var request = new AddNewsRequest()
                {
                    Title = item.Title,
                    Body = item.Body
                };

                var addNewsTask = await PlayFabAdminAPI.AddNewsAsync(request);

                if (addNewsTask.Error != null)
                    OutputPlayFabError("\t\tTitleNews Upload: " + item.Title, addNewsTask.Error);
                else
                    LogToFile("\t\t" + item.Title + " Uploaded.");
            }

            return true;
        }

        private async Task<bool> UploadCloudScript()
        {
            if (string.IsNullOrEmpty(cloudScriptPath))
                return false;

            LogToFile("Uploading CloudScript...");
            var parsedFile = ParseFile(cloudScriptPath);

            if (parsedFile == null)
            {
                LogToFile("\tAn error occurred deserializing the CloudScript.js file.");
                return false;
            }
            var files = new List<CloudScriptFile> {
                new CloudScriptFile
                {
                    Filename = "CloudScript.js",
                    FileContents = parsedFile
                }
            };

            var request = new UpdateCloudScriptRequest()
            {
                Publish = true,
                Files = files
            };

            var updateCloudScriptTask = await PlayFabAdminAPI.UpdateCloudScriptAsync(request);

            if (updateCloudScriptTask.Error != null)
            {
                OutputPlayFabError("\tCloudScript Upload Error: ", updateCloudScriptTask.Error);
                return false;
            }

            LogToFile("\tUploaded CloudScript!");
            return true;
        }

        private async Task<bool> UploadTitleData()
        {
            if (string.IsNullOrEmpty(titleDataPath))
                return false;

            LogToFile("Uploading Title Data Keys & Values...");
            var parsedFile = ParseFile(titleDataPath);
            var titleDataDict = JsonWrapper.DeserializeObject<Dictionary<string, string>>(parsedFile);

            foreach (var kvp in titleDataDict)
            {
                LogToFile("\tUploading: " + kvp.Key);

                var request = new SetTitleDataRequest()
                {
                    Key = kvp.Key,
                    Value = kvp.Value
                };

                var setTitleDataTask = await PlayFabAdminAPI.SetTitleDataAsync(request);


                if (setTitleDataTask.Error != null)
                    OutputPlayFabError("\t\tTitleData Upload: " + kvp.Key, setTitleDataTask.Error);
                else
                    LogToFile("\t\t" + kvp.Key + " Uploaded.");
            }

            return true;
        }

        private async Task<bool> UploadVc()
        {
            LogToFile("Uploading Virtual Currency Settings...");
            var parsedFile = ParseFile(currencyPath);
            var vcData = JsonWrapper.DeserializeObject<List<VirtualCurrencyData>>(parsedFile);
            var request = new AddVirtualCurrencyTypesRequest
            {
                VirtualCurrencies = vcData
            };

            var updateVcTask = await PlayFabAdminAPI.AddVirtualCurrencyTypesAsync(request);

            if (updateVcTask.Error != null)
            {
                OutputPlayFabError("\tVC Upload Error: ", updateVcTask.Error);
                return false;
            }

            LogToFile("\tUploaded VC!");
            return true;
        }

        private async Task<bool> UploadCatalog()
        {
            List<CatalogItem> reUploadList = new ListCatalogItemData().CataLogItems;
            if (string.IsNullOrEmpty(catalogPath))
                return false;

            LogToFile("Uploading CatalogItems...");
            var parsedFile = ParseFile(catalogPath);

            var catalogWrapper = JsonWrapper.DeserializeObject<CatalogWrapper>(parsedFile);
            if (catalogWrapper == null)
            {
                LogToFile("\tAn error occurred deserializing the Catalog.json file.");
                return false;
            }
            for (var z = 0; z < catalogWrapper.Catalog.Count; z++)
            {
                if (catalogWrapper.Catalog[z].Bundle != null || catalogWrapper.Catalog[z].Container != null)
                {
                    var original = catalogWrapper.Catalog[z];
                    var strippedClone =  CloneCatalogItemAndStripTables(original);

                    //reUploadList.Add(original);
                    await AddCatalogAsync(reUploadList, original);
                    catalogWrapper.Catalog.Remove(original);
                    catalogWrapper.Catalog.Add(strippedClone);
                }
            }
            return UpdateCatalog(catalogWrapper.Catalog).Result;
        }
        private async Task AddCatalogAsync(List<CatalogItem> catalogItems, CatalogItem catalogItem)
        {
            catalogItems.Add(catalogItem);
        }

        private async Task<bool> UploadDropTables()
        {
            if (string.IsNullOrEmpty(dropTablesPath))
                return false;

            LogToFile("Uploading DropTables...");
            var parsedFile = ParseFile(dropTablesPath);

            var dtDict = JsonWrapper.DeserializeObject<Dictionary<string, RandomResultTableListing>>(parsedFile);
            if (dtDict == null)
            {
                LogToFile("\tAn error occurred deserializing the DropTables.json file.");
                return false;
            }

            var dropTables = new List<RandomResultTable>();
            foreach (var kvp in dtDict)
            {
                dropTables.Add(new RandomResultTable()
                {
                    TableId = kvp.Value.TableId,
                    Nodes = kvp.Value.Nodes
                });
            }

            var request = new UpdateRandomResultTablesRequest()
            {
                CatalogVersion = defaultCatalog,
                Tables = dropTables
            };

            var updateResultTableTask = await PlayFabAdminAPI.UpdateRandomResultTablesAsync(request);

            if (updateResultTableTask.Error != null)
            {
                OutputPlayFabError("\tDropTable Upload Error: ", updateResultTableTask.Error);
                return false;
            }

            LogToFile("\tUploaded DropTables!");
            return true;
        }

        private async Task<bool> UploadStores()
        {
            if (string.IsNullOrEmpty(storesPath))
                return false;

            LogToFile("Uploading Stores...");
            var parsedFile = ParseFile(storesPath);

            var storesList = JsonWrapper.DeserializeObject<List<StoreWrapper>>(parsedFile);

            foreach (var eachStore in storesList)
            {
                LogToFile("\tUploading: " + eachStore.StoreId);

                var request = new UpdateStoreItemsRequest
                {
                    CatalogVersion = defaultCatalog,
                    StoreId = eachStore.StoreId,
                    Store = eachStore.Store,
                    MarketingData = eachStore.MarketingData
                };

                var updateStoresTask = await PlayFabAdminAPI.SetStoreItemsAsync(request);

                if (updateStoresTask.Error != null)
                    OutputPlayFabError("\t\tStore Upload: " + eachStore.StoreId, updateStoresTask.Error);
                else
                    LogToFile("\t\tStore: " + eachStore.StoreId + " Uploaded. ");
            }
            return true;
        }

        private async Task<bool> UploadCdnAssets()
        {
            if (string.IsNullOrEmpty(cdnAssetsPath))
                return false;

            LogToFile("Uploading CDN AssetBundles...");
            var parsedFile = ParseFile(cdnAssetsPath);
            var bundleNames = JsonWrapper.DeserializeObject<List<string>>(parsedFile); // TODO: This could probably just read the list of files from the directory

            if (bundleNames != null)
            {
                foreach (var bundleName in bundleNames)
                {
                    foreach (CdnPlatform eachPlatform in Enum.GetValues(typeof(CdnPlatform)))
                    {
                        var key = cdnPlatformSubfolder[eachPlatform] + bundleName;
                        var path = cdnPath + key;
                        await UploadAssetAsync(key, path);
                    }
                }
            }
            else
            {
                LogToFile("\tAn error occurred deserializing CDN Assets: ");
                return false;
            }
            return true;
        }
        #endregion

        #region Helper Functions -- these functions help the main uploading functions
        void LogToFile(string content)
        {
            //Console.WriteLine(content);
            //Dispatcher.BeginInvoke(new Action(() => textBox_ShowProgress.Text = content));
            textBox_ShowProgress.Text += content + "\n";

            logStream.WriteLine(content);
        }

        void OutputPlayFabError(string context, PlayFabError err)
        {
            hitErrors = true;
            LogToFile("\tAn error occurred during: " + context);

            var details = string.Empty;
            if (err.ErrorDetails != null)
            {
                foreach (var kvp in err.ErrorDetails)
                {
                    details += (kvp.Key + ": ");
                    foreach (var eachIssue in kvp.Value)
                        details += (eachIssue + ", ");
                    details += "\n";
                }
            }

            LogToFile(string.Format("\t\t[{0}] -- {1}: {2} ", err.Error, err.ErrorMessage, details));
        }

        string ParseFile(string path)
        {
            var s = File.OpenText(path);
            var contents = s.ReadToEnd();
            s.Close();
            return contents;
        }

        CatalogItem CloneCatalogItemAndStripTables(CatalogItem strip)
        {
            if (strip == null)
                return null;

            return new CatalogItem
            {
                ItemId = strip.ItemId,
                ItemClass = strip.ItemClass,
                CatalogVersion = strip.CatalogVersion,
                DisplayName = strip.DisplayName,
                Description = strip.Description,
                VirtualCurrencyPrices = strip.VirtualCurrencyPrices,
                RealCurrencyPrices = strip.RealCurrencyPrices,
                Tags = strip.Tags,
                CustomData = strip.CustomData,
                Consumable = strip.Consumable,
                Container = null,//strip.Container, // Clearing this is the point
                Bundle = null,//strip.Bundle, // Clearing this is the point
                CanBecomeCharacter = strip.CanBecomeCharacter,
                IsStackable = strip.CanBecomeCharacter,
                IsTradable = strip.IsTradable,
                ItemImageUrl = strip.ItemImageUrl
            };
        }

        private async Task<bool> UpdateCatalog(List<CatalogItem> catalog)
        {
            var request = new UpdateCatalogItemsRequest
            {
                CatalogVersion = defaultCatalog,
                Catalog = catalog
            };

            var updateCatalogItemsTask = await PlayFabAdminAPI.UpdateCatalogItemsAsync(request);

            if (updateCatalogItemsTask.Error != null)
            {
                OutputPlayFabError("\tCatalog Upload Error: ", updateCatalogItemsTask.Error);
                return false;
            }

            LogToFile("\tUploaded Catalog!");
            return true;
        }

        private async Task<bool> UploadAssetAsync(string key, string path)
        {
            var request = new GetContentUploadUrlRequest()
            {
                Key = key,
                ContentType = "application/x-gzip"
            };

            LogToFile("\tFetching CDN endpoint for " + key);
            var getContentUploadTask = await PlayFabAdminAPI.GetContentUploadUrlAsync(request);

            if (getContentUploadTask.Error != null)
            {
                OutputPlayFabError("\t\tAcquire CDN URL Error: ", getContentUploadTask.Error);
                return false;
            }

            var destUrl = getContentUploadTask.Result.URL;
            LogToFile("\t\tAcquired CDN Address: " + key);

            byte[] fileContents = File.ReadAllBytes(path);

            return PutFile(key, destUrl, fileContents);
        }

        private bool PutFile(string key, string url, byte[] payload)
        {
            LogToFile("\t\tStarting HTTP PUT for: " + key);

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "PUT";
            request.ContentType = "application/x-gzip";

            if (payload != null)
            {
                var dataStream = request.GetRequestStream();
                dataStream.Write(payload, 0, payload.Length);
                dataStream.Close();
            }
            else
            {
                LogToFile("\t\t\tERROR: Byte array was empty or null");
                return false;
            }

            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                LogToFile("\t\t\tHTTP PUT Successful:" + key);
                return true;
            }
            else
            {
                LogToFile(string.Format("\t\t\tERROR: Asset:{0} -- Code:[{1}] -- Msg:{2}", url, response.StatusCode, response.StatusDescription));
                return false;
            }
        }
        #endregion

        private void Abort_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

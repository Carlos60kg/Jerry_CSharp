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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_AssetFolder.Text = folderBrowserDialog.SelectedPath;
                ShowAllofTheFilesUnderPath(textBox_AssetFolder.Text);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void TextBoxTitleSstting_TextChanged(object sender, TextChangedEventArgs e)
        {

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
                    textBoxCurrency.Text = currencyPath;
                }
                if (fileInfos[i].Name == "TitleData.json")
                {
                    textBoxTitleData.Text = titleDataPath;
                }
                if (fileInfos[i].Name == "Catalog.json")
                {
                    textBoxCatalog.Text = catalogPath;
                }
                if (fileInfos[i].Name == "DropTables.json")
                {
                    textBoxDropTables.Text = dropTablesPath;
                }
                if (fileInfos[i].Name == "CloudScript.js")
                {
                    textBoxCloudScripts.Text = cloudScriptPath;
                }
                if (fileInfos[i].Name == "TitleNews.json")
                {
                    textBoxTitleNews.Text = titleNewsPath;
                }
                if (fileInfos[i].Name == "StatisticsDefinitions.json")
                {
                    textBoxStatistics.Text = statsDefPath;
                }
                if (fileInfos[i].Name == "Stores.json")
                {
                    textBoxStore.Text = storesPath;
                }
                if (fileInfos[i].Name == "CdnData.json")
                {
                    textBoxCDNAssets.Text = cdnAssetsPath;
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClearTheContentOfTextBox(textBoxTitleSstting);
        }
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
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            SingleFileSelect(textBoxTitleSstting);
        }

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
    }
}

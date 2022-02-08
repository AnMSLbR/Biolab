using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biolab
{
    public partial class ImageManager : UserControl
    {
        private string _currentPath = String.Empty;
        private string _selectedItemName = String.Empty;

        public ImageManager()
        {
            InitializeComponent();
        }

        #region Properties
        private string _initialPath = "";

        [Category("Custom Props")]
        public string DirectoryPath
        {
            get {return _initialPath; }
            set {_initialPath = value; }
        }
        #endregion

        private void ImageManager_Load(object sender, EventArgs e)
        {
            _initialPath = "Photo";
            _currentPath = _initialPath;
            GetItemsFromDirectory();
        }

        private void ExecuteSelectedItem()
        {
            if (DetermineTypeOfItem(_currentPath) == FileAttributes.Directory)
            {
                GetItemsFromDirectory();
            }
            else
            {
                OpenFile();
            }
        }

        private void GetItemsFromDirectory()
        {
            try
            {
                listV_ImagesArea.Items.Clear();
                DirectoryInfo itemList = new DirectoryInfo(_currentPath);
                var directories = itemList.GetDirectories();
                FillListViewWithDirectories(directories);
                var images = itemList.GetFiles("*.jpg");
                FillListViewWithImages(images);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateControls();
        }

        private void OpenFile()
        {
            try
            {
                Process.Start(_currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReturnToPreviousPath();
            UpdateControls();
        }

        private void FillListViewWithImages(FileInfo[] images)
        {
            for (int i = 0; i < images.Length; i++)
            {
                listV_ImagesArea.Items.Add(images[i].Name, 1);
            }
        }

        private void FillListViewWithDirectories(DirectoryInfo[] dirs)
        {
            for (int i = 0; i < dirs.Length; i++)
            {
                listV_ImagesArea.Items.Add(dirs[i].Name, 0);
            }
        }

        private void listV_ImagesArea_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                _selectedItemName = e.Item.Text;
            }
            else
            {
                _selectedItemName = String.Empty;
                listV_ImagesArea.SelectedItems.Clear();
            }
            UpdateControls();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            GoToNextPath();
            ExecuteSelectedItem();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ReturnToPreviousPath();
            ExecuteSelectedItem();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            GetItemsFromDirectory();
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateControls();
        }

        private void GoToNextPath()
        {
            _currentPath += @"\" + _selectedItemName;
            _selectedItemName = String.Empty;
        }

        private void ReturnToPreviousPath()
        {
            _currentPath = _currentPath.Substring(0, _currentPath.LastIndexOf(@"\"));
            _selectedItemName = String.Empty;
        }

        private FileAttributes DetermineTypeOfItem(string path)
        {
            FileAttributes fileAttributes = new FileAttributes();
            try
            {
                fileAttributes = File.GetAttributes(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                return FileAttributes.Directory;
            else
                return FileAttributes.Normal;
        }

        private bool IsInitialPath(string path)
        {
            if (path == _initialPath)
                return true;
            else
                return false;
        }

        private void UpdateControls()
        {
            SetBackgroundImage();
            if(IsInitialPath(_currentPath))
            {
                btn_Back.Enabled = false;
                if (String.IsNullOrEmpty(_selectedItemName))
                    btn_Show.Enabled = false;
                else
                    btn_Show.Enabled = true;
            }
            else
            {
                btn_Back.Enabled = true;
                if (String.IsNullOrEmpty(_selectedItemName))
                    btn_Show.Enabled = false;
                else
                    btn_Show.Enabled = true;
            }
            tb_Path.Text = Path.GetFullPath(_currentPath);
        }

        private void SetBackgroundImage()
        {
            if (!Directory.Exists(_currentPath) || Directory.GetDirectories(_currentPath).Length + Directory.GetFiles(_currentPath, "*.jpg").Length == 0)
            {
                listV_ImagesArea.BackgroundImage = global::Biolab.Properties.Resources.ImageManager_ImagesNotFound;
                listV_ImagesArea.Items.Clear();
            }
            else if(Directory.Exists(_currentPath) && Directory.GetDirectories(_currentPath).Length + Directory.GetFiles(_currentPath, "*.jpg").Length < listV_ImagesArea.Items.Count)
            {
                GetItemsFromDirectory();
                _selectedItemName = String.Empty;
            }
            else
                listV_ImagesArea.BackgroundImage = null;
        }

        private void ImageManager_Leave(object sender, EventArgs e)
        {
            listV_ImagesArea.SelectedItems.Clear(); 
        }

        private void listV_ImagesArea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GoToNextPath();
            ExecuteSelectedItem();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biolab
{
    public partial class ImageManager : UserControl
    {

        private string _selectedItemName = "";
        public ImageManager()
        {
            InitializeComponent();
        }

        #region Properties
        private string _dirPath = "";

        [Category("Custom Props")]
        public string DirectoryPath
        {
            get {return _dirPath; }
            set {_dirPath = value; }
        }
        #endregion

        private void ImageManager_Load(object sender, EventArgs e)
        {

        }

        private void LoadContent()
        {
            DirectoryInfo contentList;
            try
            {
                contentList = new DirectoryInfo(_dirPath);
                var directories = contentList.GetDirectories();
                FillListViewWithDirectories(directories);
                var images = contentList.GetFiles();
                FillListViewWithImages(images);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillListViewWithImages(FileInfo[] images)
        {
            for (int i = 0; i < images.Length; i++)
            {
                listV_ImagesArea.Items.Add(images[i].Name);
            }
        }

        private void FillListViewWithDirectories(DirectoryInfo[] dirs)
        {
            for (int i = 0; i < dirs.Length; i++)
            {
                listV_ImagesArea.Items.Add(dirs[i].Name);
            }
        }

        private void listV_ImagesArea_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _selectedItemName = e.Item.Text;
        }
    }
}

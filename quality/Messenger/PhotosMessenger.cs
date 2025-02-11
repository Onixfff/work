using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality.Messenger
{
    public partial class PhotosMessenger : Form
    {
        private int _photo = 0;
        private int _selectedPhoto = 0;
        private Bitmap _myImage;

        public List<Image> _images = new List<Image>();

        public PhotosMessenger(List<Image> image)
        {
            _images = image;
            _photo = _images.Count;
            InitializeComponent();
            labelCoins.Text = $"{_selectedPhoto} - {_photo}";
            if(_photo != 0)
                ChoosesWhichLabelToChange(PhotoChange.PlusSelectedPhoto);
        }
        /// <summary>
        /// Запускает openFileDialog где по фильтру выбирает image и передаёт значение в массив. После изменяет label и картинку для показа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _images.Add(Image.FromFile(openFileDialog1.FileName));

                ChoosesWhichLabelToChange(PhotoChange.PlusPhoto);
                ChoosesWhichLabelToChange(PhotoChange.PlusSelectedPhoto);
            }
        }
        /// <summary>
        /// Изменяет выбранное фото человеком на -1;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            ChoosesWhichLabelToChange(PhotoChange.MinusSelectedPhoto);
        }
        /// <summary>
        /// Изменяет выбранное фото человеком на +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            ChoosesWhichLabelToChange(PhotoChange.PlusSelectedPhoto);
        }
        /// <summary>
        /// При загрузке формы выставляет максмальное разрешение формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotosMessenger_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Отвечает за выборку изменения в label и вызывает функцию обновления картинки и изменения label в зависимости от выбора человека.
        /// </summary>
        /// <param name="coinsChange"></param>
        private void ChoosesWhichLabelToChange(Enum coinsChange)
        {
            bool labelChanged;
            switch (coinsChange)
            {
                case PhotoChange.PlusPhoto:
                    ++_photo;
                    break;
                case PhotoChange.MinusPhoto:
                    if(_photo > 1)
                    {
                        --_photo;
                    }
                    else if(_photo == 1)
                    {
                        --_photo;
                        --_selectedPhoto;
                        pictureBoxMessenger.Image = null;
                    }
                    break;
                case PhotoChange.PlusSelectedPhoto:
                    labelChanged = ChangeLabelSelected(PhotoChange.PlusSelectedPhoto);
                    ChangesTheRenderingPhoto(labelChanged);
                    break;
                case PhotoChange.MinusSelectedPhoto:
                    labelChanged = ChangeLabelSelected(PhotoChange.MinusSelectedPhoto);
                    ChangesTheRenderingPhoto(labelChanged);
                    break;
                default:
                    MessageBox.Show("ChangeLabel Error");
                    break;
            }
            labelCoins.Text = $"{_selectedPhoto} - {_photo}";
        }
        /// <summary>
        /// Изменяет в зависимости от выбора пользователем selectedPhoto.
        /// </summary>
        /// <param name="changeSelectedPhoto"></param>
        /// <returns></returns>
        private bool ChangeLabelSelected(Enum changeSelectedPhoto)
        {
            switch (changeSelectedPhoto)
            {
                case PhotoChange.PlusSelectedPhoto:
                    if (_photo > _selectedPhoto)
                        ++_selectedPhoto;
                    return true;
                case PhotoChange.MinusSelectedPhoto:
                    if (_selectedPhoto > 1)
                        --_selectedPhoto;
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Изменяет картинку в зависимости от _selectedPhoto
        /// </summary>
        /// <param name="ChangeLabel">Если true то _selectedPhoto поменялось и следует обновить картинку от значения _selectedPhoto</param>
        private void ChangesTheRenderingPhoto(bool ChangeLabel)
        {
            if(ChangeLabel == true)
            {
                int element = _selectedPhoto - 1;
                for (int i = 0; i < _images.Count; i++)
                {
                    if (i == element)
                    {
                        if (_myImage != null)
                            _myImage.Dispose();
                        _myImage = new Bitmap(_images[i]);
                        pictureBoxMessenger.Image = (Image)_myImage;
                    }
                }
            }
        }
        /// <summary>
        /// Проверяет есть ли картинки в массиве и удаляет картинку выбранную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delitePhoto_Click(object sender, EventArgs e)
        {
            if(_images.Count > 0)
            {
                int element = _selectedPhoto - 1;
                _images.RemoveAt(element);
                ChoosesWhichLabelToChange(PhotoChange.MinusPhoto);
                ChoosesWhichLabelToChange(PhotoChange.MinusSelectedPhoto);
            }
        }
        /// <summary>
        /// Закрывает форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    enum PhotoChange
    {
        PlusPhoto,
        MinusPhoto,
        PlusSelectedPhoto,
        MinusSelectedPhoto
    };
}

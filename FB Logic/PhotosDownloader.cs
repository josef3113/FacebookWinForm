using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class PhotosDownloader
    {
        private Func<Photo, string> m_StrategyNameToPhotos;

        public PhotosDownloader()
        {
            m_StrategyNameToPhotos =
                        (photo) => photo.CreatedTime.Value.ToString("dd MM yyyy hhmmss") + ".jpg";
        }

        public void SetStrategyNamesPhotos(Func<Photo, string> i_StrategyName)
        {
            if (i_StrategyName != null)
            {
                m_StrategyNameToPhotos = i_StrategyName;
            }
            else
            {
                throw new Exception("Strategy Names Can't be null");
            }
        }

        public void DownloadPhotos(IEnumerable<Photo> i_CollectionPhotoToDownload, string i_FolderName)
        {
            string nameToPhoto, path;

            if (!Directory.Exists(i_FolderName))
            {
                Directory.CreateDirectory(i_FolderName);
                foreach (Photo photo in i_CollectionPhotoToDownload)
                {
                    nameToPhoto = m_StrategyNameToPhotos.Invoke(photo);
                    path = Path.Combine(i_FolderName, nameToPhoto);

                    photo.ImageNormal.Save(path);
                }
            }
            else
            {
                throw new Exception(string.Format(
                    @"Directory {0} Alredy Exsist ", i_FolderName));
            }
        }
    }
}
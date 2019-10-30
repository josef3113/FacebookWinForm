using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class PhotoManager
    {
        private readonly UserManager r_UserLogedIn;
        private readonly List<Photo> r_ListAllPhotoOfUsre = new List<Photo>();
        private readonly List<Photo> r_ListPhotoSelected = new List<Photo>();
        private PhotosDownloader m_Downloader = null;
        private bool m_PhotosLoaded = false;
        private int m_IndexOfListToShow = 0;

        private int indexOfListToShow
        {
            get { return m_IndexOfListToShow; }
            set
            {
                if (value < 0)
                {
                    m_IndexOfListToShow = r_ListPhotoSelected.Count - 1;
                }
                else if (value >= r_ListPhotoSelected.Count)
                {
                    m_IndexOfListToShow = 0;
                }
                else
                {
                    m_IndexOfListToShow = value;
                }
            }
        }

        public PhotoManager()
        {
            r_UserLogedIn = UserManager.Instance;
        }

        private PhotosDownloader downloaderPhotos
        {
            get
            {
                if (m_Downloader == null)
                {
                    m_Downloader = new PhotosDownloader();
                }

                return m_Downloader;
            }
        }

        public Photo CurrentPhoto
        {
            get
            {
                Photo photoToReturn = null;

                if (r_ListPhotoSelected.Count > 0)
                {
                    photoToReturn = r_ListPhotoSelected.ElementAt(indexOfListToShow);
                }

                return photoToReturn;
            }
        }

        public Photo NextPhoto
        {
            get
            {
                Photo photoToReturn = null;

                if (r_ListPhotoSelected.Count > 0)
                {
                    indexOfListToShow++;
                    photoToReturn = r_ListPhotoSelected.ElementAt(indexOfListToShow);
                }

                return photoToReturn;
            }
        }

        public Photo PrevPhoto
        {
            get
            {
                Photo photoToReturn = null;

                if (r_ListPhotoSelected.Count > 0)
                {
                    indexOfListToShow--;
                    photoToReturn = r_ListPhotoSelected.ElementAt(indexOfListToShow);
                }

                return photoToReturn;
            }
        }

        public void SetTimeSelected(DateTime i_StartTime, DateTime i_EndTime)
        {
            if (!m_PhotosLoaded)
            {
                fetchAllPhotosOfUser();
                m_PhotosLoaded = true;
            }

            r_ListPhotoSelected.Clear();
            indexOfListToShow = 0;

            foreach (Photo photo in r_ListAllPhotoOfUsre)
            {
                if (photo != null)
                {
                    DateTime timeCreatPhoto = photo.CreatedTime.Value;

                    if (timeCreatPhoto > i_StartTime && timeCreatPhoto < i_EndTime)
                    {
                        r_ListPhotoSelected.Add(photo);
                    }
                }
            }
        }

        private void fetchAllPhotosOfUser()
        {
            foreach (Album album in r_UserLogedIn.User.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    r_ListAllPhotoOfUsre.Add(photo);
                }
            }

            foreach (Photo photo in r_UserLogedIn.User.PhotosTaggedIn)
            {
                r_ListAllPhotoOfUsre.Add(photo);
            }
        }

        public void SortPhotosSelectedByDateCreat()
        {
            m_IndexOfListToShow = 0;
            r_ListPhotoSelected.Sort(FactoryPostedItemSortKind.GetSortedKind(eSortedBy.DateCdreate));
        }

        public void SortPhotosSelectedByNumOfLikes()
        {
            m_IndexOfListToShow = 0;
            r_ListPhotoSelected.Sort(FactoryPostedItemSortKind.GetSortedKind(eSortedBy.NumLikes));
        }

        public void DownloadPhotosSelected(string i_FolderName)
        {
            downloaderPhotos.DownloadPhotos(r_ListPhotoSelected, i_FolderName);
        }

        public void SetNamePhotosDownload(eNameToPhoto i_Choich)
        {
            switch (i_Choich)
            {
                case eNameToPhoto.ByDateCreat:
                    downloaderPhotos.SetStrategyNamesPhotos(
                        (photo) => photo.CreatedTime.Value.ToString("dd MM yyyy hhmmss") + ".jpg");
                    break;
                case eNameToPhoto.ByID:
                    downloaderPhotos.SetStrategyNamesPhotos((photo) => photo.Id + ".jpg");
                    break;
            }
        }
    }

    public enum eNameToPhoto
    {
        ByDateCreat,
        ByID,
    }
}
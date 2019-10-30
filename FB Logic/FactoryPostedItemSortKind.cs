using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    internal static class FactoryPostedItemSortKind
    {
        public static IComparer<PostedItem> GetSortedKind(eSortedBy i_ChoiceKind)
        {
            IComparer<PostedItem> sorterReturn = null;

            switch (i_ChoiceKind)
            {
                case eSortedBy.DateCdreate:
                    sorterReturn = new SortPostedItemByDateCreat();
                    break;
                case eSortedBy.NumLikes:
                    sorterReturn = new SortPostedItemByNumOfLikes();
                    break;
                default:
                    throw new Exception("No Exsist Sort Kind");
            }

            return sorterReturn;
        }
    }

    internal enum eSortedBy
    {
        DateCdreate,
        NumLikes
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    internal class SortPostedItemByDateCreat : IComparer<PostedItem>
    {
        public int Compare(PostedItem i_X, PostedItem i_Y)
        {
            return i_X.CreatedTime.Value.CompareTo(i_Y.CreatedTime.Value);
        }
    }

    internal class SortPostedItemByNumOfLikes : IComparer<PostedItem>
    {
        public int Compare(PostedItem i_X, PostedItem i_Y)
        {
            return i_X.LikedBy.Count.CompareTo(i_Y.LikedBy.Count);
        }
    }
}
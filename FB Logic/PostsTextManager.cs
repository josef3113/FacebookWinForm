using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class PostTextManager : IEnumerable<Post>
    {
        // break input user by white spaces into words 
        private readonly char[] r_WhiteSpace = new char[] { ' ', '\t' };

        private readonly UserManager r_UserLogedIn;
        private readonly List<Post> r_ListOfAllTextPostsOfUser;
        private PostTextAnalyst m_Analyst;
        private DataTable m_Table = null;
        private bool m_PostLoad = false;

        public Func<Post, bool> FilterToIterator { get; set; } = (post) => true;

        public PostTextManager()
        {
            r_UserLogedIn = UserManager.Instance;
            r_ListOfAllTextPostsOfUser = new List<Post>();
            initializeTable();
        }

        private void initializeTable()
        {
            m_Table = new DataTable();
            m_Table.Columns.Add("word", typeof(string));
            m_Table.Columns.Add("Total count", typeof(int));
        }

        public PostTextAnalyst Analyst
        {
            get
            {
                if (m_Analyst == null)
                {
                    m_Analyst = new PostTextAnalyst(listOfPostsOfUser);
                }

                return m_Analyst;
            }
        }

        public DataTable DataTablePosts
        {
            get
            {
                return m_Table;
            }
        }

        private List<Post> listOfPostsOfUser
        {
            get
            {
                if (!m_PostLoad)
                {
                    fetchPostOfUser();
                    m_PostLoad = true;
                }

                return r_ListOfAllTextPostsOfUser;
            }
        }

        private void fetchPostOfUser()
        {
            foreach (Post post in r_UserLogedIn.User.Posts)
            {
                if (post.Message != null)
                {
                    r_ListOfAllTextPostsOfUser.Add(post);
                }
            }
        }

        public void PostsContainWords(string i_InputUser)
        {
            m_Table.Clear();
            int count = 0;
            string[] wordsToSortBy = i_InputUser.Split(r_WhiteSpace);

            foreach (string word in wordsToSortBy)
            {
                foreach (Post post in listOfPostsOfUser)
                {
                    if (post.Message.Contains(word))
                    {
                        m_Table.Rows.Add(post.Message);
                        count++;
                    }
                }

                m_Table.Rows.Add(string.Format("The number of times {0}, appear's in posts", word), count);
                count = 0;
            }
        }

        public void SortPostsByCreatTime()
        {
            r_ListOfAllTextPostsOfUser.Sort(FactoryPostedItemSortKind.GetSortedKind(eSortedBy.DateCdreate));
        }

        public void SortPostsByNumOfLikes()
        {
            r_ListOfAllTextPostsOfUser.Sort(FactoryPostedItemSortKind.GetSortedKind(eSortedBy.NumLikes));
        }

        public IEnumerator<Post> GetEnumerator()
        {
            foreach (Post post in listOfPostsOfUser)
            {
                if (FilterToIterator.Invoke(post))
                {
                    yield return post;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class PostTextAnalyst
    {
        private readonly List<Post> r_ListToAnalyze;

        private readonly string[] r_SubjectsForStatictics = { "Science", "Politics", "Other" };
        private readonly string[] r_ScienceWordsToSortBy = { "math", "computer", "science", "programing", "לימודים", "Design pattern" };
        private readonly string[] r_PoliticWordsToSortBy = { "ביבי", "יאיר", "גנץ", "שקד", "בנט", "יהודים", "ערבים" };

        public string[] SubjectsForStatictics
        {
            get
            {
                return r_SubjectsForStatictics;
            }
        }

        public double SciencePercentage { get; private set; }

        public double PoliticsPercentage { get; private set; }

        public double OtherPercentage
        {
            get
            {
                return 100 - PoliticsPercentage - SciencePercentage;
            }
        }

        public PostTextAnalyst(IEnumerable<Post> i_AllPostToAnalyze)
        {
            r_ListToAnalyze = new List<Post>(i_AllPostToAnalyze);
            statisticsOperation();
        }

        private void statisticsOperation()
        {
            SciencePercentage = dataAnalyze(r_ScienceWordsToSortBy);
            PoliticsPercentage = dataAnalyze(r_PoliticWordsToSortBy);
        }

        private double dataAnalyze(string[] i_WordsToSortBy)
        {
            int countTotalType;
            double percentageOfType;

            countTotalType = numPostFromType(i_WordsToSortBy);
            percentageOfType = calculatePercentage(countTotalType);

            return percentageOfType;
        }

        private int numPostFromType(string[] i_WordsOfType)
        {
            int countTotal = 0;

            foreach (string word in i_WordsOfType)
            {
                foreach (Post post in r_ListToAnalyze)
                {
                    if (post.Message.Contains(word))
                    {
                        countTotal++;
                    }
                }
            }

            return countTotal;
        }

        private double calculatePercentage(int i_PostsOfTypeCount)
        {
            int countPosts = r_ListToAnalyze.Count;
            double percentage = ((double)i_PostsOfTypeCount / countPosts) * 100;

            return percentage;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class DiscussionsOrganizer
    {
        private static List<Discussion> NewDiscussionList;

        public DiscussionsOrganizer()
        {
            NewDiscussionList = new List<Discussion>();
            NewDiscussionList.Add(new Discussion("Nick", "01/01/2021 1.01PM", "Guys did you clean the kitchen after last night's party"));
            NewDiscussionList.Add(new Discussion("Leo", "01/01/2021 2.02PM", "Yep just got done with it"));
        }
        public void AddDiscussion(string name,string date,string debate)
        {
            NewDiscussionList.Add(new Discussion(name, date, debate));
        }
        public List<Discussion> GetAllDiscussions()
        {
            return NewDiscussionList.ToList();
        }

        public void RemoveDiscussion(int index)
        {
            NewDiscussionList.RemoveAt(index);
        }
    }
}

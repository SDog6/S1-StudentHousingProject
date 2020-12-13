using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class DiscussionsOrganizer
    {
        private List<Discussion> NewDiscussionList;

        public DiscussionsOrganizer()
        {
            NewDiscussionList = new List<Discussion>();
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

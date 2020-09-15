using System;

namespace classes_ex1.funcs
{
    public class StackOverflowPost
    {
        private string _title;
        public string _description {get; private set;}
        private DateTime _creation_date = DateTime.Now;

        public StackOverflowPost(string title, string description)
        {
            this._title = title;
            this._description = description;
        }
        internal int votes;
        public void upVote()
        {
            votes += 1;
        }

        public void downVote()
        {
            votes -= 1;
        }

        public int get_total_votes()
        {
            return votes;
        }

        public DateTime GetCreateDate()
        {
            return this._creation_date;
        }

        public string GetTitle()
        {
            return this._title;
        }
    }
}
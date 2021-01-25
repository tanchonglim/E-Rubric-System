using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class SubmissionCollection : ItemCollection
    {
        private ArrayList _submission = new ArrayList();

        public SubmissionCollection()
        {

        }
        public int Count
        {
            get { return _submission.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _submission[index]; }
            set { _submission.Add(value); }
        }
        public ItemIterator createIterator()
        {
            return new SubmissionIterator(this);
        }

    }
}
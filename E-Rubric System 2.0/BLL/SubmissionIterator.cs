using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class SubmissionIterator : ItemIterator
    {
        private SubmissionCollection _submissions;
        private int _current = 0;
        public SubmissionIterator(SubmissionCollection submissions)
        {
            this._submissions = submissions;
        }
        public bool hasNext()
        {
            return _current < _submissions.Count;
        }

        public Item getNext()
        {
            int index = _current;
            _current++;
            return _submissions[index] as Submission;
        }
        public void reset()
        {
            this._current = 0;
        }
    }

}
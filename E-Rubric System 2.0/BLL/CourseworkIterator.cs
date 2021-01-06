using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class CourseworkIterator: ItemIterator
    {
        CourseworkCollection _courseworks;
        int _current = 0;

        public CourseworkIterator(CourseworkCollection courseworks)
        {
            this._courseworks = courseworks;
        }
        public bool hasNext()
        {
            return _current < _courseworks.Count;
        }

        public Item getNext()
        {
            int index = _current;
            _current++;
            return _courseworks[index] as Coursework;
        }
        public void reset()
        {
            this._current = 0;
        }
    }
}
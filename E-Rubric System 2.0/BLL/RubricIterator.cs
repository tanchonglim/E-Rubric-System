using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class RubricIterator : ItemIterator
    {

        private RubricCollection _rubrics;
        private int _current = 0;

        public RubricIterator(RubricCollection rubrics)
        {
            this._rubrics = rubrics;
        }
        public bool hasNext()
        {
            return _current < _rubrics.Count;
        }

        public Item getNext()
        {
            
            int index = _current;
            _current++;
            return _rubrics[index] as Rubric;
        }
        public void reset()
        {
            this._current = 0;
        }

    }
}
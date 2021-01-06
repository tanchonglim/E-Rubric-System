using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class CourseworkCollection: ItemCollection
    {
        private List<Coursework> _courseworks;
       public CourseworkCollection()
        {
            _courseworks = new List<Coursework>();
        }

        public int Count
        {
            get { return _courseworks.Count; }
        }

        // Indexer
        public object this[int index]
        {
            
            get { return _courseworks[index]; }
            set { _courseworks.Add((Coursework)value); }
        }
        public ItemIterator createIterator()
        {
            return new CourseworkIterator(this);
        }
    }
}
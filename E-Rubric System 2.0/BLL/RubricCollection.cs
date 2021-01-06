using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class RubricCollection : ItemCollection
    {
        private ArrayList _rubrics = new ArrayList();

        public RubricCollection()
        {

        }
        public int Count
        {
            get { return _rubrics.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _rubrics[index]; }
            set { _rubrics.Add(value); }
        }
        public ItemIterator createIterator()
        {
            return new RubricIterator(this);
        }
    }
}
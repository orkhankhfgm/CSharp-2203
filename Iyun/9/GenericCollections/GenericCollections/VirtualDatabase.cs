﻿using System.Collections;

namespace GenericCollections
{
    public class VirtualDatabase
    {
        private ArrayList _db = new ArrayList();

        public void Add(int data)
        {
            _db.Add(data);
        }
    }
}

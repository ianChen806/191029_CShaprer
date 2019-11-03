﻿using System;
using System.Collections.Generic;

namespace InterfaceSample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // var repository1 = new IRepository();

            var repository = new MemoryRepository();
            repository.Insert(1, "Test");
            repository.Get(1);
            repository.Dispose();
        }
    }

    interface IRepository
    {
        void Insert(int id, string message);

        string Get(int id);
    }

    class MemoryRepository : IRepository, IDisposable
    {
        private Dictionary<int, string> _dictionary = new Dictionary<int, string>();

        public void Insert(int id, string message)
        {
            _dictionary.Add(id, message);
        }

        public string Get(int id)
        {
            return _dictionary[id];
        }

        public void Dispose()
        {
            _dictionary = new Dictionary<int, string>();
        }
    }
}
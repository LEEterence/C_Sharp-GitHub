﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise15
{
    class Song : IWritable
    {
        public string name { get; set; }
        public string songWriter { get; set; }
        // Methods
        public string GetNameOfWork()
        {
            //Console.Write("Enter name of novel: ");
            //name = Console.ReadLine();
            return name;
        }
        public string GetWriter()
        {
            //Console.Write("Enter name of author: ");
            //author = Console.ReadLine();
            return songWriter;
        }
    }
}

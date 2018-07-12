using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Voting : AModel
    {
        public List<Person> People
        {
            get;
            set;
        }

        public Voting()
        {
            People = new List<Person>();
            {
                new Person();
            }
            new Movie();

        }
    }
}

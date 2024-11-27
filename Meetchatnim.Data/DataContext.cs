using Meetchatnim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetchatnim.Data
{
    public class DataContext
    {
        public List<Matchmaker> matchmakers { get; set; }
        public List<candidate> candidates { get; set; }
        public List<Matchmaker> Matchmaker { get; internal set; }
        public List<candidate> Candidate { get; internal set; }

        public DataContext()
        {

            matchmakers = new List<Matchmaker>
            {
                new Matchmaker { Id = 1, Name = "Miri", PhoneNumber = "050" },
                new Matchmaker { Id = 2, Name = "Tzipi", PhoneNumber = "456" }

            };

            candidates = new List<candidate>
            {
                new candidate {Id=2, Name="Yoram", Age=22, High=180, PlaceOfStudy="Chevron"},
                new candidate {Id=3, Name="Michal", Age=19, High=165, PlaceOfStudy="Sheransky"} ,
                new candidate {Id=4, Name="Anonimy", Age=23, High=180, PlaceOfStudy="YeshiveKdoishe"},
                new candidate {Id=5, Name="Tami", Age=19, High=168, PlaceOfStudy="Sheransky"}
            };
        }
    }
}


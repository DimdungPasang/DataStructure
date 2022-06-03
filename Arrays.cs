using System;

namespace DataStructure
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            #region Accessing Elements in Arrays
            //DVD 1
            // The actual code for creating an Array to hold DVD's.
            DVD[] dvdCollections = new DVD[10];

            // Firstly, we need to actually create a DVD object for The Avengers.
            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");

            //Create a DVD object for The Doctor Strange in the Multiverse of  Madness.
            DVD doctorStrangeDVD = new DVD("The Doctor Strange Multiverse", 2022, "Sam Raimi");

            dvdCollections[0] = avengersDVD;
            dvdCollections[1] = doctorStrangeDVD;

            Console.WriteLine(avengersDVD.ToString());
            Console.WriteLine(doctorStrangeDVD.ToString());


            //DVD 2
            // The actual code for creating an Array to hold DVD 2's.
            DVD2[] dvd2Collections = new DVD2[10];

            // Firstly, we need to actually create a DVD object for The Drama.
            DVD2 dramaDVD = new DVD2
            {
                Name = "Lost in Translation",
                ReleaseYear = 2003,
                Director = "Sofia Coppola"
            };

            dvd2Collections[0] = dramaDVD;
            Console.WriteLine(dramaDVD.ToString());
            #endregion
        }

        // A simple definition for a DVD.
        public class DVD
        {
            private readonly string _name;
            private readonly int _releaseYear;
            private readonly string _director;

            public DVD(string name, int releaseYear, string director)
            {
                _name = name;
                _releaseYear = releaseYear;
                _director = director;
            }

            public string ToString()
            {
                return _name + ", directed by " + _director + ", released in " + _releaseYear;
            }
        }

        // A simple definition for a DVD2.
        public class DVD2
        {
            public string Name { get; set; }
            public int ReleaseYear { get; set; }
            public string Director { get; set; }

            public string ToString()
            {
                return Name + ", directed by " + Director + ", released in " + ReleaseYear;
            }
        }
    }
}

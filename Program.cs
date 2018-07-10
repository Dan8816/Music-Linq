using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();
            System.Console.WriteLine("Hello, this is the start of the program");
            System.Console.WriteLine("***********************************************************************************");
            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> VernonQuery =
            from dude in Artists
            where dude.Hometown == "Mount Vernon"
            select dude;
            foreach (var dude in VernonQuery)
            {
                System.Console.WriteLine("{0} is a dude from MV and his real name is {1}", dude.ArtistName, dude.RealName);
            }//DMX is for mMV and his real name is Earl Simmons
            System.Console.WriteLine("***********************************************************************************");
            var person = Artists.OrderByDescending(a=>a.Age).Last();
            System.Console.WriteLine(person.ArtistName + "is the youngest artist on the list");
            //}//Chance the Rapper is an artist and their age is 23
            System.Console.WriteLine("************************************************************************************");      
            //Display all artists with 'William' somewhere in their real name
            var willy = Artists.Where(a=>a.RealName.Contains("William"));
            foreach(var a in willy)
            {
                System.Console.WriteLine("{0} is a willy, and {1} their artist name", a.RealName, a.ArtistName);
            }//Robert Williams is a willy, and Meek Mill their artist name
            //Bryan Williams is a willy, and Birdman their artist name
            //William Roberts is a willy, and Rick Ross their artist name
            //William Griffin is a willy, and Rakim their artist name
            System.Console.WriteLine("************************************************************************************");
            
            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> AtlantianQuery =
            from artist in Artists
            where artist.Hometown == "Atlanta"
            select artist;
            foreach (var artist in AtlantianQuery)
            {
                System.Console.WriteLine("{0} is a {1} year-old artist from Atlanta and the real name is {2}", artist.ArtistName, artist.Age, artist.RealName);
            }
            System.Console.WriteLine("****************************************************************************************");

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}

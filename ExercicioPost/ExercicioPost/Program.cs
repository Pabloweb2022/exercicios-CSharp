using System;
using System.Globalization;
using ExercicioPost.Entities;
namespace ExercicioPost
{
    class Program
    {
        static void Main(string[] args) {
        Comment c1 = new Comment("Have a nice trip"); 
        Comment c2 = new Comment("How that's awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 10:05:44"),
                "Traveling to New Zeland","I'm going to visit this wonderful coutry",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);  


            Console.WriteLine(p1);
        }

   

    }

}
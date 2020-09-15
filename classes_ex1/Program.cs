using System;
using classes_ex1.funcs;
namespace classes_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Stopwatch();

            var start1 = clock.Start();
            
            var stop1 = clock.Stop(start1);
            
            var start2 = clock.Start();

            // System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));

            var stop = clock.Stop(start2);

            /*
            StackOverFlow Exercise
            */

            var post = new StackOverflowPost("First Post" ,"This is my first attempt");
            post.upVote();
            post.upVote();

            post.downVote();
            post.upVote();
            post.downVote();
            post.downVote();
            post.downVote();
            post.downVote();

            var total_votes = post.get_total_votes();
            System.Console.WriteLine("Total votes is: " + total_votes);

            System.Console.WriteLine(post.GetCreateDate() + " " + post._description + " " + post.GetTitle());

        }

        
    }
}

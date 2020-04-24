using System;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Post post = new Post();

            while (true)
            {

                Console.WriteLine("type \"info\" to display post information\ntype \"upvote\" to upvote the post\ntype \"downvote\" to downvote the post\ntype \"exit\" to exit the program ");
                input = Console.ReadLine();


                switch (input.ToLower())
                {
                    case "info":
                        Console.WriteLine(post.info());
                        break;

                    case "upvote":
                        Console.WriteLine(post.upvote());
                        break;
                    case "downvote":
                        Console.WriteLine(post.downvote());
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }

                
            }
        }
    }
}
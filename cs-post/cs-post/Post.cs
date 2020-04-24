using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow_Post
{
    class Post
    {
        public string title { get; private set; }
        public string description { get; private set; }
        public DateTime date { get; private set; }
        public int score { get; private set; } = 0;

        public Post()
        {
            Console.WriteLine("Enter a title for your post... ");
            title = Console.ReadLine();
            Console.WriteLine("Enter a description for your post... ");
            description = Console.ReadLine();
            date = DateTime.Now;

            Console.WriteLine(info());
        }

        public string upvote()
        {
            score += 1;
            return score.ToString();
        }

        public string downvote()
        {
            score -= 1;
            return score.ToString();
        }

        public string info()
        {
            return string.Format("Titie: {0}\n Description: {1}\n Time posted: {2}\n Score: {3}", title, description, date.ToShortTimeString(), score);
        }

        




    }
}

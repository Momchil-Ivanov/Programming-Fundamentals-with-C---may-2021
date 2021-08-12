using System;

namespace _03._Articles_2._0
{
    class Program
    {
        class Article
        {
            public Article(string title, string content, string  author)
            {
                Title = title;
                Content = content;
                Author = author;

            }

            public string Title { get; set; }
            public string Author { get; set; }

            public string Content { get; set; }
            
            public void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split(": ");
                string commandName = splitted[0];
                string commandValue = splitted[1];
                if (commandName=="Edit")
                {
                    article.Edit(commandValue);
                }
                if (commandName == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }
                if (commandName == "Rename")
                {
                    article.Rename(commandValue);
                }
            }
            Console.WriteLine(article);
        }
    }
}

namespace SharpNews {
    public class Program {
        public static void Main(string[] args)
        {
            ArticleFactory factory = new();
            Author author = new("Jerry Berry");
            List<IArticle> articles = new List<IArticle>();
            articles.Add(factory.Create("TechArticle", author));
            articles[0].SetTitle(author, "Why Jerry Berry cool?");
            articles[0].SetBody(author, "Because Jerry Berry\nis\ncool\n\nThank you!!!");
            Console.WriteLine(articles[0]);
        }
    }
}
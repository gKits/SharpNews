namespace SharpNews {
    public class Reader : Person {
        public Reader(string name) : base(name) {}

        override public void Update(IArticle article) {
            Console.WriteLine(String.Format("Reader: {0} was notified about the article {1}", name, article.GetTitle()));
        }
    }
}
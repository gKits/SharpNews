namespace SharpNews {
    public class Author : Person {
        public Author(string name) : base(name) {}
        
        public static void Publish(ref IArticle article) {
            article.SetPublish(true);
        }

        override public void Update(IArticle article) {
            Console.WriteLine(String.Format("Author: {0} was notified about the article {1}", name, article.GetTitle()));
        }
    }
}
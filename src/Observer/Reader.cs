namespace SharpNews {
    public class Reader : Person {
        public Reader(string name) : base(name) {}

        public void Comment(ref IArticle article, string comment) {
            article.AddComment(String.Format("{0}: {1}", name, comment));
        }

        override public void Update(IArticle article, string message) {
            Console.WriteLine(String.Format("@[Reader] {0}: {1}", name, message));
        }
    }
}
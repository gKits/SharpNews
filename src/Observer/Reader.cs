namespace SharpNews {
    public class Reader : Person {
        private List<Type> interests;
    
        public Reader(string name) : base(name) {
            interests = new();
        }

        public void Comment(IArticle article, string comment) {
            article.AddComment(String.Format("{0}: {1}", name, comment));
        }


        // Interest Handling
        public void AddInterests(params Type[] types) {
            foreach (Type type in types) {
                interests.Add(type);
            }
        }

        public void RemoveInterest(Type type) {
            interests.Remove(type);
        }

        public bool InterestedIn(Type type) {
            if (interests.Contains(type)) {
                return true;
            }
            return false;
        }


        // Observer
        override public void Update(IArticle article, string message) {
            Console.WriteLine(String.Format("@[Reader] {0}: {1}", name, message));
        }
    }
}
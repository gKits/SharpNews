namespace SharpNews {
    public abstract class Person : IPerson {
        public string name;

        public Person(string name) {
            this.name = name;
        }

        public string GetName() => name;
        public void SetName(string name) {
            this.name = name;
        }

        public abstract void Update(IArticle article, string message);
    } 
}
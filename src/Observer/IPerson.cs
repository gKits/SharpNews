namespace SharpNews {
    public interface IPerson : IObserver<IArticle> {
        public string GetName();
        public void SetName(string name);
    } 
}
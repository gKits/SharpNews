namespace SharpNews {
    public interface IArticle : IObservable<IArticle> {
        string GetTitle();
        void SetTitle(string title);
        string GetBody();
        void SetBody(string body);
        Author GetAuthor();
    }
}
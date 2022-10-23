namespace SharpNews {
    public interface IObserver<T> {
        void Update(T observable, string message);
    }
}
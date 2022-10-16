namespace SharpNews {
    public interface IFactory<T, Tparam> {
        T Create(string type, Tparam param);
    }
}
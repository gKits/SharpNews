namespace SharpNews {
    public abstract class Manager<T> : IManager<T> {
        public readonly List<T> subjects;

        public Manager() {
            this.subjects = new();
        }

        public List<T> GetSubjects() => this.subjects;
        public void AddSubject(T subject) { this.subjects.Add(subject); }
    }
}
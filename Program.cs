namespace SharpNews {
    public class Program {
        public static void Main()
        {
            // Generall
            ArticleFactory factory = new();
            ArticleManager manager = new();

            // Authors
            Author authorJB = new("Jerry Berry");
            Author authorJF = new("Joe Foe");
            Author authorCS = new("Carl Starl");
            Author authorPS = new("Peter Seater");
            Author authorMC = new("Mark Clark");

            // Readers
            Reader reader1 = new("Icanread1");
            Reader reader2 = new("Icanread2");
            Reader reader3 = new("Icanread3");
            Reader reader4 = new("Icanread4");
            Reader reader5 = new("Icanread5");

            // Interests
            reader1.AddInterests(typeof(TechArticle), typeof(BusinessArticle));
            reader2.AddInterests(typeof(CelebrityArticle), typeof(BusinessArticle), typeof(PoliticsArticle));
            reader3.AddInterests(typeof(TechArticle), typeof(PoliticsArticle));
            reader4.AddInterests(typeof(CelebrityArticle));
            reader5.AddInterests(typeof(BusinessArticle), typeof(PoliticsArticle));

            manager.AddReaders(reader1, reader2, reader3, reader4, reader5);

            // Articles
            manager.AddSubject(factory.Create("TechArticle", authorJB));
            manager.AddSubject(factory.Create("PoliticsArticle", authorJB));
            authorJB.Publish(0);
            authorJB.Publish(1);


            manager.AddSubject(factory.Create("CelebrityArticle", authorCS));
            manager.AddSubject(factory.Create("TechArticle", authorCS));
            manager.AddSubject(factory.Create("BusinessArticle", authorCS));
            authorCS.Publish(0);
            authorCS.Publish(1);
            authorCS.Publish(2);

            manager.AddSubject(factory.Create("TechArticle", authorJF));
            manager.AddSubject(factory.Create("PoliticsArticle", authorJF));
            manager.AddSubject(factory.Create("CelebrityArticle", authorJF));
            manager.AddSubject(factory.Create("BusinessArticle", authorJF));
            authorJF.Publish(0);
            authorJF.Publish(1);
            authorJF.Publish(2);
            authorJF.Publish(3);

            manager.AddSubject(factory.Create("CelebrityArticle", authorPS));
            authorPS.Publish(0);

            manager.AddSubject(factory.Create("BusinessArticle", authorMC));
            manager.AddSubject(factory.Create("PoliticsArticle", authorMC));
            authorMC.Publish(0);
            authorMC.Publish(1);

            // Comments
            Random rnd = new Random();
            int len = manager.GetSubjects().Count;
            reader1.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader1.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");

            reader2.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader2.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader2.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");

            reader3.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader3.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader3.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader3.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");

            reader4.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");

            reader5.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");
            reader5.Comment(manager.GetSubjects()[rnd.Next(len)], "I read this article");

        }
    }
}
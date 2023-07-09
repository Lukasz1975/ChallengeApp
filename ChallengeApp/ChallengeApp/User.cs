namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(int login)
        {
            this.Login = login;
        }

        public User(int login, string surname, int age)
        {
            this.Login = login;
            this.Surname = surname;
            this.Age = age;
        }
        public int Login { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenNumberIsNotTheSame()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenNumber2IsGreater()
        {
            // arrange
            int number1 = 12;
            int number2 = 1550;

            // assert
            Assert.IsTrue(number1 < number2);
        }

        [Test]
        public void WhenDayIsNotTheSame()
        {
            // arrange
            string day1 = "Monday";
            string day2 = "Wednesday";

            // assert
            Assert.AreNotEqual(day1, day2);
        }

        [Test]
        public void WhenUserIsNotTheSame()
        {
            // arrange
            var user1 = GetUser(100258, "Kowolski", 32);
            var user2 = GetUser(100258, "Kowolski", 32);

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void WhenAgeIsTheSame()
        {
            // arrange
            var user1 = GetUser(100258, "Kowolski", 32);
            var user2 = GetUser(100852, "Nowak", 32);

            // assert
            Assert.AreEqual(user1.Age, user2.Age);
        }

        private User GetUser(int login, string surname, int age)
        {
            return new User(login, surname, age);
        }

    }
}

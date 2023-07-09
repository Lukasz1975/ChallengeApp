namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectPositivePoints_ShouldCorrectResult()
        {
            // arrange
            var user1 = new User("Lukasz", "Paczus", 42);
            var user2 = new User("Marian", "Boliboli", 82);
            var user3 = new User("Anna", "Ciekawska", 18);

            user1.AddScore(7);
            user1.AddScore(1);
            user1.AddScore(2);
            user2.AddScore(7);
            user2.AddScore(8);
            user2.AddScore(5);
            user3.AddScore(4);
            user3.AddScore(6);
            user3.AddScore(5);

            // act
            var result1 = user1.Result;
            var result2 = user2.Result;
            var result3 = user3.Result;

            // assert
            Assert.AreEqual(10, result1);
            Assert.AreEqual(20, result2);
            Assert.AreEqual(15, result3);
        }

        [Test]
        public void WhenUserCollectPositiveAndNegativePoints_ShouldCorrectResult()
        {
            // arrange
            var user1 = new User("Lukasz", "Paczus", 42);
            var user2 = new User("Marian", "Boliboli", 82);
            var user3 = new User("Anna", "Ciekawska", 18);

            user1.AddScore(7);
            user1.AddScore(1);
            user1.AddScore(-3);
            user2.AddScore(7);
            user2.AddScore(8);
            user2.AddScore(-5);
            user3.AddScore(10);
            user3.AddScore(6);
            user3.AddScore(-5);

            // act
            var result1 = user1.Result;
            var result2 = user2.Result;
            var result3 = user3.Result;

            // assert
            Assert.AreEqual(5, result1);
            Assert.AreEqual(10, result2);
            Assert.AreEqual(11, result3);

        }
        [Test]
        public void WhenUserCollectNegativePoints_ShouldCorrectResult()
        {
            // arrange
            var user1 = new User("Lukasz", "Paczus", 42);
            var user2 = new User("Marian", "Boliboli", 82);
            var user3 = new User("Anna", "Ciekawska", 18);

            user1.AddScore(-7);
            user1.AddScore(-1);
            user1.AddScore(-3);
            user2.AddScore(-7);
            user2.AddScore(-8);
            user2.AddScore(-5);
            user3.AddScore(-10);
            user3.AddScore(-8);
            user3.AddScore(-5);

            // act

            var result1 = user1.Result;
            var result2 = user2.Result;
            var result3 = user3.Result;

            // assert

            Assert.AreEqual(-11, result1);
            Assert.AreEqual(-20, result2);
            Assert.AreEqual(-23, result3);

        }
    }
}
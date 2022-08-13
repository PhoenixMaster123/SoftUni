namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            this.database = new Database();
        }

        [Test]
        public void CountShouldWorkProperlyWhenAdd()
        {
            database.Add(new Person(123, "Dari"));
            database.Add(new Person(456, "Mimi"));

            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void CountShouldWorkProperlyWhenRemove()
        {
            database.Add(new Person(123, "Dari"));
            database.Add(new Person(456, "Mimi"));
            database.Remove();

            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void RemoveUserFromEmptyDatabaseShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void AddUserToFullDatabaseShouldThrowException()
        {
            string user = "user";

            for (int i = 1; i <= 16; i++)
            {
                database.Add(new Person(i, user + i));
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(17, "user17"));
            });
        }

        [Test]
        public void DatabaseParamsMoreThan16ShouldThrowException()
        {
            Person[] persons = new Person[17];

            Assert.Throws<ArgumentException>(() =>
            {
                Database database = new Database(persons);

            }, "Provided data length should be in range [0..16]!");

        }

        [Test]
        public void DatabaseZeroParamsShouldBeValid()
        {
            Person[] persons = new Person[0];

            Database database = new Database(persons);

            Assert.AreEqual(0, database.Count);
        }

        [Test]
        public void AddUserIfSameUsernameExistShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(987654321, "user123"));
            }, "There is already user with this username!");
        }

        [Test]
        public void AddUserIfSameIdExistShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(123456789, "user321"));
            }, "There is already user with this Id!");
        }

        [Test]
        public void RemoveUserIfIsNullShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void FindByUsernameIfThereIsNoUserWithThisUsernameShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("user");
            }, "No user is present by this username!");
        }

        [Test]
        public void FindByUsernameShouldReturnCorrectPerson()
        {
            database.Add(new Person(123, "Koko"));
            database.Add(new Person(456, "Maya"));

            var user = database.FindByUsername("Koko");

            Assert.AreEqual(123, user.Id);
            Assert.AreEqual("Koko", user.UserName);
        }

        [Test]
        public void FindByIdShouldReturnCorrectPerson()
        {
            database.Add(new Person(123, "Koko"));
            database.Add(new Person(456, "Maya"));

            var user = database.FindById(123);

            Assert.AreEqual(123, user.Id);
            Assert.AreEqual("Koko", user.UserName);
        }

        [Test]
        public void FindByUsernameIfTheUsernameParamIsNullShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername("");
            }, "Username parameter is null!");
        }

        [Test]
        public void FindByUsernameCaseSensitiveShouldThrowException()
        {
            database.Add(new Person(123456789, "User123"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("user123");
            });
        }

        [Test]
        public void FindByIdIfThereIsNoUserWithSameIdShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindById(123);
            }, "No user is present by this ID!");
        }

        [Test]
        public void FindByIdIfTheIdParamIsNegativeShouldThrowException()
        {
            database.Add(new Person(123456789, "user123"));

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(-123);
            }, "Id should be a positive number!");
        }
    }
}
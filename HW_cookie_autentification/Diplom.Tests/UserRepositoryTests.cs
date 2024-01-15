using HW_cookie_autentification.DataAccess;
using HW_cookie_autentification.DataAccess.Repositories.UserRepositories;
using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;

namespace Diplom.Tests
{
    [TestFixture]
    public class RepositoryTest
    {
        private UserRepository _Repository;
        private Mock<UserDbContext> _userContextMock;
        private static readonly List<User> _users = new List<User>(){
                    new User { Id = 1,Email="Dmitry123@mail.ru",Password="123",Role="orders",Name="Dmitry",},
                    new User { Id = 2,Email="1@mail.ru",Password="123",Role="customer",Name="DD",},
                    new User { Id = 3,Email="2@mail.ru",Password="123",Role="admin",Name="Mit",},
                    new User { Id = 4,Email="3@mail.ru",Password="123",Role="supervisor",Name="adsa",}
                };
                

        [SetUp]
        public void Setup()
        {
            _userContextMock = new Mock<UserDbContext>(new DbContextOptionsBuilder<UserDbContext>().UseInMemoryDatabase("TestDb").Options);
            _userContextMock.Setup(x => x.Set<User>()).ReturnsDbSet(_users);
            _Repository = new UserRepository(_userContextMock.Object);
        }


        [Test]
        public async Task GetAllUsers_ReturnsCorrectListUsers()
        {

            //Act
            var userGetAll = await _Repository.GetAll();
            //Assert
            Assert.NotNull(userGetAll);
            Assert.That(userGetAll.Count(), Is.EqualTo(_users.Count));
            for (int i = 0; i < userGetAll.Count(); i++)
            {
                Assert.That(userGetAll.ElementAt(i).Id, Is.EqualTo(_users.ElementAt(i).Id));
                Assert.That(userGetAll.ElementAt(i).Email, Is.EqualTo(_users.ElementAt(i).Email));
                Assert.That(userGetAll.ElementAt(i).Name, Is.EqualTo(_users.ElementAt(i).Name));
                Assert.That(userGetAll.ElementAt(i).Description, Is.EqualTo(_users.ElementAt(i).Description));
                Assert.That(userGetAll.ElementAt(i).Password, Is.EqualTo(_users.ElementAt(i).Password));
                Assert.That(userGetAll.ElementAt(i).Role, Is.EqualTo(_users.ElementAt(i).Role));
                Assert.That(userGetAll.ElementAt(i).Phone, Is.EqualTo(_users.ElementAt(i).Phone));
            }
        }

        [Test]
        public async Task GetDetailsByEmail_ReturnsExpectedResult()
        {
            var UserEmail = "2@mail.ru";
            // Arrange
            _userContextMock.Setup((x) => x.Set<User>().FindAsync(UserEmail)).ReturnsAsync((_users.Find(i => i.Email == UserEmail)));

            // Act
            var actualEntity = await _Repository.GetDetailsByEmail(UserEmail);

            // Assert
            Assert.That(actualEntity.Id, Is.EqualTo(_users.ElementAt(2).Id));
            Assert.That(actualEntity.Email, Is.EqualTo(_users.ElementAt(2).Email));
            Assert.That(actualEntity.Name, Is.EqualTo(_users.ElementAt(2).Name));
            Assert.That(actualEntity.Description, Is.EqualTo(_users.ElementAt(2).Description));
            Assert.That(actualEntity.Password, Is.EqualTo(_users.ElementAt(2).Password));
            Assert.That(actualEntity.Role, Is.EqualTo(_users.ElementAt(2).Role));
            Assert.That(actualEntity.Phone, Is.EqualTo(_users.ElementAt(2).Phone));
        }

        [Test]
        public async Task GetDetailsById_ReturnsExpectedResult()
        {
            var UserId = 3;
            // Arrange
            _userContextMock.Setup((x) => x.Set<User>().FindAsync(UserId)).ReturnsAsync((_users.Find(i => i.Id  == UserId)));

            // Act
            var actualEntity = await _Repository.GetDetails(UserId);

            // Assert
            Assert.That(actualEntity.Id, Is.EqualTo(_users.ElementAt(2).Id));
            Assert.That(actualEntity.Email, Is.EqualTo(_users.ElementAt(2).Email));
            Assert.That(actualEntity.Name, Is.EqualTo(_users.ElementAt(2).Name));
            Assert.That(actualEntity.Description, Is.EqualTo(_users.ElementAt(2).Description));
            Assert.That(actualEntity.Password, Is.EqualTo(_users.ElementAt(2).Password));
            Assert.That(actualEntity.Role, Is.EqualTo(_users.ElementAt(2).Role));
            Assert.That(actualEntity.Phone, Is.EqualTo(_users.ElementAt(2).Phone));
        }

        [Test]
        public async Task CreateUser_InvokesDbContextMethod()
        {
            // Arrange
            var Entity = new User
            {
                Id = 1,
                Email = "Dmitry123@mail.ru",
                Password = "123",
                Role = "orders",
                Name = "Dmitry",
            };


            // Act
            await _Repository.Create(Entity);

            // Assert
            _userContextMock.Verify(x => x.Set<User>().AddAsync(It.IsAny<User>(),CancellationToken.None), Times.Once);
        }

        [Test]
        public async Task UpdateUser_InvokesDbContextMethod()
        {
            
            // Arrange
            var Entity = new User
            {
                Id = 1,
                Email = "Dmitry123@mail.ru",
                Password = "123",
                Role = "orders",
                Name = "Dmitry",
            };
            // Act
            await _Repository.Update(Entity);

            // Assert
            _userContextMock.Verify(x => x.Set<User>().Update(It.IsAny<User>()), Times.Once);
        }

        [Test]
        public async Task DeleteUser_InvokesDbContextMethod()
        {

            // Arrange
            int id = 1;

            // Act
            await _Repository.Delete(id);

            // Assert
            _userContextMock.Verify(x => x.Set<User>().Remove(It.IsAny<User>()), Times.Once);
        }
    }
}
using System;
using Pets;
using Xunit;

namespace Pets.Tests
{
    public class PetTests {
        [Fact]
        public void DogTalkToOwnerReturnsWoof () {
            // Arrange
            string expected = "Woof!";
            Dog Willy = new Dog("Willy", Rooms.DiningRoom);
            // Act
            string actual = Willy.TalkToOwner ();
            // Assert
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void CatTalkToOwnerReturnsMeow () {
            string pattern = "Meow!";
            Cat Kitty = new Cat ("KatziTatzi", Rooms.Kitchen);
            string actual = Kitty.TalkToOwner ();

            Assert.Contains (pattern, actual);
        }

    }
}

using System;

namespace Pets
{
    /// <summary>
    /// Die Klasse implementiert Objekte vom Typ Hund auf der Basis der <c>Pets</c> Klasse.
    /// Er Bellt den Besitzer an
    /// </summary>
    public class Dog : Pet
    {
        public Dog(string name, Rooms currentRoom) : base (name, currentRoom) { }

        public override string TalkToOwner() => "Woof!";

        public bool SearchForCat(Cat cat)
        {
            if (cat.LocalizedInRoom == this.LocalizedInRoom)
            {
                Console.WriteLine($"Found cat in {this.LocalizedInRoom}");
                return true;
            }
            else
            {
                Console.WriteLine("No cat in current room!");
                return false;
            }
        }
    }
}

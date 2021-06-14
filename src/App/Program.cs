using System;
using System.Collections.Generic;
using Pets;

namespace ConsoleApplication {
    public class MyLittleZoo {
        public static void Main (string[] args) {
            Dog Willy = new Dog("Willy", Rooms.DiningRoom);
            Cat Kitty = new Cat ("KatziTatzi", Rooms.Kitchen);
            List<Pet> pets = new List<Pet> {Willy, Kitty};

            foreach (var pet in pets) {
                Console.WriteLine (pet.TalkToOwner ());
            }

            Willy.SearchForCat(Kitty);
            Willy.LocalizedInRoom = Rooms.Kitchen;
            Willy.SearchForCat(Kitty);
        }
    }
}

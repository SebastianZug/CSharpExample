using System;
using System.Collections.Generic;
using Pets;

namespace ConsoleApplication {
    public class MyLittleZoo {
        public static void Main (string[] args) {
            List<Pet> pets = new List<Pet> {
                new Dog ("Willy", Rooms.DiningRoom),
                new Cat ("KatziTatzi", Rooms.Kitchen)
            };

            foreach (var pet in pets) {
                Console.WriteLine (pet.TalkToOwner ());
            }
        }
    }
}

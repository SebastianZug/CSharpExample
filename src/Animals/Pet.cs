using System;

namespace Pets {
  public abstract class Pet{
    public Pet (string name, Rooms currentRoom) {
      petName = name;
      localizedInRoom = currentRoom;
    }

    string petName;
    public string PetName {
      get { return petName; }
    }

    Rooms localizedInRoom;
    public Rooms LocalizedInRoom {
      get { return localizedInRoom; }
      set { localizedInRoom = value; }
    }   

    public abstract string TalkToOwner ();
    /// <summary>
    /// Das Tier schläft für einige Stunden und sollte nicht gestört werden.
    /// </summary>
    /// <param name="hours">
    /// Anzahl der Stunden
    /// </param>
    void Sleeps (byte hours) {
      Console.WriteLine ($"Iam not avialable for {hours} hours!");
    }
  }
}

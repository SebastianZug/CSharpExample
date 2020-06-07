using System;

namespace Pets {
  /// <summary>
  /// Diese Klasse implementiert Objekte vom Typ Katze auf der Basis der <c>Pets</c> Klasse.
  /// <remarks>
  /// <para>Die Katze bekommt einen Namen und interagiert artspezifisch mit dem Nutzer.</para>
  /// </remarks>
  /// </summary>
  public class Cat : Pet {
    /// <summary>
    /// Instanziert ein Katzenobjekt mit einem Namen
    /// </summary>
    /// <param name="name"> string Katezname.</param>
    public Cat (string name, Rooms currentRoom) : base (name, currentRoom) { }

    /// <summary>
    /// Kommuniziert mit dem Besitzer
    /// </summary>
    /// <returns>
    /// string Katzengeräusch
    /// </returns>
    public override string TalkToOwner () => "Meow!";
  }
}
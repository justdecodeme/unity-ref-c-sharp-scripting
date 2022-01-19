using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ************* */
/* Inheritance */
/* ************* */
// public class ChildClass : ParentClass
// {
// }
public class Paladin : Character
{
    /* ************* */
    /* Base constructors */
    /* ************* */
    // public ChildClass() : base()
    // {
    // }
    /* When the Paladin constructor fires, it passes the name parameter to the 
    Character constructor, which sets the name value. Essentially, we used the 
    Character constructor to do the initialization work for the Paladin class, 
    making the Paladin constructor only responsible for initializing its unique 
    properties */
    public Paladin(string name) : base(name)
    {
    }

    /* ************* */
    /* Composition */
    /* ************* */
    /* Aside from inheritance, classes can be composed of other classes. Take our 
    Weapon struct, for example. Paladin can easily contain a Weapon variable inside 
    itself and have access to all its properties and methods. */
    public Weapon weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    /* Can override inherited member 'Character.PrintStatsInfo()' only if it is 
    marked virtual, abstract, or override */
    /* What we've done by marking PrintStatsInfo as virtual in the Character 
    class is to tell the compiler that this 
    method can have many shapes according to the calling class. */
    /* When we declared the overridden version of PrintStatsInfo in Paladin, 
    we added the custom behavior that only applies to that class. Thanks to 
    polymorphism, we don't have to choose which version of PrintStatsInfo we 
    want to call from a Character or Paladin object—the compiler already knows */
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", name, weapon.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ************* */
/* structs */
/* ************* */
// accessModifier struct UniqueName 
// {
//     Variables
//     Constructors
//     Methods
// }

/* The main difference is that they are value types, meaning they are passed by value instead of reference, like classes are. */

/* Variables cannot be initialized with values inside the struct declaration unless they're marked with the static or const 
modifier—you can read more about this in Chapter 10, Revisiting Types, Methods, and Classes.
Constructors without parameters aren't permitted.
Structs come with a default constructor that will automatically set all variables to their default values according to their type.
 */

/* We deleted the generated code because we won't need to attach this script to a Unity GameObject. */
public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", name, damage);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ************* */
/* classes */
/* ************* */
// accessModifier class UniqueName
// {
//     Variables
//     Constructors
//     Methods
// }

/*  The main thing to remember with classes is that they are reference types—that is, when they are assigned or passed to another variable, the original object is referenced, not a new copy.  */

/* If a constructor is not specified, C# generates a default one. The default constructor sets 
any variables to their default type values—numeric values are set to zero, Booleans to false, 
and reference types (classes) to null.
Custom constructors can be defined with parameters, just like any other method, and are used 
to set class variable values at initialization.
A class can have multiple constructors.
 */

/* We deleted the generated code because we won't need to attach this script to a Unity GameObject. */
public class Character
{
    public string name;
    public int exp = 0;

    /* ************* */
    /* constructors */
    /* ************* */
    /* Constructors are written like regular methods but with a few differences; for instance, 
    they need to be public, have no return type, and the method name is always the class name. 
    As an example, let's add a basic constructor with no parameters to the Character class and 
    set the name field to something other than null. */
    public Character()
    {
        // name = "Not assigned";
        Reset();
    }

    /* ************* */
    /* constructor overloading */
    /* ************* */
    /* Assign the parameter to the class's name variable using the this keyword. This is called 
    constructor overloading */
    public Character(string name)
    {
        this.name = name;
    }

    /* ************* */
    /* class methods */
    /* ************* */
    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Name: {0} - {1} EXP", name, exp);
    }

    /* ************* */
    /* Encapsulation */
    /* ************* */
    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    void Start()
    {
        Character hero1 = new Character();
        Debug.LogFormat("Name: {0} - {1} EXP", hero1.name, hero1.exp);
        hero1.PrintStatsInfo();

        Character hero2 = new Character("Alita");
        Debug.LogFormat("Name: {0} - {1} EXP", hero2.name, hero2.exp);
        hero2.PrintStatsInfo();

        Paladin knight = new Paladin("Sir Arthur");
        knight.PrintStatsInfo();

        Weapon warBow = new Weapon("War  Bow", 105);
        Paladin knight2 = new Paladin("Sir Mathew", warBow);
        knight2.PrintStatsInfo();
    }
}

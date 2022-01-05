using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        /* for */
        string[] namesArr = new string[] { "Name1", "Name2", "Name3" };
        for (int i = 0; i < namesArr.Length; i++) {
            Debug.Log(namesArr[i]);
        }

        /* foreach */
        List<string> namesList = new List<string>() { "Name1", "Name2", "Name3" };
        foreach (string name in namesList) {
            Debug.Log(name);
        }

        /* while */
        int lives = 3;
        while (lives > 0) {
            Debug.Log("Lives: " + lives);
            lives--;
        }
        Debug.Log("You are now dead.");
    }
}

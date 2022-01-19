using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Log to the console");
        Debug.LogWarning("Warning to the console");
        Debug.LogError("Error to the console");
        Debug.Log($"Sring Interpolation | a = {2} and b = {5}");
        Debug.LogFormat("Variable Placeholders | a = {0} and b = {1}", 2, 5);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    void Start()
    {
        /* if */
        int temp = 40;
        if (temp <= 32)
        {
            Debug.Log("It is freezing");
        }

        /* if else */
        if (temp <= 32)
        {
            Debug.Log("It is freezing");
        }
        else if (temp < 50)
        {
            Debug.Log("Wear a jacket");
        }
        else if (temp < 70)
        {
            Debug.Log("Wear pants");
        }
        else if (temp < 90)
        {
            Debug.Log("Wear shorts");
        }
        else
        {
            Debug.Log("Wear a bathing suit!");
        }

        /* switch */
        string weather = "cloudy";
        switch (weather)
        {
            case "sunny":
                Debug.Log("'Wear suntan lotion");
                break;
            case "rainy":
                Debug.Log("Bring an umbrella");
                break;
            case "snowing":
                Debug.Log("Wear a warm jacket");
                break;
            default:
                Debug.Log("Dress for success");
                break;
        }
    }
}

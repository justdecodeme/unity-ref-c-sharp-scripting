using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorTips : MonoBehaviour
{
    /* applying before and after header  */
    // [Space(20)]
    
    [Header("GameObjects")] /* have space on top by default */
    public GameObject sword;
    public GameObject armor;


    [Header("Settings")]
    [Space(30)] /* apply before Header (to change default top space) */
    [Min(5)]
    [Tooltip("Player Speed")]
    public int speed = 7;
    [Range(1, 10)]
    public int force = 1;

    [Space(20)]
    
    [TextArea]
    public string description = "This is description, can be multiline if required.";
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonUtility : MonoBehaviour
{
    void Start()
    {
        PlayerData playerData = new PlayerData();
        playerData.position = new Vector3(0, 0, 0);
        playerData.health = 80;

        /* not working... 'JsonUtility' does not contain a definition for 'ToJson'*/
        // string json = JsonUtility.ToJson(playerData);
        // Debug.Log(json);
    }

    private class PlayerData
    {
        public Vector3 position;
        public int health;
    }

}

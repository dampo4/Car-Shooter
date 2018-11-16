using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    System.Random rnd = new System.Random();
    public GameObject[] powerups = new GameObject[3];
    int xMin = -30;
    int xMax = 30;
    int zMin = -30;
    int zMax = 30;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameObject.FindGameObjectsWithTag("PowerUp").Length < 5)
        {
            int type = rnd.Next(0, powerups.Length);
            int x = rnd.Next(xMin, xMax);
            int z = rnd.Next(zMin, zMax);
            Vector3 pos = new Vector3(x, 0.451f, z);
            Quaternion angle = new Quaternion(3, 3, 3, 3);
            var powerup = (GameObject)Instantiate(powerups[type], pos, angle);
        }

    }
}

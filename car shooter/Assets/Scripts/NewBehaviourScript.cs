using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    System.Random rnd = new System.Random();
    public GameObject[] types = new GameObject[3];
    private GameObject[] powerups = new GameObject[8];
    private int[] quadrant = new int[8] { 1, 1, 2, 2, 3, 3, 4, 4 };
    private Vector3[] pos = new Vector3[8];
    int xMin = -30;
    int xMax = 30;
    int zMin = -30;
    int zMax = 30;

    // Use this for initialization
    void Start () {
            GenereateType();
            GeneratePos();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        

    }

    void GenereateType()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            powerups[i] = types[rnd.Next(0, types.Length)];
        }
    }



    void GeneratePos()
    {
        foreach (var item in quadrant)
        {
            int x = 0;
            int z = 0;
            switch (item)
            {
                case 1:
                    x = rnd.Next(-30, 0);
                    z = rnd.Next(0, 30);
                    break;
                case 2:
                    x = rnd.Next(0, 30);
                    z = rnd.Next(0, 30);
                    break;
                case 3:
                    x = rnd.Next(-30, 0);
                    z = rnd.Next(-30, 0);
                    break;
                case 4:
                    x = rnd.Next(0, 30);
                    z = rnd.Next(-30, 0);
                    break;
            }
            pos[item] = new Vector3(x, 0.451f, z);
        }

    }
}

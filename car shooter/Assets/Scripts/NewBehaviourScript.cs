using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    System.Random rnd = new System.Random();
    public GameObject[] types = new GameObject[3];
    private GameObject[] powerups = new GameObject[8];
    private int[] quadrant = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
    private Vector3[] pos = new Vector3[8];
    float timer = 0.0f;
    float xMin = -25f;
    float xMax = 25f;
    float zMin = -25f;
    float zMax = 25f;

    // Use this for initialization
    void Start () {
        SpawnPowerups();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.deltaTime;
        if (timer > 5 )
        {
            ClearPowerups();
            SpawnPowerups();
            timer = 0;
        }

    }

    void ClearPowerups()
    {
        GameObject[] activePowerups = GameObject.FindGameObjectsWithTag("PowerUp");
        foreach (GameObject powerup in activePowerups)
            GameObject.Destroy(powerup);
    }

    void SpawnPowerups()
    {
        GenereateType();
        GeneratePos();
        PlaceObjects();
    }

    void PlaceObjects()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            Debug.Log(pos);
            Instantiate(powerups[i], pos[i], new Quaternion(0, 0, 0, 0));
        }

    }

    void GenereateType()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            powerups[i] = types[Random.Range(0, types.Length)];
        }
    }



    void GeneratePos()
    {
        for (int i = 0; i < 8; i++)
        {
            float x = 0;
            float z = 0;
            float xMin = -25f;
            float xMax = 25f;
            float zMin = -25f;
            float zMax = 25f;
            if (i == 0 | i == 1)
            {
                do
                {
                    x = Random.Range(xMin, -1f);
                    z = Random.Range(0f, zMax);
                }
                while (x < -10 && x > -20 && z > 10 && z < 20 );
            }
            else if (i == 2 | i == 3)
            {
                do
                {
                    x = Random.Range(1f, xMax);
                    z = Random.Range(0f, zMax);
                }
                while (x > 10 && x < 20 && z > 10 && z < 20);

            }
            else if (i == 4 | i == 5)
            {
                do
                {
                    x = Random.Range(xMin, -1f);
                    z = Random.Range(zMin, 0f);
                }
                while (x < -10 && x > -20 && z < -10 && z > -20);

            }
            else if (i == 6 | i == 7)
            {
                do
                {
                    x = Random.Range(1f, xMax);
                    z = Random.Range(zMin, 0f);
                }
                while (x > 10 && x < 20 && z < -10 && z > -20);

            }
            pos[i] = new Vector3(x, 0.451f, z);
        }





        /*foreach (int item in quadrant)
        {
            float x = 55;
            float z = 55;
            switch (item)
            {
                case 0 | 4:
                    x = Random.Range(xMin, 0f);
                    z = Random.Range(0f, zMax);
                    pos[item] = new Vector3(x, 0.451f, z);
                    break;
                case 1 | 5:
                    x = Random.Range(0f, xMax);
                    z = Random.Range(0f, zMax);
                    pos[item] = new Vector3(x, 0.451f, z);
                    break;
                case 2 | 6:
                    x = Random.Range(xMin, 0f);
                    z = Random.Range(zMin, 0f);
                    pos[item] = new Vector3(x, 0.451f, z);
                    break;
                case 3 | 7:
                    x = Random.Range(0f, xMax);
                    z = Random.Range(zMin, 0f);
                    pos[item] = new Vector3(x, 0.451f, z);
                    break;
            }

        }*/


    }
}

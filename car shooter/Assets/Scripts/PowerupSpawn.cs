using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerupSpawn : MonoBehaviour {
    System.Random rnd = new System.Random();
    public GameObject[] types = new GameObject[3];
    private GameObject[] powerups = new GameObject[8];
    private int[] quadrant = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
    private Vector3[] pos = new Vector3[8];
    GameObject[] activePowerups;
    bool isDone = false;
    private IEnumerator coroutine;
    float timer = 0.0f;
    float xMin = -25f;
    float xMax = 25f;
    float zMin = -25f;
    float zMax = 25f;

    // Use this for initialization
    void Start () {
        SpawnPowerups();
        coroutine = DoIT(timer);
    }

    // Update is called once per frame
    void FixedUpdate() {
        timer += Time.deltaTime;
        activePowerups = GetPowerups();
        if (timer > 10)
        {
            if (!isDone)
            {
                isDone = true;
                StartCoroutine(coroutine);
            }
            if (timer > 15)
            {
                StopCoroutine(coroutine);
                ClearPowerups();
                SpawnPowerups();
                timer = 0;
                isDone = false;
            }

        }
        

    }
    IEnumerator DoIT(float timer)
    {
        Debug.Log("doing something");
        while (timer < 15)
        {

            foreach(GameObject powerup in activePowerups)
            {
                Debug.Log("made it");
                powerup.GetComponent<Renderer>().enabled = false;

            }
            yield return new WaitForSeconds(0.2f);
            foreach (GameObject powerup in activePowerups)
            {
                powerup.GetComponent<Renderer>().enabled = true;

            }
            yield return new WaitForSeconds(0.4f);
        }
    }

    GameObject[] GetPowerups()
    {
        GameObject[] array = GameObject.FindGameObjectsWithTag("PowerUp");
        return array;
    }
    void ClearPowerups()
    {
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
            Instantiate(powerups[i], pos[i], powerups[i].transform.rotation);
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



    }
}

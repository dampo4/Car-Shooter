using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour {

    public int health;

    void Start () {
        health = 100;
	}
	
	void Update () {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            collision.gameObject.SetActive(false);
            GameObject player = GameObject.FindWithTag("Player");
            CarWeapon script = player.GetComponent<CarWeapon>();
            health = health - script.damage;
        }
    }
}

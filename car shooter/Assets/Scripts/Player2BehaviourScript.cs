using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2BehaviourScript : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;
    public Transform healthBar;
    public Slider healthFill;
    public float healthBarYOffset = 2;

    void Start () {
        maxHealth = 100;
        currentHealth = maxHealth;
	}
	
	void Update () {
        PositionHealthBar();
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1Bullet")
        {
            collision.gameObject.SetActive(false);
            GameObject player = GameObject.FindWithTag("Player1");
            Player1CarWeapon script = player.GetComponent<Player1CarWeapon>();
            currentHealth = currentHealth - script.damage;
            healthFill.value = currentHealth / maxHealth;
        }
    }
    private void PositionHealthBar()
    {
        Vector3 currentPos = transform.position;
        healthBar.position = new Vector3(currentPos.x, currentPos.y + healthBarYOffset, currentPos.z);
        healthBar.LookAt(Camera.main.transform);
    }
}

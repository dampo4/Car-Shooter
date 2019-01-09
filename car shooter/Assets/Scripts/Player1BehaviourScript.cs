using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1BehaviourScript : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    public Transform healthBar;
    public Slider healthFill;
    public float healthBarYOffset = 2;
    public Camera Player2Cam;

    void Start()
    {
        maxHealth = 400;
        currentHealth = maxHealth;
    }

    void Update()
    {
        healthFill.value = currentHealth / maxHealth;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player2Bullet")
        {
            collision.gameObject.SetActive(false);
            GameObject player = GameObject.FindWithTag("Player2");
            Player2CarWeapon script = player.GetComponent<Player2CarWeapon>();
            currentHealth = currentHealth - script.damage;
            healthFill.value = currentHealth / maxHealth;
        }
    }

}

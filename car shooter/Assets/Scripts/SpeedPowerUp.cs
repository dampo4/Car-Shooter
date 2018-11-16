using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour {

    void OnTriggerEnter(Collider tag)
    {
        if (tag.CompareTag("Player1") || tag.CompareTag("Player2"))
        {
            {
                Pickup(tag);
            }
        }
    }
    void Pickup(Collider player)
    {
        if (player.tag == "Player1")
        {
            Player1CarMovement script = player.GetComponent<Player1CarMovement>();
            script.speed += 1f;
            Destroy(gameObject);
        }
        else
        {
            Player2CarMovement script = player.GetComponent<Player2CarMovement>();
            script.speed += 1f;
            Destroy(gameObject);
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerup : MonoBehaviour {

	void OnTriggerEnter (Collider tag)
	{
		if (tag.CompareTag ("Player1") || tag.CompareTag("Player2")) {
			{
				Pickup (tag);
			}
		}
	}
	void Pickup(Collider player)
	{
        if (player.tag == "Player1")
        {
            Player1BehaviourScript script = player.GetComponent<Player1BehaviourScript>();
            script.currentHealth += 50;
            Destroy(gameObject);
        }
        else
        {
            Player2BehaviourScript script = player.GetComponent<Player2BehaviourScript>();
            script.currentHealth += 50;
            Destroy(gameObject);
        }

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePowerup : MonoBehaviour {

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
            Player1CarWeapon script = player.GetComponent<Player1CarWeapon>();
            script.damage *= 2;
            Destroy(gameObject);
        }
        else
        {
            Player2CarWeapon script = player.GetComponent<Player2CarWeapon>();
            script.damage *= 2;
            Destroy(gameObject);
        }

	}
}

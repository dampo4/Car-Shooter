using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

	void OnTriggerEnter (Collider tag)
	{
		if (tag.CompareTag ("Player")) {
			{
				Pickup (tag);
			}
		}
	}
	void Pickup(Collider player)
	{
        CarWeapon script = player.GetComponent<CarWeapon>();
        script.damage *= 2;
	}
}

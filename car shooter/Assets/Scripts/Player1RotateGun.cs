using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1RotateGun : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Vector2 mouse = Input.mousePosition;
            Vector3 direction = new Vector3(hit.point.x, hit.point.y, hit.point.z) - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = rotation;
        }


    }
}

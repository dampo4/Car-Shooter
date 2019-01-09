using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2RotateGun : MonoBehaviour {
    float h1 = 0;
    float v1 = 0;
    float zRot = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("JoyHorizontal") * Time.deltaTime * 100.0f;
        transform.Rotate(0, -x, 0);
        // var x = Input.GetAxis("Turret") * 3;
        //transform.Rotate(0, x, 0);

        //lookDirection += new Vector3(Input.GetAxis("JoyHorizontal"), Input.GetAxis("JoyVertical"));
        //Quaternion targetRotation = Quaternion.LookRotation(lookDirection);

        // Smoothly rotate towards the target point.
        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        h1 = Input.GetAxis("TurretV");
       v1 = Input.GetAxis("TurretH");

        transform.localEulerAngles = new Vector3(0f, Mathf.Atan2(h1, v1) * 180 / Mathf.PI, 0f);

        zRot = Mathf.Atan2(h1, v1) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, zRot, 0));


    }
}

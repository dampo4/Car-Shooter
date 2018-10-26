using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2RotateGun : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("JoyHorizontal") * 10;
        transform.Rotate(0, x, 0);


    }
}

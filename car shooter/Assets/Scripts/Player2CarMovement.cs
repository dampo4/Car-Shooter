using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CarMovement : MonoBehaviour {
    public float speed = 6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("JoyHorizontal") * Time.deltaTime * 100.0f;
        var z = Input.GetAxis("JoyVertical") * Time.deltaTime * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        

    }
}

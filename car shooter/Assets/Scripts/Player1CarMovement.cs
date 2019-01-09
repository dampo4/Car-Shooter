using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1CarMovement : MonoBehaviour {
    public float speed = 1f;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);


    }
}

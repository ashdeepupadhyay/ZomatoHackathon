using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatex : MonoBehaviour {

    public float rotationAngle = 40f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotationAngle * Time.deltaTime, 0, 0);
    }
}

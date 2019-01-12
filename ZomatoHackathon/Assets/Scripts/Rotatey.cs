using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatey : MonoBehaviour {
    public float rotationAngle = 40f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationAngle * Time.deltaTime, 0);

    }
}

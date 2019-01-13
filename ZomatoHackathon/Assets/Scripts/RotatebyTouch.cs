using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatebyTouch : MonoBehaviour {

    public float speed = 0.2F;

    void Update()
    {

        int nbTouches = Input.touchCount;

        if (nbTouches > 0)
        {
            for (int i = 0; i < nbTouches; i++)
            {
                Touch touch = Input.GetTouch(i);

                TouchPhase phase = touch.phase;

                switch (phase)
                {
                    case TouchPhase.Began:
                        break;
                    case TouchPhase.Moved:
                        if (touch.deltaPosition.y >= 0)
                        {
                            Debug.Log("positive");

                            transform.Rotate(new Vector3(0, touch.deltaPosition.y * speed, 0 ), Space.World);
                            //transform.Rotate(new Vector3(0,touch.deltaPosition.y * speed, touch.deltaPosition.x));
                        }
                        else
                        {
                            Debug.Log("negative");
                            transform.Rotate(new Vector3(0, -touch.deltaPosition.y * speed, 0), Space.World);

                        }
                        if (touch.deltaPosition.x >= 0)
                        {
                            Debug.Log("positive x");

                            transform.Rotate(new Vector3(touch.deltaPosition.x * speed, 0, 0), Space.World);
                            //transform.Rotate(new Vector3(0,touch.deltaPosition.y * speed, touch.deltaPosition.x));
                        }
                        else
                        {
                            Debug.Log("negative x");
                            transform.Rotate(new Vector3(-touch.deltaPosition.x * speed, 0, 0), Space.World);

                        }
                        break;
                    case TouchPhase.Ended:
                        break;

                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour 
{
    private Touch touch;
    private float speedModifier;

    float smooth = 5.0f;

    private void Start()
    {
        speedModifier = 0.01f;
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                Debug.Log(touch.deltaPosition.x);
                if(touch.deltaPosition.x < 0)
                {
                    Quaternion target = Quaternion.Euler(0, -15, 0);
                    transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                }
                else
                {
                    Quaternion target = Quaternion.Euler(0, 15, 0);
                    transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                }

                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z);
            }

        }
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlane : MonoBehaviour
{
    public float speed = 1f;
    

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    Rigidbody rb;

    public CameraShake cameraShakeScript;
   

    public AudioSource jumpAudio;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraShakeScript = FindObjectOfType<CameraShake>();
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trampolin")
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAudio.Play();

            StartCoroutine(waitAndVibrate());

        }
    }

    IEnumerator waitAndVibrate()
    {
        yield return new WaitForSeconds(0.8f);
        //Vibrate the Mobile
        Handheld.Vibrate();
        Debug.Log("Vibrate");

        //shake the screen
        cameraShakeScript.ShakeTheCamera();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStrength : MonoBehaviour
{
    public int strenght = 0;
    public Text strengthText;
    Rigidbody rb;
    public Image strengthBar;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        strengthText.text = "Strenght : " + strenght.ToString();
        strengthBar.fillAmount = (float)strenght / 10;

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FinishLine")
        {
            rb.AddForce(0, 0, strenght * 5, ForceMode.Impulse);
            print("forece");

        }

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public int score = 0;
    public Text scoreText;
    GameFlow gameFlowScript;
    Rigidbody rb;

    private void Start()
    {
        gameFlowScript = FindObjectOfType<GameFlow>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        scoreText.text = "Score : " + score.ToString();
        MoveHorizontal();
        Die();
    }

    private void MoveHorizontal()
    {
        //Give the value between -1 or 1 based on the button pressed
        float MoveHorizontal = Input.GetAxis("Horizontal") * speed;

        MoveHorizontal *= Time.deltaTime;

        //Move the Player Left Right
        transform.Translate(MoveHorizontal, 0, 0);
    }

    private void Die()
    {
        if (transform.position.y <= -2f)
        {
            //Restart the level
            gameFlowScript.Restart();
        }
    }

    private void FixedUpdate()
    {
        // Move the Player forward with speed
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);

    }
}

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

    private void Start()
    {
        gameFlowScript = FindObjectOfType<GameFlow>();
    }

    void Update()
    {
        scoreText.text = "Score : "+score.ToString();
        
        //Give the value between -1 or 1 based on the button pressed
        float MoveHorizontal = Input.GetAxis("Horizontal") * speed;
        
        MoveHorizontal *= Time.deltaTime;
        

        // Move the Player forward with speed
        transform.Translate(0, 0, speed * Time.deltaTime);

        //Move the Player Left Right
        transform.Translate(MoveHorizontal, 0, 0);

        if(transform.position.y <= -2f)
        {
            //Restart the level
            gameFlowScript.Restart();
        }
    }
}

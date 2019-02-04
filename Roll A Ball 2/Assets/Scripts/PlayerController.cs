using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    public Text scoreText;
    public Text livesText;
    public Text loseText;

    private Rigidbody rb;
    private int count;
    private int score;
    private int lives;
    private int lose;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
        loseText.text = "";
        score = 0;
        lives = 3;

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKey("escape"))
            Application.Quit();


        }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score - 1;
            lives = lives - 1;
            SetCountText();
        }
        if (count == 12)

        {
            transform.position = new Vector3(21.15f, transform.position.y, -0.17f);
        }

    }

    void SetCountText ()
    {
            countText.text = "Count: " + count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }

        scoreText.text = "Score: " + score.ToString();

        livesText.text = "Lives" + lives.ToString();



        {

            if (lives == 0) ;
            loseText.text = "You Lose!";
            

        }



      



    }

  
}
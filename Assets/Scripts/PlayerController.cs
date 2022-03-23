using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float force;

    public GameObject gameOverText;
    public GameObject restartButton;
    
    public GameObject flappyBird;

    void Start()
    {
        flappyBird.SetActive(true);
        gameOverText.SetActive(false);
        restartButton.SetActive(true);

        rb.gravityScale = 0;
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * force;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }
}

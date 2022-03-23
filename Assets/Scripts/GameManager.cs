using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject flappyBirdText;
    public GameObject restartButton;

    public Rigidbody2D birdRb;

    public Transform pipeManager;
    
    public void RestartGame()
    {
        if (Time.timeScale > 0)
        {
            flappyBirdText.SetActive(false);
            restartButton.SetActive(false);
            birdRb.gravityScale = 0.6f;
            pipeManager.GetComponent<PipeManager>().StartSpawning();
        }
        else
        {
            SceneManager.LoadScene(0);   
        }
    }
}

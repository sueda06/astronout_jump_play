using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    public TMP_Text scoreText;

    private float score;

    public Transform cam;

    public GameObject panel;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (rb.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;
        }

        scoreText.text = Mathf.Round(score).ToString();

        if(cam.position.y > transform.position.y + 7f)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(
            moveX*speed,
            rb.velocity.y
            );
    }
    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }
}

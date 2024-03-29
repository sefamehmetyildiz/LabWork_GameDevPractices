using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionMechanics : MonoBehaviour
{
    public int score = 0;
    Animator animator;
    public GameObject VictoryScreen;
    public GameObject GameOverScreen;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gold"))
        {
            score++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOverScreen.SetActive(true);
            animator.SetBool("isGameStart", false);
            animator.SetBool("isDie", true);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            VictoryScreen.SetActive(true);
            animator.SetBool("isGameStart", false);
            animator.SetBool("Victory", true);
        }
    }


}

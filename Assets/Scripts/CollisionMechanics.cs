using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionMechanics : MonoBehaviour
{
    public int score = 0;
    Animator animator;
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
            animator.SetBool("isGameStart", false);
            animator.SetBool("isDie", true);
        }
        
    }


}

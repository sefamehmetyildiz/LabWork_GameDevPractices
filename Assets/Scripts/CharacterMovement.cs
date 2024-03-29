using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;
using System.Runtime.CompilerServices;
public class CharacterMovement : MonoBehaviour
{
    public float speed = 10.0F;
    float transSpeed = 0.5f;
    public bool onLeft,onRight = false , mid= true;

    Animator animator;
    Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public bool isGrounded;
    public float timer = 0;
    public GameObject startScreen;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 5.0f, 0.0f);
       
    }
    
    void OnCollisionStay()        
    {        
        isGrounded = true;        
    }
    void GroundFalse()
    {
        isGrounded = false;
    }
   
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            animator.SetBool("isGameStart", true);
        }

        if (animator.GetBool("isGameStart"))
        {
            startScreen.SetActive(false);
            timer += Time.deltaTime;
            transform.Translate(new Vector3(0,0,1)* Time.deltaTime * speed);

            if (Input.GetKeyDown(KeyCode.A) && onLeft == false && mid == true)
            {
                onLeft = true;
                mid = false;
                transform.DOMoveX(-6, transSpeed);
            }
            else if (Input.GetKeyDown(KeyCode.A) && mid == false && onRight == true)
            {
                onRight = false;
                mid = true;
                transform.DOMoveX(0, transSpeed);
            }
            if (Input.GetKeyDown(KeyCode.D) && onRight == false && mid == true)
            {
                onRight = true;
                mid = false;
                transform.DOMoveX(6, transSpeed); 
            }
            else if (Input.GetKeyDown(KeyCode.D) && onLeft == true && mid == false)
            {
                onLeft = false;
                mid = true;
                transform.DOMoveX(0, transSpeed);
            }
            //Jumping and animations
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                animator.SetTrigger("Jump");
                Invoke(nameof(GroundFalse), 0.1f);
            }
        }           
	}
    
}

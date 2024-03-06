using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CharacterMovement : MonoBehaviour
{
 public float speed = 15.0F;
 float transSpeed = 0.5f;
 public bool onLeft,onRight = false , mid= true;
	
	void Update () {

        transform.Translate(new Vector3(0,0,1)* Time.deltaTime * speed);

		if (Input.GetKeyDown(KeyCode.A) && onLeft == false && mid == true)
        {
            onLeft = true;
            mid = false;
            transform.DOMoveX(-6, transSpeed);
            //transform.position = new Vector3(-6,2,transform.position.z);   
        }
        else if(Input.GetKeyDown(KeyCode.A) && mid == false && onRight == true)
        {
            onRight = false;
            mid = true;
            transform.DOMoveX(0, transSpeed);
            //transform.position = new Vector3(0,2,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && onRight == false && mid == true)
        {
            onRight = true;
            mid = false;
            transform.DOMoveX(6, transSpeed);
            //transform.position = new Vector3(6,2,transform.position.z);   
        }
        else if(Input.GetKeyDown(KeyCode.D) && onLeft == true && mid == false)  
        {
            onLeft = false;
            mid = true;
            transform.DOMoveX(0, transSpeed);
            //transform.position = new Vector3(0,2,transform.position.z);
        }
	}
}

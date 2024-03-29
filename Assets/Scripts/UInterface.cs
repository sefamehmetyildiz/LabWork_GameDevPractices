using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UInterface : MonoBehaviour
{
    private TextMesh tm;
    public GameObject myCharacterReference;
    public GameObject myScoreCounter;
    public GameObject myTimer;
    
    
    void Update()
    {
        
        myTimer.GetComponent<Text>().text = myCharacterReference.GetComponent<CharacterMovement>().timer.ToString("F1");
        myScoreCounter.GetComponent<Text>().text = myCharacterReference.GetComponent<CollisionMechanics>().score.ToString();
    }
}

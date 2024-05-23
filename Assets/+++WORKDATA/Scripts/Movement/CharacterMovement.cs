using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
   
    //SimpleCounter
    int updateCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Start");
    }

    // Update is called once per frame
    void Update()
    {
        // updateCount = updateCount + 1;
        //Debug.Log(message: "update:" + updateCount);
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("A key was pressed");
        }

        
    }
    
    void OnJump()
    {
        Debug.Log(message: "Jump");
    }


    void OnSneak()
    {
        Debug.Log(message: "Sneak");
    }

    void OnMove()
    {
        Debug.Log(message: "Move");
    }

}
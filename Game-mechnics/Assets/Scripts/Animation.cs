using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator m_Animator;
   
    void Start()
    {
        
        m_Animator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {


            
            m_Animator.SetTrigger("Jump");

        }

    }
}

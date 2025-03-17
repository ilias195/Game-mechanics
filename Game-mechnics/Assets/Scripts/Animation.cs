using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator m_Animator;
    private string _stateName;


    void Start()
    {


        //Pak het animator component en sla die op in de variabele
        //   ani = GetComponent<Animator>();
        _stateName = "idle";

    }


    void Update()
    {

        Debug.Log("!!");

        Debug.Log(Input.GetAxis("Vertical")); 

        if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            _stateName = "idle";
            m_Animator.SetTrigger("Idle");
            m_Animator.ResetTrigger("Walk");
            Debug.Log("Stop Walking");
        }else
        {
            m_Animator.SetTrigger("Walk");
            m_Animator.ResetTrigger("Idle");
            Debug.Log("Start Walking");
        }

        if (Input.anyKeyDown)
        {
            Debug.Log("Stop Walking");
        }
    }

    
    
}

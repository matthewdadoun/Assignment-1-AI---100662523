using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    bool isOpen = false;
    public Animator animator;

    //Triggers the interaction of the door object
    public void TriggerIneraction()
    {
       
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }
}


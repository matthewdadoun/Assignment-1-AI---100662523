using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public AudioSource Hot;
    public AudioSource Noisy;
    public AudioSource notSafe;
    bool HotCheck;
    bool NoisyCheck;
    bool SafeCheck;

    public Camera camera;
    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //Detects whether the mouse is touching an object with a collider on it
        if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
        {
            //References to the created objects necessary for the mouse detection
            InteractiveObject obj = hit.collider.GetComponent<InteractiveObject>();
            DoorProperty door = hit.collider.GetComponent<DoorProperty>();

            if (door != null && door.isHot == true)
            {
                if (HotCheck == false)
                {
                    Hot.enabled = true;
                    Debug.Log("This door is hot!");
                }
                HotCheck = true;
            }

            else
            { 
                HotCheck = false;
            }

           
            if (door != null && door.isNoisy == true)
            {
                if (NoisyCheck == false)
                {
                    Noisy.enabled = true;
                    Debug.Log("This door is Noisy!");
                }
                NoisyCheck = true;
            }

            else
            {
                NoisyCheck = false;
            }

            if(Input.GetMouseButtonDown(0))
            {

                if (door != null && door.isSafe == false)
                {

                    {
                        notSafe.Play();
                        Debug.Log("This door is unsafe!");
                    }
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (obj)
                {
                    obj.TriggerIneraction();
                }



             


            }
        }
    
        else
        {
            Hot.enabled = false;
            Noisy.enabled = false;
        }
        
         
    }
}

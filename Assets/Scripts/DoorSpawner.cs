using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawner : MonoBehaviour
{
    public DoorProperty Door;
    
    void Start()
    {
   
        //Spawns doors with properties receieved from the property function
        for (int i = 0; i <= 19; i++)
        {
            Instantiate(Door);
            Door.transform.position = new Vector3(Random.Range(0.0f, 50.0f), 1.2f, Random.Range(0.0f, 50.0f));
            Door.CheckValues();

        }
    }

    // Update is called once per frame
    void Update() 
    {
    }
    
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
//Hot   Noisy Safe Door  Percentage of Doors
//Y     Y        Y                       0.05
//Y     Y        N                       0.30
//Y     N        Y                       0.03
//Y     N        N                       0.21
//N     Y        Y                       0.06
//N     Y        N                       0.11
//N     N        Y                       0.20
//N     N        N                       0.04
public class DoorProperty : MonoBehaviour
{
 
    public TextAsset probabilities;
  public  bool isHot;
  public  bool isNoisy;
   public bool isSafe;
    // Start is called before the first frame update
    void Start()
    {
    }

    //Returns each value back to assign it to each door that spawns

        //Returns values to the door spawner 
    public void CheckValues() 
    {
        string path = "Assets/Text Documents/probabilities.txt";
        StreamReader reader = new StreamReader(path);
        string wholeArray = reader.ReadToEnd();


        string[] stringArr = wholeArray.Split('\n');

        int rnd = Random.Range(0, 99);

        for(int i = 0; i<stringArr.Length; i++)
        {
            Debug.Log(stringArr[i]);
        }
        if (Mathf.Clamp(rnd, 0, 4) == rnd) //5%
        {
            isHot = true;
            isNoisy = true;
            isSafe = true;
        }

        else if (Mathf.Clamp(rnd, 5, 34) == rnd) //30%
        {
            isHot = true;
            isNoisy = true;
            isSafe = false;
        }

        else if (Mathf.Clamp(rnd, 35, 37) == rnd) //3%
        {
            isHot = true;
            isNoisy = false;
            isSafe = true;
        }

        else if (Mathf.Clamp(rnd, 38, 58) == rnd) //21%
        {
            isHot = true;
            isNoisy = false;
            isSafe = false;
        }

        else if (Mathf.Clamp(rnd, 59, 64) == rnd)//6%
        {
            isHot = false;
            isNoisy = true;
            isSafe = true;
        }

        if (Mathf.Clamp(rnd, 65, 75) == rnd)//11%
        {
            isHot = false;
            isNoisy = true;
            isSafe = false;
        }

        if (Mathf.Clamp(rnd, 76, 95) == rnd)//20%
        {
            isHot = false;
            isNoisy = false;
            isSafe = true;
        }

        if (Mathf.Clamp(rnd, 96, 99) == rnd)//4%
        {
            isHot = false;
            isNoisy = false;
            isSafe = false;
        }

    }
    // Update is called once per frame

    void Update()
    {
        
    }

}

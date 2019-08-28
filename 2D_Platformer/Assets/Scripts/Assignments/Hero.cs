using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    string name = "Peter Parker";
    int age  = 21;
    float height = 5.8f;
    bool powers = true; 




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Powers: " + powers);
    }

    
}

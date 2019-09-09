using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HWFun1 : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    int num1;
    int num2;
    int num3;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        // firstName = "John";

        // lastName = "Doe";

        // age = 32;

        // Customer(firstName, lastName, age);
        CalcAdd(6,14,20);

    }

   int CalcAdd (int n1, int n2, int n3)
   {
       Debug.Log("Number 1 = " + n1 + "Number 2 = " + n2 + "Number 3 = " + n3);
       total = n1 + n2 + n3;
        Debug.Log(total);
       return total;
       
    }

    // void Customer(string fName, string lName, int a)
    // {
    //     Debug.Log(fName + " " + lName + " " + a);
    // }
}

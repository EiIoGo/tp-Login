using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    const string password = "admin";

    public InputField TXTpassword;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPassword()
    {
        if(TXTpassword.text == password)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}

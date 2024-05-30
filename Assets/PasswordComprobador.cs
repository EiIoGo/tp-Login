using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordComprobador : MonoBehaviour
{
    const string pass = "12345";

    public InputField password;
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Presionar()
    {
        if(password.text == pass)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}

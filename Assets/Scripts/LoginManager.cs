using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //tropheo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void tropheo()
    {
        GameJoltUI.Instance.ShowSignIn((bool signedIn) =>
        {
            if (signedIn)
            {
                SceneManager.LoadScene("Nivel 1");
            }
        });
    }
}

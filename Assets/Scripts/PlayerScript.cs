using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.API.Objects;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] bool sesion;
    [SerializeField] int trofeos;
    public int kill;
    [SerializeField] GameObject bulllet;
    [SerializeField] int killMax;
    [SerializeField] int Nextscene;

    enum trp
    {
        LV1,LV2, LV3
    }

    void Start()
    {
        if (sesion)
        {
            tropheo();
        }
    }
    void Update()
    {
        if(kill >= killMax)
        {
            Win(Nextscene);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject a = Instantiate(bulllet);
            a.transform.position = transform.position + new Vector3(1f,0,0);
        }
    }
    void tropheo()
    {
        Trophies.Get(198269, (Trophy trophy) =>
        {
            if (trophy != null)
            {
                Trophies.TryUnlock(trophy, (TryUnlockResult result) =>
                {
                    switch (result)
                    {
                        case TryUnlockResult.Unlocked:
                            Debug.Log("Desbloqueo con exito");
                            break;
                        case TryUnlockResult.AlreadyUnlocked:
                            Debug.Log("DeYa estaba desbloqueado");
                            break;
                        case TryUnlockResult.Failure:
                            Debug.Log("Fallo");
                            break;
                    }
                });
            }
        });
    }


    void Win(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    //Derrota
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        SceneManager.LoadScene("Derrota");
    }
}

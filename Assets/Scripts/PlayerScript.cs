using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.API.Objects;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}

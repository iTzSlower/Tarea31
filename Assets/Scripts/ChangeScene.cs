using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

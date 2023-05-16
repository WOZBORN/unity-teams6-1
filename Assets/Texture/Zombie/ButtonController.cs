using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}

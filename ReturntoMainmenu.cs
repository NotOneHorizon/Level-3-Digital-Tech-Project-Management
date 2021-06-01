using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMainmenu : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}

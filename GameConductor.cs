using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConductor : MonoBehaviour
{
    bool gameHasConcluded = false;

    public float restartDelay = 1f;

    public void EndGame()
    {
        if (gameHasConcluded == false)
        {
            gameHasConcluded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

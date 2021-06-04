using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameConductor gameManager;

    private void OnTriggerEnter2D()
    {
        gameManager.CompleteLevel();
    }
}

using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public PlayerMovement movement;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;
    }
}

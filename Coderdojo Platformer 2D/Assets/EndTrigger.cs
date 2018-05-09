using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter2D ()
    {
        Debug.Log("LEVEL WON!");
        // gameManager.CompleteLevel();
    }
 

}

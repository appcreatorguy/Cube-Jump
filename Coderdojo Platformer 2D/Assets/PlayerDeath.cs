using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public GameManager GameManager;

	void Update () {
        if (transform.position.y < 20f)
        {
            GameManager.EndGame();
        }
	}
}

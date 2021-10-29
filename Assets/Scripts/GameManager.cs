using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        GameEnded();
    }

    void GameEnded()
    {
        if (FindObjectOfType<PlinkoBallController>().isEnded)
            if (Input.anyKey)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

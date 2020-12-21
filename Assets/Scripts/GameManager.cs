using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame ()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            // 2sec delay
            Invoke("Restart", 2f);
        }
    }

    void Restart() 
    {
        // SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelui;
   
    public void completelevel()
    {
        completelevelui.SetActive(true);
    }
    public void Endgame ()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER");
            Invoke("restart", restartdelay);

        }
                  
    }

    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;
    void OnTriggerEnter ()
    {
        gamemanager.completelevel();
    }
}

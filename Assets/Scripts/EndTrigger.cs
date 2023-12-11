using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        Debug.Log("Collision Ocurred");
        playerMovement.endTrigger = true;
    }
}
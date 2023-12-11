using UnityEngine;

public class DestroyerScript : MonoBehaviour
{

    public void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.tag == "Obstacle")
            Destroy(obstacle.gameObject);
        Debug.Log("Collision Ocurred");
    }
}

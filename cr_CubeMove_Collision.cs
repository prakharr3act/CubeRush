using UnityEngine;

public class playerCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "obstacle")
        {
            Debug.Log("Game Over");
        }
    }
}

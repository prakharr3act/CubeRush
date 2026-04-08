using UnityEngine;

public class playerCollision : MonoBehaviour
{
   
    void OnCollisionEnter( )
    {
        Debug.Log("Collided with an object!");
    }
}

using UnityEngine;

public class playerCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
    }
}

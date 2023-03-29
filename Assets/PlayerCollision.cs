using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    int flag = 0;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" && flag == 0)
        {
            Debug.Log("We hit an obstacle!");
            //movement.enabled = false;
            flag = 1;
        }
        
    }
}

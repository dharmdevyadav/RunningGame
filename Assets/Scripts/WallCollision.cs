

using UnityEngine;

public class CollisionBody : MonoBehaviour
{
    [SerializeField] PlayerMovement moment;
    
    
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Wall")
        {

            moment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

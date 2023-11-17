using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform Player;
    public Vector3 Offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Player.position+Offset;
    }
}

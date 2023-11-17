using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
       
        gameManager.CompleteLevel();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPage : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject NextLevelUI;
    void OnTriggerEnter(Collider other)
    {
        NextLevelUI.SetActive(true);
        gameManager.Finished();

    }
}

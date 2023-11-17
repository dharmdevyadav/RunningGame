
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform Player;
    
    [SerializeField] TextMeshProUGUI Scoretext;

    
    void Update()
    {
        Scoretext.text = Player.position.z.ToString("0");
    }
}

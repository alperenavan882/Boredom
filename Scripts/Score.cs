

using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public Transform player; //oyuncunun scale,rotation gibi bilgilerini alacak. Transform ile
    public TextMeshProUGUI scoreText;
    
    
    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = player.position.z.ToString("0");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //Eðer çarptýðýmýz nesnenin tagý Obstacle ise(devamý aþaðýda.) Normalde adý yapmýþtýk fakat büyük çaplý bir oyun yaparsak ve obstacle'lardan 1000lerce yaparsak iþler karýþacaðý için tag yoluyla daha kolay yapabileceðimizi öðrendik.
        {
            movement.enabled = false; //Burada üstten unity'de public yapýp birbiriyle iliþkilendirdiðimiz playermovement kodundaki movement hareketini deðiþtirdik.
            FindObjectOfType<GameManager>().EndGame(); //Oyunu bitirirken Player'imiz kaybolacaðý için burada kodlar da kaybolacaktý bu yüzden public yapýp variable tanýmlamaktansa direkt olarak bu komutla çektik.

        }
    }









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

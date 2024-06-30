using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //E�er �arpt���m�z nesnenin tag� Obstacle ise(devam� a�a��da.) Normalde ad� yapm��t�k fakat b�y�k �apl� bir oyun yaparsak ve obstacle'lardan 1000lerce yaparsak i�ler kar��aca�� i�in tag yoluyla daha kolay yapabilece�imizi ��rendik.
        {
            movement.enabled = false; //Burada �stten unity'de public yap�p birbiriyle ili�kilendirdi�imiz playermovement kodundaki movement hareketini de�i�tirdik.
            FindObjectOfType<GameManager>().EndGame(); //Oyunu bitirirken Player'imiz kaybolaca�� i�in burada kodlar da kaybolacakt� bu y�zden public yap�p variable tan�mlamaktansa direkt olarak bu komutla �ektik.

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
    void Start()
    {
        // Spawner tag'li nesneyi bul
        GameObject spawner = GameObject.FindGameObjectWithTag("Spawner");

        // Player tag'li nesneyi bul
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Eğer Spawner ve Player bulunduysa
        if (spawner != null && player != null)
        {
            // Player'ı Spawner'ın pozisyonuna taşı
            player.transform.position = spawner.transform.position;

            // Player'ın Rigidbody2D bileşenini bul
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

            // Eğer Rigidbody2D bulunduysa, yerçekimini devre dışı bırak ve hareketi dondur
            if (rb != null)
            {
                rb.gravityScale = 0;  // Yerçekimini devre dışı bırak
                rb.velocity = Vector2.zero;  // Hızını sıfırla
                rb.constraints = RigidbodyConstraints2D.FreezeAll;  // Tüm hareketleri dondur
            }
        }
        else
        {
            Debug.LogWarning("Spawner veya Player bulunamadı!");
        }
    }
        
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class elmarespawner : MonoBehaviour
{
    [SerializeField] private GameObject elmaprefab;
    [SerializeField] private TMP_Text Kalanzaman;
    
    public float timer;
    
    

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Kalanzaman.SetText("Zorunlu üretime kalan: " + timer.ToString("F2"));

        if (timer <= 0)
        {
            spawnapple();
            timer = 3;
            // oyun zorlaþsýn diye timer dolduðunda otomatik elma üretimi ekledim ve bunu ekrana yazdýrdým.
        
        
        
        
        
        
        }       
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            spawnapple();
            timer = 3;
  
        }
            
    }      
    private void spawnapple()
    {
        Vector3 kamera = Camera.main.transform.position;
        // kameramýn konumunu aldým

        Instantiate(elmaprefab, new Vector3(kamera.x, kamera.y - 3f, kamera.z), Quaternion.identity);
        // kameramýn 3 birim altýnda elma oluþturdum
    }

}


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
        Kalanzaman.SetText("Zorunlu �retime kalan: " + timer.ToString("F2"));

        if (timer <= 0)
        {
            spawnapple();
            timer = 3;
            // oyun zorla�s�n diye timer doldu�unda otomatik elma �retimi ekledim ve bunu ekrana yazd�rd�m.
        
        
        
        
        
        
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
        // kameram�n konumunu ald�m

        Instantiate(elmaprefab, new Vector3(kamera.x, kamera.y - 3f, kamera.z), Quaternion.identity);
        // kameram�n 3 birim alt�nda elma olu�turdum
    }

}


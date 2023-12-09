using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sepetspawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnpoint;

    [SerializeField] private TMP_Text skortext;
    public int sayac = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elma"))
        {   
            sepetspawnr(); 
            sayac += 1;
            skortext.SetText("Skor: " + sayac);
            Destroy(other.gameObject);

            // skor yazýsýný 1 arttýrýr ve elmayý siler.


        }
    }

    private void sepetspawnr()
    {
        int index = Random.Range(0, spawnpoint.Length);


        transform.position = spawnpoint[index].position;

        //rastgele seçilmiþ bir spawnpoint konumuna taþýr
    }


}


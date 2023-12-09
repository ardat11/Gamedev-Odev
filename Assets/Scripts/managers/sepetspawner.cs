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

            // skor yaz�s�n� 1 artt�r�r ve elmay� siler.


        }
    }

    private void sepetspawnr()
    {
        int index = Random.Range(0, spawnpoint.Length);


        transform.position = spawnpoint[index].position;

        //rastgele se�ilmi� bir spawnpoint konumuna ta��r
    }


}


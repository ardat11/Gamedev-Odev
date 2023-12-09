using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private TMP_Text cantext;
    public int health;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elma"))
        {
            health--;
            cantext.SetText("Can:  " + health);
            Destroy(other.gameObject);
            // can yazýsýný 1 azaltýr ve elmayý siler.

        }

    }
}

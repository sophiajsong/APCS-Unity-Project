using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    private int cherries = 0;

    private void OnTriggerEnter2D (Collider2D collision) {
      if (collision.gameObject.CompareTag("cherry")) {
        Destroy(collision.gameObject);
        cherries++;
        Debug.Log("Cherries: " + cherries);
      }
    }
}

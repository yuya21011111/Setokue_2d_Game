using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemGet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�A�C�e���擾�I�I");
            transform.position = ItemInventory.instance.ItemSlot.transform.position;
        }
    }
}
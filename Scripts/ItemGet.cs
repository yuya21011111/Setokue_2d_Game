using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemGet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("アイテム取得！！");
            transform.position = ItemInventory.instance.ItemSlot.transform.position;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update

    public float waitTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(waitTime > 0)
        {
            waitTime -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("アイテム取得！！");
            transform.position = ItemInventory.instance.ItemSlot.transform.position;
        }
    }
}

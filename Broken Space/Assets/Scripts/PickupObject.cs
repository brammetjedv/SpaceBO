using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
    public bool itemUSB;
    public bool itemBlowtorch;
    public bool itemWrench;
    public bool itemWiring;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(itemUSB == true)
            {
                Inventory.USB = true;
                Destroy(gameObject);
                Debug.Log("usb = " + Inventory.USB);
            }

            if (itemBlowtorch == true)
            {
                Inventory.Blowtorch = true;
                Destroy(gameObject);
                Debug.Log("Blowtorch = " + Inventory.Blowtorch);
            }

            if (itemWrench == true)
            {
                Inventory.Wrench = true;
                Destroy(gameObject);
                Debug.Log("Wrench = " + Inventory.Wrench);
            }

            if (itemWiring == true)
            {
                Inventory.Wiring = true;
                Destroy(gameObject);
                Debug.Log("Wiring = " + Inventory.Wiring);
            }
        }
    }
    void Update()
    {
       
    }
}



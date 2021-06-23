using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comms : MonoBehaviour
{
    private bool startTimer = false;
    private float timer;
    public GameObject Box;



    public static bool showtext;
    // Start is called before the first frame update
    void Start()
    {
        void OnCollisionExit(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                startTimer = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5.0f)
        {
            Box.SetActive(false);
            startTimer = false;
            timer = 0;
        }
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            if(Inventory.allItems == true)
            {
                Debug.Log("You're at comms with all items");
                Inventory.USB = false;
                Inventory.Wiring = false;
                Inventory.Wrench = false;
                Inventory.Blowtorch = false;
                Inventory.Keycard = false;
                showtext = false;
                
            }

            if (Inventory.allItems == false)
            {
                Debug.Log("You need all the items");
                showtext = true;
                Box.SetActive(true);

                //delay
                //showtext = false;

            }
        }
    }
}

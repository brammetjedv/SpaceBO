using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public static bool USB;
    public static bool Blowtorch;
    public static bool Wrench;
    public static bool Wiring;
    public static bool Keycard;

    public static bool allItems;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (USB == true)
        {
            if(Blowtorch == true)
            {
                if(Wrench == true)
                {
                    if(Wiring == true)
                    {
                        if (Keycard == true)

                        {
                            allItems = true;
                            Debug.Log(allItems + "all items");
                        }
                    }
                }
            }
        }
    }
}

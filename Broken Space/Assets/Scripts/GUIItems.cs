using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIItems : MonoBehaviour
{
    public Text utext;
    public Text wText;
    public Text wiText;
    public Text bText;
    public Text Ntext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.USB == true)
        {
            utext.text = "USB";
        }
        if (Inventory.USB == false)
        {
            utext.text = " ";
        }



        if (Inventory.Wrench == true)
        {
            wText.text = "WRENCH";
        }
        if (Inventory.Wrench == false)
        {
            wText.text = " ";
        }


        if (Inventory.Blowtorch == true)
        {
            bText.text = "BLOWTORCH";
        }
        if (Inventory.Blowtorch == false)
        {
            bText.text = " ";
        }


        if (Inventory.Wiring == true)
        {
            wiText.text = "WIRING";
        }
        if (Inventory.Wiring == false)
        {
            wiText.text = " ";
        }

        if (Comms.showtext == true)
        {
            Ntext.text = "You Need More Items";
        }

        if(Comms.showtext == false)
        {
            Ntext.text = " ";
        }
    }
}

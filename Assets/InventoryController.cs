using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    void Start()
    {
        
    }
 public GameObject[] InventorySlots;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SelectSlot(0); // Slot 1
            }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SelectSlot(1); // Slot 2
            }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SelectSlot(2); // Slot 3
            }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SelectSlot(3); // Slot 4
            }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                SelectSlot(4); // Slot 5
            }
        

    }

    void SelectSlot(int index)
    {
        //Intervall för inventory gränserna
        if (index >= 0 && index < InventorySlots.Length)
        {
            // Perform actions to select the slot (e.g., change appearance, perform actions)
            Debug.Log("Selected slot " + (index + 1));
        }
    }
}


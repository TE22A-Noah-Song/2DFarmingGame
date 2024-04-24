using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryController : MonoBehaviour
{
    public Image[] InventorySlots;
    public Sprite RedSquareSprite;
    private int selectedSlotIndex = -1;

    void Update()
    {
        // kolla input för vald slot
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                SelectSlot(i);
                break; // gå ut ur loopen efter vald slot
            }
        }
    }

    void SelectSlot(int index)
    {
        // Ta bort tidigare vald slot
        if (selectedSlotIndex != -1)
        {
            // åteställ färg
            if(selectedSlotIndex != index)
            {
                InventorySlots[selectedSlotIndex].color = Color.white;
            }
        }

        // Välj nya slots
        if (index >= 0 && index < InventorySlots.Length)
        {
            InventorySlots[index].color = Color.red; // Markera den valda sloten med röd färg
            selectedSlotIndex = index;

            // Debugga vald slot
            Debug.Log("Selected slot " + (index + 1));
        }
    }
}

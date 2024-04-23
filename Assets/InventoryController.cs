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
        // Check for input to select slots
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                SelectSlot(i);
                break; // Exit loop after selecting a slot
            }
        }
    }

    void SelectSlot(int index)
    {
        // Deselect previous slot if one was selected
        if (selectedSlotIndex != -1)
        {
            // Reset color only if it's not the currently selected slot
            if(selectedSlotIndex != index)
            {
                InventorySlots[selectedSlotIndex].color = Color.white;
            }
        }

        // Select new slot
        if (index >= 0 && index < InventorySlots.Length)
        {
            InventorySlots[index].color = Color.red; // Highlight the selected slot
            selectedSlotIndex = index;

            // Debug selected slot
            Debug.Log("Selected slot " + (index + 1));
        }
    }
}

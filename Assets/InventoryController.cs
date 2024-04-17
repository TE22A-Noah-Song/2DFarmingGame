using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public Image[] InventorySlots;
    public Sprite RedSquareSprite;

    public int selectedSlotIndex = -1;

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
        // Välj nya sloten
        if (index >= 0 && index < InventorySlots.Length)
        {
            InventorySlots[index].sprite = RedSquareSprite;
            selectedSlotIndex = index;


            // debug vald slot
            Debug.Log("Selected slot " + (index + 1));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Useful resources:
//https://www.youtube.com/watch?v=2WnAOV7nHW0
//https://www.youtube.com/watch?v=w6_fetj9PIw
//https://www.youtube.com/watch?v=BGr-7GZJNXg

//This script is used to display graphuically the data from the inventory script
public class UI_Inventory : MonoBehaviour
{
    private Inventory inv; //create inventory type (which holds all the item data)
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Awake()
    {
        itemSlotContainer = transform.Find("ItemSlotContainer"); //get the item slot container of the inventory
        itemSlotTemplate = itemSlotContainer.Find("ItemSlot"); //get the item slot of said container
    }

    public void SetInv(Inventory inv) //set the inventory of this object to the generic inventory
    {
        this.inv = inv;
    }
    
    private void RefreshInvItems() //refresh the items to make sure they're updated
    {
        foreach (Item item in inv.GetItemList()) //Runs through each item in the loop (of the local getItemList)
        {
            RectTransform itemSlotRectTransform =
                Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            //Unfinished... (according to the tutorial I'm following)
        }
    }
}

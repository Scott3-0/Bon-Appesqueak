using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Useful resources:
//https://www.youtube.com/watch?v=bTPEMt1RG3s //8:54 in here
//https://www.youtube.com/watch?v=2WnAOV7nHW0
//https://www.youtube.com/watch?v=w6_fetj9PIw
//https://www.youtube.com/watch?v=BGr-7GZJNXg

//This script is used to display graphuically the data from the inventory script
/*
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
        RefreshInvItems();
    }
    
    private void RefreshInvItems() //refresh the items to make sure they're updated
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;

        foreach (Item item in inv.GetItemList()) //Runs through each item in the loop (of the local getItemList)
        {
            RectTransform itemSlotRectTransform =
                Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();

            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            x++;

            if (x > 1)
            {
                x = 0;
                y++;
            }
        }
    }
}
*/
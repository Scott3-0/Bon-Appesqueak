using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item //item types class
{
    public enum ItemType //place all new items in here
    {
        //raw ingredients
        Bread,
        Butter,

        //Intermediate Dishes / Ingredients / Steps
        Toast,

        //Dishes
        ButteredToast,

        //Servable Dishes
        S_ButteredToast
    }

    public ItemType itemType;
    public int amount;
}

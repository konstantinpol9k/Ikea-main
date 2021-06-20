using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="mebel",menuName ="Inventory/Items/New mebel")]
public class mebel : ItemScriptableObject
{

    private void Start()
    {
        itemType = ItemType.chair;
        itemType = ItemType.bed;
        itemType = ItemType.table;
    }
}

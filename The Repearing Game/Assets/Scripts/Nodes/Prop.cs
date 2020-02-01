using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Prop : Node
{
    public Location loc;
    public Item item;
    public Object dest;
    
    

    void Update()
    {
        if (Input.GetKeyDown("space") && item != null && GameManager.ins.currentNode == this)
        {
            
            Inventory.inv.AddItem(item);
            loc.Arrive();
            Destroy(dest);
            
                
        }

    }
}
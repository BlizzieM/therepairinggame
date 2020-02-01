using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "My Assets/Items")]
public class Item : ScriptableObject

{
    public Sprite sprite;
    public GameObject itemObject;

    public void PointerDownEvent(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

}
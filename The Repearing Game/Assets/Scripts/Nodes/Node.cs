using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour 
{
    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();
    //<lists> in angle brackets,[arrays] in square brackets


    [HideInInspector]
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
    }

    void OnMouseDown()
    {
        Camera.main.transform.position = cameraPosition.position;
        Camera.main.transform.rotation = cameraPosition.rotation;
    }

}

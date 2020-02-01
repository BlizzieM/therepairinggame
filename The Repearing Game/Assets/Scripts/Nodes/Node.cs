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
        Arrive ();
    }

    public void Arrive()
    {
        //leave existing current node
        if (GameManager.ins.currentNode != null)
        {
            GameManager.ins.currentNode.Leave();
        }
        //set currentNode
        GameManager.ins.currentNode = this;

        //move the camera
        Camera.main.transform.position = cameraPosition.position;
        Camera.main.transform.rotation = cameraPosition.rotation;

        //turn off our own collider
        if (col != null)
            col.enabled = false;

        //turn on all reachable node's colliders
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = true;
            }
        }



    }

    public void Leave()
    {
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = false;
            }
        }
    }
}

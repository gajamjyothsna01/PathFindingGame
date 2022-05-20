using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public enum NodeType //Two different node constants
    {
        Open = 0,
        Blocked = 1
    }
public class Node
{
    public NodeType nodeType = NodeType.Open; //Default node, which is open

    public int xIndex = -1; //index of rows of 2Dimesional array
    public int yIndex = -1; //index of coloums

    public Vector3 position; //position of the node based on the index

    public List<Node> neighbors = new List<Node>(); //List of neighbours 

    public Node previous = null; //previous node

    public Node(int xIndex, int yIndex, NodeType nodeType) //This is a constructor to initialize the values
    {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
        this.nodeType = nodeType;
    }

    public void Reset() //Reset the nodes in the graph
    {
        previous = null;
    }
}



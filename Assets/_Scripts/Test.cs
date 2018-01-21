using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Grid grid;
    private int width = 5;
    private int height = 5;

    private List<Node> stack = new List<Node>();

    private void Start()
    {
        grid = new Grid(width, height);
        werk(0, 0);
        //show();
    }

    private void werk(int x, int y)
    {
        Node currentNode = grid.getNode(x, y);
        currentNode.cube.GetComponent<MeshRenderer>().material.color = Color.red;
        if (!currentNode.Visited)
        {
            currentNode.Visited = true;
            stack.Add(currentNode);
        }
        List<Node> neighbours = new List<Node>();

        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                if (Mathf.Abs(i) == Mathf.Abs(j))
                    continue;

                int nX = x + i;
                int nY = y + j;

                if (!grid.nodeExists(nX, nY))
                    continue;

                Node tmpN = grid.getNode(nX, nY);

                if (tmpN.Visited)
                    continue;

                neighbours.Add(tmpN);
            }
        }

        if (neighbours.Count != 0)
        {
            int r = Random.Range(0, neighbours.Count);
            Node tmp = neighbours[r];
            werk(tmp.X, tmp.Y);
        }
        else
        {
            if (stack.Count <= 1)
                return;
            
            stack.RemoveAt(stack.Count - 1);
            Node tmp = stack[stack.Count - 1];
            werk(tmp.X, tmp.Y);
        }
    }

    //private void show()
    //{
    //    for (int i = 0; i < width; i++)
    //    {
    //        for (int j = 0; j < height; j++)
    //        {
    //            if(grid.getNode(i, j).Visited)
    //            {
    //                GameObject tmp = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //                tmp.transform.position = new Vector3(i, 0, j);   
    //            }

    //            //Debug.Log(grid.getNode(i, j).Value);
    //        }
    //    }
    //}
}

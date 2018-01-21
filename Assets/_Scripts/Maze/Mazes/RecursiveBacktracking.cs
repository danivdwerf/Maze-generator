using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursiveBacktracking : Maze
{
    private List<Node> stack = new List<Node>();

    public override void create(Grid grid, int startX, int startY)
    {
        this.grid = grid;
        createMaze(startX, startY);
    }

    private void createMaze(int startX, int startY)
    {
        Node currentNode = grid.getNode(startX, startY);
        if (!currentNode.Visited)
        {
            currentNode.cube.GetComponent<MeshRenderer>().material.color = Color.red;
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

                int nX = startX + i;
                int nY = startY + j;

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
            createMaze(tmp.X, tmp.Y);
        }
        else
        {
            if (stack.Count <= 1)
                return;

            stack.RemoveAt(stack.Count - 1);
            Node tmp = stack[stack.Count - 1];
            createMaze(tmp.X, tmp.Y);
        }
    }
}

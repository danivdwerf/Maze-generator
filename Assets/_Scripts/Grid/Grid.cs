using UnityEngine;

public class Grid
{
    private Node[,] grid;

    private int width;
    public int Width{get{return this.width;}}

    private int height;
    public int Height{get{return this.height;}}

    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        if (this.width < 0 || this.height < 0)
        {
            Debug.LogError("Values should be greater than 0");
            return;
        }

        this.createGrid();
    }

    private void createGrid()
    {
        this.grid = new Node[this.width, this.height];

        for (int i = 0; i < this.width; i++)
        {
            for (int j = 0; j < this.height; j++)
                this.grid[i, j] = new Node(i, j);
        }
    }

    public Node getNode(int x, int y)
    {
        return (this.nodeExists(x, y)) ? this.grid[x, y] : null;
    }

    public void reset()
    {
        for (var i = 0; i < this.width; i++)
        {
            for (var j = 0; j < Height; j++)
                this.grid[i, j] = new Node(i, j);
        }
    }

    public bool nodeExists(int x, int y)
    {
        return (this.grid[x, y] == null);
    }
}
using UnityEngine;

public class Node
{
    private Vector2 position;
    public Vector2 Position { get { return this.position; } }
    public int X { get { return (int)this.position.x; } }
    public int Y { get { return (int)this.position.y; } }


    public Node(int x, int y)
    {
        this.position = new Vector2(x, y);
    }
}
using UnityEngine;

public class Node
{
    private Vector2 position;
    public Vector2 Position { get { return this.position; } }
    public int X { get { return (int)this.position.x; } }
    public int Y { get { return (int)this.position.y; } }

    private bool visited = false;
    public bool Visited{ get { return this.visited; } set { this.visited = value; }}

    public GameObject cube;


    public Node(int x, int y)
    {
        this.position = new Vector2(x, y);
        this.cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        this.cube.transform.position = new Vector3(this.X, 0, this.Y);
    }
}
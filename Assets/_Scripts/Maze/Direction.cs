using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction
{
    private string name;
    public string Name{ get { return this.name; }}

    private byte value;
    public byte Value{ get { return this.value; }}

    private int dx;
    public int DeltaX{ get { return this.dx; }}

    private int dy;
    public int DeltaY { get { return this.dy; } }

    private Direction opposite; 
    public Direction Opposite{ get { return this.opposite; } set { this.opposite = value; }} 

    public Direction(string name, byte value, int dx, int dy)
    {
        this.name = name;
        this.dx = dx;
        this.dy = dy;
    }

    public Direction(string name, byte value, int dx, int dy, Direction opposite)
    {
        this.name = name;
        this.dx = dx;
        this.dy = dy;
        this.opposite = opposite;
    }

    public void setOpposite(Direction opposite)
    {
        this.opposite = opposite;
    }
}

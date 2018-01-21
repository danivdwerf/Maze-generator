using UnityEngine;

public abstract class Maze : MonoBehaviour
{
    protected Grid grid;
    public abstract void create(Grid grid, int startX, int startY);
}

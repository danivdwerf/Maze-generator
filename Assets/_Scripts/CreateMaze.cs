using UnityEngine;

public class CreateMaze : MonoBehaviour 
{
    private MazeFactory factory;

    private void Start()
    {
        this.factory = this.GetComponent<MazeFactory>();
        Grid grid = new Grid(20, 20);
        factory.createMaze(MazeType.RECURSIVE_BACKTRACKING, grid, 0, 0);
    }
}

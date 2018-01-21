using UnityEngine;

public enum MazeType { RECURSIVE_BACKTRACKING };

public class MazeFactory : MonoBehaviour
{
    private RecursiveBacktracking backtrackingMaze;

    private void Start()
    {
        this.backtrackingMaze = this.GetComponent<RecursiveBacktracking>();
    }

    public void createMaze(MazeType type, Grid grid, int startX, int startY)
    {
        if (type == MazeType.RECURSIVE_BACKTRACKING)
            backtrackingMaze.create(grid, startX, startY);
    }
}

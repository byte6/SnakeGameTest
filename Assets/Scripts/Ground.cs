using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField]
    private GroundCell GroundPrefab;

    [SerializeField]
    private int maxRows = 10;

    [SerializeField]
    private int maxCols = 20;

    private List<GroundCell> groundCells = new List<GroundCell>();


    public void Start()
    {
        SpawnGround();
    }

    private void SpawnGround()
    {
        for (int row = 0; row < maxRows; row++)
        {
            for (int col = 0; col < maxCols; col++)
            {
                GroundCell groundCell = Instantiate(GroundPrefab);
                groundCell.SetGroundCell(row, col);

            }
        }
    }

    
    public GroundCell GetGroundCell(Vector2 pos)
    {
        foreach(GroundCell cell in groundCells)
        {
            Vector3 cellPosition = cell.transform.position;

            float cellRight = cell.transform.position.x + cell.width/2;
          
            float cellTopEnd = cell.transform.position.y + cell.height / 2;
            
            
        }
        return null;
    }
}

public class GroundCell : MonoBehaviour
{
    public int row = 0, col = 0;

    public int width = 0, height = 0;

    public void SetGroundCell(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

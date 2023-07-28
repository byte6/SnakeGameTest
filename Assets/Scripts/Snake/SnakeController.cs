using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SnakeController : MonoBehaviour
{

    [SerializeField]
    private int snakeLength = 4;

    [SerializeField]
    private int snakeMaxLength = 0;

    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float bulletSpeed = 0f;

    [SerializeField]
    private float shootingRate = 0f;

    [SerializeField]
    private SnakeHead snakeHeadPrefab;

    [SerializeField]
    private SnakeBody snakeBodyPrefab;

    [SerializeField]
    private SnakeTail snakeTailPrefab;

    private List<ISnakeBodyPart> snakeBodyParts = new List<ISnakeBodyPart>();

    private Vector2 snakePosition = new Vector2(0, 0);

    private GameObject snakeContainer;

    private void Start()
    {
        SpawnSnake();
    }


    //SpawnSnake

    private void SpawnSnake()
    {
        snakeContainer = new GameObject();

        var snakeHeadGO = Instantiate(snakeHeadPrefab, snakeContainer.transform);
        snakeBodyParts.Add(snakeHeadGO);
        snakeHeadGO.Set(SnakeBodyPart.Head, 0);

        SnakeBody snakeBody;

        for(int i = 1; i< snakeLength - 1; i++)
        {
            snakeBody = Instantiate(snakeBodyPrefab, snakeContainer.transform);
            snakeBodyParts.Add(snakeBody);
            snakeBody.Set(SnakeBodyPart.Body, i);
        }


        var snakeTail = Instantiate(snakeTailPrefab, snakeContainer.transform);
        snakeBodyParts.Add(snakeTail);
        snakeHeadGO.Set(SnakeBodyPart.Tail, snakeLength - 1);

    }


    // Snake can move

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            snakePosition.y += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            snakePosition.y -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            snakePosition.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            snakePosition.x += moveSpeed * Time.deltaTime;
        }

        snakeContainer.transform.position = new Vector3(snakePosition.x, snakePosition.y);
    }

    // Snake can consume apples

    // Snake can shoot the apples at enemies

    // Snake can collide with wall
}

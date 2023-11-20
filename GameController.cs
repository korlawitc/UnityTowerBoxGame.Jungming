using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public BoxSpawner boxSpawner;
    public Box currentBox;
    public CameraFollow cameraFollow;
    public int score;
    public Text scoretxt;
    public int moveCount;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseInput();
    }

    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }
    public void SpawnNewBox()
    {
        Invoke("NextBox", 2f);
    }
    public void NextBox()
    {
        boxSpawner.SpawnBox();
    }
    public void addScore()
    {
        score++;
        scoretxt.text = "" + score;
    }
    public void MoveCamera()
    {
        moveCount++;
        if (moveCount == 2)
        {
            moveCount = 0;
            cameraFollow.targetPos.y += 2f;
        }
    }
}
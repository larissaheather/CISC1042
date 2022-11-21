using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject GreenBall;
    public Vector3 firstPosition;
    public float gap = 2;
    public GameObject objectToCreate;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        Vector3 position = firstPosition;
        for (int i = 0; i < 5; i++)
        {

            // Homework: Do something interesting here
            Destroy(GreenBall);
            Instantiate(objectToCreate, position, Quaternion.identity);
            position.x += gap;
        }
    }
}




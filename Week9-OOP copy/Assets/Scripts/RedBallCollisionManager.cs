using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject RedBall;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        Destroy(RedBall);
        Instantiate(RedBall, transform.position, transform.rotation);

    }
}






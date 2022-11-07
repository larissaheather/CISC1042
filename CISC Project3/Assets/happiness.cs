using System;

public class happiness
{
    private float car;
    private float door;
    private float food;

    public happiness()
    {
        // Default values for my instantiated happiness.
        car = 0f;
        door = 0f;
        food = 0f;
    }

    public happiness(float newCar, float newDoor, float newFood)
    {
        // Should consider testing for positive numbers before accepting the parameters

        car = newCar;
        door = newDoor;
        food = newFood;
    }

    public float GetHappiness()
    {
        return 40 * car + 10 * door + food;
    }

    public float GetCar()
    {
        return car;
    }

    public void SetCar(float newCar)
    {
        car = newCar;
    }

    public float GetDoor()
    {
        return door;
    }

    public void SetDoor(float newDoor)
    {
        door = newDoor;
    }

    public float GetFood()
    {
        return food;
    }

    public void SetFood(float newFood)
    {
        food = newFood;
    }
}


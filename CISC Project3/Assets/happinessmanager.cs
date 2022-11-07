using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class happinessmanager : MonoBehaviour
{
    private happiness myhappiness;

    public Slider CarSlider;
    public Slider DoorSlider;
    public Slider FoodSlider;

    public GameObject carTextObject;
    public GameObject DoorTextObject;
    public GameObject foodTextObject;
    public GameObject HappinessTextObject;

    private TextMeshProUGUI carText { get; set; }
    private TextMeshProUGUI DoorText { get; set; }
    private TextMeshProUGUI foodText { get; set; }
    private TextMeshProUGUI HappinessText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        carText = carTextObject.GetComponent<TextMeshProUGUI>();
        DoorText = DoorTextObject.GetComponent<TextMeshProUGUI>();
        foodText = foodTextObject.GetComponent<TextMeshProUGUI>();
        HappinessText = HappinessTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets car and door to 0
        myhappiness = new happiness();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        carText.text = "Car ride : " + myhappiness.GetCar().ToString();
        DoorText.text = "Is someone at the Door : " + myhappiness.GetDoor().ToString();
        foodText.text = "Is the bowl full: " + myhappiness.GetFood().ToString();
        HappinessText.text = "Rosie's Happiness Level: " + myhappiness.GetHappiness().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myhappiness.SetCar(CarSlider.value);
        myhappiness.SetDoor(DoorSlider.value);
        myhappiness.SetFood(FoodSlider.value);
    }
}



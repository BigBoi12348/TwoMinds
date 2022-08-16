using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PizzaManager : MonoBehaviour
{
    public Text pointText;
    public AudioSource foodEat;
    public AudioSource wrongFood;
    public AudioSource yuckyFood;

    //public List<GameObject> orders; 

    private int score;

    public GameObject pizza;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Pizza"))
        {
            Point.point += 1;
            pointText.text = Point.point.ToString();
            foodEat.Play();
            Destroy(pizza);
        }

        if (other.name.Equals("Fries"))
        {
            wrongFood.Play();
            Point.point -= 1;
            pointText.text = Point.point.ToString();
        }
        if (other.name.Equals("Cheese_02"))
        {
            wrongFood.Play();
            Point.point -= 1;
            pointText.text = Point.point.ToString();
        }
        if (other.name.Equals("Burger"))
        {
            wrongFood.Play();
            Point.point -= 1;
            pointText.text = Point.point.ToString();
        }
        if (other.name.Equals("Drink_01"))
        {
            wrongFood.Play();
            Point.point -= 1;
            pointText.text = Point.point.ToString();
        }
    }
}

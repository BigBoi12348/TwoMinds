using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BurgerManager : MonoBehaviour
{
    public Text pointText;
    public AudioSource foodEat;
    public AudioSource wrongFood;
    public AudioSource yuckyFood;

    public List<GameObject> orders; 

    private int score = 0; 

    

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
        if (orders.Contains(other.gameObject))
        {
            pointText.text = "" + ++score;
            foodEat.Play();
            Destroy(other.gameObject);
        }
        else
        {
            wrongFood.Play();
            pointText.text = "" + --score;
        }      
    }
}

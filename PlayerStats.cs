using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public float Health;
    public float healthOverTimer;



    public float Hunger;
    public float hungerOverTime;

   



    public Slider HealthBar;

    public Slider HungerBar;


    public float minAmount = 5f;


    Rigidbody myBody;

    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        HealthBar.maxValue = Health;

        HungerBar.maxValue = Hunger;


        updateUI();
    }

    private void Update()
    {
        CalculateValues();
    }

    private void CalculateValues()
    {
        Hunger -= hungerOverTime * Time.deltaTime;


        if (Health <= 0)
        {
            print("PLAYER HAS DIED");
        }

        updateUI();
    }

    private void updateUI()
    {
        Health = Mathf.Clamp(Health, 0, 100f);

        Hunger = Mathf.Clamp(Hunger, 0, 100f);
       

        HealthBar.value = Health;

        HungerBar.value = Hunger;
       
    }

    public void TakeDamage(float amnt)
    {
        Health -= amnt;
        updateUI();
    }

    //end o class
}

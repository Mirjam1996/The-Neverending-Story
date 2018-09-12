using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //wichtig

public class PlayerStats : MonoBehaviour { //Skript wird dem Fuchs zugeordnet.

    //folgende Werte lassen sich in Unity einstellen:
    public float Health;
    public float healtOverTime;

    public float Hunger;
    public float hungerOverTime;

    //Zwei Slider-Elemente, die mit den Slider der GUI verbunden werden.
    public Slider HealthBar;
    public Slider HungerBar;

    //Ab diesem Hungerwert verliert man Leben.
    public float minAmount = 5f;

    Rigidbody myBody;

	
	private void Start () {
        myBody = GetComponent<Rigidbody>();
        //Man startet mit vollem Leben und voller Hungeranzeige.
        HealthBar.maxValue = Health;
        HungerBar.maxValue = Hunger;
        
        updateUI();
	}
	
	private void Update () {
        //Wird ausgelagert in:
        CalculateValues();
	}

    private void CalculateValues() {
        //Hungeranzeige reduziert sich (Stärke festlegbar).
        Hunger -= hungerOverTime * Time.deltaTime;

        //Sobald Hunger den Wert 'minAmount' unterschritten hat, reduziert sich auch die Lebensanzeige.
        if(Hunger <= minAmount) {
            Health -= healthOverTime * Time.deltaTime;
        }

        //Wenn nix Gesundheit --> nix fröhlich weiter rumlaufen.
        if(Health <= 0) {
            print("PLAYER HAS DIED");
        }
    }

    //GUI wird geupdatet.
    private void updateUI() {
        Health = Mathf.Clamp(Health, 0, 100f);
        Hunger = Mathf.Clamp(Hunger, 0, 100f);

        //Zuordnung der neuen Werte.
        HealthBar.value = Health;
        HungerBar.value = Hunger;
    }

    //Schadenmenge ('amount') wird vom aktuellen Leben abgezogen.
    public void TakeDamage(float amount) {
        Health -= amount;
        updateUI();
    }
}

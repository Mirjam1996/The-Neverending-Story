using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth : MonoBehaviour {

    public int winkel;
    public int laenge;
    public GameObject turtle;
    //public GameObject wall;

	// Use this for initialization
	void Start () {
		
        turtle = new GameObject("turtle");

        turtle.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        Laby(100);
	}
    public void Turn(int winkel)
    {
        //Die Turtle wird um die z-Achse um einen bestimmten Winkel rotiert, der in der Koch1-Funktion übergeben wird
        turtle.transform.Rotate(0.0f, winkel, 0.0f);
    }

    public void Move(int laenge)
    {
        turtle.transform.Translate(laenge / 2, 0.0f, 0.0f);

        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);

        wall.transform.localScale = new Vector3(laenge, 10.0f, 0.1f);

        wall.transform.rotation = turtle.transform.rotation;

        wall.transform.position = turtle.transform.position;

        wall.GetComponent<Renderer>().material.color = new Color(0.54509804f, 0.03921569f, 0.31372549f);

        turtle.transform.Translate(laenge / 2, 0.0f, 0.0f);
    }

    public void Laby(int laenge){

        Move(laenge);
        Turn(90);
        Move(laenge);
        Turn(90);
        Move(laenge / 2);

        turtle.transform.position = new Vector3(laenge / 2 -10, 0.0f, -laenge);

        Move(laenge / 2 - 10);
        Turn(90);
        Move(laenge/2);

        turtle.transform.position = new Vector3(0.0f, 0.0f, -laenge / 2 + 10);

        Move(laenge / 2 - 10);

        turtle.transform.position = new Vector3(laenge / 2, 0.0f, -laenge);
        Turn(0);
        Move(laenge / 5);

        turtle.transform.position = new Vector3(laenge / 2 -10, 0.0f, -laenge);
        Turn(0);
        Move(laenge / 5 + 10);
        Turn(90);
        Move(laenge / 5);
        Turn(90);
        Move(laenge / 5);

        turtle.transform.position = new Vector3(laenge, 0.0f, -laenge+30);
        Turn(90);
        Move(laenge / 5 -5);
        Turn(-90);
        Move(laenge / 5 - 5);
        Turn(90);
        Move(laenge / 5 - 6);
        Turn(-90);
        Move(laenge / 10 - 5);
        Turn(-90);
        Move(laenge / 5);
        Turn(-90);
        Move(laenge / 5 - 5);
        Turn(90);
        Move(laenge / 10-1);

        turtle.transform.position = new Vector3(laenge, 0.0f, -laenge + 40);
        Turn(180);
        Move(laenge / 5 + 5);
        Turn(-90);
        Move(laenge / 5 - 6);
        Turn(90);
        Move(laenge / 10 - 6);
        Turn(90);
        Move(laenge / 2 - 10);
        Turn(90);
        Move(laenge / 10 - 6);
        Turn(90);
        Move(laenge / 5);
        Turn(-90);
        Move(laenge / 5);
        Turn(-90);
        Move(laenge / 2);
        Turn(-90);
        Move(laenge / 2 -15);
        Turn(-90);
        Move(laenge / 2 - 10);
        Turn(90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 2 - 5);

        turtle.transform.position = new Vector3(laenge-5, 0.0f, -laenge + 55);
        Turn(-90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 2 - 20);
        Turn(-90);
        Move(laenge / 5 - 5);
        Turn(-90);
        Move(laenge / 10);

        turtle.transform.position = new Vector3(0.0f, 0.0f, -laenge + 50);
        Turn(-90);
        Move(laenge / 10 - 5);
        Turn(90);
        Move(laenge / 10 + 5);
        Turn(-90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 10);
        Turn(-90);
        Move(laenge / 5);
        Turn(-90);
        Move(laenge / 5 + 10);
        Turn(-90);
        Move(laenge / 2 - 10);
        Turn(90);
        Move(laenge / 5 + 6);
        Turn(90);
        Move(laenge / 10 + 6);

        turtle.transform.position = new Vector3(0.0f, 0.0f, -laenge + 60);
        Turn(-90);
        Move(laenge / 10 + 4);
        Turn(90);
        Move(laenge / 10 + 5);
        Turn(-90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 5 + 10);
        Turn(90);
        Move(laenge / 10);

        turtle.transform.position = new Vector3(laenge/10 - 5, 0.0f, -laenge + 60);
        Turn(90);
        Move(laenge / 5 + 10);
        Turn(-90);
        Move(laenge / 10 - 5);

        turtle.transform.position = new Vector3(laenge / 10 + 5, 0.0f, -laenge + 55);
        Turn(180);
        Move(laenge / 5 + 5);
        Turn(-90);
        Move(laenge / 5 + 15);
        Turn(-90);
        Move(laenge / 10 - 5);
        Turn(-90);
        Move(laenge / 5 + 10);
        Turn(90);
        Move(laenge / 10);
        Turn(90);
        Move(laenge / 5 + 10);

        turtle.transform.position = new Vector3(laenge / 10 + 4, 0.0f, -laenge + 60);
        Turn(0);
        Move(laenge / 5 + 10);

        turtle.transform.position = new Vector3(laenge / 10 + 4, 0.0f, -laenge + 70);
        Turn(90);
        Move(laenge / 10 +1);
    }

}

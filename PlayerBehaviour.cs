using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    
    public int length;
    public float speed = 0.3f;
    private float timer = 0f;
    private float winkel;
	// Use this for initialization
	void Start () {
		
	}
    void Forward(int length,float speed){
        transform.Translate(length * speed, 0f, 0f);
        length += 1;
    }
    void Backwards(int length, float speed)
    {
        transform.Translate(-length * speed, 0f, 0f);
        length += 1;
    }
    void Right(int length, float speed)
    {
        transform.Translate(0f, 0f, length * speed);
        length += 1;
    }
    void Left(int length, float speed)
    {
        transform.Translate(0f, 0f, -length * speed);
        length += 1;
    }
    void Turn(float winkel){
        transform.Rotate(0f, winkel, 0f);
    }
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Forward(1, 1.0f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Backwards(1, 1.0f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if(Input.GetKeyDown(KeyCode.RightArrow)){
                    Turn(90.0f); 
                } 
                Right(1, 1.0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Left(1, 1.0f);
            }
        }
	}
}

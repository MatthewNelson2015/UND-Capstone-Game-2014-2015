﻿//Written by Christian Sandtveit
//Script which is used so that player can interact with books pressing the interact button (e)

using UnityEngine;
using System.Collections;

public class InteractBook : MonoBehaviour
{
    public float rayLength; //Length of ray, i.e. how far away player can interact with book
    bool showBook1, showBook2, showBook3;

    // Use this for initialization
    void Start()
    {
        rayLength = 1.5f;
        showBook1 = false;
        showBook2 = false;
		showBook3 = false;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit; //Used to query what the ray hit
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = camera.ScreenPointToRay(new Vector3(x, y)); //Ray goes towards middle of screen

        if (Input.GetButton("Interact")) //If interact button is pressed, a ray will be sent out
        {
            if (Physics.Raycast(ray, out hit, rayLength)) //If the ray hit something
            {
                if (hit.collider.tag == "Book1") //If the ray hit the object with label Book1
                {
                    showBook1 = true; //Allow OnGUI function to display on screen
                    Invoke("HideBook1", 3.0F); //Invoke the Hide function after 3seconds, makes the text dissapear
                }
                if (hit.collider.tag == "Book2") //If the ray hit the object with label Book2
                {
                    showBook2 = true; //Allow OnGUI function to display on screen
                    Invoke("HideBook2", 3.0F); //Invoke the Hide function after 3seconds, makes the text dissapear
                }
				if (hit.collider.tag == "Book3") //If the ray hit the object with label Book2
				{
					showBook3 = true; //Allow OnGUI function to display on screen
					Invoke("HideBook3", 3.0F); //Invoke the Hide function after 3seconds, makes the text dissapear
				}
            }
        }
    }

    //Display text to screen
    void OnGUI()
    {
        if (showBook1)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Search the caves for keys and treasures!");
        }
        if (showBook2)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Pull the lever and see what happens!");
        }
		if (showBook3)
		{
			GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Find");
		}
    }

    //Set bool variable to false, so that text dissapears
    void HideBook1()
    {
        showBook1 = false;
    }

    //Set bool variable to false, so that text dissapears
    void HideBook2()
    {
        showBook2 = false;
    }

	//Set bool variable to false, so that text dissapears
	void HideBook3()
	{
		showBook3 = false;
	}
}

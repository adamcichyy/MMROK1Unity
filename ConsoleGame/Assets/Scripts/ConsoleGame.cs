using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleGame : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int shoot = 500;

    void CalculateShoot(int minOrmax)
    {
        minOrmax = shoot;
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest wieksza lud mniejsza od " + shoot + " ?");
    }

    void StartMessage()
    {
        Debug.Log("Witaj w grze. Wybierz w glowie liczbe od " + min + " do " + max);
        Debug.Log("Czy twoja liczba jest wieksza lud mniejsza od " + shoot + " ?");
        Debug.Log("Jesli wieksza to nacisnij strzalke do gory \n" +
                  "Jesli mniejsza to nacisnij strzalke w dol \n" +
                  "Jesli rowna to nacisnij klawisz ENTER");
    }

    void Start()
    {
        StartMessage();
        max++;
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {  
            CalculateShoot(min);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CalculateShoot(max);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Haha wygralem - zgadlem twoja liczbe");
        }
    }

    
}

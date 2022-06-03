using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    public Text startText;
    public Image[] images;
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    void NextLevel(string description, int imageAddress, int audioclipAddress )
    {
        images[imageAddress].enabled = false;
        startText.text = description;
        startText.color = Color.white;
        audioSource.clip = audioClips[audioclipAddress];
        audioSource.Play();
    }

    void Start()
    {
        startText.text = "Witaj w grze - nacisnij klawisz ENTER,aby kontynuowaæ";
        audioSource.clip = audioClips[0];
        audioSource.Play();
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            NextLevel("Budzisz sie w celi -jesli nacisniesz klawisz Q to podejdziesz do drzwi ",0,1);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            NextLevel("Podchodzisz do drzwi i widzisz cos tam", 1,2);
        }
        
    }
}
// 10 stanów ->
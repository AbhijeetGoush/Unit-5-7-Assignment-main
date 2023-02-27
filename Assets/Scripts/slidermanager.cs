using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidermanager : MonoBehaviour
{
    
    AudioManager am;
    [SerializeField] Slider volumeSlider;
    [SerializeField] AudioSource Music;
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        slidervol();
    }

    public void slidervol()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
}


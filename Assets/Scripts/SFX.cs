using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SFX : MonoBehaviour
{
    [SerializeField] Slider slide;
    [SerializeField] AudioSource Sfx;
    // Start is called before the first frame update
    void Start()
    {
        load();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void save()
    {
        PlayerPrefs.SetFloat("SFX", slide.value);
    }
    private void load()
    {
        slide.value = PlayerPrefs.GetFloat("SFX");
    }

    public void ChangesVolume()
    {
        Sfx.volume = slide.value;
        PlayerPrefs.SetFloat("SFX", slide.value);
    }
}

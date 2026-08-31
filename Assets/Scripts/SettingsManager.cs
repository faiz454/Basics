using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject MainMenuPanel;
    public AudioSource bgm;
    public AudioSource carsound;
    public Slider bgmSlider;
    public Slider carslider;

    // Start is called before the first frame update
    void Start()
    {
        float savedBGMVolume = PlayerPrefs.GetFloat("BGMVolume", 0.7f);
        float savedCarVolume = PlayerPrefs.GetFloat("CarVolume", 0.8f);

        if(bgmSlider !=null ) bgmSlider.value = savedBGMVolume;
        if(carslider != null) carslider.value = savedCarVolume;

        SetBGMVolume(savedBGMVolume);
        SetCarVolume(savedCarVolume);
    }

    public void SetBGMVolume(float volume)
    {
        if(bgm != null)
        {
            bgm.volume = volume;
            
        }
        PlayerPrefs.SetFloat("BGMVolume", volume);
        PlayerPrefs.Save();

    }

    public void SetCarVolume(float volume)
    {
        if(carsound != null)
        {
            carsound.volume = volume;
        }
        PlayerPrefs.SetFloat("CarVolume", volume);
        PlayerPrefs.Save();
    }

    public void OpenSettings()
    {
        if(SettingsPanel != null) SettingsPanel.SetActive(true);
        if(MainMenuPanel != null) MainMenuPanel.SetActive(false);
    }

    public void CloseSettings()
    {
        if(SettingsPanel != null) SettingsPanel.SetActive(false);
        if(MainMenuPanel != null) MainMenuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsControl : MonoBehaviour
{

    [SerializeField]
    private AudioMixer _audioMixer;

    [SerializeField]
    private Slider _musicSlider;

    [SerializeField]
    private Slider _buttonSlider;

    [SerializeField]
    private float _musicVolume;

    [SerializeField]
    private float _buttonVolume;



    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu Scene")
        {
            LoadData();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustVolume()
    {
        _audioMixer.SetFloat("BG_Music", _musicSlider.value);        
    }

    public void AdjustButtonVolume()
    {
        _audioMixer.SetFloat("ButtonSound", _buttonSlider.value);      
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("MusicVolume", _musicSlider.value);
        PlayerPrefs.SetFloat("ButtonVolume", _buttonSlider.value);
        //_musicVolume = _musicSlider.value;
        //_buttonVolume = _buttonSlider.value;
    }

    public void LoadData()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        _buttonSlider.value = PlayerPrefs.GetFloat("ButtonVolume");
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("MusicVolume");
        PlayerPrefs.DeleteKey("ButtonVolume");
    }

}

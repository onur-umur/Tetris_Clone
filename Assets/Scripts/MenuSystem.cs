using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MenuSystem : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void PlayAgain(){
        Application.LoadLevel("Level");
    }


    public void QuitGame(){
        Application.Quit();
        Debug.Log("Oyundan çıkış");
    }

    
    //***************AYARLAR İÇİN **************
    //ses---------

    public AudioMixer audioMixer;
    public void SetVolume(float volume){
        audioMixer.SetFloat("volume",volume); 
        Debug.Log(volume);
    }
    //----------


    //ekran-------
    public void SetFullscreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }
    // --------


    //kalite-----
    public void SetQuality (int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    //-----------
    //*********************************************** 
    
  public void SettingsMenu(){
    Application.LoadLevel("SettingsMenu");
    Debug.Log("Ayarlar menüsü");
  }

    public void GeriTusu(){
        Application.LoadLevel("GirisEkrani");
    }

    public void GameStop(){
        Application.LoadLevel("GirisEkrani");
    }
}

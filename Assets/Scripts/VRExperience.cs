using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class VRExperience : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject text;
    public GameObject stresssound;

    bool textbool = false;

    public TerrainData terrainData;
    public NoiseData noiseData;

    public void playvideo(){
        videoPlayer.GetComponent<VideoPlayer>().Play();
        //videoPlayer.SetActive(true);
        stresssound.SetActive(true);
    }

    public void videoscene(){
        SceneManager.LoadScene("VideoScene");
    }

    public void testbutton(){
        if(textbool==false){
            text.SetActive(true);
            textbool = true;
        }
        else{
            text.SetActive(false);
            textbool = false;
        }
    }

    public void loadWorldGenVR() {
        stresssound.SetActive(false);
        videoPlayer.SetActive(false);
        SceneManager.LoadScene("StartScene");
        terrainData.useFlatShading = true;
        //noiseData.worldscene = 0;
    }

    public void setsccene(){
        noiseData.worldscene = 0;
    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToAnotherScene : MonoBehaviour
{
   public void LoadSceneTentang () {
        SceneManager.LoadScene ("Tentang");
    }

     public void LoadSceneMateri () {
        SceneManager.LoadScene ("Materi");
    }

     public void LoadSceneBantuan () {
        SceneManager.LoadScene ("Bantuan");
    }

    public void LoadSceneScanner () {
        SceneManager.LoadScene ("Scanner");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int mins;
    public float secs;
    void Update()
    {
        secs -= Time.deltaTime;
        if (secs < 0)
        {
            if (mins > 0)
            {
                secs += 59;
                mins -= 1;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex); 
            }
        }
    }
}

using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "lvl2")
            SceneManager.LoadScene (sceneName:"lvl_2");
        if(collision.tag == "lvl3")
            SceneManager.LoadScene (sceneName:"lvl_3");
    }
    
}

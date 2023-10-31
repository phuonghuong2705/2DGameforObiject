using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BGMusic : MonoBehaviour
{
    public static BGMusic instance;
    //[SerializeField] private AudioSource bgMusic;
    private int scene;

    private void FixedUpdate()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(scene);
    }

    private void Awake()
    {
        if (instance == null && scene == 0)
        {          
            instance = this;
            DontDestroyOnLoad(gameObject);
        }      

        else
        {
            Destroy(gameObject);
        }
    }
    
}

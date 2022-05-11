using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomScenes : MonoBehaviour {

    public int lowBound;
    public int highBound;
    private Scene scene;

    public void LoadRandomScene() {
        int index = Random.Range(lowBound, highBound);
        SceneManager.LoadScene(index);
        scene = SceneManager.GetActiveScene();
        Debug.Log("Scene Loaded: " + scene.name);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
        LoadRandomScene();
        }
    }
}

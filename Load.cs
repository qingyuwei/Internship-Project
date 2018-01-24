using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    public Text text;
    public Slider slider;
    AsyncOperation cover;
    int progress = 0;

	// Use this for initialization

	void Start () 
    {
        StartCoroutine(loadScene());
	}
	
	// Update is called once per frame
	void Update () 
    {
        progress = (int)(cover.progress * 100);
        slider.value = progress;
        text.text = Mathf.Floor(slider.value) + "%";
	}
    IEnumerator loadScene()
    {
        cover = SceneManager.LoadSceneAsync("scene");
        yield return cover;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityChan;
//using TMPro;

public class RestartManager : MonoBehaviour
{
    private GameObject player;
    //private GameObject text;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public RestartManager(GameObject player/*, GameObject text*/)
    {
        this.player = player;
        //this.text = text;
    }

    public void PrintGameOver()
    {
        //text.GetComponent<TextMeshProUGUI>().text = "GameOver...";
        //text.SetActive(true);

        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        player.GetComponent<Animator>().enabled = false;
        isGameOver = true;
    }

    public void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}

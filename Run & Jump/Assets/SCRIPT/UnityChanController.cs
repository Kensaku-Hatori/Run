using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;//LoadSceneを使うために必要

public class UnityChanController : MonoBehaviour
{
    public float WallkSpeed = 1;
    public Rigidbody UnityChan;
    public GameObject ScoreText;//スコアのUI
    public GameObject Item;
    private int score;//スコア

    // Start is called before the first frame update
    void Start()
    {
        UnityChan = GetComponent<Rigidbody>();
        score = 0;//得点の初期化
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && UnityChan.transform.position.x >= 0)
        {
            UnityChan.transform.Translate(-3,0,0);
            //transform.Translate(-3, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && UnityChan.transform.position.x <= 0)
        {
            UnityChan.transform.Translate(3, 0, 0);
        }
        UnityChan.transform.Translate(0, 0, WallkSpeed / 10);
    }
    private void OnTriggerEnter(Collider other)
    {
           //その収集アイテムを非表示にする
           other.gameObject.SetActive(false);
           score = score + 1;//スコア加算
           SetText();

    }
    void SetText()
    {
        score *= 100;

        //スコアの表示を更新
        ScoreText.GetComponent<TextMeshProUGUI>().text = "Count:" + score.ToString();
    }


}

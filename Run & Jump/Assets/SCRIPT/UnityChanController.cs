using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;//LoadScene���g�����߂ɕK�v

public class UnityChanController : MonoBehaviour
{
    public float WallkSpeed = 1;
    public Rigidbody UnityChan;
    public GameObject ScoreText;//�X�R�A��UI
    public GameObject Item;
    private int score;//�X�R�A

    // Start is called before the first frame update
    void Start()
    {
        UnityChan = GetComponent<Rigidbody>();
        score = 0;//���_�̏�����
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
           //���̎��W�A�C�e�����\���ɂ���
           other.gameObject.SetActive(false);
           score = score + 1;//�X�R�A���Z
           SetText();

    }
    void SetText()
    {
        score *= 100;

        //�X�R�A�̕\�����X�V
        ScoreText.GetComponent<TextMeshProUGUI>().text = "Count:" + score.ToString();
    }


}

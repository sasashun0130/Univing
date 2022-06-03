using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�e�t���A�ɂ�����K�i�ɂ���Ď��̃X�e�[�W�ɕϑJ
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stair")
        {
            SceneManager.LoadScene("2ndStage");
        }
        else if (collision.gameObject.tag == "Stair1")
        {
            SceneManager.LoadScene("3rdStage");
        }
        else if (collision.gameObject.tag == "Stair2")
        {
            SceneManager.LoadScene("1stStage");
        }
        else if (collision.gameObject.tag == "FalseStair")
        {
            int stage = Random.Range(1, 11);
            if (stage < 7)
            {
                //Debug.Log(stage);
                SceneManager.LoadScene("BStage");
            }
            else
            {
                //Debug.Log(stage); 
                SceneManager.LoadScene("CStage");
            }
        }
        else if (collision.gameObject.tag == "Treasure")
        {
            SceneManager.LoadScene("ResultStage");
        }
        else if (collision.gameObject.tag == "FalseTresure")
        {
            SceneManager.LoadScene("GameOverStage");
        }
    }
}
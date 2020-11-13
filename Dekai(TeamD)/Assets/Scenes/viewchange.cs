using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class viewchange : MonoBehaviour
{
    //ゲームオブジェクト、ボタンの設定
    public GameObject white, black, blue, red;
    public Button Left, Right;
    
    // Start is called before the first frame update
    void Start()
    {
        //ボタンの有効・無効設定
        white.SetActive(true);
        black.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //矢印キーを押した時の動作
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            white.SetActive(false);
            black.SetActive(true);
            blue.SetActive(false);
            red.SetActive(false);
            Debug.Log("black");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            white.SetActive(false);
            black.SetActive(false);
            blue.SetActive(true);
            red.SetActive(false);
            Debug.Log("blue");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            white.SetActive(false);
            black.SetActive(false);
            blue.SetActive(false);
            red.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            white.SetActive(true);
            black.SetActive(false);
            blue.SetActive(false);
            red.SetActive(false);
        }
    }
}

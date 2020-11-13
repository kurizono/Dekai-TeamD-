using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class viewchange : MonoBehaviour
{
    //ゲームオブジェクト、ボタンの設定
    public GameObject north, east, south, west;
    public Button Left, Right;

    int compass = 0;

    // Start is called before the first frame update
    void Start()
    {
        //有効・無効設定
        north.SetActive(true);
        east.SetActive(false);
        south.SetActive(false);
        west.SetActive(false);
        
        //ボタンを押した時の動作
        Left.onClick.AddListener(Left_Click);
        Right.onClick.AddListener(Right_Click);
    }

    // Update is called once per frame
    void Update()
    {
        //矢印キーを押した時の動作
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            north.SetActive(false);
            east.SetActive(true);
            south.SetActive(false);
            west.SetActive(false);
            Debug.Log("east");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            north.SetActive(false);
            east.SetActive(false);
            south.SetActive(true);
            west.SetActive(false);
            Debug.Log("south");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            north.SetActive(false);
            east.SetActive(false);
            south.SetActive(false);
            west.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            north.SetActive(true);
            east.SetActive(false);
            south.SetActive(false);
            west.SetActive(false);
        }
    }

    //左ボタン押したらどうなるか
    private void Left_Click()
    {
        compass = (compass + 3) % 4;
        Compass_Check();
    }
    //右ボタン押したらどうなるか
    private void Right_Click()
    {
        compass = (compass + 1) % 4;
        Compass_Check();
    }
    //コンパスを確認して、向きを変えたい
    private void Compass_Check()
    {
        switch (compass)
        {
            case 0:
                north.SetActive(true);
                east.SetActive(false);
                south.SetActive(false);
                west.SetActive(false);
                Debug.Log("north");
                break;
            case 1:
                north.SetActive(false);
                east.SetActive(true);
                south.SetActive(false);
                west.SetActive(false);
                Debug.Log("east");
                break;
            case 2:
                north.SetActive(false);
                east.SetActive(false);
                south.SetActive(true);
                west.SetActive(false);
                Debug.Log("south");
                break;
            case 3:
                north.SetActive(false);
                east.SetActive(false);
                south.SetActive(false);
                west.SetActive(true);
                Debug.Log("west");
                break;
        }
    }
}

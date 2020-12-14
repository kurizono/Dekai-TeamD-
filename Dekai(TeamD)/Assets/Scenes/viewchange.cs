using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class viewchange : MonoBehaviour
{
    itemget itemgetcs;
    //ゲームオブジェクト、ボタンの設定
    public GameObject North, East, South, West;
    public Button Left, Right;
    public int compass = 0;

    // Start is called before the first frame update
    void Start()
    {
        itemgetcs = GetComponent<itemget>();
        CompassCheck();
        //ボタンの有効・無効設定
        North.SetActive(true);
        East.SetActive(false);
        South.SetActive(false);
        West.SetActive(false);
        //ボタンを押したときの動作
        Left.onClick.AddListener(Left_Click);
        Right.onClick.AddListener(Right_Click);
    }

    // Update is called once per frame
    void Update()
    {


    }
    //ボタンを押したらどうなるか
    private void Left_Click()
    {
        compass = (compass + 3) % 4;
        CompassCheck();
    }
    private void Right_Click()
    {
        compass = (compass + 1) % 4;
        CompassCheck();
    }

    //コンパスを確認して向きを変えたい
    private void CompassCheck()
    {
        switch (compass)
        {
            case 0:
                North.SetActive(true);
                East.SetActive(false);
                South.SetActive(false);
                West.SetActive(false);
                itemgetcs.North_Item();
                break;
            case 1:
                North.SetActive(false);
                East.SetActive(true);
                South.SetActive(false);
                West.SetActive(false);
                itemgetcs.East_Item();
                break;
            case 2:
                North.SetActive(false);
                East.SetActive(false);
                South.SetActive(true);
                West.SetActive(false);
                itemgetcs.South_Item();
                break;
            case 3:
                North.SetActive(false);
                East.SetActive(false);
                South.SetActive(false);
                West.SetActive(true);
                itemgetcs.West_Item();
                break;
        }
    }
}

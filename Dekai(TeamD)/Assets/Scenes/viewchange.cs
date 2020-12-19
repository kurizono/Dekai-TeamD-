using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class viewchange : MonoBehaviour
{
    itemget itemgetcs;
    //ゲームオブジェクト、ボタンの設定
    public GameObject North, North_Open, East, South, West;
    public Button Left, Right, Desk_Left, Desk_Right; 
    public Button Desk;
    public int compass = 0;
    public int deskscreen = 0;

    void Start()
    {
        itemgetcs = GetComponent<itemget>();
        CompassCheck();
        //ボタンを押したときの動作
        Left.onClick.AddListener(Left_Click);
        Right.onClick.AddListener(Right_Click);
        Desk.onClick.AddListener(Desk_Click);
        Desk_Left.onClick.AddListener(Desk_Left_Click);
        Desk_Right.onClick.AddListener(Desk_Right_Click);
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
    private void Desk_Click()
    {
        if (North.activeSelf == true)
        {
            North.SetActive(false);
            North_Open.SetActive(true);
        }
        else if (North_Open.activeSelf == true)
        {
            if (itemgetcs.getitem_diy.gameObject.activeSelf && !itemgetcs.getitem_note.gameObject.activeSelf) 
            {
                itemgetcs.getitem_note.gameObject.SetActive(true);
            }
            else
            {
                North.SetActive(true);
                North_Open.SetActive(false);
            }
        }
    }
    private void Desk_Left_Click()
    {
        deskscreen = (deskscreen + 3) % 4;
        itemgetcs.Desk_Item(deskscreen);
    }
    private void Desk_Right_Click()
    {
        deskscreen = (deskscreen + 1) % 4;
        itemgetcs.Desk_Item(deskscreen);
    }

    //コンパスを確認して向きを変えたい
    private void CompassCheck()
    {
        FirstPosi();
        switch (compass)
        {
            case 0:
                North.SetActive(true);
                Desk.gameObject.SetActive(true);
                Desk_Left.gameObject.SetActive(true);
                Desk_Right.gameObject.SetActive(true);
                deskscreen = 0;
                itemgetcs.North_Item();
                break;
            case 1:
                East.SetActive(true);
                itemgetcs.East_Item();
                break;
            case 2:
                South.SetActive(true);
                itemgetcs.South_Item();
                break;
            case 3:
                West.SetActive(true);
                itemgetcs.West_Item();
                break;
        }
    }

    private void FirstPosi()
    {
        North.SetActive(false);
        North_Open.SetActive(false);
        East.SetActive(false);
        South.SetActive(false);
        West.SetActive(false);
        Desk.gameObject.SetActive(false);
        Desk_Left.gameObject.SetActive(false);
        Desk_Right.gameObject.SetActive(false);
    }
}

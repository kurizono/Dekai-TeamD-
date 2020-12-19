using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemget : MonoBehaviour
{
    //viewchangeスクリプトをviewchangecsという名前で定義づけてる感じなのかなあ…
    viewchange viewchangecs;

    //配列(連続した箱を作るイメージ)
    private Button[] button_all;

    public Button button_closet, button_upperbed, button_underbed;

    public Button button_cat, button_dictionary;
    public Button button_diy, button_log, button_mazai;
    public Button button_mypipe, button_myth, button_note;
    public Button button_sign;

    //buttonとitemを同時に参照できる
    private int[] button_north;
    private int[] button_east;
    private int[] button_south;
    private int[] button_west;
    private int[] button_desk;

    public Button[] getitem_all;

    public Button getitem_adalt, getitem_cat, getitem_cloth, getitem_dictionary;
    public Button getitem_diy, getitem_general, getitem_log, getitem_mazai;
    public Button getitem_mypipe, getitem_myth, getitem_note, getitem_pillow;
    public Button getitem_sign, getitem_stick, getitem_sword, getitem_whitesweet;

    //AwakeはStartより優先されるのでviewchangeで使われるbutton系の宣言を先にしておく
    private void Awake()
    {
        button_all = new Button[16]
        {
            button_underbed, button_cat, button_closet, button_dictionary,
            button_diy, button_underbed, button_log, button_mazai,
            button_mypipe, button_myth, null, button_upperbed,
            button_sign, button_closet, button_closet, button_closet
        };
        getitem_all = new Button[16]
        {
            getitem_adalt, getitem_cat, getitem_cloth, getitem_dictionary,
            getitem_diy, getitem_general, getitem_log, getitem_mazai,
            getitem_mypipe, getitem_myth, getitem_note, getitem_pillow,
            getitem_sign, getitem_stick, getitem_sword, getitem_whitesweet
        };
        button_east = new int[3] { 0, 5, 11 };
        button_north = new int[0] {};
        button_west = new int[4] { 3, 4, 7, 9};
        button_south = new int[4] { 2, 13, 14, 15 };
        button_desk = new int[3] { 1, 6, 8 };
        for (int i = 0; i < button_all.Length; i++)
        {
            getitem_all[i].gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        viewchangecs = GetComponent<viewchange>();
        //button_allをクリックしたらItem_Clickが起きる
        for (int i = 0; i < button_all.Length; i++)
        {
            if (button_all[i] != null)
            {
                GameObject item = getitem_all[i].gameObject;
                GameObject button = button_all[i].gameObject;
                if (button != button_underbed.gameObject)
                {
                    button_all[i].onClick.AddListener(() => { Item_Click(item, button); });
                }
            }
        }

        button_underbed.onClick.AddListener(Bed_Click);

    }

    //ボタン消してアイテムを表示する
    public void Item_Click(GameObject item_gameobject, GameObject item_button)
    {
        item_gameobject.SetActive(true);
        item_button.SetActive(false);
        
    }
    private void Bed_Click()
    {
        if(getitem_stick.gameObject.activeSelf == true)
        {
            button_underbed.gameObject.SetActive(false);
            getitem_adalt.gameObject.SetActive(true);
            getitem_general.gameObject.SetActive(true);
        }
        else
        {

        }
    }


    //北のアイテム
    public void North_Item()
    {
        AllItem_False();
        //button_northの配列数だけ繰り返す
        for (int i = 0; i < button_north.Length; i++)
        {
            //item_allの内のbutton_north[i]がactiveselfじゃない(取得されてない)
            if (!getitem_all[button_north[i]].gameObject.activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_north[i]].gameObject.SetActive(true);
            }
        }
    }
    //東のアイテム
    public void East_Item()
    {
        AllItem_False();
        //button_eastの配列数だけ繰り返す
        for (int i = 0; i < button_east.Length; i++)
        {
            //item_allの内のbutton_east[i]がactiveselfじゃない(取得されてない)
            if (!getitem_all[button_east[i]].gameObject.activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_east[i]].gameObject.SetActive(true);
            }
        }
        button_underbed.gameObject.SetActive(true);
    }
    //南のアイテム
    public void South_Item()
    {
        AllItem_False();
        //button_southの配列数だけ繰り返す
        for (int i = 0; i < button_south.Length; i++)
        {
            //item_allの内のbutton_south[i]がactiveselfじゃない(取得されてない)
            if (!getitem_all[button_south[i]].gameObject.activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_south[i]].gameObject.SetActive(true);
            }
        }
        button_closet.gameObject.SetActive(true);
    }
    //西のアイテム
    public void West_Item()
    {
        AllItem_False();
        //button_westの配列数だけ繰り返す
        for (int i = 0; i < button_west.Length; i++)
        {
            //item_allの内のbutton_west[i]がactiveselfじゃない(取得されてない)
            if (!getitem_all[button_west[i]].gameObject.activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_west[i]].gameObject.SetActive(true);
            }
        }
    }
    public void Desk_Item(int num)
    {
        for (int i = 0; i < button_desk.Length; i++) 
        {
            button_all[button_desk[i]].gameObject.SetActive(false);
        }
        if(num != 0)
        {
            if (!getitem_all[button_desk[num - 1]].gameObject.activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_desk[num - 1]].gameObject.SetActive(true);
            }
        }
    }


    private void AllItem_False()
    {
        for (int i = 0; i < button_all.Length; i++)
        {
            if (button_all[i] != null)
            {
                button_all[i].gameObject.SetActive(false);
            }
        }
        button_underbed.gameObject.SetActive(false);
        button_closet.gameObject.SetActive(false);
    }
}

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

    public Button button_adalt, button_cat, button_cloth, button_dictionary;
    public Button button_diy, button_general, button_log, button_mazai;
    public Button button_mypipe, button_myth, button_note, button_pillow;
    public Button button_sign, button_stick, button_sword, button_whitesweet;

    //buttonとitemを同時に参照できる(？？？？？？？？？？？？？？？？)
    private int[] button_north;
    private int[] button_east;
    private int[] button_south;
    private int[] button_west;

    private GameObject[] item_all;
    
    public GameObject item_adalt, item_cat, item_cloth, item_dictionary;
    public GameObject item_diy, item_general, item_log, item_mypipe;
    public GameObject item_myth, item_note, item_pillow, item_sign;
    public GameObject item_stick, item_sword, item_whitesweet, item_mazai;


private void Awake()
    {
        button_all = new Button[16]
        {
        button_adalt, button_cat, button_cloth, button_dictionary,
        button_diy, button_general, button_log, button_mazai,
        button_mypipe, button_myth, button_note, button_pillow,
        button_sign, button_stick, button_sword, button_whitesweet };
        item_all = new GameObject[16]
        {
            item_adalt, item_cat, item_cloth, item_dictionary,
            item_diy, item_general, item_log, item_mazai,
            item_mypipe, item_myth, item_note, item_pillow,
            item_sign, item_stick, item_sword, item_whitesweet,
        };
        button_east = new int[3] { 0, 5, 11 };
        button_north = new int[5] { 1, 6, 7, 8, 12 };
        button_west = new int[4] { 3, 4, 9, 10 };
        button_south = new int[4] { 2, 13, 14, 15 };
        for (int i = 0; i < 16; i++)
        {
            item_all[i].SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        viewchangecs = GetComponent<viewchange>();
        //North_Item();
        for (int i = 0; i < 16; i++)
        {
            GameObject item = item_all[i];
            GameObject button = button_all[i].gameObject;
            button_all[i].onClick.AddListener(() => { Item_Click(item, button); });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //アイテム欄の旗が現れてゲーム画面の旗が消える
    private void Item_Click(GameObject item_gameobject, GameObject item_button)
    {
        item_gameobject.SetActive(true);
        item_button.SetActive(false);
    }
    //北のアイテム
    public void North_Item()
    {
        AllItem_False();
        //button_northの配列数だけ繰り返す
        for (int i = 0; i < button_north.Length; i++)
        {
            //item_allの内のbutton_north[i]がactiveselfじゃない(取得されてない)
            if (!item_all[button_north[i]].activeSelf)
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
            if (!item_all[button_east[i]].activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_east[i]].gameObject.SetActive(true);
            }
        }
    }
    //南のアイテム
    public void South_Item()
    {
        AllItem_False();
        //button_southの配列数だけ繰り返す
        for (int i = 0; i < button_south.Length; i++)
        {
            //item_allの内のbutton_south[i]がactiveselfじゃない(取得されてない)
            if (!item_all[button_south[i]].activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_south[i]].gameObject.SetActive(true);
            }
        }
    }
    //西のアイテム
    public void West_Item()
    {
        AllItem_False();
        //button_westの配列数だけ繰り返す
        for (int i = 0; i < button_west.Length; i++)
        {
            //item_allの内のbutton_west[i]がactiveselfじゃない(取得されてない)
            if (!item_all[button_west[i]].activeSelf)
            {
                //それのSetActiveをtrueにする
                button_all[button_west[i]].gameObject.SetActive(true);
            }
        }
    }
    private void AllItem_False()
    {
        for (int i = 0; i < 16; i++)
        {
            button_all[i].gameObject.SetActive(false);
        }
    }
}

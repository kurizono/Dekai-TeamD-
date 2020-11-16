using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemget : MonoBehaviour
{
    //viewchangeスクリプトをviewchangecsという名前で定義づけてる感じなのかなあ…
    viewchange viewchangecs;

    public Button button_flag;
    public GameObject g_button_flag, item_flag;
    // Start is called before the first frame update
    void Start()
    {
        North_Item();
        viewchangecs = GetComponent<viewchange>();
        item_flag.SetActive(false);
        //button_flag(ゲーム画面の旗)をクリックしたら
        button_flag.onClick.AddListener(Flag_Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //アイテム欄の旗が現れてゲーム画面の旗が消える
    private void Flag_Click()
    {
        item_flag.SetActive(true);
        g_button_flag.SetActive(false);
    }
    //北のアイテム
    public void North_Item()
    {
        g_button_flag.SetActive(false);
    }
    //東のアイテム
    public void East_Item()
    {
        g_button_flag.SetActive(false);
    }
    //南のアイテム
    public void South_Item()
    {
        if (!item_flag.activeSelf)
        {
            g_button_flag.SetActive(true);
        }
        
    }
    //西のアイテム
    public void West_Item()
    {
        g_button_flag.SetActive(false);
    }
}

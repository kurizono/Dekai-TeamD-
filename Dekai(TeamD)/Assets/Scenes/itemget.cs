using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemget : MonoBehaviour
{
    //viewchangeスクリプトをviewchangecsという名前で定義づけてる感じなのかなあ…
    viewchange viewchangecs;

    public Button button_flag, button_adalt, button_cat, button_cloth, button_dictionary;
    public Button button_diy, button_general, button_log, button_mazai;
    public Button button_mypipe, button_myth, button_note, button_pillow;
    public Button button_sign, button_stick, button_sword, button_whitesweet;
    public GameObject g_button_flag, g_button_adalt, g_button_cat, g_button_cloth, g_button_dictionary;
    public GameObject g_button_diy, g_button_log, g_button_mazai, g_button_mypipe;
    public GameObject g_button_myth, g_button_note, g_button_pillow, g_button_sign;
    public GameObject g_button_stick, g_button_sword, g_button_whitesweet, g_button_general;
    public GameObject item_flag, item_adalt, item_cat, item_cloth, item_dictionary;
    public GameObject item_diy, item_general, item_log, item_mypipe;
    public GameObject item_myth, item_note, item_pillow, item_sign;
    public GameObject item_stick, item_sword, item_whitesweet, item_mazai;
    // Start is called before the first frame update
    void Start()
    {
        North_Item();
        viewchangecs = GetComponent<viewchange>();
        item_flag.SetActive(false);
        item_adalt.SetActive(false);
        item_cat.SetActive(false);
        item_cloth.SetActive(false);
        item_dictionary.SetActive(false);
        item_diy.SetActive(false);
        item_general.SetActive(false);
        item_log.SetActive(false);
        item_mazai.SetActive(false);
        item_mypipe.SetActive(false);
        item_myth.SetActive(false);
        item_note.SetActive(false);
        item_pillow.SetActive(false);
        item_sign.SetActive(false);
        item_stick.SetActive(false);
        item_sword.SetActive(false);
        item_whitesweet.SetActive(false);
        //button_flag(ゲーム画面の旗)をクリックしたら
        button_flag.onClick.AddListener(Flag_Click);
        button_adalt.onClick.AddListener(Adalt_Click);
        button_cat.onClick.AddListener(Cat_Click);
        button_cloth.onClick.AddListener(Cloth_Click);
        button_dictionary.onClick.AddListener(Dictionary_Click);
        button_diy.onClick.AddListener(Diy_Click);
        button_general.onClick.AddListener(General_Click);
        button_mazai.onClick.AddListener(Mazai_Click);
        button_mypipe.onClick.AddListener(Mypipe_Click);
        button_myth.onClick.AddListener(Myth_Click);
        button_note.onClick.AddListener(Note_Click);
        button_pillow.onClick.AddListener(Pillow_Click);
        button_sign.onClick.AddListener(Sign_Click);
        button_stick.onClick.AddListener(Stick_Click);
        button_sword.onClick.AddListener(Sword_Click);
        button_whitesweet.onClick.AddListener(Whitesweet_Click);
        button_log.onClick.AddListener(Log_Click);
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
    private void Adalt_Click()
    {
        item_adalt.SetActive(true);
        g_button_adalt.SetActive(false);
    }
    private void Cat_Click()
    {
        item_cat.SetActive(true);
        g_button_cat.SetActive(false);
    }
    private void Dictionary_Click()
    {
        item_dictionary.SetActive(true);
        g_button_dictionary.SetActive(false);
    }
    private void Diy_Click()
    {
        item_diy.SetActive(true);
        g_button_diy.SetActive(false);
    }
    private void General_Click()
    {
        item_general.SetActive(true);
        g_button_general.SetActive(false);
    }
    private void Mazai_Click()
    {
        item_mazai.SetActive(true);
        g_button_mazai.SetActive(false);
    }
    private void Log_Click()
    {
        item_log.SetActive(true);
        g_button_log.SetActive(false);
    }
    private void Note_Click()
    {
        item_note.SetActive(true);
        g_button_note.SetActive(false);
    }
    private void Mypipe_Click()
    {
        item_mypipe.SetActive(true);
        g_button_mypipe.SetActive(false);
    }
    private void Myth_Click()
    {
        item_myth.SetActive(true);
        g_button_myth.SetActive(false);
    }
    private void Pillow_Click()
    {
        item_pillow.SetActive(true);
        g_button_pillow.SetActive(false);
    }
    private void Sign_Click()
    {
        item_sign.SetActive(true);
        g_button_sign.SetActive(false);
    }
    private void Stick_Click()
    {
        item_stick.SetActive(true);
        g_button_stick.SetActive(false);
    }
    private void Sword_Click()
    {
        item_sword.SetActive(true);
        g_button_sword.SetActive(false);
    }
    private void Whitesweet_Click()
    {
        item_whitesweet.SetActive(true);
        g_button_whitesweet.SetActive(false);
    }
    private void Cloth_Click()
    {
        item_cloth.SetActive(true);
        g_button_cloth.SetActive(false);
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

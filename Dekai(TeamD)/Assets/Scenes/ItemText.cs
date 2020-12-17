using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour
{
    public Text itemsetumei;
    //このcsはスクリプトの意
    itemget itemgetcs;


    private string[] item_text = new string[16]
    {
        "adult", "cat", "cloth", "dictionary",
        "diy", "general", "log", "mazai",
        "mypipe", "myth", "note", "pillow",
        "sign", "stick", "sword", "whitesweet"
    };
    // Start is called before the first frame update
    void Start()
    {
        itemgetcs = GetComponent<itemget>();
        itemsetumei.text = "";

        for (int i = 0; i < itemgetcs.getitem_all.Length; i++)
        {
            string input_text = item_text[i];
            itemgetcs.getitem_all[i].onClick.AddListener(() => { Item_Click(input_text); });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //アイテムをクリックしたときにtextを出す
    private void Item_Click(string talk)
    {
        itemsetumei.text = talk;
    }
}
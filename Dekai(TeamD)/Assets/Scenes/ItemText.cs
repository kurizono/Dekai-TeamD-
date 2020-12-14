using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour
{
    public Text itemsetumei;
    itemget itemgets;
    // Start is called before the first frame update
    void Start()
    {
        itemgets = GetComponent<itemget>();
        itemsetumei.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        itemgets.getitem_adalt.onClick.AddListener(Adalt_Click);
        itemgets.getitem_cat.onClick.AddListener(Cat_Click);
        itemgets.getitem_cloth.onClick.AddListener(Cloth_Click);
        itemgets.getitem_dictionary.onClick.AddListener(Dictionary_Click);
        itemgets.getitem_diy.onClick.AddListener(Diy_Click);
        itemgets.getitem_general.onClick.AddListener(General_Click);
        itemgets.getitem_log.onClick.AddListener(Log_Click);
        itemgets.getitem_mazai.onClick.AddListener(Mazai_Click);
        itemgets.getitem_mypipe.onClick.AddListener(Mypipe_Click);
        itemgets.getitem_myth.onClick.AddListener(Myth_Click);
        itemgets.getitem_note.onClick.AddListener(Note_Click);
        itemgets.getitem_pillow.onClick.AddListener(Pillow_Click);
        itemgets.getitem_sign.onClick.AddListener(Sign_Click);
        itemgets.getitem_stick.onClick.AddListener(Stick_Click);
        itemgets.getitem_sword.onClick.AddListener(Sword_Click);
        itemgets.getitem_whitesweet.onClick.AddListener(Whitesweet_Click);
    }

    private void Adalt_Click()
    {
        itemsetumei.text = "adalt";
    }
    private void Cat_Click()
    {
        itemsetumei.text = "cat";
    }
    private void Cloth_Click()
    {
        itemsetumei.text = "cloth";
    }
    private void Dictionary_Click()
    {
        itemsetumei.text = "dictionary";
    }
    private void Diy_Click()
    {
        itemsetumei.text = "diy";
    }
    private void General_Click()
    {
        itemsetumei.text = "general";
    }
    private void Log_Click()
    {
        itemsetumei.text = "log";
    }
    private void Mazai_Click()
    {
        itemsetumei.text = "mazai";
    }
    private void Mypipe_Click()
    {
        itemsetumei.text = "mypipe";
    }
    private void Myth_Click()
    {
        itemsetumei.text = "myth";
    }
    private void Note_Click()
    {
        itemsetumei.text = "note";
    }
    private void Pillow_Click()
    {
        itemsetumei.text = "pillow";
    }
    private void Sign_Click()
    {
        itemsetumei.text = "sign";
    }
    private void Stick_Click()
    {
        itemsetumei.text = "stick";
    }
    private void Sword_Click()
    {
        itemsetumei.text = "sword";
    }
    private void Whitesweet_Click()
    {
        itemsetumei.text = "whitesweet";
    }
}

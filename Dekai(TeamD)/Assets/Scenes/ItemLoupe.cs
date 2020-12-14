using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLoupe : MonoBehaviour
{
    itemget itemgetcs;

    public GameObject Loupe_backgraund;
    public Button Return_button;

    public GameObject[] All_Item;
    public GameObject item_adalt, item_cat, item_cloth, item_dictionary;
    public GameObject item_diy, item_general, item_log, item_mazai;
    public GameObject item_mypipe, item_myth, item_note, item_pillow;
    public GameObject item_sign, item_stick, item_sword, item_whitesweet;

    // Start is called before the first frame update
    void Start()
    {
        itemgetcs = GetComponent<itemget>();

        All_Item = new GameObject[16]
        {
            item_adalt, item_cat, item_cloth, item_dictionary,
            item_diy, item_general, item_log, item_mazai,
            item_mypipe, item_myth, item_note, item_pillow,
            item_sign, item_stick, item_sword, item_whitesweet
        };

        First_Active();

        Return_button.onClick.AddListener(Return_Click);
        for (int i = 0; i < itemgetcs.getitem_all.Length; i++)
        {
            GameObject item = All_Item[i];
            itemgetcs.getitem_all[i].onClick.AddListener(() => { Item_Click(item); });
        }
    }

    private void First_Active()
    {
        Loupe_backgraund.SetActive(false);
        Return_button.gameObject.SetActive(false);
        for (int i = 0; i < All_Item.Length; i++)
        {
            All_Item[i].SetActive(false);
        }
    }

    private void Item_Click(GameObject setitem)
    {
        Loupe_backgraund.SetActive(true);
        Return_button.gameObject.SetActive(true);
        setitem.SetActive(true);
    }

    private void Return_Click()
    {
        First_Active();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public GameObject storytext_object, credittext_object;
    public Button start_button, story_button, credit_button, return_button;


    // Start is called before the first frame update
    void Start()
    {
        FirstPosi();
        start_button.onClick.AddListener(Start_Click);
        story_button.onClick.AddListener(Story_Click);
        credit_button.onClick.AddListener(Credit_Click);
        return_button.onClick.AddListener(Return_Click);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FirstPosi()
    {
        start_button.gameObject.SetActive(true);
        story_button.gameObject.SetActive(true);
        storytext_object.SetActive(false);
        credit_button.gameObject.SetActive(true);
        credittext_object.SetActive(false);
        return_button.gameObject.SetActive(false);
    }



    private void Start_Click()
    {
        SceneManager.LoadScene("game");
    }
    private void Story_Click()
    {
        All_False();
        storytext_object.SetActive(true);
        return_button.gameObject.SetActive(true);
    }
    private void Credit_Click()
    {
        All_False();
        credittext_object.SetActive(true);
        return_button.gameObject.SetActive(true);
    }
    private void Return_Click()
    {
        FirstPosi();
    }

    private void All_False()
    {
        start_button.gameObject.SetActive(false);
        story_button.gameObject.SetActive(false);
        credit_button.gameObject.SetActive(false);
        credittext_object.SetActive(false);
        return_button.gameObject.SetActive(false);
    }
}

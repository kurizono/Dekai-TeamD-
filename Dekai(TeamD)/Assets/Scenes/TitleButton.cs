using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    private GameObject start_object, story_object, credit_object, return_object;
    public GameObject credittext_object;
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
        start_object = start_button.gameObject;
        story_object = story_button.gameObject;
        credit_object = credit_button.gameObject;
        return_object = return_button.gameObject;
        start_object.SetActive(true);
        story_object.SetActive(true);
        credit_object.SetActive(true);
        credittext_object.SetActive(false);
        return_object.SetActive(false);
    }



    private void Start_Click()
    {
        SceneManager.LoadScene("game");
    }
    private void Story_Click()
    {

    }
    private void Credit_Click()
    {
        start_object.SetActive(false);
        story_object.SetActive(false);
        credit_object.SetActive(false);
        credittext_object.SetActive(true);
        return_object.SetActive(true);
    }
    private void Return_Click()
    {
        FirstPosi();
    }
}

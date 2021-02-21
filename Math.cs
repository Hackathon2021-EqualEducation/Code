using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour
{
    int a;
    int b;
    int total;
    int correct;
    int i;
    string model1;
    string model2;
    public GameObject AnswerInput;
    public GameObject Display;
    public static string answer;
    public GameObject Input;
    public GameObject Score;
    public GameObject Panel;
    public GameObject CorrectOrIncorrect;
    public GameObject ScorePanel;

    int convert;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        correct = 0;
        a = UnityEngine.Random.Range(1, 10);
        b = UnityEngine.Random.Range(1, 10);
        Debug.Log(a);
        Debug.Log(b);
        // Debug.Log(model1);
        //Debug.Log(model2);
        Display.GetComponent<Text>().text = a + " + " + b;
        Score.GetComponent<Text>().text = correct + "/10";
        Panel.SetActive(false);

    }

    // Update is called once per frame
    public void Answers()
    {
        total = (a + b);
        answer = AnswerInput.GetComponent<InputField>().text;
        convert = Convert.ToInt32(answer);





    }
    void Update()
    {
        if (i == 10)
        {
            Panel.SetActive(true);
            ScorePanel.GetComponent<Text>().text = "Your Score: " + correct + "/10";
        }

    }
    public void Check()
    {
        if (convert == total)
        {
            Debug.Log("Correct");
            correct += 1;
            CorrectOrIncorrect.GetComponent<Text>().text = "You're answer is correct";

        }
        else
        {
            Debug.Log("Incorrect");
            CorrectOrIncorrect.GetComponent<Text>().text = "You're answer is incorrect. " + a + " + " + b + " = " + total;

        }
        i++;
        a = UnityEngine.Random.Range(1, 10);
        b = UnityEngine.Random.Range(1, 10);
        Score.GetComponent<Text>().text = correct + "/10";
        Display.GetComponent<Text>().text = a + " + " + b;
        total = (a + b);
        Input.GetComponent<InputField>().text = "";
    }

}

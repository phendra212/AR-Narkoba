using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_materi_penang : MonoBehaviour
{
    public GameObject[] background;
    int index;
    public GameObject back;
    public GameObject next;

    void Start()
    {
        index = 0;
    }


    void Update()
    {
        if (index >= 8)
            index = 8;

        if (index < 0)
            index = 0;

        if (index == 2)
        {
            next.gameObject.SetActive(false);

        }
        else
        {
            next.gameObject.SetActive(true);
            back.gameObject.SetActive(true);

        }



        if (index == 0)
        {
            background[0].gameObject.SetActive(true);
            back.gameObject.SetActive(false);

        }

    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }


}
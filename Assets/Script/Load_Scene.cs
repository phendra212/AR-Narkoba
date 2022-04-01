using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour
{
    public string sceneName;

    public Button loadSceneBtn;

    // Start is called before the first frame update
    void Start()
    {
        loadSceneBtn.onClick.AddListener(ChangeScene);
    }


    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }


}
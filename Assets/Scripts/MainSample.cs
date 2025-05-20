using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainSample : MonoBehaviour
{
    [Inject]
    private Image _image;

    [Inject]
    private SceneController _sceneController;

    private void Awake()
    {
        // -image будет ненулевая
        _image.enabled = false;
    }

    public void OpenMainScene()
    {
        _sceneController.OpenMainScene();
    }        
}

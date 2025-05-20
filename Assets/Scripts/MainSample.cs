using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainSample : MonoBehaviour
{
    [Inject]
    private Image _image;

    private void Awake()
    {
        // -image будет ненулевая
        _image.enabled = false;
    }
}

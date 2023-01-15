using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainConfetti : MonoBehaviour
{
    public static int _blobVisited;
    public GameObject _confetti;

    private void Awake()
    {
        _confetti.SetActive(false);
    }
    private void Update()
    {
        if(_blobVisited>=4)
        {
            //RainConfetti
            _confetti.SetActive(true);
        }
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{
    

    public void LoadS()
    {
        SceneManager.LoadScene("GamePlay2");
    }
    public void LoadS1()
    {
        SceneManager.LoadScene("ManiManu");
    }
}

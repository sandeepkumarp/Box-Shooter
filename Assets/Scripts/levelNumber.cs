using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelNumber : MonoBehaviour
{

    int levelNum;
    public Text text;
    // Use this for initialization
    void Start()
    {
        levelNum = Application.loadedLevel+1;
        text.text = "LEVEL: " + levelNum;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Text Message;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Message.text = "GAMEOVER! \nPRESS ENTER TO RESTART GAME.";
        Message.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameLevel");
        }

    }
}

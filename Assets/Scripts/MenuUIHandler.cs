using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    //This is the handler of the main menu scene

    public TMP_InputField PlayerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerData.Instance.PlayerName = PlayerNameInput.text;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetTableNo : MonoBehaviour
{
    public InputField tableNoInput;
    string tableNo;

    public void saveTableNo() {
        tableNo = tableNoInput.text;
        PlayerPrefs.SetString("tableNoKeyName", tableNo);
        SceneManager.LoadScene(1);

    }

}

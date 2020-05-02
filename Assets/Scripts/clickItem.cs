using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class clickItem : MonoBehaviour
{
    // public int foodItemNo;
    // Start is called before the first frame update
    public void updateFoodItem(int foodItemNo) {
        PlayerPrefs.SetInt("foodItemNoGlobal", foodItemNo);
        SceneManager.LoadScene(2);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTableNo : MonoBehaviour
{
    string tableNo;
    public Text setTableNo;

    void Start()
    {
        tableNo = PlayerPrefs.GetString("tableNoKeyName");
        setTableNo.text = tableNo;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

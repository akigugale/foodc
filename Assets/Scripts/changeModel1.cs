using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using UnityEngine.SceneManagement;

public class changeModel1 : MonoBehaviour
{


   void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
  }

  void OnDisable() {
      SceneManager.sceneLoaded -= OnSceneLoaded;
  }
    private int currentModel;
    public GameObject[] FoodModelsArr;

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        currentModel = PlayerPrefs.GetInt("foodItemNoGlobal");
        Debug.Log("\n\n this is start \n " + currentModel);
        FoodModelsArr = GameObject.FindGameObjectsWithTag("foodModel");
        GameObject IT = GameObject.Find("ImageTarget");
        Debug.Log("IMAGE TARGET IS - " + FoodModelsArr);
        disableAll();
        changemodelscene();

   //do stuff
    }
    // private string[] FoodItemNames = new string[] {"Bread","chinese-rice-food","cookie","eggs-chives","fried-dumplings","cake","salad-head"};
    // private string[] FoodItemPrices = new string[] {"₹ 200/-","₹ 300/-","₹ 150/-", "₹ 175/-"};
    // private string[] FoodItemContents = new string[] {"Tender apple slices and sweet cinnamon baked into a classic lattice crust.", "Barley malt, corn, hops, yeast, antioxidants (ascorbic acid), and propylene glycol alginate as a stabiliser.", "Delicious combination of garden fresh lettuce, tomatoes, green peppers, onions, olives and pickles. Served on freshly baked bread.","The grandness of Dubai."};

    void Start(){
    }


    private void disableAll() {
        for(int i = 0; i < FoodModelsArr.Length; i++)
        {
             FoodModelsArr[i].SetActive(false);
        }
    }

    public void BacktoMainMenu()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void changemodelscene() {

        FoodModelsArr[currentModel].SetActive(true);
        // currentModel = (++currentModel) % FoodModelsArr.Length;
        // FoodModelsArr[currentModel].SetActive(true);

        Debug.Log("THE SIZE IS: " + FoodModelsArr.Length);

        Debug.Log("Button pressed");
        Debug.Log("CURRENT MODEL = " + currentModel);

        // -------------------- Change Item Name
        GameObject parent = GameObject.Find("Canvas");
        // parent.transform.Find("FoodItemName").GetComponent<TsText>().text = FoodItemContents[currentModel];

    }
    public void changemodelscene2() {
        FoodModelsArr[currentModel].SetActive(false);
        currentModel = (currentModel + FoodModelsArr.Length - 1) % FoodModelsArr.Length;
        FoodModelsArr[currentModel].SetActive(true);

        Debug.Log("THE SIZE IS: " + FoodModelsArr.Length);

        Debug.Log("Button pressed");
        Debug.Log("CURRENT MODEL = " + currentModel);

        // -------------------- Change Item Name
        GameObject parent = GameObject.Find("Canvas");
        // parent.transform.Find("FoodItemName").GetComponent<Text>().text = FoodItemNames[currentModel];
        // parent.transform.Find("FoodItemPrice").GetComponent<Text>().text = FoodItemPrices[currentModel];
        // parent.transform.Find("FoodItemContent").GetComponent<Text>().text = FoodItemContents[currentModel];

    }
}

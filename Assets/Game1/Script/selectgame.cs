using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectgame : MonoBehaviour {

    public static int[] item;
    public static int[] itemect;
    public GameObject SelectSex, SelectyypeMale, SelectyypeFemale,
        Gameinterface, Menu, male, female, maleregis,
        maleems, femaleregis, femaleems, costumeMale, costumeMaleEMS, costumeFemale, costumeFemaleEMS, selectgame1,
        CMmaleP1, CMmaleP2, CMmaleP3,
        CMmaleEMSP1, CMmaleEMSP2, CMmaleEMSP3,
        CMFemaleP1, CMFemaleP2, CMFemaleP3,
        CMFemaleEMSP1, CMFemaleEMSP2, CMFemaleEMSP3,
        TShirtM, CoatM, HelmetM, PlantM, ShoesM, IDCardM,
        TShirtEMS, CoatEMS, HelmetEMS, PlantEMS, ShoesEMS, IDCardEMS,
        TShirt, Coat, Helmet, Plant, Shoes, IDCard,
        TShirtFEMS, CoatFEMS, HelmetFEMS, PlantFEMS, ShoesFEMS, IDCardFEMS,
        GameLogicGame1;
    public int type_game1;
	// Use this for initialization
	void Start () {
        StartGame();
    }
    public void StartGame()
    {
        SelectSex.SetActive(true);
        SelectyypeMale.SetActive(false);
        SelectyypeFemale.SetActive(false);
        Gameinterface.SetActive(false);
        Menu.SetActive(false);
        male.SetActive(false);
        female.SetActive(false);
        maleregis.SetActive(false);
        maleems.SetActive(false);
        femaleregis.SetActive(false);
        femaleems.SetActive(false);
        costumeMale.SetActive(false);
        costumeMaleEMS.SetActive(false);
        costumeFemale.SetActive(false);
        costumeFemaleEMS.SetActive(false);
        selectgame1.SetActive(false);
        GameLogicGame1.SetActive(false);
        randomitem();
        randomitemect();
}
// Update is called once per frame
public void randomitem()
{
    int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    item = numbers.OrderBy(keySelector: n => Guid.NewGuid()).ToArray();

}
    public void randomitemect()
    {
        int[] numbers = new[] { 1, 2};
        itemect = numbers.OrderBy(keySelector: n => Guid.NewGuid()).ToArray();
    }
    public void SelectSexMan()
    {
        SelectSex.SetActive(false);
        SelectyypeMale.SetActive(true);
        SelectyypeFemale.SetActive(false);
        Gameinterface.SetActive(false);
        Menu.SetActive(false);
        
    }
    public void SelectSexWoman()
    {
        SelectSex.SetActive(false);
        SelectyypeMale.SetActive(false);
        SelectyypeFemale.SetActive(true);
        Gameinterface.SetActive(false);
        Menu.SetActive(false);
        
    }
    public void restartCurrentScene()
    {
        GameLogic.score = 0f;
        GameLogic.time = 60f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void SelectGame_1()
    {
        selectgame1.SetActive(true);
        SelectyypeMale.SetActive(false);
        SelectyypeFemale.SetActive(false);
        Gameinterface.SetActive(false);
        Menu.SetActive(false);
        male.SetActive(false);
        female.SetActive(false);
        maleregis.SetActive(false);
        maleems.SetActive(false);
        femaleregis.SetActive(false);
        femaleems.SetActive(false);
        costumeMale.SetActive(false);
        costumeMaleEMS.SetActive(false);
        costumeFemale.SetActive(false);
        costumeFemaleEMS.SetActive(false);
        TShirtM.SetActive(false);
        CoatM.SetActive(false);
        HelmetM.SetActive(false);
        PlantM.SetActive(false);
        ShoesM.SetActive(false);
        IDCardM.SetActive(false);
        TShirtEMS.SetActive(false);
        CoatEMS.SetActive(false);
        HelmetEMS.SetActive(false);
        PlantEMS.SetActive(false);
        ShoesEMS.SetActive(false);
        IDCardEMS.SetActive(false);
        TShirt.SetActive(false);
        Coat.SetActive(false);
        Helmet.SetActive(false);
        Plant.SetActive(false);
        Shoes.SetActive(false);
        IDCard.SetActive(false);
        TShirtFEMS.SetActive(false);
        CoatFEMS.SetActive(false);
        HelmetFEMS.SetActive(false);
        PlantFEMS.SetActive(false);
        ShoesFEMS.SetActive(false);
        IDCardFEMS.SetActive(false);
        randomitem();
        randomitemect();
    }
    public void Menu_MaleSelect()
    {
        selectgame1.SetActive(true);
        type_game1 = 1;
    }
    public void Menu_MaleSelectEMS()
    {
        selectgame1.SetActive(true);
        type_game1 = 2;

    }
    public void Menu_FemaleSelect()
    {
        selectgame1.SetActive(true);
        type_game1 = 3;
    }

    public void Menu_FemaleSelectEms()
    {
        selectgame1.SetActive(true);
        type_game1 = 4;
    }
    public void startgame1()
    {
        if(type_game1 == 1)
        {
            SelectSex.SetActive(false);
            SelectyypeMale.SetActive(false);
            SelectyypeFemale.SetActive(false);
            Gameinterface.SetActive(true);
            Menu.SetActive(true);
            maleregis.SetActive(true);
            costumeMale.SetActive(true);
            selectgame1.SetActive(false);
            male.SetActive(true);
            CMmaleP1.SetActive(true);
            CMmaleP2.SetActive(false);
            CMmaleP3.SetActive(false);
            GameLogicGame1.SetActive(true);
        }
        if (type_game1 == 2)
        {
            SelectSex.SetActive(false);
            SelectyypeMale.SetActive(false);
            SelectyypeFemale.SetActive(false);
            Gameinterface.SetActive(true);
            Menu.SetActive(true);
            maleems.SetActive(true);
            costumeMaleEMS.SetActive(true);
            costumeFemaleEMS.SetActive(true);
            selectgame1.SetActive(false);
            male.SetActive(true);
            CMmaleEMSP1.SetActive(true);
            CMmaleEMSP2.SetActive(false);
            CMmaleEMSP3.SetActive(false);
            GameLogicGame1.SetActive(true);
        }
        if (type_game1 == 3)
        {
            SelectSex.SetActive(false);
            SelectyypeMale.SetActive(false);
            SelectyypeFemale.SetActive(false);
            Gameinterface.SetActive(true);
            Menu.SetActive(true);
            femaleregis.SetActive(true);
            costumeFemale.SetActive(true);
            selectgame1.SetActive(false);
            female.SetActive(true);
            CMFemaleP1.SetActive(true);
            CMFemaleP2.SetActive(false);
            CMFemaleP3.SetActive(false);
            GameLogicGame1.SetActive(true);
        }
        if (type_game1 == 4)
        {
            SelectSex.SetActive(false);
            SelectyypeMale.SetActive(false);
            SelectyypeFemale.SetActive(false);
            Gameinterface.SetActive(true);
            Menu.SetActive(true);
            femaleems.SetActive(true);
            costumeFemaleEMS.SetActive(true);
            selectgame1.SetActive(false);
            female.SetActive(true);
            CMFemaleEMSP1.SetActive(true);
            CMFemaleEMSP2.SetActive(false);
            CMFemaleEMSP3.SetActive(false);
            GameLogicGame1.SetActive(true);
        }
    }

}

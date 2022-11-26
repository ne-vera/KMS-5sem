using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    TMP_Text message;               //ОБЪЕКТНАЯ ПЕРЕМЕННАЯ ТИПА TEXT   
    public GameObject ammeter;
    public GameObject capacitor;
    public GameObject ressistBox;
    public GameObject latr;
    public GameObject oscilloscope;
    public GameObject torus;
    public Material plasticGloss;
    public Material greyMetalic;
    public Material highlited;
    public Material redWood;
    public Material copper;

    public void InfoAmmeter()
    {
        message.text = "Амперметр";
    }

     public void InfoCapacitor()
    {
        message.text = "Конденсатор";
    }

    public void InfoResistBox()
    {
        message.text = "Коробка резисторов";
    }

    public void InfoLATR()
    {
        message.text = "Лабораторные автотрансформаторы (ЛАTР) — это автотрансформаторы с возможностью плавного и точного регулирования выходного напряжения.";
    }

    public void InfoOscilloscope()
    {
        message.text = "Осциллограф";
    }
    
    public void InfoTorus()
    {
        message.text = "Тороидальная катушка";
    }
    public void OnExit()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ 
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }

    #region Изменение цвета амперметра
    public void HighliteAmmeter()          
    {
        ammeter.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultAmmeter()          
    {
        ammeter.GetComponent<Renderer>().material = plasticGloss;
    }
    #endregion

    #region Изменение цвета конденсатора
    public void HighliteCapacitor()          
    {
        capacitor.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultCapacitor()          
    {
        capacitor.GetComponent<Renderer>().material = greyMetalic;
    }
    #endregion

      #region Изменение цвета коробки резисторов
    public void HighliteResistBox()          
    {
        ressistBox.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultResistBox()          
    {
        ressistBox.GetComponent<Renderer>().material = redWood;
    }
    #endregion

    #region Изменение цвета ЛАТРа
    public void HighliteLATR()          
    {
        latr.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultLATR()          
    {
        latr.GetComponent<Renderer>().material = plasticGloss;
    }
    #endregion

    #region Изменение цвета осциллографа
    public void HighliteOscilliscope()          
    {
        oscilloscope.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultOscilloscope()          
    {
        oscilloscope.GetComponent<Renderer>().material = greyMetalic;
    }
    #endregion

        #region Изменение цвета тороидальная катушка
    public void HighliteTorus()          
    {
        torus.GetComponent<Renderer>().material = highlited;
    }
    public void DefaultTorus()          
    {
        torus.GetComponent<Renderer>().material = copper;
    }
    #endregion

}
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

    public string defaultText;

    public void Start()
    {
        defaultText = message.text;
    }

    public void InfoAmmeter()
    {
        message.text = "Амперме́тр — прибор для измерения силы тока в амперах.";
    }

     public void InfoCapacitor()
    {
        message.text = "Конденса́тор — устройство для накопления заряда и энергии электрического поля.";
    }

    public void InfoResistBox()
    {
        message.text = "Магазин электрического сопротивления — образцовые резисторы, специально сконструированные и изготовленные для использования в качестве мер электрического сопротивления.";
    }

    public void InfoLATR()
    {
        message.text = "Лабораторные автотрансформаторы (ЛАTР) — это автотрансформаторы с возможностью плавного и точного регулирования выходного напряжения.";
    }

    public void InfoOscilloscope()
    {
        message.text = "Осциллограф — прибор, предназначенный для исследования амплитудных и временных параметров электрического сигнала, подаваемого на его вход, и наглядно отображаемого непосредственно на экране либо регистрируемого на фотоленту.";
    }
    
    public void InfoTorus()
    {
        message.text = "Тороидальные катушки — это электрические компоненты, которые состоят из металлического сердечника в форме кольца, который имеет проводящий металлический провод, намотанный на петлю или намотанный вокруг него, чтобы сформировать катушку индуктивности.";
    }
    public void OnExit()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ 
        message.text = defaultText;
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
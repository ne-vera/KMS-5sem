using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Practice : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;


    //default text
     public void OnExit()
    {
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }

    //1 задание
    public void Set1A()
    {
        message.text = "Переключателем на амперметре установите диапазон, обеспечивающий измерение тока 1 А.";
        StateVariables.canChangeCurrency = true;
    }
    //2 задание
    public void EnableOscilloscope()
    {
        message.text = "Включите осциллограф.";
    }

    public void CenterPoint()
    {
         message.text = "Регуляторами на передней панели выведите световую точку в центр экрана";
    }
    //3 задание
    public void SetLATRZero()
    {
        message.text = "Рукоятку ЛАТРа установите в положение «0»";
    }

    public void PlugIn()
    {
        message.text = "Включите установку в сеть.";
    }
    //4 задание
    public void SetCurrency()
    {
        message.text = "Установите ЛАТРом ток в обмотке тороида I = 0,6 А";
    }

    public void MaxHysteresis()
    {
        message.text = "Получите максимальное изображение петли гистерезиса в пределах экрана осциллографа, манипулируя ручкой «В/дел» осциллографа и изменяя величину сопротивления R и емкости С на магазинах сопротивлений и емкостей";
    }
    void Update()
    {
        if (StateVariables.is1A)
        {
            EnableOscilloscope();
        }

        if (StateVariables.isOscilloscopeEnabled)
        {
            CenterPoint();
        }

        if (StateVariables.isLATRZero)
        {
            PlugIn();
        }

        if (StateVariables.isPlugged)
        {
            SetCurrency();
        }

        if (StateVariables.isCurrency)
        {
            MaxHysteresis();
        }
    }
}

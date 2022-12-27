﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskFlow : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;
    public GameObject InputPanel;
    // Start is called before the first frame update

    public void OnExit()
    {
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }

    public void StartPractice()
    {
        StateVariables.step = 1;
    }
    // Update is called once per frame
    void Update()
    {
        switch (StateVariables.step)
        {
            case 1:
                message.text = "Переключателем на амперметре установите диапазон, обеспечивающий измерение тока 1 А.";
                break;
            case 2:
                message.text = "Включите осциллограф.";
                break;
            case 3:
                message.text = "Регуляторами на передней панели выведите световую точку в центр экрана";
                break;
            case  4:
                message.text = "Рукоятку ЛАТРа установите в положение «0»";
                break;  
            case  5:
                message.text = "Включите установку в сеть.";
                break;
            case 6:
                message.text = "Установите ЛАТРом ток в обмотке тороида I = 0,6 А";
                break;
            case 7:
                message.text = "Получите максимальное изображение петли гистерезиса в пределах экрана осциллографа, изменяя величину сопротивления R из диапазона 8,0−9,5 кОм на магазине сопротивлений";
                break;
            case 8:
                message.text = "Запишите значение R в таблицу";
                InputPanel.SetActive(true);
                break;
            case 9:
                message.text ="и емкости С из диапазона 0,4−0,8 мкФ на магазине емкостей";
                InputPanel.SetActive(false);
                break;
            case 10:
                message.text = "Запишите значение C в таблицу";
                InputPanel.SetActive(true);
                break;
            case 11:
                message.text = "Снова выставьте рукоятку ЛАТРа в исходное положение (ток равен нулю).";
                InputPanel.SetActive(false);
                break;
            case 12:
                message.text = $"Поворотом рукоятки ЛАТРа установите по амперметру ток {StateVariables.currency} А";
                break;
            case 13:
                message.text = "Запишите в делениях шкалы экрана координаты точек пересечения петли гистерезиса с осями координат Xk";
                break;
            case 14:
                message.text = "Запишите в делениях шкалы экрана координаты точек пересечения петли гистерезиса с осями координат Yk";
                break;
            case 15:
                message.text = "Запишите в делениях шкалы экрана координаты вершин петли Xm";
                break;
            case 16:
                message.text = "Запишите в делениях шкалы экрана координаты вершин петли Ym";
                break;
        }
    }
}

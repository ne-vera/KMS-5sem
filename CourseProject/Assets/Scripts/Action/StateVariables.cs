using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StateVariables 
{
    public static bool canChangeCurrency = false;
    public static bool is1A = false;
    public static bool isOscilloscopeEnabled = false;
    public static bool isCentrallized = false;
    public static bool isLATRZero = false;
    public static bool isPlugged = false;

    public static float currency = 0;

    public static bool isResistanceSet = false;
    public static int step = 0;

    //1. Переключателем на амперметре установите диапазон, обеспечивающий измерение тока 1 А
    //2. Включите осциллограф.
    //3. Регуляторами на передней панели выведите световую точку в центр экрана
    //4. Рукоятку ЛАТРа установите в положение «0»
    //5. Включите установку в сеть.
    //6. Установите ЛАТРом ток в обмотке тороида I = 0,6 А
    //7. Получите максимальное изображение петли гистерезиса в пределах экрана осциллографа, изменяя величину сопротивления R из диапазона 8,0−9,5 кОм на магазине сопротивлений
    //8. Запишите значение R в таблицу
    //9. и емкости С из диапазона 0,4−0,8 мкФ на магазине емкостей
    //10. Запишите значение C в таблицу
    //11. Снова выставьте рукоятку ЛАТРа в исходное положение (ток равен нулю). 
    
    //12. Поворотом рукоятки ЛАТРа установите по амперметру ток 0,1 А
    //13. Запишите в делениях шкалы экрана координаты точек пересечения петли гистерезиса с осями координат 
    //14. Xк
    //15. Yк
    //16. вершин петли Xm, 
    //17. Ym 

    //повторить 12-17 с 0.05 до 0.6 а

}

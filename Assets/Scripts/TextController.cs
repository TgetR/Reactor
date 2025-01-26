using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    TemperatureControll temperature;
    EnergyControll energy;
    public TMP_Text textTemperature;
    public TMP_Text textTemperatureMax;
    public TMP_Text textEnergy;
    public TMP_Text textEnergyMax;
    public GlobalData globalData;
    private void Start()
    {
        temperature = GetComponent<TemperatureControll>();
        energy = GetComponent<EnergyControll>();
    }
    private void Update()
    {
        textEnergy.text = "���������������: " + energy.EnergyProduction + " ����.���";
        textEnergyMax.text = "��������: " + globalData.EnergyMax + " ����.���";
        textTemperature.text = "�����������: " + temperature.Temperature + "�C";
        textTemperatureMax.text = "��������: " + globalData.TemperatureMax + "�C";

    }
}

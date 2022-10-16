using System;
using Event;
using UnityEngine;
using UnityEngine.UI;

namespace MenuScene
{
    public class Examination : MonoBehaviour
    {
        [SerializeField] private Text _inputTime;
        [SerializeField] private Text _inputSpeed;
        [SerializeField] private Text _inputDistance;
        
        public void ExaminationInput()
        {
            if (_inputTime.text != "" & _inputSpeed.text != "" & _inputDistance.text != "")
            {
                GlabalEventManager.OnInputData.Invoke(
                    Convert.ToInt32(_inputTime.text),
                    Convert.ToInt32(_inputSpeed.text),
                    Convert.ToInt32(_inputDistance.text));
                Debug.Log("Переход на другую сцену");
            }
        }
    }
}
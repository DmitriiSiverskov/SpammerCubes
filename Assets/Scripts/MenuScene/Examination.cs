using System;
using ActionScene;
using Structure;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MenuScene
{
    public class Examination : MonoBehaviour
    {
        [SerializeField] private Text _inputTime;
        [SerializeField] private Text _inputSpeed;
        [SerializeField] private Text _inputDistance;
        
        public void ExaminationInput(int i)
        {
            if (_inputTime.text != "" & _inputSpeed.text != "" & _inputDistance.text != "")
            {
                InstanceCubes.StructureData = new StructureInputData( 
                    Convert.ToInt32(_inputTime.text),
                    Convert.ToInt32(_inputSpeed.text),
                    Convert.ToInt32(_inputDistance.text));
                SceneManager.LoadScene(i);
            }
        }
    }
}
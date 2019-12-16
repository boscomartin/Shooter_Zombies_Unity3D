using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevel : MonoBehaviour
{
    public void StarWaveLevel()
    {
        _isStart = true;
    }

    //Cada estado de las oleadas es independiente y una vez que finaliza uno se activa el siguiente
    //Podremos elegir cuantas oleadas habrá
    public void Execute()
    {
        if (_isStart == false || _currentIndex >= _waves.Length)
        {
            return;
        }
        switch (_waves[_currentIndex].CurrentState)
        {
            case Wave.State.Setup:

                _waves[_currentIndex].Setup();
                _waves[_currentIndex].ChangeState(Wave.State.Begin);

                break;

            case Wave.State.Begin:

                if (_waves[_currentIndex].Begin())
                {
                    _waves[_currentIndex].ChangeState(Wave.State.Run);
                }

                break;

            case Wave.State.Run:

                if (_waves[_currentIndex].Run())
                {
                    _waves[_currentIndex].ChangeState(Wave.State.End);
                }

                break;

            case Wave.State.End:

                _waves[_currentIndex].End();
                if (_currentIndex == _waves.Length - 1)
                {
                    _isStart = false;
                }
                else
                {
                    _currentIndex++;
                }

                break;

        }

    }

    [SerializeField]
    private Wave[] _waves;
    private int _currentIndex = 0;
    private bool _isStart = false;
}

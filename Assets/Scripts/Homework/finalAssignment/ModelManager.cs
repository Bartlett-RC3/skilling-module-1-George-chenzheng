using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int numberOfX = 10;
        [SerializeField] private int numberOfY = 10;

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;

        private List<Cell> _cellList = new List<Cell>();
        private List<List<Cell>> _frameList = new List<List<Cell>>();

        private IEnumerator coroutine;

        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            // create cell array
            _cells = new Cell[numberOfY, numberOfX];

            // instantiate cell prefabs and store in array
            for (int y = 0; y < numberOfY; y++)
            {
                for (int x = 0; x < numberOfX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                }
            }

            // create model
            _model = new GameOfLife2D(numberOfY, numberOfX);

            // initialize model
            _initializer.Initialize(_model.CurrentState);

            coroutine = ShowAge();
            StartCoroutine(coroutine);

        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {

            CheckPressing();

            _model.Step();
            _stepCount++;
 
            int[,] state = _model.CurrentState;


            // update cells based on current state of model
            for (int y = 0; y < numberOfY; y++)
            {
                for (int x = 0; x < numberOfX; x++)
                {
                    if (_cells[y, x].State == 1 && state[y, x] == 1)
                    {
                        _cells[y, x].Age += 1;
                    }
                    else if (_cells[y, x].State == 0 && state[y, x] == 1)
                    {
                        _cells[y, x].Age = 1;
                    }
                    else if (state[y, x] == 0)
                    {
                        _cells[y, x].Age = 0;
                    }


                    _cells[y, x].State = state[y, x];
                   
                    _cellList.Add(_cells[y, x]);
                    _frameList.Add(_cellList);
                    Debug.Log(_cells[y, x].Age);
                }
            }
        }

        private IEnumerator ShowAge()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);

                for (int y = 0; y < numberOfY; y++)
                {
                    for (int x = 0; x < numberOfX; x++)
                    {
                        int age = _cells[y, x].Age;
                        _cells[y, x].GetComponent<Renderer>().material.color = new Color(0.2f * age, 0.2f * age, 0.2f * age);
                    }
                }
            }

        }

        private void CheckPressing()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _model._rules = Rules.Rule2333;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                _model._rules = Rules.Rule3435;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _model._rules = Rules.Rule2636;
            }

        }

    }

}




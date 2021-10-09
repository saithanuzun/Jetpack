using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jetpack.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] int coins=0;
        private void Awake()
        {
            SingletonThisObject();
        }
        
        public void IncreaseCoin(int coin)
        {
            coins += coin;
        }
        public void restrat()
        {
            SceneManager.LoadScene(0);
        }


        private void SingletonThisObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}


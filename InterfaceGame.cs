using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceGame : MonoBehaviour {

    public Text pontos;
    public Canvas canvas;
    public Text velocidade;
    private int pontuação = 1000;
    public float speed = 0;
    private float MaxSpeed = 300;
    private float MinSpeed = 0;
    public GameObject fimdojogo;

    void Start()
    {
        pontos.text = pontuação.ToString();
        speed = 0;
        velocidade.text = speed.ToString();
        GameObject.Find("Restart").GetComponentInChildren<Text>().text = "RESTART";
        fimdojogo.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speed >= MaxSpeed)
            {
                speed = MaxSpeed;
                velocidade.text = speed.ToString();
            }

            else if(/*speed >= MinSpeed &&*/ speed < MaxSpeed)
            {
                speed += 2;
                Debug.Log("velocidade = " + speed);
                velocidade.text = speed.ToString();
            }
            if(speed > 60)
            {
                Debug.Log("Multa");
            }
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (speed >= MinSpeed && speed <= MaxSpeed)
            {
                speed -= 5;
                Debug.Log("velocidade = " + speed);
                velocidade.text = speed.ToString();
            }
            if (speed > 60)
            {
                Debug.Log("Multa");
            }

        }
        else /*if (Input.GetKey(KeyCode.DownArrow))*/
        {
            if (speed > MinSpeed && speed <= MaxSpeed)
            {
                speed -= 1;
                velocidade.text = speed.ToString();
            }

            if (speed > 60)
            {
                Debug.Log("Multa");
            }
        }
        if (speed < MinSpeed)
        {
            speed = 0;
            velocidade.text = speed.ToString();
        }
            
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Carta_CFC")
        {
            // Se colidiu faz sumir carta_cfc (pois o player a pegou)
            Debug.Log("Pegou CFC");
            Destroy(col.gameObject);

            // Aumenta a pontuação do player
            pontuação += 10;
            pontos.text = pontuação.ToString();
        }

        if (col.gameObject.tag == "Carteira")
        {
            // Se colidiu faz sumir carta_cfc (pois o player a pegou)
            Debug.Log("Pegou Carteira");
            Destroy(col.gameObject);

            //Mostra a tela de Game over
            //SceneManager.LoadScene("FimdoJogo", LoadSceneMode.Additive);
            fimdojogo.SetActive(true);

        }

    }

    void OnCollisionEnter(Collision col) { 

         if (col.gameObject.tag == "Building" || col.gameObject.tag == "Arvore")
        {
            Debug.Log("Seu boçal");
            pontuação -= 30;
            pontos.text = pontuação.ToString();
        }

        else if (col.gameObject.tag == "Carro" || col.gameObject.tag == "Humano")
        {
            Debug.Log("Seu boçal");
            pontuação -= 60;
            pontos.text = pontuação.ToString();
        }
    
    }
}

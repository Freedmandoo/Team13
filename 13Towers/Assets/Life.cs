using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
    private int lives;







    // Use this for initialization
    void Awake()
    {

       
    }


    void Start()
    {
      
        setLives(WaveSpawner.life);
       
    }

    public void setLives(int newLife)
    {
        lives = newLife;
    }

    public int getLives()
    {
        return lives;
    }


    public void decLife()
    {
        setLives(getLives() - 1);

    }
	
	// Update is called once per frame
	void Update () {
	    if (getLives() == 0)
        {
            Destroy(gameObject);
            
            
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lighthouse")
        {
            decLife();
            GameScore.scoreValue += 100;

            Debug.Log(ScoreScript.scoreValue);
            //Destroy(gameObject);

        }
    }


}

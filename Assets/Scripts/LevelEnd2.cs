using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEnd2 : MonoBehaviour {

	public string levelToLoad;

	public PlayerController thePlayer;
	public CameraController1 theCamera;
	public LevelManager theLevelManager;

	public float waitToMove;
	public float waitToLoad;
	private bool movePlayer;

	public GameObject pauseScreen;

    public bool tutorial;

    public float score;
    public float scoretobeatlevel;
    public GameObject LevelEndScreen;
    public Text scoreText;
    public bool levelactive;
    public Text finalscore;
    public Image goldstar;

	// Use this for initialization
	void Start () {

       
        

    }
	
    //IEnumerator FindPlayer()
    //{
    //    //yield return new WaitForSeconds(.25f);
    //  
    //
    //}
	// Update is called once per frame
	void fixedUpdate () {
        if (levelactive == true)
        {
            scoreText.text = "score:" + (Mathf.RoundToInt(score));
            score += .025f;
        }

        finalscore.text = "FINAL SCORE:" + (Mathf.RoundToInt(score));
        thePlayer = FindObjectOfType<PlayerController>();
        if (movePlayer) 
		{
			thePlayer.myRigidBody.velocity = new Vector3 (thePlayer.moveSpeed, thePlayer.myRigidBody.velocity.y, 0f);
		}
        if (score >= scoretobeatlevel)
        {
            LevelEnd();
        }
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
			{
				//SceneManager.LoadScene(levelToLoad);
			   LevelEnd();
			}

        if (tutorial == true)
        {
            PlayerPrefs.SetInt("lvlStart", 1);
        }
	}

	public void LevelEnd()
	{
        levelactive = false;
		thePlayer.canMove = false;
		theCamera.followTarget = false;
		//pauseScreen.SetActive (false);
		theLevelManager.invincible = true;
		thePlayer.myRigidBody.velocity = Vector3.zero;

		//PlayerPrefs.SetInt ("CoinCount", theLevelManager.coinCount);
		//PlayerPrefs.SetInt ("PlayerLives", theLevelManager.currentLives);
        PlayerPrefs.SetInt("GB", 2);

        theLevelManager.levelMusic.Stop ();
		theLevelManager.gameOverMusic.Play ();

        //yield return new WaitForSeconds (waitToMove);
        //movePlayer = true;

        //yield return new WaitForSeconds (waitToLoad);
        //SceneManager.LoadScene(levelToLoad);
        LevelEndScreen.SetActive(true);

        if (score > 100)
        {
            //goldstar.enabled = true;

        }
	}
}

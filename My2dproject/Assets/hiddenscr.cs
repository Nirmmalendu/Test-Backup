using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hiddenscr : MonoBehaviour {

    //public GameObject animobj;
    public AudioSource soundclip;
    public AudioSource alart;
    public AudioSource clap;
    public AudioSource back;
    private int count;
    public Text countText;
    public GameObject panel;
    Animator anim;
    //Use this for initialization
    void Start () {
        scorescr.scorevalue = 0;
        count = 3;
        countText.text = "Attempt Left :" + count.ToString();
        panel.SetActive(false);
        soundclip.Stop();
        alart.Stop();
        clap.Stop();
        anim = GetComponent<Animator>();
        anim.StopPlayback();



    }

    // Update is called once per frame
    void FixedUpdate() {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);

        
            if (hit.collider != null)
            {


                
                
                
                //gameObject.animation["animationName"].wrapMode = WrapMode.Once;
                soundclip.Play();
                scorescr.scorevalue += 10;
                Destroy(hit.transform.gameObject);
                if (scorescr.scorevalue >= 30)
                {                
                    clap.Play();
                    panel.SetActive(true);
                    Time.timeScale = 0;
                }
            }

                if (hit.collider == null)
            {
                alart.Play();
                //Debug.Log("Fail");
                count = count - 1;
                countText.text = "Attempt Left :" + count.ToString();

                if (count < 0 )
                {
                    
                    SceneManager.LoadScene("gameover");        
                }

            }

        }

    }

    public void khanamim()
    {
        anim.Play("New Animation");
    }
}

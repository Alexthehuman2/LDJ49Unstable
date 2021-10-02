using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnstableEffects : MonoBehaviour
{
    [SerializeField] private Button start_game;
    [SerializeField] private Animator buttonAnim;
    [SerializeField] private Animator title_player_anim;
    [SerializeField] private Animator title_anim;
    [SerializeField] private Text start_text;
    [SerializeField] private Text title;
    [SerializeField] private int min_rando = 1;
    [SerializeField] private int max_rando = 10;
    [SerializeField] private Image bg;
    private void Start()
    {
        buttonAnim = GameObject.Find("Exit").GetComponent<Animator>();
        title_player_anim = GameObject.Find("PlayerLaunch").GetComponent<Animator>();
        int death = DeathCountSGT.Instance.val;
        if (death >= 1 && death < 4)
        {

            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }
            if (Random.Range(min_rando, max_rando) > 7)
            {
                buttonAnim.SetBool("isDroppable", true);
            }
        }
        if (death >=4 && death < 7)
        {

            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }
            if (Random.Range(min_rando, max_rando) > 7)
            {
                title_anim.GetComponent<Animator>().SetBool("titleDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 8)
            {
                title_player_anim.SetBool("canLaunch", true);
            }
        }
        if (death >= 7 && death < 10)
        {

            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }

            if (Random.Range(min_rando, max_rando) > 6)
            {
                start_game.gameObject.transform.localScale = new Vector3(start_game.gameObject.transform.localScale.x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 7)
            {
                buttonAnim.SetBool("isDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 7)
            {
                title_player_anim.SetBool("canLaunch", true);
            }
        }
        if (death >= 10 && death < 13)
        {
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_game.gameObject.transform.localScale = new Vector3(start_game.gameObject.transform.localScale.x * -1, 1, 1);
            }
            if (Random.Range(min_rando,max_rando) > 5)
            {
                //reverse title
                float title_scale_x = title.gameObject.transform.localScale.x;
                title.gameObject.transform.localScale = new Vector3(title_scale_x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                title_anim.GetComponent<Animator>().SetBool("titleDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 9)
            {
                bg.color = Color.red;
            }
        }

        if (death >= 13 && death < 16)
        {
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }

            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_game.gameObject.transform.localScale = new Vector3(start_game.gameObject.transform.localScale.x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_x = title.gameObject.transform.localScale.x;
                title.gameObject.transform.localScale = new Vector3(title_scale_x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_y = title.gameObject.transform.localScale.y;
                title.gameObject.transform.localScale = new Vector3(1, title_scale_y * -1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                title_anim.GetComponent<Animator>().SetBool("titleDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                buttonAnim.SetBool("isDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                title_player_anim.SetBool("canLaunch", true);
            }
            if (Random.Range(min_rando, max_rando) > 8)
            {
                bg.color = Color.red;
            }
        }

        if (death >= 16 && death < 19)
        {
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_game.gameObject.transform.localScale = new Vector3(start_game.gameObject.transform.localScale.x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_x = title.gameObject.transform.localScale.x;
                title.gameObject.transform.localScale = new Vector3(title_scale_x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_y = title.gameObject.transform.localScale.y;
                title.gameObject.transform.localScale = new Vector3(1, title_scale_y * -1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float text_scale_y = start_text.gameObject.transform.localScale.y;
                start_text.gameObject.transform.localScale = new Vector3(1, text_scale_y * -1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                title_anim.GetComponent<Animator>().SetBool("titleDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                buttonAnim.SetBool("isDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                title_player_anim.SetBool("canLaunch", true);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                bg.color = Color.red;
            }
        }
        if (death >= 19)
        {
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_text.color = Color.green;
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                title.color = Color.cyan;
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                start_game.gameObject.transform.localScale = new Vector3(start_game.gameObject.transform.localScale.x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_x = title.gameObject.transform.localScale.x;
                title.gameObject.transform.localScale = new Vector3(title_scale_x * -1, 1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float title_scale_y = title.gameObject.transform.localScale.y;
                title.gameObject.transform.localScale = new Vector3(1, title_scale_y * -1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                float text_scale_y = start_text.gameObject.transform.localScale.y;
                start_text.gameObject.transform.localScale = new Vector3(1, text_scale_y * -1, 1);
            }
            if (Random.Range(min_rando, max_rando) > 6)
            {
                title_anim.GetComponent<Animator>().SetBool("titleDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                buttonAnim.SetBool("isDroppable", true);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                title_player_anim.SetBool("canLaunch", true);
            }
            if (Random.Range(min_rando, max_rando) > 5)
            {
                bg.color = Color.red;
            }
        }
    }
}

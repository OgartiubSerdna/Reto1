using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TransicionEscena : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private AnimationClip animacionfinal;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CambiarEscena());
        }
    }

    IEnumerator CambiarEscena()
    {
        animator.SetTrigger("Iniciar");

        yield return new WaitForSeconds(animacionfinal.length);

        SceneManager.LoadScene("World1");
    }
}

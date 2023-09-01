using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    static int hashAttack = Animator.StringToHash("Attack");
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Test"))
        {
            animator.SetTrigger(hashAttack);
        }
    }
}

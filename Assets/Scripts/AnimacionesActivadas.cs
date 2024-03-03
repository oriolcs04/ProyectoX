using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject[] prefabs; 
    private bool isAnimating = false;

    public void ActivateAnimator()
    {
        if (!isAnimating)
        {
            foreach (GameObject prefab in prefabs)
            {
                Animator animator = prefab.GetComponent<Animator>();
                if (animator != null)
                {
                    animator.enabled = true; 
                }
            }

            isAnimating = true;
            Invoke("DeactivateAnimator", 3f); 
        }
    }

    private void DeactivateAnimator()
    {
        foreach (GameObject prefab in prefabs)
        {
            Animator animator = prefab.GetComponent<Animator>();
            if (animator != null)
            {
                animator.enabled = false; 

            }
        }

        isAnimating = false;
    }
}
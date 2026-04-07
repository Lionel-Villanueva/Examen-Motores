using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    public float delay = 2f;
    public float explosionRadius = 5f;

    void Start()
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(delay);

        Collider[] hits = Physics.OverlapSphere(transform.position, explosionRadius);

        for (int i = 0; i < hits.Length; i++) 
        {
            if (!hits[i].CompareTag("Enemy") ) continue;
            GameObject enemy = hits[i].gameObject;

            if (enemy != null) 
            {
                Destroy(enemy);
            }

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
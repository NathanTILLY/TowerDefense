using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// 
    private Transform enemytransform { get; set; } = null;
    private void Start()
    {
        enemytransform = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
}

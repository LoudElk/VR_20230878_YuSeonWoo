using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject MyPrefab;
    public GameObject InteractiveObject;

    private bool hasCollided = false; // 충돌 여부를 나타내는 변수

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided && collision.gameObject.name == "GameObject")
        {
            hasCollided = true; // 충돌 발생

            Debug.Log(gameObject.name);

            GameObject GO = Instantiate(MyPrefab, transform.position, transform.rotation); // 새 오브젝트 생성
            GO.transform.parent = InteractiveObject.transform;

            Destroy(GO, 3f); // 새 오브젝트를 일정 시간 후에 파괴
            Destroy(gameObject); // 충돌된 오브젝트를 바로 파괴
        }
    }
}

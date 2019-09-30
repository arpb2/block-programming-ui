using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfFactory : MonoBehaviour
{
    public GameObject IfBtnPrefab;

    public void BuildIf()
    {
        GameObject asd = Instantiate(IfBtnPrefab, IfBtnPrefab.transform.position + new Vector3(10, 10 + Random.Range(10, 50), 0), Quaternion.identity) as GameObject;
        asd.SetActive(true);
        asd.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }
}

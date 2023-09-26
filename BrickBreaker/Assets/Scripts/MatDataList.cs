using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MatDataList : ScriptableObject
{
    public List<MatData> MatList;
    public MatData currentMat;
    private int num;

    public void SetFirstMaterial()
    {
        currentMat = MatList[0];
    }

    public void SetCurrentMaterialRandomly()
    {
        num = Random.Range(0, MatList.Count);
        currentMat = MatList[num];
    }
    public void SetNewMaterialSequential()
    {
        num += 1;
        currentMat = MatList[num];
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[Serializable]
public struct Map
{
    public enum EType
    {
        None,
        /// <summary> �� </summary>
        Wall,
        /// <summary> ���� </summary>
        Start,
        /// <summary> ���� </summary>
        End,
        /// <summary> ���� </summary>
        Coin,
        /// <summary> �� </summary>
        Star,
        /// <summary> ���� </summary>
        ThornUp,
        ThornDown,
        ThornRight,
        ThornLeft,
    }

    public EType eType;
    public Vector2Int coord;
}

[Serializable]
public struct LevelData
{
    public List<Map> maps;
}

[Serializable]
public class TileData
{
    public Map.EType eType;
    public bool isObject;
    public TileBase tileBase;
    public GameObject prefab;
}

[Serializable]
public class StageData 
{
    public int level;
    public int star;
    public bool isLock;
}

[Serializable]
public class SaveModel 
{
    public int coin;
    public List<StageData> stageDatas;
}

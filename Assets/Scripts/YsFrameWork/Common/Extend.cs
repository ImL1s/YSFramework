﻿//
// /**************************************************************************
//
// IUnityManager.cs
//
// Author: ImL1s  <ImL1s@outlook.com>
//
// Date: 16-02-28
//
// Description:擴展方法.
//
// Copyright (c) 2016 ImL1s
//
// **************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using YSFramework;

public static class Extend
{
    /// <summary>
    /// 在Transform下找尋指定組件.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static T FindAndGet<T>(this Transform t, string name,bool isAdd = false) where T : Component
    {
        Transform transform = t.Find(name);

        if (transform != null)
        {
            T target = transform.GetComponent<T>();

            if (target != null)
            {
                return target;
            }
            else if (isAdd)
            {
                target = transform.gameObject.AddComponent<T>();
                return target;
            }
        }

        Debug.LogError("Fail to FindAndGet<T> component. Component:" + typeof(T).ToString());
        return null;
    }


    /// <summary>
    /// Get or add component in gameObject. 加入指定的組件，如果該組件不存在，那就加入新的組件.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="go"></param>
    /// <returns></returns>
    public static T GetOrAddComponent<T>(this GameObject go) where T : Component
    {
        T t = go.GetComponent<T>();

        if (t == null) t = go.AddComponent<T>();

        return t;
    }

    /// <summary>
    /// Get or add component in gameObject. 加入指定的組件，如果該組件不存在，那就加入新的組件.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="tr"></param>
    /// <returns></returns>
    public static T GetOrAddComponent<T>(this Transform tr) where T : Component
    {
        T t = tr.GetComponent<T>();

        if (t == null) t = tr.gameObject.AddComponent<T>();

        return t;
    }

    /// <summary>
    /// 嘗試加入組件，如果該組件已存在，將不做任何動作.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>是否成功加入組件</returns>
    public static bool AddComponentNotMulti<T>(this GameObject go) where T : Component
    {
        T t = go.GetComponent<T>();

        if (t == null)
        {
            t = go.AddComponent<T>();
            return true;
        }
        return false;
    }

    /// <summary>
    /// 找尋GameObject，找不到就創建一個.
    /// </summary>
    /// <param name="objName"></param>
    /// <returns></returns>
    public static GameObject FindOrCreateGO(string objName)
    {
        GameObject temp = GameObject.Find(objName);
        if(temp == null)
        {
            temp = new GameObject(objName);
            temp.transform.position = Vector3.zero;
        }

        return temp;
    }

    /// <summary>
    /// 加入IPointDown的EventTriggerListener,讓該物體具備接收使用者點擊的能力
    /// </summary>
    /// <param name="btn">要加入EventTriggerListener的按鈕</param>
    /// <returns></returns>
    public static void AddPointDownListener(this Button btn,
        Define.OnTouchEventHandler handler, params object[] paras)
    {
        var trigger = btn.gameObject.GetOrAddComponent<EventTriggerListener>();
        trigger.SetOnclickHandle(handler, paras);
    }
}


// Decompiled with JetBrains decompiler
// Type: SRPG.SceneAwakeObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001105")]
  public static class SceneAwakeObserver
  {
    [Token(Token = "0x4003D85")]
    [FieldOffset(Offset = "0x0")]
    private static SceneAwakeObserver.SceneEvent mListeners;

    [Token(Token = "0x6004832")]
    [Address(RVA = "0x11F1F80", Offset = "0x11F0D80", VA = "0x111F1F80")]
    public static void ClearListeners()
    {
    }

    [Token(Token = "0x6004833")]
    [Address(RVA = "0x11F1EB0", Offset = "0x11F0CB0", VA = "0x111F1EB0")]
    public static void AddListener(SceneAwakeObserver.SceneEvent listener)
    {
    }

    [Token(Token = "0x6004834")]
    [Address(RVA = "0x11F2230", Offset = "0x11F1030", VA = "0x111F2230")]
    public static void RemoveListener(SceneAwakeObserver.SceneEvent listener)
    {
    }

    [Token(Token = "0x6004835")]
    [Address(RVA = "0x11F2080", Offset = "0x11F0E80", VA = "0x111F2080")]
    public static void Invoke(GameObject scene)
    {
    }

    [Token(Token = "0x6004836")]
    [Address(RVA = "0x11F2300", Offset = "0x11F1100", VA = "0x111F2300")]
    static SceneAwakeObserver()
    {
    }

    [Token(Token = "0x2001106")]
    public delegate void SceneEvent(GameObject sceneRoot);
  }
}

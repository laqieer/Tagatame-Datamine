// Decompiled with JetBrains decompiler
// Type: TunagiScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000170")]
[AddComponentMenu("Common/TunagiScene")]
public class TunagiScene : MonoBehaviour
{
  [Token(Token = "0x40006F2")]
  [FieldOffset(Offset = "0x0")]
  public static bool AutoDeactivateScene;
  [Token(Token = "0x40006F3")]
  [FieldOffset(Offset = "0x4")]
  public static TunagiScene.LoadCompleteEvent OnLoadComplete;
  [Token(Token = "0x40006F4")]
  [FieldOffset(Offset = "0x8")]
  private static List<TunagiScene> mScenes;
  [Token(Token = "0x40006F5")]
  [FieldOffset(Offset = "0xC")]
  public float ZMin;
  [Token(Token = "0x40006F6")]
  [FieldOffset(Offset = "0x10")]
  public float ZMax;

  [Token(Token = "0x17000146")]
  public static int SceneCount
  {
    [Token(Token = "0x600096D"), Address(RVA = "0xF50F20", Offset = "0xF4FD20", VA = "0x10F50F20")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x600096E")]
  [Address(RVA = "0xF50C70", Offset = "0xF4FA70", VA = "0x10F50C70")]
  public static void SetScenesActive(bool active)
  {
  }

  [Token(Token = "0x600096F")]
  [Address(RVA = "0xF50940", Offset = "0xF4F740", VA = "0x10F50940")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000970")]
  [Address(RVA = "0xF50B30", Offset = "0xF4F930", VA = "0x10F50B30")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000971")]
  [Address(RVA = "0xF50BA0", Offset = "0xF4F9A0", VA = "0x10F50BA0")]
  public static void PopFirstScene()
  {
  }

  [Token(Token = "0x6000972")]
  [Address(RVA = "0xF50A50", Offset = "0xF4F850", VA = "0x10F50A50")]
  public static void DestroyAllScenes()
  {
  }

  [Token(Token = "0x17000147")]
  public static TunagiScene LastScene
  {
    [Token(Token = "0x6000973"), Address(RVA = "0xF50E80", Offset = "0xF4FC80", VA = "0x10F50E80")] get
    {
      return (TunagiScene) null;
    }
  }

  [Token(Token = "0x17000148")]
  public static TunagiScene FirstScene
  {
    [Token(Token = "0x6000974"), Address(RVA = "0xF50DE0", Offset = "0xF4FBE0", VA = "0x10F50DE0")] get
    {
      return (TunagiScene) null;
    }
  }

  [Token(Token = "0x6000975")]
  [Address(RVA = "0xF50DC0", Offset = "0xF4FBC0", VA = "0x10F50DC0")]
  public TunagiScene()
  {
  }

  [Token(Token = "0x6000976")]
  [Address(RVA = "0xF50D40", Offset = "0xF4FB40", VA = "0x10F50D40")]
  static TunagiScene()
  {
  }

  [Token(Token = "0x2000171")]
  public delegate void LoadCompleteEvent(TunagiScene scene);
}

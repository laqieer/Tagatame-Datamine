// Decompiled with JetBrains decompiler
// Type: WatchManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200024B")]
[AddComponentMenu("Manager/WatchManager")]
public class WatchManager : MonoSingleton<WatchManager>
{
  [Token(Token = "0x40009CC")]
  [FieldOffset(Offset = "0x10")]
  public List<DateTime> mealTimes;
  [Token(Token = "0x40009CD")]
  [FieldOffset(Offset = "0x0")]
  private static readonly bool IS_DEBUG;

  [Token(Token = "0x17000173")]
  public bool IsAvailable
  {
    [Token(Token = "0x6000C33"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000C34"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
    {
    }
  }

  [Token(Token = "0x6000C35")]
  [Address(RVA = "0x108C410", Offset = "0x108B210", VA = "0x1108C410")]
  public List<int> GetMealHours() => (List<int>) null;

  [Token(Token = "0x6000C36")]
  [Address(RVA = "0x108C3D0", Offset = "0x108B1D0", VA = "0x1108C3D0")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000C37")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
  private static bool connectToWatch() => new bool();

  [Token(Token = "0x6000C38")]
  [Address(RVA = "0x108C500", Offset = "0x108B300", VA = "0x1108C500")]
  public void Init()
  {
  }

  [Token(Token = "0x6000C39")]
  [Address(RVA = "0x108C570", Offset = "0x108B370", VA = "0x1108C570", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x6000C3A")]
  [Address(RVA = "0x108C7E0", Offset = "0x108B5E0", VA = "0x1108C7E0", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x6000C3B")]
  [Address(RVA = "0x108C650", Offset = "0x108B450", VA = "0x1108C650")]
  public void OnEatMeal(string message)
  {
  }

  [Token(Token = "0x6000C3C")]
  [Address(RVA = "0x108C830", Offset = "0x108B630", VA = "0x1108C830")]
  public WatchManager()
  {
  }

  [Token(Token = "0x200024C")]
  private class MyDebug
  {
    [Token(Token = "0x40009CE")]
    [FieldOffset(Offset = "0x0")]
    private static WatchManager.MyDebug self;
    [Token(Token = "0x40009CF")]
    [FieldOffset(Offset = "0x8")]
    private List<string> contents;

    [Token(Token = "0x6000C3D")]
    [Address(RVA = "0x1082E60", Offset = "0x1081C60", VA = "0x11082E60")]
    public static void PushMessage(string msg, bool is_log = false)
    {
    }

    [Token(Token = "0x6000C3E")]
    [Address(RVA = "0x1082E00", Offset = "0x1081C00", VA = "0x11082E00")]
    public static IEnumerable<string> EachMessage() => (IEnumerable<string>) null;

    [Token(Token = "0x6000C3F")]
    [Address(RVA = "0x1082D20", Offset = "0x1081B20", VA = "0x11082D20")]
    public static void Clear()
    {
    }

    [Token(Token = "0x6000C40")]
    [Address(RVA = "0x1083180", Offset = "0x1081F80", VA = "0x11083180")]
    public MyDebug()
    {
    }

    [Token(Token = "0x6000C41")]
    [Address(RVA = "0x10830C0", Offset = "0x1081EC0", VA = "0x110830C0")]
    static MyDebug()
    {
    }
  }
}

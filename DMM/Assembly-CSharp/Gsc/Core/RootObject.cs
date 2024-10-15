// Decompiled with JetBrains decompiler
// Type: Gsc.Core.RootObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gsc.Core
{
  [Token(Token = "0x20035E3")]
  public class RootObject : MonoBehaviour
  {
    [Token(Token = "0x400FE16")]
    [FieldOffset(Offset = "0x0")]
    private static RootObject _instance;

    [Token(Token = "0x17002260")]
    public static RootObject Instance
    {
      [Token(Token = "0x600F026"), Address(RVA = "0xB0F440", Offset = "0xB0E240", VA = "0x10B0F440")] get
      {
        return (RootObject) null;
      }
    }

    [Token(Token = "0x600F027")]
    [Address(RVA = "0xB0F1C0", Offset = "0xB0DFC0", VA = "0x10B0F1C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F028")]
    [Address(RVA = "0xB0F310", Offset = "0xB0E110", VA = "0x10B0F310")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x600F029")]
    [Address(RVA = "0xB0F290", Offset = "0xB0E090", VA = "0x10B0F290")]
    public void DelayInvoke(Action f, float seconds)
    {
    }

    [Token(Token = "0x600F02A")]
    public void DelayInvoke<T1>(Action<T1> f, T1 arg1, float seconds)
    {
    }

    [Token(Token = "0x600F02B")]
    public void DelayInvoke<T1, T2>(Action<T1, T2> f, T1 arg1, T2 arg2, float seconds)
    {
    }

    [Token(Token = "0x600F02C")]
    public void DelayInvoke<T1, T2, T3>(
      Action<T1, T2, T3> f,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      float seconds)
    {
    }

    [Token(Token = "0x600F02D")]
    [Address(RVA = "0xB0F3D0", Offset = "0xB0E1D0", VA = "0x10B0F3D0")]
    private static IEnumerator _DelayInvoke(Action f, float seconds) => (IEnumerator) null;

    [Token(Token = "0x600F02E")]
    private static IEnumerator _DelayInvoke<T1>(Action<T1> f, T1 arg1, float seconds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F02F")]
    private static IEnumerator _DelayInvoke<T1, T2>(
      Action<T1, T2> f,
      T1 arg1,
      T2 arg2,
      float seconds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F030")]
    private static IEnumerator _DelayInvoke<T1, T2, T3>(
      Action<T1, T2, T3> f,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      float seconds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F031")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RootObject()
    {
    }
  }
}

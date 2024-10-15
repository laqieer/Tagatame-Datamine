// Decompiled with JetBrains decompiler
// Type: SRPG.EventCall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200125D")]
  [AddComponentMenu("Event/EventCall")]
  public class EventCall : MonoBehaviour
  {
    [Token(Token = "0x40043A6")]
    [FieldOffset(Offset = "0xC")]
    public EventCall.CustomEvent m_Events;
    [Token(Token = "0x40043A7")]
    [FieldOffset(Offset = "0x0")]
    public static object currentValue;

    [Token(Token = "0x6004DC5")]
    [Address(RVA = "0x12329B0", Offset = "0x12317B0", VA = "0x112329B0")]
    public void Invoke(string key, string value)
    {
    }

    [Token(Token = "0x6004DC6")]
    [Address(RVA = "0x1232A20", Offset = "0x1231820", VA = "0x11232A20")]
    public void Invoke(string key, string value, object obj)
    {
    }

    [Token(Token = "0x6004DC7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventCall()
    {
    }

    [Token(Token = "0x200125E")]
    [Serializable]
    public class CustomEvent : UnityEvent<string, string>
    {
      [Token(Token = "0x6004DC8")]
      [Address(RVA = "0x1227BC0", Offset = "0x12269C0", VA = "0x11227BC0")]
      public CustomEvent()
      {
      }
    }
  }
}

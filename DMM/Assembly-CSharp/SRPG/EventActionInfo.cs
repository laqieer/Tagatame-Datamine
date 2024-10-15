// Decompiled with JetBrains decompiler
// Type: SRPG.EventActionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011E7")]
  public class EventActionInfo : Attribute
  {
    [Token(Token = "0x4004124")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x4004125")]
    [FieldOffset(Offset = "0xC")]
    public string Description;
    [Token(Token = "0x4004126")]
    [FieldOffset(Offset = "0x10")]
    public Color32 DefaultColor;
    [Token(Token = "0x4004127")]
    [FieldOffset(Offset = "0x14")]
    public Color32 FocusColor;

    [Token(Token = "0x6004C19")]
    [Address(RVA = "0x1215450", Offset = "0x1214250", VA = "0x11215450")]
    public EventActionInfo(string name, string description, int defaultColor = 5592405, int focusColor = 4473992)
    {
    }
  }
}

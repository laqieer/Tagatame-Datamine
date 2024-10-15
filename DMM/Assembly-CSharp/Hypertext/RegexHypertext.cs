// Decompiled with JetBrains decompiler
// Type: Hypertext.RegexHypertext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Hypertext
{
  [Token(Token = "0x2000B47")]
  public class RegexHypertext : HypertextBase
  {
    [Token(Token = "0x4001B2C")]
    [FieldOffset(Offset = "0xAC")]
    private readonly List<RegexHypertext.Entry> entries;

    [Token(Token = "0x6002B2F")]
    [Address(RVA = "0xFCC2A0", Offset = "0xFCB0A0", VA = "0x10FCC2A0")]
    public void OnClick(string regexPattern, Action<string> onClick)
    {
    }

    [Token(Token = "0x6002B30")]
    [Address(RVA = "0xFCC3C0", Offset = "0xFCB1C0", VA = "0x10FCC3C0")]
    public void OnClick(string regexPattern, Color color, Action<string> onClick)
    {
    }

    [Token(Token = "0x6002B31")]
    [Address(RVA = "0xFCC4D0", Offset = "0xFCB2D0", VA = "0x10FCC4D0", Slot = "86")]
    public override void RemoveListeners()
    {
    }

    [Token(Token = "0x6002B32")]
    [Address(RVA = "0xFCBFD0", Offset = "0xFCADD0", VA = "0x10FCBFD0", Slot = "87")]
    protected override void AddListeners()
    {
    }

    [Token(Token = "0x6002B33")]
    [Address(RVA = "0xFCC540", Offset = "0xFCB340", VA = "0x10FCC540")]
    public RegexHypertext()
    {
    }

    [Token(Token = "0x2000B48")]
    private struct Entry
    {
      [Token(Token = "0x4001B2D")]
      [FieldOffset(Offset = "0x0")]
      public readonly string RegexPattern;
      [Token(Token = "0x4001B2E")]
      [FieldOffset(Offset = "0x4")]
      public readonly Color Color;
      [Token(Token = "0x4001B2F")]
      [FieldOffset(Offset = "0x14")]
      public readonly Action<string> Callback;

      [Token(Token = "0x6002B34")]
      [Address(RVA = "0xFC8B90", Offset = "0xFC7990", VA = "0x10FC8B90")]
      public Entry(string regexPattern, Color color, Action<string> callback)
      {
      }
    }
  }
}

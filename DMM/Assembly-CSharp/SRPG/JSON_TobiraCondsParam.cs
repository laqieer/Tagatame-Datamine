﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TobiraCondsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D5A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TobiraCondsParam
  {
    [Token(Token = "0x400738F")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x4007390")]
    [FieldOffset(Offset = "0xC")]
    public int category;
    [Token(Token = "0x4007391")]
    [FieldOffset(Offset = "0x10")]
    public JSON_TobiraConditionParam[] conds;

    [Token(Token = "0x6007833")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TobiraCondsParam()
    {
    }
  }
}
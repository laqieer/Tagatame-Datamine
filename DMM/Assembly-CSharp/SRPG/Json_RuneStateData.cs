﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RuneStateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010EC")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_RuneStateData
  {
    [Token(Token = "0x4003D2A")]
    [FieldOffset(Offset = "0x8")]
    public Json_RuneBuffData basic;
    [Token(Token = "0x4003D2B")]
    [FieldOffset(Offset = "0xC")]
    public Json_RuneBuffData[] evo;
    [Token(Token = "0x4003D2C")]
    [FieldOffset(Offset = "0x10")]
    public Json_RuneDedicatedData dedicated;

    [Token(Token = "0x6004784")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RuneStateData()
    {
    }
  }
}
﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BuyCoinSteps
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002113")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BuyCoinSteps
  {
    [Token(Token = "0x4008F50")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4008F51")]
    [FieldOffset(Offset = "0xC")]
    public string product_id;
    [Token(Token = "0x4008F52")]
    [FieldOffset(Offset = "0x10")]
    public int step;
    [Token(Token = "0x4008F53")]
    [FieldOffset(Offset = "0x14")]
    public int loop;
    [Token(Token = "0x4008F54")]
    [FieldOffset(Offset = "0x18")]
    public int soldout;

    [Token(Token = "0x6008A87")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BuyCoinSteps()
    {
    }
  }
}
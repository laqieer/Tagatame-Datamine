﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePridePotentialStatusLotteryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D07")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePridePotentialStatusLotteryData
  {
    [Token(Token = "0x40071C6")]
    [FieldOffset(Offset = "0x8")]
    public string draw_name;
    [Token(Token = "0x40071C7")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x40071C8")]
    [FieldOffset(Offset = "0x10")]
    public string tag;
    [Token(Token = "0x40071C9")]
    [FieldOffset(Offset = "0x14")]
    public int ex_type;
    [Token(Token = "0x40071CA")]
    [FieldOffset(Offset = "0x18")]
    public int calc_type;
    [Token(Token = "0x40071CB")]
    [FieldOffset(Offset = "0x1C")]
    public int min;
    [Token(Token = "0x40071CC")]
    [FieldOffset(Offset = "0x20")]
    public int max;

    [Token(Token = "0x6007737")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePridePotentialStatusLotteryData()
    {
    }
  }
}
// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneDedicatedCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CED")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneDedicatedCost
  {
    [Token(Token = "0x4007159")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400715A")]
    [FieldOffset(Offset = "0xC")]
    public int use_gold;
    [Token(Token = "0x400715B")]
    [FieldOffset(Offset = "0x10")]
    public int use_coin;
    [Token(Token = "0x400715C")]
    [FieldOffset(Offset = "0x14")]
    public JSON_RuneDedicatedCostItem[] items;

    [Token(Token = "0x60076CD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneDedicatedCost()
    {
    }
  }
}

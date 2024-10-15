// Decompiled with JetBrains decompiler
// Type: SRPG.RuneCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE1")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneCost
  {
    [Token(Token = "0x4007136")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007137")]
    [FieldOffset(Offset = "0xC")]
    public string use_item;
    [Token(Token = "0x4007138")]
    [FieldOffset(Offset = "0x10")]
    public int use_zeny;
    [Token(Token = "0x4007139")]
    [FieldOffset(Offset = "0x14")]
    public int use_num;
    [Token(Token = "0x400713A")]
    [FieldOffset(Offset = "0x18")]
    public int use_coin;

    [Token(Token = "0x60076A9")]
    [Address(RVA = "0x398650", Offset = "0x397450", VA = "0x10398650")]
    public bool Deserialize(JSON_RuneCost json) => new bool();

    [Token(Token = "0x60076AA")]
    [Address(RVA = "0x3986A0", Offset = "0x3974A0", VA = "0x103986A0")]
    public bool IsPlayerAmountEnough() => new bool();

    [Token(Token = "0x60076AB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneCost()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.Json_UnitPieceShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200117C")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_UnitPieceShopItem
  {
    [Token(Token = "0x4003F59")]
    [FieldOffset(Offset = "0x8")]
    public string itype;
    [Token(Token = "0x4003F5A")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4003F5B")]
    [FieldOffset(Offset = "0x10")]
    public int sold;
    [Token(Token = "0x4003F5C")]
    [FieldOffset(Offset = "0x14")]
    public int maxnum;
    [Token(Token = "0x4003F5D")]
    [FieldOffset(Offset = "0x18")]
    public int boughtnum;
    [Token(Token = "0x4003F5E")]
    [FieldOffset(Offset = "0x1C")]
    public int cost_num;
    [Token(Token = "0x4003F5F")]
    [FieldOffset(Offset = "0x20")]
    public int expired_at;
    [Token(Token = "0x4003F60")]
    [FieldOffset(Offset = "0x24")]
    public int has_next_step;

    [Token(Token = "0x6004A9C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_UnitPieceShopItem()
    {
    }
  }
}

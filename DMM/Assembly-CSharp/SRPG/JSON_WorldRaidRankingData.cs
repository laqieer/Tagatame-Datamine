// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D56")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidRankingData
  {
    [Token(Token = "0x400E217")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x400E218")]
    [FieldOffset(Offset = "0x10")]
    public long score;
    [Token(Token = "0x400E219")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x400E21A")]
    [FieldOffset(Offset = "0x1C")]
    public int lv;
    [Token(Token = "0x400E21B")]
    [FieldOffset(Offset = "0x20")]
    public Json_UnitSkin unit;
    [Token(Token = "0x400E21C")]
    [FieldOffset(Offset = "0x24")]
    public JSON_ViewGuild guild;
    [Token(Token = "0x400E21D")]
    [FieldOffset(Offset = "0x28")]
    public string selected_award;

    [Token(Token = "0x600D33B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidRankingData()
    {
    }
  }
}

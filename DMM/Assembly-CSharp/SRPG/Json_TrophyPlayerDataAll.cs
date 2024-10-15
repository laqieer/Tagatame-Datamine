// Decompiled with JetBrains decompiler
// Type: SRPG.Json_TrophyPlayerDataAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FF1")]
  [MessagePackObject(true)]
  public class Json_TrophyPlayerDataAll
  {
    [Token(Token = "0x40038A8")]
    [FieldOffset(Offset = "0x8")]
    public Json_TrophyPlayerData player;
    [Token(Token = "0x40038A9")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;
    [Token(Token = "0x40038AA")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x40038AB")]
    [FieldOffset(Offset = "0x14")]
    public Json_TrophyConceptCards concept_cards;
    [Token(Token = "0x40038AC")]
    [FieldOffset(Offset = "0x18")]
    public ReqTrophyStarMission.StarMission star_mission;
    [Token(Token = "0x40038AD")]
    [FieldOffset(Offset = "0x1C")]
    public Json_HotDealInfo[] hot_deals;

    [Token(Token = "0x6004255")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_TrophyPlayerDataAll()
    {
    }
  }
}

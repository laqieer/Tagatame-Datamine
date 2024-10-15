// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinHotDealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019C2")]
  public class BuyCoinHotDealParam
  {
    [Token(Token = "0x4005E98")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E99")]
    [FieldOffset(Offset = "0xC")]
    public int appearance_time;
    [Token(Token = "0x4005E9A")]
    [FieldOffset(Offset = "0x10")]
    public int interval;
    [Token(Token = "0x4005E9B")]
    [FieldOffset(Offset = "0x14")]
    public string prefab_name;
    [Token(Token = "0x4005E9C")]
    [FieldOffset(Offset = "0x18")]
    public BuyCoinHotDealParam.Condition condition;
    [Token(Token = "0x4005E9D")]
    [FieldOffset(Offset = "0x1C")]
    public int condition_total_num;
    [Token(Token = "0x4005E9E")]
    [FieldOffset(Offset = "0x20")]
    public List<BuyCoinHotDealParam.HotDealConditionParam> condition_params;
    [Token(Token = "0x4005E9F")]
    [FieldOffset(Offset = "0x24")]
    public string speech;
    [Token(Token = "0x4005EA0")]
    [FieldOffset(Offset = "0x28")]
    public string url;
    [Token(Token = "0x4005EA1")]
    [FieldOffset(Offset = "0x2C")]
    public int sort_order;

    [Token(Token = "0x6006918")]
    [Address(RVA = "0x34E3A0", Offset = "0x34D1A0", VA = "0x1034E3A0")]
    public bool Deserialize(JSON_BuyCoinHotDealParam json) => new bool();

    [Token(Token = "0x6006919")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinHotDealParam()
    {
    }

    [Token(Token = "0x20019C3")]
    public enum Condition
    {
      [Token(Token = "0x4005EA3")] Login = 1,
      [Token(Token = "0x4005EA4")] LvUp = 2,
      [Token(Token = "0x4005EA5")] QuestClear = 3,
      [Token(Token = "0x4005EA6")] TowerClear = 4,
      [Token(Token = "0x4005EA7")] UnitGet = 5,
      [Token(Token = "0x4005EA8")] UnitTobiraOpen = 6,
      [Token(Token = "0x4005EA9")] UnitTobiraMaster = 7,
      [Token(Token = "0x4005EAA")] UnitLvOver = 8,
      [Token(Token = "0x4005EAB")] CombatOver = 9,
      [Token(Token = "0x4005EAC")] CardGet = 10, // 0x0000000A
      [Token(Token = "0x4005EAD")] GachaUnitRarety = 11, // 0x0000000B
      [Token(Token = "0x4005EAE")] GachaCardRarety = 12, // 0x0000000C
      [Token(Token = "0x4005EAF")] DuelRanking = 13, // 0x0000000D
      [Token(Token = "0x4005EB0")] DuelWinning = 14, // 0x0000000E
      [Token(Token = "0x4005EB1")] DuelLosing = 15, // 0x0000000F
      [Token(Token = "0x4005EB2")] RankMatch = 16, // 0x00000010
      [Token(Token = "0x4005EB3")] ComeBack = 17, // 0x00000011
    }

    [Token(Token = "0x20019C4")]
    public class HotDealConditionParam
    {
      [Token(Token = "0x4005EB4")]
      [FieldOffset(Offset = "0x8")]
      public string condition_str;
      [Token(Token = "0x4005EB5")]
      [FieldOffset(Offset = "0xC")]
      public int condition_num;

      [Token(Token = "0x600691A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public HotDealConditionParam()
      {
      }
    }
  }
}

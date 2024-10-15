// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignChildParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C2F")]
  public class QuestCampaignChildParam
  {
    [Token(Token = "0x4006D50")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D51")]
    [FieldOffset(Offset = "0xC")]
    public QuestCampaignScopes scope;
    [Token(Token = "0x4006D52")]
    [FieldOffset(Offset = "0x10")]
    public QuestTypes questType;
    [Token(Token = "0x4006D53")]
    [FieldOffset(Offset = "0x11")]
    public QuestDifficulties questMode;
    [Token(Token = "0x4006D54")]
    [FieldOffset(Offset = "0x14")]
    public string questId;
    [Token(Token = "0x4006D55")]
    [FieldOffset(Offset = "0x18")]
    public string unit;
    [Token(Token = "0x4006D56")]
    [FieldOffset(Offset = "0x1C")]
    public int dropRate;
    [Token(Token = "0x4006D57")]
    [FieldOffset(Offset = "0x20")]
    public int dropNum;
    [Token(Token = "0x4006D58")]
    [FieldOffset(Offset = "0x24")]
    public int expPlayer;
    [Token(Token = "0x4006D59")]
    [FieldOffset(Offset = "0x28")]
    public int expUnit;
    [Token(Token = "0x4006D5A")]
    [FieldOffset(Offset = "0x2C")]
    public int apRate;
    [Token(Token = "0x4006D5B")]
    [FieldOffset(Offset = "0x30")]
    public int rentalFavRate;
    [Token(Token = "0x4006D5C")]
    [FieldOffset(Offset = "0x34")]
    public QuestCampaignParentParam[] parents;
    [Token(Token = "0x4006D5D")]
    [FieldOffset(Offset = "0x38")]
    public QuestCampaignTrust campaignTrust;
    [Token(Token = "0x4006D5E")]
    [FieldOffset(Offset = "0x3C")]
    public QuestCampaignInspSkill campaignInspSkill;

    [Token(Token = "0x60073F0")]
    [Address(RVA = "0x380B70", Offset = "0x37F970", VA = "0x10380B70")]
    public bool Deserialize(JSON_QuestCampaignChildParam json) => new bool();

    [Token(Token = "0x60073F1")]
    [Address(RVA = "0x380E10", Offset = "0x37FC10", VA = "0x10380E10")]
    public QuestCampaignData[] MakeData() => (QuestCampaignData[]) null;

    [Token(Token = "0x60073F2")]
    [Address(RVA = "0x380DA0", Offset = "0x37FBA0", VA = "0x10380DA0")]
    public bool IsValidQuest(QuestParam questParam) => new bool();

    [Token(Token = "0x60073F3")]
    [Address(RVA = "0x380C50", Offset = "0x37FA50", VA = "0x10380C50")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x60073F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCampaignChildParam()
    {
    }
  }
}

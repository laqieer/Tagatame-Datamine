// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignTrust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C30")]
  public class QuestCampaignTrust
  {
    [Token(Token = "0x4006D5F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D60")]
    [FieldOffset(Offset = "0xC")]
    public string concept_card;
    [Token(Token = "0x4006D61")]
    [FieldOffset(Offset = "0x10")]
    public int card_trust_lottery_rate;
    [Token(Token = "0x4006D62")]
    [FieldOffset(Offset = "0x14")]
    public int card_trust_qe_bonus;

    [Token(Token = "0x60073F5")]
    [Address(RVA = "0x3816D0", Offset = "0x3804D0", VA = "0x103816D0")]
    public bool Deserialize(JSON_QuestCampaignTrust json) => new bool();

    [Token(Token = "0x60073F6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCampaignTrust()
    {
    }
  }
}

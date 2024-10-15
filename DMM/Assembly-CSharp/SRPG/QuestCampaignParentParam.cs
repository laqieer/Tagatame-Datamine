// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignParentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C2E")]
  public class QuestCampaignParentParam
  {
    [Token(Token = "0x4006D4C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D4D")]
    [FieldOffset(Offset = "0x10")]
    public DateTime beginAt;
    [Token(Token = "0x4006D4E")]
    [FieldOffset(Offset = "0x18")]
    public DateTime endAt;
    [Token(Token = "0x4006D4F")]
    [FieldOffset(Offset = "0x20")]
    public string[] children;

    [Token(Token = "0x60073EC")]
    [Address(RVA = "0x3814D0", Offset = "0x3802D0", VA = "0x103814D0")]
    public bool Deserialize(JSON_QuestCampaignParentParam json) => new bool();

    [Token(Token = "0x60073ED")]
    [Address(RVA = "0x381680", Offset = "0x380480", VA = "0x10381680")]
    public bool IsChild(string childId) => new bool();

    [Token(Token = "0x60073EE")]
    [Address(RVA = "0x3815E0", Offset = "0x3803E0", VA = "0x103815E0")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x60073EF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCampaignParentParam()
    {
    }
  }
}

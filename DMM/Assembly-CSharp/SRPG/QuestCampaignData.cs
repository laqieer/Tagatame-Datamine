// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C32")]
  public class QuestCampaignData
  {
    [Token(Token = "0x4006D66")]
    [FieldOffset(Offset = "0x8")]
    public QuestCampaignValueTypes type;
    [Token(Token = "0x4006D67")]
    [FieldOffset(Offset = "0xC")]
    public string unit;
    [Token(Token = "0x4006D68")]
    [FieldOffset(Offset = "0x10")]
    public int value;

    [Token(Token = "0x60073FC")]
    [Address(RVA = "0x381460", Offset = "0x380260", VA = "0x10381460")]
    public float GetRate() => new float();

    [Token(Token = "0x60073FD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCampaignData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002824")]
  public class PointQuestRewardData
  {
    [Token(Token = "0x400BF4F")]
    [FieldOffset(Offset = "0x8")]
    public RaidRewardType ItemType;
    [Token(Token = "0x400BF50")]
    [FieldOffset(Offset = "0xC")]
    public string ItemIname;
    [Token(Token = "0x400BF51")]
    [FieldOffset(Offset = "0x10")]
    public int ItemNum;

    [Token(Token = "0x600B51E")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_PointQuestRewardData json) => new bool();

    [Token(Token = "0x600B51F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRewardData()
    {
    }
  }
}

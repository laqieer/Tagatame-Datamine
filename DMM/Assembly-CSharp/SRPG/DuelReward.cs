// Decompiled with JetBrains decompiler
// Type: SRPG.DuelReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC5")]
  public class DuelReward
  {
    [Token(Token = "0x4006333")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType mItemType;
    [Token(Token = "0x4006334")]
    [FieldOffset(Offset = "0xC")]
    private string mItemIname;
    [Token(Token = "0x4006335")]
    [FieldOffset(Offset = "0x10")]
    private int mItemNum;

    [Token(Token = "0x17000C71")]
    public RaidRewardType ItemType
    {
      [Token(Token = "0x6006E5A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17000C72")]
    public string ItemIname
    {
      [Token(Token = "0x6006E5B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C73")]
    public int ItemNum
    {
      [Token(Token = "0x6006E5C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E5D")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_DuelReward json) => new bool();

    [Token(Token = "0x6006E5E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelReward()
    {
    }
  }
}

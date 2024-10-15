// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F88")]
  public class AdventureDrop
  {
    [Token(Token = "0x400852E")]
    [FieldOffset(Offset = "0x8")]
    private RewardIcon.eType mItemType;
    [Token(Token = "0x400852F")]
    [FieldOffset(Offset = "0xC")]
    private string mItemIname;
    [Token(Token = "0x4008530")]
    [FieldOffset(Offset = "0x10")]
    private int mItemNum;
    [Token(Token = "0x4008531")]
    [FieldOffset(Offset = "0x14")]
    private ItemParam mItemParam;

    [Token(Token = "0x17001293")]
    public RewardIcon.eType ItemType
    {
      [Token(Token = "0x6008183"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RewardIcon.eType();
      }
    }

    [Token(Token = "0x17001294")]
    public string ItemIname
    {
      [Token(Token = "0x6008184"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001295")]
    public int ItemNum
    {
      [Token(Token = "0x6008185"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001296")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x6008186"), Address(RVA = "0x421F80", Offset = "0x420D80", VA = "0x10421F80")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x6008187")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_AdventureDrop json) => new bool();

    [Token(Token = "0x6008188")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdventureDrop()
    {
    }
  }
}

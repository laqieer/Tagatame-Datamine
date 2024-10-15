// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B27")]
  public class GuildAttendReward
  {
    [Token(Token = "0x4006778")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType mType;
    [Token(Token = "0x4006779")]
    [FieldOffset(Offset = "0xC")]
    private string mItemIname;
    [Token(Token = "0x400677A")]
    [FieldOffset(Offset = "0x10")]
    private int mNum;

    [Token(Token = "0x17000D16")]
    public RaidRewardType type
    {
      [Token(Token = "0x6006FF2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17000D17")]
    public string item_iname
    {
      [Token(Token = "0x6006FF3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D18")]
    public int num
    {
      [Token(Token = "0x6006FF4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006FF5")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_GuildAttendReward json) => new bool();

    [Token(Token = "0x6006FF6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildAttendReward()
    {
    }
  }
}

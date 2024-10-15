// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRewardItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC7")]
  [MessagePackObject(true)]
  public class LeagueMatchRewardItemParam
  {
    [Token(Token = "0x4006A55")]
    [FieldOffset(Offset = "0x8")]
    private RewardIcon.eType mItem_type;
    [Token(Token = "0x4006A56")]
    [FieldOffset(Offset = "0xC")]
    private string mItem_iname;
    [Token(Token = "0x4006A57")]
    [FieldOffset(Offset = "0x10")]
    private int mItem_num;

    [Token(Token = "0x17000E1A")]
    public RewardIcon.eType Item_type
    {
      [Token(Token = "0x60072B0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RewardIcon.eType();
      }
    }

    [Token(Token = "0x17000E1B")]
    public string Item_iname
    {
      [Token(Token = "0x60072B1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E1C")]
    public int Item_num
    {
      [Token(Token = "0x60072B2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60072B3")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_LeagueMatchRewardItemParam json) => new bool();

    [Token(Token = "0x60072B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRewardItemParam()
    {
    }
  }
}

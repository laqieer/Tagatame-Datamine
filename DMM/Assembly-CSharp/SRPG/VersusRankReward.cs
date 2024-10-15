// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED9")]
  public class VersusRankReward
  {
    [Token(Token = "0x40081B7")]
    [FieldOffset(Offset = "0x8")]
    private RewardType mType;
    [Token(Token = "0x40081B8")]
    [FieldOffset(Offset = "0xC")]
    private string mIName;
    [Token(Token = "0x40081B9")]
    [FieldOffset(Offset = "0x10")]
    private int mNum;

    [Token(Token = "0x170011CC")]
    public RewardType Type
    {
      [Token(Token = "0x6007E36"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RewardType();
      }
    }

    [Token(Token = "0x170011CD")]
    public string IName
    {
      [Token(Token = "0x6007E37"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011CE")]
    public int Num
    {
      [Token(Token = "0x6007E38"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007E39")]
    [Address(RVA = "0x3569E0", Offset = "0x3557E0", VA = "0x103569E0")]
    public bool Deserialize(JSON_VersusRankRewardRewardParam json) => new bool();

    [Token(Token = "0x6007E3A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankReward()
    {
    }
  }
}

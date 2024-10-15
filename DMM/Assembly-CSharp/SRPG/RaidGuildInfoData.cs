// Decompiled with JetBrains decompiler
// Type: SRPG.RaidGuildInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E7")]
  public class RaidGuildInfoData
  {
    [Token(Token = "0x4003D0E")]
    [FieldOffset(Offset = "0x8")]
    private int mRank;
    [Token(Token = "0x4003D0F")]
    [FieldOffset(Offset = "0xC")]
    private int mScore;

    [Token(Token = "0x17000741")]
    public int Rank
    {
      [Token(Token = "0x600477A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000742")]
    public int Score
    {
      [Token(Token = "0x600477B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600477C")]
    [Address(RVA = "0x370F90", Offset = "0x36FD90", VA = "0x10370F90")]
    public bool Deserialize(Json_RaidGuildInfoData json) => new bool();

    [Token(Token = "0x600477D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidGuildInfoData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED0")]
  public class VersusRankMissionParam
  {
    [Token(Token = "0x400818F")]
    [FieldOffset(Offset = "0x8")]
    private string mIName;
    [Token(Token = "0x4008190")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4008191")]
    [FieldOffset(Offset = "0x10")]
    private string mExpire;
    [Token(Token = "0x4008192")]
    [FieldOffset(Offset = "0x14")]
    private RankMatchMissionType mType;
    [Token(Token = "0x4008193")]
    [FieldOffset(Offset = "0x18")]
    private string mSVal;
    [Token(Token = "0x4008194")]
    [FieldOffset(Offset = "0x1C")]
    private int mIVal;
    [Token(Token = "0x4008195")]
    [FieldOffset(Offset = "0x20")]
    private string mRewardId;

    [Token(Token = "0x170011B7")]
    public string IName
    {
      [Token(Token = "0x6007E14"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011B8")]
    public string Name
    {
      [Token(Token = "0x6007E15"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011B9")]
    public string Expire
    {
      [Token(Token = "0x6007E16"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011BA")]
    public RankMatchMissionType Type
    {
      [Token(Token = "0x6007E17"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new RankMatchMissionType();
      }
    }

    [Token(Token = "0x170011BB")]
    public string SVal
    {
      [Token(Token = "0x6007E18"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011BC")]
    public int IVal
    {
      [Token(Token = "0x6007E19"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011BD")]
    public string RewardId
    {
      [Token(Token = "0x6007E1A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E1B")]
    [Address(RVA = "0x3FB190", Offset = "0x3F9F90", VA = "0x103FB190")]
    public bool Deserialize(JSON_VersusRankMissionParam json) => new bool();

    [Token(Token = "0x6007E1C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankMissionParam()
    {
    }
  }
}

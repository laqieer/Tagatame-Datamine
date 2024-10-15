// Decompiled with JetBrains decompiler
// Type: SRPG.RaidGuildInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E6")]
  public class RaidGuildInfo
  {
    [Token(Token = "0x4003D0C")]
    [FieldOffset(Offset = "0x8")]
    private RaidGuildInfoData mBeat;
    [Token(Token = "0x4003D0D")]
    [FieldOffset(Offset = "0xC")]
    private RaidGuildInfoData mRescue;

    [Token(Token = "0x1700073F")]
    public RaidGuildInfoData Beat
    {
      [Token(Token = "0x6004776"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (RaidGuildInfoData) null;
      }
    }

    [Token(Token = "0x17000740")]
    public RaidGuildInfoData Rescue
    {
      [Token(Token = "0x6004777"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (RaidGuildInfoData) null;
      }
    }

    [Token(Token = "0x6004778")]
    [Address(RVA = "0x11E8590", Offset = "0x11E7390", VA = "0x111E8590")]
    public bool Deserialize(Json_RaidGuildInfo json) => new bool();

    [Token(Token = "0x6004779")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidGuildInfo()
    {
    }
  }
}

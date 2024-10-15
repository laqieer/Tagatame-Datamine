// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRoleBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B2A")]
  public class GuildRoleBonusParam
  {
    [Token(Token = "0x4006782")]
    [FieldOffset(Offset = "0x8")]
    private int mID;
    [Token(Token = "0x4006783")]
    [FieldOffset(Offset = "0xC")]
    private GuildMemberData.eRole mRoleID;
    [Token(Token = "0x4006784")]
    [FieldOffset(Offset = "0x10")]
    private long mStartAt;
    [Token(Token = "0x4006785")]
    [FieldOffset(Offset = "0x18")]
    private long mEndAt;
    [Token(Token = "0x4006786")]
    [FieldOffset(Offset = "0x20")]
    private GuildRoleBonusDetail[] mRewards;

    [Token(Token = "0x17000D19")]
    public int id
    {
      [Token(Token = "0x6006FF9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D1A")]
    public GuildMemberData.eRole role
    {
      [Token(Token = "0x6006FFA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new GuildMemberData.eRole();
      }
    }

    [Token(Token = "0x17000D1B")]
    public long start_at
    {
      [Token(Token = "0x6006FFB"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000D1C")]
    public long end_at
    {
      [Token(Token = "0x6006FFC"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000D1D")]
    public GuildRoleBonusDetail[] rewards
    {
      [Token(Token = "0x6006FFD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GuildRoleBonusDetail[]) null;
      }
    }

    [Token(Token = "0x6006FFE")]
    [Address(RVA = "0x371250", Offset = "0x370050", VA = "0x10371250")]
    public static bool Deserialize(ref GuildRoleBonusParam[] param, JSON_GuildRoleBonus[] json)
    {
      return new bool();
    }

    [Token(Token = "0x6006FFF")]
    [Address(RVA = "0x371360", Offset = "0x370160", VA = "0x10371360")]
    public void Deserialize(JSON_GuildRoleBonus json)
    {
    }

    [Token(Token = "0x6007000")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRoleBonusParam()
    {
    }
  }
}

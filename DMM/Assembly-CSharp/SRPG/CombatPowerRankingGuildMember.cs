// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerRankingGuildMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F92")]
  public class CombatPowerRankingGuildMember : GuildMemberData, IRankingContent, ICombatPowerContent
  {
    [Token(Token = "0x40036CB")]
    [FieldOffset(Offset = "0x48")]
    private int mRank;
    [Token(Token = "0x40036CC")]
    [FieldOffset(Offset = "0x50")]
    private long mCombatPower;

    [Token(Token = "0x1700058D")]
    public int Rank
    {
      [Token(Token = "0x60040AC"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700058E")]
    public long CombatPower
    {
      [Token(Token = "0x60040AD"), Address(RVA = "0x118D300", Offset = "0x118C100", VA = "0x1118D300", Slot = "5")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x60040AE")]
    [Address(RVA = "0x118D290", Offset = "0x118C090", VA = "0x1118D290")]
    public bool Deserialize(JSON_CombatPowerRankingGuildMember json) => new bool();

    [Token(Token = "0x60040AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CombatPowerRankingGuildMember()
    {
    }
  }
}

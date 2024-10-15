// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerRankingViewGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F91")]
  public class CombatPowerRankingViewGuild : ViewGuildData, IRankingContent, ICombatPowerContent
  {
    [Token(Token = "0x40036C9")]
    [FieldOffset(Offset = "0x30")]
    private int mRank;
    [Token(Token = "0x40036CA")]
    [FieldOffset(Offset = "0x38")]
    private long mCombatPower;

    [Token(Token = "0x1700058B")]
    public int Rank
    {
      [Token(Token = "0x60040A8"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700058C")]
    public long CombatPower
    {
      [Token(Token = "0x60040A9"), Address(RVA = "0x1105E50", Offset = "0x1104C50", VA = "0x11105E50", Slot = "5")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x60040AA")]
    [Address(RVA = "0x118D310", Offset = "0x118C110", VA = "0x1118D310")]
    public bool Deserialize(JSON_CombatPowerRankingViewGuild json) => new bool();

    [Token(Token = "0x60040AB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CombatPowerRankingViewGuild()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventModeInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001958")]
  public class AdvanceEventModeInfoParam
  {
    [Token(Token = "0x4005C36")]
    [FieldOffset(Offset = "0x8")]
    private AdvanceStarParam mStarParam;
    [Token(Token = "0x4005C37")]
    [FieldOffset(Offset = "0xC")]
    private int mLiberationQuestNo;
    [Token(Token = "0x4005C38")]
    [FieldOffset(Offset = "0x10")]
    private string mBossUnitId;
    [Token(Token = "0x4005C39")]
    [FieldOffset(Offset = "0x14")]
    private UnitParam mBossUnitParam;
    [Token(Token = "0x4005C3A")]
    [FieldOffset(Offset = "0x18")]
    private int mBossHp;
    [Token(Token = "0x4005C3B")]
    [FieldOffset(Offset = "0x1C")]
    private string mBossChallengeItemId;
    [Token(Token = "0x4005C3C")]
    [FieldOffset(Offset = "0x20")]
    private ItemParam mBossChallengeItemParam;
    [Token(Token = "0x4005C3D")]
    [FieldOffset(Offset = "0x24")]
    private int mBossChallengeItemNum;
    [Token(Token = "0x4005C3E")]
    [FieldOffset(Offset = "0x28")]
    private AdvanceRewardParam mBossRewardParam;
    [Token(Token = "0x4005C3F")]
    [FieldOffset(Offset = "0x2C")]
    private int mModeUiIndex;
    [Token(Token = "0x4005C40")]
    [FieldOffset(Offset = "0x30")]
    private string mLapBossId;
    [Token(Token = "0x4005C41")]
    [FieldOffset(Offset = "0x34")]
    private AdvanceLapBossParam mLapBossParam;

    [Token(Token = "0x17000A70")]
    public AdvanceStarParam StarParam
    {
      [Token(Token = "0x6006744"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (AdvanceStarParam) null;
      }
    }

    [Token(Token = "0x17000A71")]
    public int LiberationQuestNo
    {
      [Token(Token = "0x6006745"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A72")]
    public UnitParam BossUnitParam
    {
      [Token(Token = "0x6006746"), Address(RVA = "0x319A80", Offset = "0x318880", VA = "0x10319A80")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17000A73")]
    public int BossHp
    {
      [Token(Token = "0x6006747"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A74")]
    public ItemParam BossChallengeItemParam
    {
      [Token(Token = "0x6006748"), Address(RVA = "0x3199E0", Offset = "0x3187E0", VA = "0x103199E0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000A75")]
    public int BossChallengeItemNum
    {
      [Token(Token = "0x6006749"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A76")]
    public AdvanceRewardParam BossRewardParam
    {
      [Token(Token = "0x600674A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (AdvanceRewardParam) null;
      }
    }

    [Token(Token = "0x17000A77")]
    public int ModeUiIndex
    {
      [Token(Token = "0x600674B"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A78")]
    public bool IsLapBoss
    {
      [Token(Token = "0x600674C"), Address(RVA = "0x319B20", Offset = "0x318920", VA = "0x10319B20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A79")]
    public AdvanceLapBossParam LapBossParam
    {
      [Token(Token = "0x600674D"), Address(RVA = "0x319B40", Offset = "0x318940", VA = "0x10319B40")] get
      {
        return (AdvanceLapBossParam) null;
      }
    }

    [Token(Token = "0x600674E")]
    [Address(RVA = "0x319860", Offset = "0x318660", VA = "0x10319860")]
    public void Deserialize(JSON_AdvanceEventModeInfoParam json)
    {
    }

    [Token(Token = "0x600674F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceEventModeInfoParam()
    {
    }
  }
}

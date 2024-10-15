// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterModeInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B06")]
  public class GenesisChapterModeInfoParam
  {
    [Token(Token = "0x40066FE")]
    [FieldOffset(Offset = "0x8")]
    private GenesisStarParam mStarParam;
    [Token(Token = "0x40066FF")]
    [FieldOffset(Offset = "0xC")]
    private int mLiberationQuestNo;
    [Token(Token = "0x4006700")]
    [FieldOffset(Offset = "0x10")]
    private string mBossUnitId;
    [Token(Token = "0x4006701")]
    [FieldOffset(Offset = "0x14")]
    private UnitParam mBossUnitParam;
    [Token(Token = "0x4006702")]
    [FieldOffset(Offset = "0x18")]
    private int mBossHp;
    [Token(Token = "0x4006703")]
    [FieldOffset(Offset = "0x1C")]
    private string mBossChallengeItemId;
    [Token(Token = "0x4006704")]
    [FieldOffset(Offset = "0x20")]
    private ItemParam mBossChallengeItemParam;
    [Token(Token = "0x4006705")]
    [FieldOffset(Offset = "0x24")]
    private int mBossChallengeItemNum;
    [Token(Token = "0x4006706")]
    [FieldOffset(Offset = "0x28")]
    private GenesisRewardParam mBossRewardParam;
    [Token(Token = "0x4006707")]
    [FieldOffset(Offset = "0x2C")]
    private int mModeUiIndex;
    [Token(Token = "0x4006708")]
    [FieldOffset(Offset = "0x30")]
    private string mLapBossId;
    [Token(Token = "0x4006709")]
    [FieldOffset(Offset = "0x34")]
    private GenesisLapBossParam mLapBossParam;

    [Token(Token = "0x17000CE8")]
    public GenesisStarParam StarParam
    {
      [Token(Token = "0x6006F80"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (GenesisStarParam) null;
      }
    }

    [Token(Token = "0x17000CE9")]
    public int LiberationQuestNo
    {
      [Token(Token = "0x6006F81"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CEA")]
    public UnitParam BossUnitParam
    {
      [Token(Token = "0x6006F82"), Address(RVA = "0x36B260", Offset = "0x36A060", VA = "0x1036B260")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17000CEB")]
    public int BossHp
    {
      [Token(Token = "0x6006F83"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CEC")]
    public ItemParam BossChallengeItemParam
    {
      [Token(Token = "0x6006F84"), Address(RVA = "0x36B1C0", Offset = "0x369FC0", VA = "0x1036B1C0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000CED")]
    public int BossChallengeItemNum
    {
      [Token(Token = "0x6006F85"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CEE")]
    public GenesisRewardParam BossRewardParam
    {
      [Token(Token = "0x6006F86"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (GenesisRewardParam) null;
      }
    }

    [Token(Token = "0x17000CEF")]
    public int ModeUiIndex
    {
      [Token(Token = "0x6006F87"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CF0")]
    public bool IsLapBoss
    {
      [Token(Token = "0x6006F88"), Address(RVA = "0x319B20", Offset = "0x318920", VA = "0x10319B20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CF1")]
    public GenesisLapBossParam LapBossParam
    {
      [Token(Token = "0x6006F89"), Address(RVA = "0x36B300", Offset = "0x36A100", VA = "0x1036B300")] get
      {
        return (GenesisLapBossParam) null;
      }
    }

    [Token(Token = "0x6006F8A")]
    [Address(RVA = "0x36B040", Offset = "0x369E40", VA = "0x1036B040")]
    public void Deserialize(JSON_GenesisChapterModeInfoParam json)
    {
    }

    [Token(Token = "0x6006F8B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisChapterModeInfoParam()
    {
    }
  }
}

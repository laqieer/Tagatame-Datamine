// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisLapBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B0B")]
  public class GenesisLapBossParam
  {
    [Token(Token = "0x400671D")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400671E")]
    [FieldOffset(Offset = "0xC")]
    private int mRoundBuffMax;
    [Token(Token = "0x400671F")]
    [FieldOffset(Offset = "0x10")]
    private string mBossBuffId;
    [Token(Token = "0x4006720")]
    [FieldOffset(Offset = "0x14")]
    private string mOtherBuffId;
    [Token(Token = "0x4006721")]
    [FieldOffset(Offset = "0x18")]
    private GenesisLapBossParam.LapInfo[] mLapInfo;
    [Token(Token = "0x4006722")]
    [FieldOffset(Offset = "0x1C")]
    private BuffEffectParam mBossBuffParam;
    [Token(Token = "0x4006723")]
    [FieldOffset(Offset = "0x20")]
    private BuffEffectParam mOtherBuffParam;

    [Token(Token = "0x17000CFC")]
    public string Iname
    {
      [Token(Token = "0x6006FA8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CFD")]
    public int RoundBuffMax
    {
      [Token(Token = "0x6006FA9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CFE")]
    public string BossBuffId
    {
      [Token(Token = "0x6006FAA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CFF")]
    public BuffEffectParam BossBuffParam
    {
      [Token(Token = "0x6006FAB"), Address(RVA = "0x36D410", Offset = "0x36C210", VA = "0x1036D410")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17000D00")]
    public string OtherBuffId
    {
      [Token(Token = "0x6006FAC"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D01")]
    public BuffEffectParam OtherBuffParam
    {
      [Token(Token = "0x6006FAD"), Address(RVA = "0x36D550", Offset = "0x36C350", VA = "0x1036D550")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17000D02")]
    public List<GenesisLapBossParam.LapInfo> LapInfoList
    {
      [Token(Token = "0x6006FAE"), Address(RVA = "0x36D4B0", Offset = "0x36C2B0", VA = "0x1036D4B0")] get
      {
        return (List<GenesisLapBossParam.LapInfo>) null;
      }
    }

    [Token(Token = "0x6006FAF")]
    [Address(RVA = "0x36D170", Offset = "0x36BF70", VA = "0x1036D170")]
    public void Deserialize(JSON_GenesisLapBossParam json)
    {
    }

    [Token(Token = "0x6006FB0")]
    [Address(RVA = "0x36D310", Offset = "0x36C110", VA = "0x1036D310")]
    public GenesisRewardParam GetRoundReward(int round) => (GenesisRewardParam) null;

    [Token(Token = "0x6006FB1")]
    [Address(RVA = "0x36D030", Offset = "0x36BE30", VA = "0x1036D030")]
    public static void Deserialize(
      ref List<GenesisLapBossParam> list,
      JSON_GenesisLapBossParam[] json)
    {
    }

    [Token(Token = "0x6006FB2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisLapBossParam()
    {
    }

    [Token(Token = "0x2001B0C")]
    public class LapInfo
    {
      [Token(Token = "0x4006724")]
      [FieldOffset(Offset = "0x8")]
      private int mRound;
      [Token(Token = "0x4006725")]
      [FieldOffset(Offset = "0xC")]
      private string mRewardId;
      [Token(Token = "0x4006726")]
      [FieldOffset(Offset = "0x10")]
      private GenesisRewardParam mReward;

      [Token(Token = "0x17000D03")]
      public int Round
      {
        [Token(Token = "0x6006FB3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000D04")]
      public string RewardId
      {
        [Token(Token = "0x6006FB4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000D05")]
      public GenesisRewardParam Reward
      {
        [Token(Token = "0x6006FB5"), Address(RVA = "0x378500", Offset = "0x377300", VA = "0x10378500")] get
        {
          return (GenesisRewardParam) null;
        }
      }

      [Token(Token = "0x6006FB6")]
      [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
      public void Deserialize(JSON_GenesisLapBossParam.LapInfo json)
      {
      }

      [Token(Token = "0x6006FB7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapInfo()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.DuelBattleResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200231A")]
  [MessagePackObject(true)]
  [Serializable]
  public class DuelBattleResultData
  {
    [Token(Token = "0x4009CA0")]
    [FieldOffset(Offset = "0x8")]
    private int mBeforeRank;
    [Token(Token = "0x4009CA1")]
    [FieldOffset(Offset = "0xC")]
    private int mAfterRank;
    [Token(Token = "0x4009CA2")]
    [FieldOffset(Offset = "0x10")]
    private string mPointStr;
    [Token(Token = "0x4009CA3")]
    [FieldOffset(Offset = "0x14")]
    private float mPoint;
    [Token(Token = "0x4009CA4")]
    [FieldOffset(Offset = "0x18")]
    private int mChainWin;
    [Token(Token = "0x4009CA5")]
    [FieldOffset(Offset = "0x1C")]
    private int mTotalWin;
    [Token(Token = "0x4009CA6")]
    [FieldOffset(Offset = "0x20")]
    private int mAddPlayerExp;
    [Token(Token = "0x4009CA7")]
    [FieldOffset(Offset = "0x24")]
    private int mAddGold;
    [Token(Token = "0x4009CA8")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsWin;
    [Token(Token = "0x4009CA9")]
    [FieldOffset(Offset = "0x2C")]
    private JSON_DuelRewardData[] mWinLoseRewards;
    [Token(Token = "0x4009CAA")]
    [FieldOffset(Offset = "0x30")]
    private JSON_DuelRewardData[] mChainWinRewards;
    [Token(Token = "0x4009CAB")]
    [FieldOffset(Offset = "0x34")]
    private JSON_DuelRewardData[] mTotalWinRewards;
    [Token(Token = "0x4009CAC")]
    [FieldOffset(Offset = "0x38")]
    public int mPoint_Base;
    [Token(Token = "0x4009CAD")]
    [FieldOffset(Offset = "0x3C")]
    public int mPoint_BonusUnit;
    [Token(Token = "0x4009CAE")]
    [FieldOffset(Offset = "0x40")]
    public int mPoint_ChainWin;
    [Token(Token = "0x4009CAF")]
    [FieldOffset(Offset = "0x44")]
    public int mPoint_RestAct;
    [Token(Token = "0x4009CB0")]
    [FieldOffset(Offset = "0x48")]
    public int mPoint_EnemyRank;

    [Token(Token = "0x1700151E")]
    public int BeforeRank
    {
      [Token(Token = "0x60096FA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700151F")]
    public int AfterRank
    {
      [Token(Token = "0x60096FB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001520")]
    public string PointStr
    {
      [Token(Token = "0x60096FC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001521")]
    public int ChainWin
    {
      [Token(Token = "0x60096FD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001522")]
    public int TotalWin
    {
      [Token(Token = "0x60096FE"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001523")]
    public int AddPlayerExp
    {
      [Token(Token = "0x60096FF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001524")]
    public int AddGold
    {
      [Token(Token = "0x6009700"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001525")]
    public bool IsWin
    {
      [Token(Token = "0x6009701"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001526")]
    public JSON_DuelRewardData[] WinLoseRewards
    {
      [Token(Token = "0x6009702"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (JSON_DuelRewardData[]) null;
      }
    }

    [Token(Token = "0x17001527")]
    public JSON_DuelRewardData[] ChainWinRewards
    {
      [Token(Token = "0x6009703"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (JSON_DuelRewardData[]) null;
      }
    }

    [Token(Token = "0x17001528")]
    public JSON_DuelRewardData[] TotalWinRewards
    {
      [Token(Token = "0x6009704"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (JSON_DuelRewardData[]) null;
      }
    }

    [Token(Token = "0x17001529")]
    public int Point_Base
    {
      [Token(Token = "0x6009705"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700152A")]
    public int Point_BonusUnit
    {
      [Token(Token = "0x6009706"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700152B")]
    public int Point_ChainWin
    {
      [Token(Token = "0x6009707"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700152C")]
    public int Point_RestAct
    {
      [Token(Token = "0x6009708"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700152D")]
    public int Point_EnemyRank
    {
      [Token(Token = "0x6009709"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700152E")]
    public float Point
    {
      [Token(Token = "0x600970A"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600970B")]
    [Address(RVA = "0x596F10", Offset = "0x595D10", VA = "0x10596F10")]
    public void Deserialize(
      JSON_DuelBattleResultData json,
      JSON_DuelRewardDetailData reward_detail,
      bool is_win)
    {
    }

    [Token(Token = "0x600970C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelBattleResultData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002718")]
  public class MasteryRewardManager : MonoBehaviour
  {
    [Token(Token = "0x400B83D")]
    [FieldOffset(Offset = "0xC")]
    private int mMasteryRank;
    [Token(Token = "0x400B83E")]
    [FieldOffset(Offset = "0x10")]
    private List<MasteryRewardStatusData> mRewardStatusList;
    [Token(Token = "0x400B83F")]
    [FieldOffset(Offset = "0x0")]
    private static MasteryRewardManager mInstance;
    [Token(Token = "0x400B840")]
    [FieldOffset(Offset = "0x14")]
    private List<MasteryRewardsItemData> mMasteryRewardItemList;
    [Token(Token = "0x400B841")]
    [FieldOffset(Offset = "0x18")]
    private int mDoorMasterUnitNum;
    [Token(Token = "0x400B842")]
    [FieldOffset(Offset = "0x1C")]
    private string mNowEmblem;

    [Token(Token = "0x17001838")]
    public int MasteryRank
    {
      [Token(Token = "0x600AF43"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001839")]
    public static MasteryRewardManager Instance
    {
      [Token(Token = "0x600AF44"), Address(RVA = "0x738560", Offset = "0x737360", VA = "0x10738560")] get
      {
        return (MasteryRewardManager) null;
      }
    }

    [Token(Token = "0x1700183A")]
    public List<MasteryRewardsItemData> MasteryRewardItemList
    {
      [Token(Token = "0x600AF45"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<MasteryRewardsItemData>) null;
      }
    }

    [Token(Token = "0x1700183B")]
    public int DoorMasterUnitNum
    {
      [Token(Token = "0x600AF46"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700183C")]
    public string NowEmblem
    {
      [Token(Token = "0x600AF47"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600AF48")]
    [Address(RVA = "0x737C10", Offset = "0x736A10", VA = "0x10737C10")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600AF49")]
    [Address(RVA = "0x737B90", Offset = "0x736990", VA = "0x10737B90")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600AF4A")]
    [Address(RVA = "0x736C60", Offset = "0x735A60", VA = "0x10736C60")]
    public void Deserialize(JSON_MasteryRewardStatusData[] json)
    {
    }

    [Token(Token = "0x600AF4B")]
    [Address(RVA = "0x736DA0", Offset = "0x735BA0", VA = "0x10736DA0")]
    public List<MasteryRewardData> GetMasteryRewardDataList() => (List<MasteryRewardData>) null;

    [Token(Token = "0x600AF4C")]
    [Address(RVA = "0x7375D0", Offset = "0x7363D0", VA = "0x107375D0")]
    public MasteryRewardParam IsNowMasteryReward() => (MasteryRewardParam) null;

    [Token(Token = "0x600AF4D")]
    [Address(RVA = "0x7373E0", Offset = "0x7361E0", VA = "0x107373E0")]
    public MasteryRewardParam IsNextMasteryReward() => (MasteryRewardParam) null;

    [Token(Token = "0x600AF4E")]
    [Address(RVA = "0x737890", Offset = "0x736690", VA = "0x10737890")]
    public RewardStatus IsRewardStatus(string Iname) => new RewardStatus();

    [Token(Token = "0x600AF4F")]
    [Address(RVA = "0x7371B0", Offset = "0x735FB0", VA = "0x107371B0")]
    public bool IsAchievementAllReward() => new bool();

    [Token(Token = "0x600AF50")]
    [Address(RVA = "0x737310", Offset = "0x736110", VA = "0x10737310")]
    public bool IsAchievementReward(string Iname) => new bool();

    [Token(Token = "0x600AF51")]
    [Address(RVA = "0x7377C0", Offset = "0x7365C0", VA = "0x107377C0")]
    public bool IsReceivedReward(string Iname) => new bool();

    [Token(Token = "0x600AF52")]
    [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
    public void SetDoorMasterUnitNum(int json)
    {
    }

    [Token(Token = "0x600AF53")]
    [Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")]
    public void SetMasteryRank(int json)
    {
    }

    [Token(Token = "0x600AF54")]
    [Address(RVA = "0x737C90", Offset = "0x736A90", VA = "0x10737C90")]
    public void SetMasteryRewardItemList(JSON_MasteryRewardsItemData[] json)
    {
    }

    [Token(Token = "0x600AF55")]
    [Address(RVA = "0x736920", Offset = "0x735720", VA = "0x10736920")]
    public List<RewardListItem> CreateItemIcon(RewardListItem listItem)
    {
      return (List<RewardListItem>) null;
    }

    [Token(Token = "0x600AF56")]
    [Address(RVA = "0x737960", Offset = "0x736760", VA = "0x10737960")]
    public void NowEmblemUpDate()
    {
    }

    [Token(Token = "0x600AF57")]
    [Address(RVA = "0x738110", Offset = "0x736F10", VA = "0x10738110")]
    public void ____TestCreateItemList()
    {
    }

    [Token(Token = "0x600AF58")]
    [Address(RVA = "0x738510", Offset = "0x737310", VA = "0x10738510")]
    public MasteryRewardManager()
    {
    }
  }
}

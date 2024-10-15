// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200284D")]
  public class PointQuestRewardParam : MonoBehaviour
  {
    [Token(Token = "0x400C04C")]
    private const string SYS_POINTQUEST_REWARD_GROUP_TEXT = "sys.POINTQUEST_REWARD_GROUP_TEXT";
    [Token(Token = "0x400C04D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Completed;
    [Token(Token = "0x400C04E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject BgCover;
    [Token(Token = "0x400C04F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject InvalidButton;
    [Token(Token = "0x400C050")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button GetRewardButton;
    [Token(Token = "0x400C051")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject RewardBadge;
    [Token(Token = "0x400C052")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject AlreadyRewardMark;
    [Token(Token = "0x400C053")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject Count;
    [Token(Token = "0x400C054")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject RewardUnit;
    [Token(Token = "0x400C055")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject RewardItem;
    [Token(Token = "0x400C056")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject RewardCard;
    [Token(Token = "0x400C057")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject RewardArtifact;
    [Token(Token = "0x400C058")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject RewardAward;
    [Token(Token = "0x400C059")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject RewardGold;
    [Token(Token = "0x400C05A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject RewardCoin;
    [Token(Token = "0x400C05B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text RewardText;
    [Token(Token = "0x400C05C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform RewardList;
    [Token(Token = "0x400C05D")]
    [FieldOffset(Offset = "0x4C")]
    private PointQuestTotalRewardData mRewardData;
    [Token(Token = "0x400C05E")]
    [FieldOffset(Offset = "0x50")]
    private PointQuestEventRewardParam mRewardItemParam;
    [Token(Token = "0x400C05F")]
    [FieldOffset(Offset = "0x54")]
    private PointQuestRewardStatus mRewardStatus;

    [Token(Token = "0x170018E8")]
    public PointQuestTotalRewardData RewardData
    {
      [Token(Token = "0x600B5E4"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (PointQuestTotalRewardData) null;
      }
    }

    [Token(Token = "0x170018E9")]
    public PointQuestEventRewardParam RewardItemParam
    {
      [Token(Token = "0x600B5E5"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (PointQuestEventRewardParam) null;
      }
    }

    [Token(Token = "0x170018EA")]
    public PointQuestRewardStatus RewardStatus
    {
      [Token(Token = "0x600B5E6"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (PointQuestRewardStatus) null;
      }
    }

    [Token(Token = "0x600B5E7")]
    [Address(RVA = "0x7C1770", Offset = "0x7C0570", VA = "0x107C1770")]
    public bool Setup(
      PointQuestTotalRewardData reward_data,
      PointQuestEventRewardParam item_param,
      PointQuestRewardStatus item_status)
    {
      return new bool();
    }

    [Token(Token = "0x600B5E8")]
    [Address(RVA = "0x7C0B90", Offset = "0x7BF990", VA = "0x107C0B90")]
    private void CreateReward()
    {
    }

    [Token(Token = "0x600B5E9")]
    [Address(RVA = "0x7C1680", Offset = "0x7C0480", VA = "0x107C1680")]
    private void SetStatus(PointQuestRewardStatus pqrStatus)
    {
    }

    [Token(Token = "0x600B5EA")]
    [Address(RVA = "0x7C14E0", Offset = "0x7C02E0", VA = "0x107C14E0")]
    private void OnClickButton(SRPG_Button btn)
    {
    }

    [Token(Token = "0x600B5EB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestRewardParam()
    {
    }
  }
}

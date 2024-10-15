// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBattleResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028CE")]
  [FlowNode.Pin(107, "GetRaidBattleAmountReward", FlowNode.PinTypes.Output, 107)]
  [FlowNode.Pin(106, "GetRewardEnd", FlowNode.PinTypes.Output, 106)]
  [AddComponentMenu("UI/Raid/RaidBattleResult")]
  [FlowNode.Pin(104, "GetRaidBattleRatioReward", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(102, "AttackCountupEnd", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "AttackCountON", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "TotalCountON", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "RewardObjectON", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "AttackCountSkip", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(6, "TotalCountSkip", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(7, "GetRewardSkip", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(101, "Common Output", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "TotalCountupEnd", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(105, "NotRaidBattleReward", FlowNode.PinTypes.Output, 105)]
  public class RaidBattleResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C39E")]
    private const int PIN_ATTACK_COUNT_ON = 1;
    [Token(Token = "0x400C39F")]
    private const int PIN_TOTAL_COUNT_ON = 2;
    [Token(Token = "0x400C3A0")]
    private const int PIN_REWARD_ON = 3;
    [Token(Token = "0x400C3A1")]
    private const int PIN_ATTACK_COUNT_SKIP = 4;
    [Token(Token = "0x400C3A2")]
    private const int PIN_TOTAL_COUNT_SKIP = 6;
    [Token(Token = "0x400C3A3")]
    private const int PIN_GET_REWARD_SKIP = 7;
    [Token(Token = "0x400C3A4")]
    private const int PIN_COMMON_OUTPUT = 101;
    [Token(Token = "0x400C3A5")]
    private const int PIN_ATTACK_COUNTUP_END = 102;
    [Token(Token = "0x400C3A6")]
    private const int PIN_TOTAL_COUNTUP_END = 103;
    [Token(Token = "0x400C3A7")]
    private const int PIN_GET_RAID_BATTLE_RATIOREWARD = 104;
    [Token(Token = "0x400C3A8")]
    private const int PIN_GET_RAID_BATTLE_AMOUNTREWARD = 107;
    [Token(Token = "0x400C3A9")]
    private const int PIN_NOT_RAID_BATTLE_REWARD = 105;
    [Token(Token = "0x400C3AA")]
    private const int PIN_GET_REWARD_END = 106;
    [Token(Token = "0x400C3AB")]
    private const int CHANGE_COLOR_DIGITS_NUM_01 = 6;
    [Token(Token = "0x400C3AC")]
    private const int CHANGE_COLOR_DIGITS_NUM_02 = 8;
    [Token(Token = "0x400C3AD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼表示物オブジェクト")]
    private GameObject AttackObject;
    [Token(Token = "0x400C3AE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject TotalObject;
    [Token(Token = "0x400C3AF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject RewardObject;
    [Token(Token = "0x400C3B0")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼キャラクタイメージ")]
    [SerializeField]
    private GameObject CharacterImage;
    [Token(Token = "0x400C3B1")]
    [FieldOffset(Offset = "0x1C")]
    [HeaderBar("▼ダメージ表記")]
    [SerializeField]
    private Transform AttackDamageGrid;
    [Token(Token = "0x400C3B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject AttackDamageFont01;
    [Token(Token = "0x400C3B3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject AttackDamageFont02;
    [Token(Token = "0x400C3B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject AttackDamageFont03;
    [Token(Token = "0x400C3B5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform TotalDamageGrid;
    [Token(Token = "0x400C3B6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject TotalDamageFont01;
    [Token(Token = "0x400C3B7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject TotalDamageFont02;
    [Token(Token = "0x400C3B8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject TotalDamageFont03;
    [Token(Token = "0x400C3B9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float NextNumberSecond;
    [Token(Token = "0x400C3BA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string CountActionObjectName;
    [Token(Token = "0x400C3BB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [HeaderBar("▼割合報酬オブジェクト")]
    private string RaidRewardIconPath;
    [Token(Token = "0x400C3BC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string ItemPath;
    [Token(Token = "0x400C3BD")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int ChangeGridItemNum;
    [Token(Token = "0x400C3BE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Transform BattleRatioRewardItemGrid;
    [Token(Token = "0x400C3BF")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject BattleRatioRewardItemBase;
    [Token(Token = "0x400C3C0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Transform OverBattleRatioRewardItemGrid;
    [Token(Token = "0x400C3C1")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject OverBattleRatioRewardItemBase;
    [Token(Token = "0x400C3C2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    [HeaderBar("▼到達報酬オブジェクト")]
    private Transform BattleAmountRewardItemGrid;
    [Token(Token = "0x400C3C3")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject BattleAmountRewardItemBase;
    [Token(Token = "0x400C3C4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform OverBattleAmountRewardItemGrid;
    [Token(Token = "0x400C3C5")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject OverBattleAmountRewardItemBase;
    [Token(Token = "0x400C3C6")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    [HeaderBar("▼数値表示演出時のSE")]
    private string DecideNumberSE;
    [Token(Token = "0x400C3C7")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private string FinishDecideNumberSE;
    [Token(Token = "0x400C3C8")]
    [FieldOffset(Offset = "0x78")]
    private RaidBattleResult.eState mState;
    [Token(Token = "0x400C3C9")]
    [FieldOffset(Offset = "0x7C")]
    private ReqRaidBtlEnd.Response mRaidBtlEndParam;
    [Token(Token = "0x400C3CA")]
    [FieldOffset(Offset = "0x80")]
    private ReqGuildRaidBtlEnd.Response mGuildRaidBtlEndParam;
    [Token(Token = "0x400C3CB")]
    [FieldOffset(Offset = "0x84")]
    private int mBeforeRaidBossHp;
    [Token(Token = "0x400C3CC")]
    [FieldOffset(Offset = "0x88")]
    private int mAfterRaidBossHp;
    [Token(Token = "0x400C3CD")]
    [FieldOffset(Offset = "0x8C")]
    private int mCountupDigitsNum;
    [Token(Token = "0x400C3CE")]
    [FieldOffset(Offset = "0x90")]
    private float mCountupTime;
    [Token(Token = "0x400C3CF")]
    [FieldOffset(Offset = "0x94")]
    private CustomSound mCustomSound;
    [Token(Token = "0x400C3D0")]
    [FieldOffset(Offset = "0x98")]
    private RaidBattleResult.eRaidRewardType mReawardStatus;
    [Token(Token = "0x400C3D1")]
    [FieldOffset(Offset = "0x9C")]
    private List<RaidBattleResult.DamageNumber> mAttackDamageNumber;
    [Token(Token = "0x400C3D2")]
    [FieldOffset(Offset = "0xA0")]
    private List<RaidBattleResult.DamageNumber> mTotalDamageNumber;
    [Token(Token = "0x400C3D3")]
    [FieldOffset(Offset = "0xA4")]
    private List<GameObject> mItemRewardIcon;

    [Token(Token = "0x600B87E")]
    [Address(RVA = "0x7F6480", Offset = "0x7F5280", VA = "0x107F6480")]
    private void Start()
    {
    }

    [Token(Token = "0x600B87F")]
    [Address(RVA = "0x7F6F50", Offset = "0x7F5D50", VA = "0x107F6F50")]
    private void Update()
    {
    }

    [Token(Token = "0x600B880")]
    [Address(RVA = "0x7F5990", Offset = "0x7F4790", VA = "0x107F5990")]
    private bool Countup(List<RaidBattleResult.DamageNumber> list) => new bool();

    [Token(Token = "0x600B881")]
    [Address(RVA = "0x7F58A0", Offset = "0x7F46A0", VA = "0x107F58A0")]
    private void CountAllOn(List<RaidBattleResult.DamageNumber> list)
    {
    }

    [Token(Token = "0x600B882")]
    [Address(RVA = "0x7F5C90", Offset = "0x7F4A90", VA = "0x107F5C90")]
    private void GetDamageRewardItems(RaidBattleResult.eRaidRewardType type)
    {
    }

    [Token(Token = "0x600B883")]
    [Address(RVA = "0x7F55B0", Offset = "0x7F43B0", VA = "0x107F55B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B884")]
    [Address(RVA = "0x7F7080", Offset = "0x7F5E80", VA = "0x107F7080")]
    public RaidBattleResult()
    {
    }

    [Token(Token = "0x20028CF")]
    private enum eState
    {
      [Token(Token = "0x400C3D5")] None,
      [Token(Token = "0x400C3D6")] AttackCountup,
      [Token(Token = "0x400C3D7")] TotalCountup,
    }

    [Token(Token = "0x20028D0")]
    private enum eRaidRewardType
    {
      [Token(Token = "0x400C3D9")] None,
      [Token(Token = "0x400C3DA")] Ratio,
      [Token(Token = "0x400C3DB")] Amount,
    }

    [Token(Token = "0x20028D1")]
    private struct DamageNumber
    {
      [Token(Token = "0x400C3DC")]
      [FieldOffset(Offset = "0x0")]
      public GameObject go;
      [Token(Token = "0x400C3DD")]
      [FieldOffset(Offset = "0x4")]
      public int num;

      [Token(Token = "0x600B885")]
      [Address(RVA = "0x7F2780", Offset = "0x7F1580", VA = "0x107F2780")]
      public DamageNumber(GameObject _go, int _num)
      {
      }
    }
  }
}

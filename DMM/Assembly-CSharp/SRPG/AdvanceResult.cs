// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C5E")]
  [FlowNode.Pin(1, "報酬表示", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("Battle/BattleUI/AdvanceResult")]
  [FlowNode.Pin(102, "強制終了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "シェア画面表示した", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "報酬表示した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "シェア画面表示へ", FlowNode.PinTypes.Input, 11)]
  public class AdvanceResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4002129")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400212A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject GoReward;
    [Token(Token = "0x400212B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoShare;
    [Token(Token = "0x400212C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(10f)]
    private GameObject GoSingle;
    [Token(Token = "0x400212D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject GoMultiple;
    [Token(Token = "0x400212E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Space(5f)]
    private Text TextRewardName;
    [Token(Token = "0x400212F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text TextRewardNum;
    [Token(Token = "0x4002130")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject TextRewardConn;
    [Token(Token = "0x4002131")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private AdvanceRewardIcon RewardIconTemplate;
    [Token(Token = "0x4002132")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform TrRewardIconParent;
    [Token(Token = "0x4002133")]
    [FieldOffset(Offset = "0x34")]
    [Space(5f)]
    [SerializeField]
    private AdvanceResultItem RewardItemListTemplate;
    [Token(Token = "0x4002134")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform TrRewardItemListParent;
    [Token(Token = "0x4002135")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private AdvanceResultItem RewardIconListTemplate;
    [Token(Token = "0x4002136")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform TrRewardIconListParent;
    [Token(Token = "0x4002137")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [Space(10f)]
    private GameObject GoShareParent;
    [Token(Token = "0x4002138")]
    private const int PIN_IN_REWARD = 1;
    [Token(Token = "0x4002139")]
    private const int PIN_IN_SHARE = 11;
    [Token(Token = "0x400213A")]
    private const int PIN_OUT_REWARD = 100;
    [Token(Token = "0x400213B")]
    private const int PIN_OUT_SHARE = 101;
    [Token(Token = "0x400213C")]
    private const int PIN_OUT_EXIT = 102;

    [Token(Token = "0x60030B6")]
    [Address(RVA = "0x101D060", Offset = "0x101BE60", VA = "0x1101D060")]
    private void Awake()
    {
    }

    [Token(Token = "0x60030B7")]
    [Address(RVA = "0x101D330", Offset = "0x101C130", VA = "0x1101D330")]
    private void RewardStart()
    {
    }

    [Token(Token = "0x60030B8")]
    [Address(RVA = "0x101DCF0", Offset = "0x101CAF0", VA = "0x1101DCF0")]
    private void ShareStart()
    {
    }

    [Token(Token = "0x60030B9")]
    [Address(RVA = "0x101D140", Offset = "0x101BF40", VA = "0x1101D140")]
    private void PrepareAsset()
    {
    }

    [Token(Token = "0x60030BA")]
    [Address(RVA = "0x101D0D0", Offset = "0x101BED0", VA = "0x1101D0D0")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x60030BB")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void Exit()
    {
    }

    [Token(Token = "0x60030BC")]
    [Address(RVA = "0x101D030", Offset = "0x101BE30", VA = "0x1101D030", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60030BD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceResult()
    {
    }
  }
}

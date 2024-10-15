// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisResult
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
  [Token(Token = "0x2000C61")]
  [FlowNode.Pin(1, "報酬表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "シェア画面表示へ", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "報酬表示した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "シェア画面表示した", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("Battle/BattleUI/GenesisResult")]
  [FlowNode.Pin(102, "強制終了", FlowNode.PinTypes.Output, 102)]
  public class GenesisResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4002147")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x4002148")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject GoReward;
    [Token(Token = "0x4002149")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoShare;
    [Token(Token = "0x400214A")]
    [FieldOffset(Offset = "0x18")]
    [Space(10f)]
    [SerializeField]
    private GameObject GoSingle;
    [Token(Token = "0x400214B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject GoMultiple;
    [Token(Token = "0x400214C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Space(5f)]
    private Text TextRewardName;
    [Token(Token = "0x400214D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text TextRewardNum;
    [Token(Token = "0x400214E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject TextRewardConn;
    [Token(Token = "0x400214F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GenesisRewardIcon RewardIconTemplate;
    [Token(Token = "0x4002150")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform TrRewardIconParent;
    [Token(Token = "0x4002151")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Space(5f)]
    private GenesisResultItem RewardItemListTemplate;
    [Token(Token = "0x4002152")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform TrRewardItemListParent;
    [Token(Token = "0x4002153")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GenesisResultItem RewardIconListTemplate;
    [Token(Token = "0x4002154")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform TrRewardIconListParent;
    [Token(Token = "0x4002155")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [Space(10f)]
    private GameObject GoShareParent;
    [Token(Token = "0x4002156")]
    private const int PIN_IN_REWARD = 1;
    [Token(Token = "0x4002157")]
    private const int PIN_IN_SHARE = 11;
    [Token(Token = "0x4002158")]
    private const int PIN_OUT_REWARD = 100;
    [Token(Token = "0x4002159")]
    private const int PIN_OUT_SHARE = 101;
    [Token(Token = "0x400215A")]
    private const int PIN_OUT_EXIT = 102;

    [Token(Token = "0x60030C8")]
    [Address(RVA = "0x10219C0", Offset = "0x10207C0", VA = "0x110219C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60030C9")]
    [Address(RVA = "0x1021C90", Offset = "0x1020A90", VA = "0x11021C90")]
    private void RewardStart()
    {
    }

    [Token(Token = "0x60030CA")]
    [Address(RVA = "0x10225D0", Offset = "0x10213D0", VA = "0x110225D0")]
    private void ShareStart()
    {
    }

    [Token(Token = "0x60030CB")]
    [Address(RVA = "0x1021AA0", Offset = "0x10208A0", VA = "0x11021AA0")]
    private void PrepareAsset()
    {
    }

    [Token(Token = "0x60030CC")]
    [Address(RVA = "0x1021A30", Offset = "0x1020830", VA = "0x11021A30")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x60030CD")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void Exit()
    {
    }

    [Token(Token = "0x60030CE")]
    [Address(RVA = "0x1021990", Offset = "0x1020790", VA = "0x11021990", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60030CF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisResult()
    {
    }
  }
}

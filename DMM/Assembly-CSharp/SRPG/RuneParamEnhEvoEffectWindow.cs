// Decompiled with JetBrains decompiler
// Type: SRPG.RuneParamEnhEvoEffectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029BD")]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("UI/Rune/RuneParamEnhEvoEffectWindow")]
  [FlowNode.Pin(910, "覚醒ステータス強化通信開始", FlowNode.PinTypes.Output, 910)]
  [FlowNode.Pin(900, "閉じるボタン押下", FlowNode.PinTypes.Input, 900)]
  [FlowNode.Pin(100, "ゲージアニメ開始", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(920, "強化アニメ開始", FlowNode.PinTypes.Output, 920)]
  [FlowNode.Pin(110, "覚醒ステータス強化通信完了", FlowNode.PinTypes.Input, 110)]
  public class RuneParamEnhEvoEffectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CA6F")]
    private const int INPUT_START_GAUGE_ANIM = 100;
    [Token(Token = "0x400CA70")]
    private const int INPUT_ENHANCE_EVO_REQUEST_END = 110;
    [Token(Token = "0x400CA71")]
    private const int INPUT_CLOSE = 900;
    [Token(Token = "0x400CA72")]
    private const int OUTPUT_ENHANCE_EVO_REQUEST_START = 910;
    [Token(Token = "0x400CA73")]
    private const int OUTPUT_ENHANCE_EVO_ANIM_START = 920;
    [Token(Token = "0x400CA74")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400CA75")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400CA76")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneDrawEnhanceEffect mRuneDrawEnhanceEffect;
    [Token(Token = "0x400CA77")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEvoStateOneSetting mRuneDrawEvoStateOneSetting;
    [Token(Token = "0x400CA78")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCostEnhanceEvoTemp;
    [Token(Token = "0x400CA79")]
    [FieldOffset(Offset = "0x1C")]
    private BindRuneData mRuneDataBefore;
    [Token(Token = "0x400CA7A")]
    [FieldOffset(Offset = "0x20")]
    private BindRuneData mRuneDataCurr;
    [Token(Token = "0x400CA7B")]
    [FieldOffset(Offset = "0x24")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CA7C")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsEnhanceSuccess;
    [Token(Token = "0x400CA7D")]
    [FieldOffset(Offset = "0x2C")]
    private int mEvoSlot;
    [Token(Token = "0x400CA7E")]
    [FieldOffset(Offset = "0x30")]
    private int mEvoIndex;
    [Token(Token = "0x400CA7F")]
    [FieldOffset(Offset = "0x34")]
    private List<Button> mCreatedEvoEnhanceButtons;
    [Token(Token = "0x400CA80")]
    [FieldOffset(Offset = "0x38")]
    private List<RuneDrawCost> mCreatedDrawCost;
    [Token(Token = "0x400CA81")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject mConfirmEvoEnhancePopup;

    [Token(Token = "0x600BDD3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BDD4")]
    [Address(RVA = "0x856A70", Offset = "0x855870", VA = "0x10856A70")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BDD5")]
    [Address(RVA = "0x856290", Offset = "0x855090", VA = "0x10856290", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BDD6")]
    [Address(RVA = "0x857080", Offset = "0x855E80", VA = "0x10857080")]
    private IEnumerator StartGaugeAnimation() => (IEnumerator) null;

    [Token(Token = "0x600BDD7")]
    [Address(RVA = "0x856F00", Offset = "0x855D00", VA = "0x10856F00")]
    public void Setup(
      RuneManager manager,
      BindRuneData before_rune_data,
      BindRuneData after_rune_data)
    {
    }

    [Token(Token = "0x600BDD8")]
    [Address(RVA = "0x8565B0", Offset = "0x8553B0", VA = "0x108565B0")]
    private void CreateEnhanceEvoButtons()
    {
    }

    [Token(Token = "0x600BDD9")]
    [Address(RVA = "0x8568E0", Offset = "0x8556E0", VA = "0x108568E0")]
    private void OnClickEnhanceEvo(RuneCost cost)
    {
    }

    [Token(Token = "0x600BDDA")]
    [Address(RVA = "0x856B20", Offset = "0x855920", VA = "0x10856B20")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BDDB")]
    [Address(RVA = "0x856D10", Offset = "0x855B10", VA = "0x10856D10")]
    private void SetGaugeStatus()
    {
    }

    [Token(Token = "0x600BDDC")]
    [Address(RVA = "0x8570F0", Offset = "0x855EF0", VA = "0x108570F0")]
    public RuneParamEnhEvoEffectWindow()
    {
    }
  }
}

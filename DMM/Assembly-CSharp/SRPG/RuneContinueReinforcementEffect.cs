// Decompiled with JetBrains decompiler
// Type: SRPG.RuneContinueReinforcementEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002978")]
  [AddComponentMenu("UI/Rune/RuneContinueReinforcementEffectWindow")]
  [FlowNode.Pin(2101, "自身を閉じて再度連続強化ウインドウを開く", FlowNode.PinTypes.Output, 2101)]
  [FlowNode.Pin(2001, "強化ボタン", FlowNode.PinTypes.Input, 2001)]
  [FlowNode.Pin(111, "連続「強化・覚醒」アニメ開始", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(11, "連続「強化・覚醒」アニメ開始", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "閉じるボタン", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  public class RuneContinueReinforcementEffect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C809")]
    private const int INPUT_INIT = 1;
    [Token(Token = "0x400C80A")]
    private const int OUTPUT_INIT = 101;
    [Token(Token = "0x400C80B")]
    private const int INPUT_RUNE_ENHANCE_EFFECT_START = 11;
    [Token(Token = "0x400C80C")]
    private const int OUTPUT_RUNE_ENHANCE_EFFECT_START = 111;
    [Token(Token = "0x400C80D")]
    private const int INPUT_CLOSE_BUTTON = 200;
    [Token(Token = "0x400C80E")]
    private const int OUTPUT_CLOSE_EFFECT = 1000;
    [Token(Token = "0x400C80F")]
    private const int INPUT_RUNE_ENHANCE_BUTTON = 2001;
    [Token(Token = "0x400C810")]
    private const int OUTPUT_CLOSE_EFFECT_AND_OPEN_BULK_ENHANCE = 2101;
    [Token(Token = "0x400C811")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C812")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneIcon mAfterRuneIcon;
    [Token(Token = "0x400C813")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceLevel;
    [Token(Token = "0x400C814")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawEnhancedBaseState mRuneDrawEnhancedBaseState;
    [Token(Token = "0x400C815")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceEvoLevel;
    [Token(Token = "0x400C816")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawEnhanceEffect mRuneDrawEnhanceEffect;
    [Token(Token = "0x400C817")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mOneSettingParent;
    [Token(Token = "0x400C818")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mOneSettingBase;
    [Token(Token = "0x400C819")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400C81A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C81B")]
    [FieldOffset(Offset = "0x34")]
    private RuneContinueReinforcementEffectModel mModel;
    [Token(Token = "0x400C81C")]
    [FieldOffset(Offset = "0x38")]
    private List<RuneDrawEvoStateOneSetting> mOneSettingList;
    [Token(Token = "0x400C81D")]
    [FieldOffset(Offset = "0x3C")]
    private RuneManager mRuneManager;

    [Token(Token = "0x600BBC9")]
    [Address(RVA = "0x8310C0", Offset = "0x82FEC0", VA = "0x108310C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BBCA")]
    [Address(RVA = "0x831410", Offset = "0x830210", VA = "0x10831410")]
    private void PlayAnimation()
    {
    }

    [Token(Token = "0x600BBCB")]
    [Address(RVA = "0x8311C0", Offset = "0x82FFC0", VA = "0x108311C0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BBCC")]
    [Address(RVA = "0x831580", Offset = "0x830380", VA = "0x10831580")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BBCD")]
    [Address(RVA = "0x831CE0", Offset = "0x830AE0", VA = "0x10831CE0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600BBCE")]
    [Address(RVA = "0x8318B0", Offset = "0x8306B0", VA = "0x108318B0")]
    private void SetupOneSettingList()
    {
    }

    [Token(Token = "0x600BBCF")]
    [Address(RVA = "0x831F30", Offset = "0x830D30", VA = "0x10831F30")]
    public RuneContinueReinforcementEffect()
    {
    }
  }
}

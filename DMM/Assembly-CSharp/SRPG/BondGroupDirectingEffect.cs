// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupDirectingEffect
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
  [Token(Token = "0x20020AF")]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "スキップ", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/Bond/BondGroupDirectingEffect")]
  [FlowNode.Pin(102, "スキップ完了", FlowNode.PinTypes.Output, 102)]
  public class BondGroupDirectingEffect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008CDE")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008CDF")]
    private const int PIN_INPUT_SKIP = 2;
    [Token(Token = "0x4008CE0")]
    private const int PIN_OUTPUT_INIT_FINISH = 101;
    [Token(Token = "0x4008CE1")]
    private const int PIN_OUTPUT_SKIP_FINISH = 102;
    [Token(Token = "0x4008CE2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mGroupImg;
    [Token(Token = "0x4008CE3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mBannerImg;
    [Token(Token = "0x4008CE4")]
    [FieldOffset(Offset = "0x14")]
    private BondGroupParam mBondGroupParam;

    [Token(Token = "0x6008806")]
    [Address(RVA = "0x494850", Offset = "0x493650", VA = "0x10494850", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008807")]
    [Address(RVA = "0x494940", Offset = "0x493740", VA = "0x10494940")]
    private void Initialized()
    {
    }

    [Token(Token = "0x6008808")]
    [Address(RVA = "0x494CF0", Offset = "0x493AF0", VA = "0x10494CF0")]
    private IEnumerator RefreshBGImage() => (IEnumerator) null;

    [Token(Token = "0x6008809")]
    [Address(RVA = "0x494C30", Offset = "0x493A30", VA = "0x10494C30")]
    public void OnSkipExecute()
    {
    }

    [Token(Token = "0x600880A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondGroupDirectingEffect()
    {
    }
  }
}

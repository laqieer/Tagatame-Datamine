// Decompiled with JetBrains decompiler
// Type: SRPG.HotDeal_EffectDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002640")]
  [FlowNode.Pin(10, "FirstView", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "NotFirstView", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(20, "Generate", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(21, "NotGenerate", FlowNode.PinTypes.Output, 21)]
  [AddComponentMenu("UI/HotDeal/HotDeal_EffectDialog")]
  public class HotDeal_EffectDialog : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B2AF")]
    private const int PIN_INPUT_START = 0;
    [Token(Token = "0x400B2B0")]
    private const int PIN_OUTPUT_FIRST_VIEE = 10;
    [Token(Token = "0x400B2B1")]
    private const int PIN_OUTPUT_NOT_FIRST_VIEW = 11;
    [Token(Token = "0x400B2B2")]
    private const int PIN_OUTPUT_GENERATE_EFFECT = 20;
    [Token(Token = "0x400B2B3")]
    private const int PIN_OUTPUT_NOT_GENERATE_EFFECT = 21;
    [Token(Token = "0x400B2B4")]
    [FieldOffset(Offset = "0xC")]
    private bool m_IsPlayFirstViewEffect;
    [Token(Token = "0x400B2B5")]
    [FieldOffset(Offset = "0xD")]
    private bool m_IsPlayGenerateEffect;
    [Token(Token = "0x400B2B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("メッセージ")]
    private Text m_Message;

    [Token(Token = "0x600AABE")]
    [Address(RVA = "0x6E1EE0", Offset = "0x6E0CE0", VA = "0x106E1EE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AABF")]
    [Address(RVA = "0x6E1F30", Offset = "0x6E0D30", VA = "0x106E1F30")]
    public void SetUp(string _message)
    {
    }

    [Token(Token = "0x600AAC0")]
    [Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")]
    public void SetIsFirstViewEffect(bool is_first_view)
    {
    }

    [Token(Token = "0x600AAC1")]
    [Address(RVA = "0x3DA470", Offset = "0x3D9270", VA = "0x103DA470")]
    public void SetIsGenerateEffect(bool is_generate)
    {
    }

    [Token(Token = "0x600AAC2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HotDeal_EffectDialog()
    {
    }
  }
}

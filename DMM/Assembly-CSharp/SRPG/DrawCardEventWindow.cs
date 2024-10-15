// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardEventWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022FA")]
  [FlowNode.Pin(101, "Enable", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "IsEnable", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "Disable", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("UI/DrawCard/DrawCardEventWindow")]
  public class DrawCardEventWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009C11")]
    private const int INPUT_PIN_IS_ENABLE = 1;
    [Token(Token = "0x4009C12")]
    private const int OUTPUT_PIN_ENABLE = 101;
    [Token(Token = "0x4009C13")]
    private const int OUTPUT_PIN_DISABLE = 111;
    [Token(Token = "0x4009C14")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject RuleWindow;
    [Token(Token = "0x4009C15")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject DrawCard;
    [Token(Token = "0x4009C16")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GameStart;
    [Token(Token = "0x4009C17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text RuleText;

    [Token(Token = "0x600966D")]
    [Address(RVA = "0x592FF0", Offset = "0x591DF0", VA = "0x10592FF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600966E")]
    [Address(RVA = "0x593010", Offset = "0x591E10", VA = "0x10593010")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600966F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DrawCardEventWindow()
    {
    }
  }
}

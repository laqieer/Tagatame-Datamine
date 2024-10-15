// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidHealBpWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D65")]
  [FlowNode.Pin(105, "BP回復上限", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(104, "BP回復不可", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(999, "その他エラー", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(101, "BPが満タン", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "幻晶石数確認", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(103, "幻晶石が足りていない", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(2, "BPが足りないときの初期化", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "幻晶石が足りている", FlowNode.PinTypes.Output, 102)]
  public class WorldRaidHealBpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E248")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400E249")]
    private const int PIN_INPUT_INIT_NOT_ENOUGH_BP = 2;
    [Token(Token = "0x400E24A")]
    private const int PIN_INPUT_CHECK_COIN_NUM = 3;
    [Token(Token = "0x400E24B")]
    private const int PIN_OUTPUT_NOT_NEED_HEAL = 101;
    [Token(Token = "0x400E24C")]
    private const int PIN_OUTPUT_ENOUGH_COIN = 102;
    [Token(Token = "0x400E24D")]
    private const int PIN_OUTPUT_NOT_ENOUGH_COIN = 103;
    [Token(Token = "0x400E24E")]
    private const int PIN_OUTPUT_NOT_HEAL_BP = 104;
    [Token(Token = "0x400E24F")]
    private const int PIN_OUTPUT_NOT_REMAIN_HEAL_BP = 105;
    [Token(Token = "0x400E250")]
    private const int PIN_OUTPUT_OTHER_ERROR = 999;
    [Token(Token = "0x400E251")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400E252")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Slider HealSlider;
    [Token(Token = "0x400E253")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button DownButton;
    [Token(Token = "0x400E254")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button UpButton;
    [Token(Token = "0x400E255")]
    [FieldOffset(Offset = "0x1C")]
    private WorldRaidHealBpWindowModel mModel;

    [Token(Token = "0x600D38A")]
    [Address(RVA = "0x9E5D40", Offset = "0x9E4B40", VA = "0x109E5D40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D38B")]
    [Address(RVA = "0x9E5E40", Offset = "0x9E4C40", VA = "0x109E5E40")]
    private void Init(bool _not_enough_bp)
    {
    }

    [Token(Token = "0x600D38C")]
    [Address(RVA = "0x9E5DC0", Offset = "0x9E4BC0", VA = "0x109E5DC0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600D38D")]
    [Address(RVA = "0x9E61D0", Offset = "0x9E4FD0", VA = "0x109E61D0")]
    public void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x600D38E")]
    [Address(RVA = "0x9E61A0", Offset = "0x9E4FA0", VA = "0x109E61A0")]
    public void OnClickUpButton()
    {
    }

    [Token(Token = "0x600D38F")]
    [Address(RVA = "0x9E6170", Offset = "0x9E4F70", VA = "0x109E6170")]
    public void OnClickDownButton()
    {
    }

    [Token(Token = "0x600D390")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidHealBpWindow()
    {
    }
  }
}

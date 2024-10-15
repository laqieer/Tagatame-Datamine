// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSortWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CFA")]
  [FlowNode.Pin(101, "決定", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(102, "キャンセル", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("UI/UnitSortWindow")]
  public class UnitSortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DFA5")]
    [FieldOffset(Offset = "0xC")]
    public Toggle[] ToggleElements;
    [Token(Token = "0x400DFA6")]
    [FieldOffset(Offset = "0x10")]
    public Button BtnReset;
    [Token(Token = "0x400DFA7")]
    [FieldOffset(Offset = "0x14")]
    public Button BtnOk;
    [Token(Token = "0x400DFA8")]
    [FieldOffset(Offset = "0x18")]
    public Button BtnClose;
    [Token(Token = "0x400DFA9")]
    [FieldOffset(Offset = "0x1C")]
    private bool[] mToggleBkupValues;
    [Token(Token = "0x400DFAA")]
    [FieldOffset(Offset = "0x20")]
    private bool mPlaySE;

    [Token(Token = "0x600D15C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D15D")]
    [Address(RVA = "0x9C4360", Offset = "0x9C3160", VA = "0x109C4360")]
    private void Start()
    {
    }

    [Token(Token = "0x600D15E")]
    [Address(RVA = "0x9C41F0", Offset = "0x9C2FF0", VA = "0x109C41F0")]
    private void SelectToggleElement(int index)
    {
    }

    [Token(Token = "0x600D15F")]
    [Address(RVA = "0x9C4110", Offset = "0x9C2F10", VA = "0x109C4110")]
    private void OnReset()
    {
    }

    [Token(Token = "0x600D160")]
    [Address(RVA = "0x7B97F0", Offset = "0x7B85F0", VA = "0x107B97F0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x600D161")]
    [Address(RVA = "0x9C4070", Offset = "0x9C2E70", VA = "0x109C4070")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600D162")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitSortWindow()
    {
    }
  }
}

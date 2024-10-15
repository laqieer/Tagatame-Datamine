// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDedicatedWindow
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
  [Token(Token = "0x200296F")]
  [FlowNode.Pin(11, "Refresh", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "In Confirm", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(13, "In Confirm Reset", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(21, "Out Confirm Reset", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(14, "In Wait Effect Dedicated", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(22, "Out Wait Effect Dedicated", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(15, "In Wait Effect Reset Dedicated", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(23, "Out Wait Effect Reset Dedicated", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(30, "Out Init Dedicated", FlowNode.PinTypes.Output, 30)]
  [FlowNode.Pin(31, "Out Init Reset Dedicated", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(50, "Out Refresh", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(10, "Selected Unit", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "Out Confirm", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(1, "Initalize", FlowNode.PinTypes.Input, 1)]
  public class RuneDedicatedWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C7A4")]
    protected const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C7A5")]
    protected const int PIN_IN_SELECTED_UNIT = 10;
    [Token(Token = "0x400C7A6")]
    protected const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400C7A7")]
    protected const int PIN_IN_CONFIRM = 12;
    [Token(Token = "0x400C7A8")]
    protected const int PIN_IN_CONFIRM_RESET = 13;
    [Token(Token = "0x400C7A9")]
    protected const int PIN_IN_WAIT_EFFECT_DEDICATED = 14;
    [Token(Token = "0x400C7AA")]
    protected const int PIN_IN_WAIT_EFFECT_RESET_DEDICATED = 15;
    [Token(Token = "0x400C7AB")]
    protected const int PIN_OUT_CONFIRM = 20;
    [Token(Token = "0x400C7AC")]
    protected const int PIN_OUT_CONFIRM_RESET = 21;
    [Token(Token = "0x400C7AD")]
    protected const int PIN_OUT_WAIT_EFFECT_DEDICATED = 22;
    [Token(Token = "0x400C7AE")]
    protected const int PIN_OUT_WAIT_EFFECT_RESET_DEDICATED = 23;
    [Token(Token = "0x400C7AF")]
    protected const int PIN_OUT_INIT_DEDICATED = 30;
    [Token(Token = "0x400C7B0")]
    protected const int PIN_OUT_INIT_RESET_DEDICATED = 31;
    [Token(Token = "0x400C7B1")]
    protected const int PIN_OUT_REFRESH = 50;
    [Token(Token = "0x400C7B2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList[] _ExhibitList;
    [Token(Token = "0x400C7B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList[] _CostItemExhibitsList;
    [Token(Token = "0x400C7B4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour svb;
    [Token(Token = "0x400C7B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Color DefaultColor;
    [Token(Token = "0x400C7B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Color DedicatedColor;
    [Token(Token = "0x400C7B7")]
    [FieldOffset(Offset = "0x38")]
    private RuneDedicatedModel _runeDedicatedModel;
    [Token(Token = "0x400C7B8")]
    [FieldOffset(Offset = "0x3C")]
    private RuneData _currentRuneData;
    [Token(Token = "0x400C7B9")]
    [FieldOffset(Offset = "0x40")]
    private List<RuneDedicatedCostModel> costModels;
    [Token(Token = "0x400C7BA")]
    [FieldOffset(Offset = "0x0")]
    public static long SelectedRuneUid;
    [Token(Token = "0x400C7BB")]
    [FieldOffset(Offset = "0x8")]
    public static long LastSelectedUnit;

    [Token(Token = "0x600BB78")]
    [Address(RVA = "0x833710", Offset = "0x832510", VA = "0x10833710", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BB79")]
    [Address(RVA = "0x833CA0", Offset = "0x832AA0", VA = "0x10833CA0")]
    public void Initalize(UnitData unitData)
    {
    }

    [Token(Token = "0x600BB7A")]
    [Address(RVA = "0x833F50", Offset = "0x832D50", VA = "0x10833F50")]
    public void Initalize(RuneData runeData, UnitData unitData)
    {
    }

    [Token(Token = "0x600BB7B")]
    [Address(RVA = "0x834530", Offset = "0x833330", VA = "0x10834530")]
    private void UpdateUnitData()
    {
    }

    [Token(Token = "0x600BB7C")]
    [Address(RVA = "0x8343C0", Offset = "0x8331C0", VA = "0x108343C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BB7D")]
    [Address(RVA = "0x833A70", Offset = "0x832870", VA = "0x10833A70")]
    private void Confirm()
    {
    }

    [Token(Token = "0x600BB7E")]
    [Address(RVA = "0x8339A0", Offset = "0x8327A0", VA = "0x108339A0")]
    private void ConfirmReset()
    {
    }

    [Token(Token = "0x600BB7F")]
    [Address(RVA = "0x833B90", Offset = "0x832990", VA = "0x10833B90")]
    private void Draw()
    {
    }

    [Token(Token = "0x600BB80")]
    [Address(RVA = "0x834420", Offset = "0x833220", VA = "0x10834420")]
    private void UpdateSelectData(long unit_id, long rune_id)
    {
    }

    [Token(Token = "0x600BB81")]
    [Address(RVA = "0x834370", Offset = "0x833170", VA = "0x10834370")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BB82")]
    [Address(RVA = "0x834810", Offset = "0x833610", VA = "0x10834810")]
    public RuneDedicatedWindow()
    {
    }

    [Token(Token = "0x600BB83")]
    [Address(RVA = "0x8347C0", Offset = "0x8335C0", VA = "0x108347C0")]
    static RuneDedicatedWindow()
    {
    }
  }
}

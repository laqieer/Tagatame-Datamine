// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceUnitConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200294B")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "決定クリック", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "共鳴通信開始", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Resonance/ResonanceUnitConfirmWindow")]
  public class ResonanceUnitConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C6F3")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C6F4")]
    private const int PIN_IN_OK = 2;
    [Token(Token = "0x400C6F5")]
    private const int PIN_OUT_REQRESONANCE = 100;
    [Token(Token = "0x400C6F6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<ExhibitList> confirmExhibitList;
    [Token(Token = "0x400C6F7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ExhibitList> baseUnitExhibitList;
    [Token(Token = "0x400C6F8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<ExhibitList> resonanceUnitExhibitList;
    [Token(Token = "0x400C6F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject itemTemplate;
    [Token(Token = "0x400C6FA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400C6FB")]
    [FieldOffset(Offset = "0x20")]
    private UnitData unitData;
    [Token(Token = "0x400C6FC")]
    [FieldOffset(Offset = "0x24")]
    private UnitData resonanceUnitData;

    [Token(Token = "0x600BAC4")]
    [Address(RVA = "0x823280", Offset = "0x822080", VA = "0x10823280", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAC5")]
    [Address(RVA = "0x823680", Offset = "0x822480", VA = "0x10823680")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BAC6")]
    [Address(RVA = "0x823690", Offset = "0x822490", VA = "0x10823690")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BAC7")]
    [Address(RVA = "0x8233A0", Offset = "0x8221A0", VA = "0x108233A0")]
    private void CreateMaterialItem()
    {
    }

    [Token(Token = "0x600BAC8")]
    [Address(RVA = "0x823C90", Offset = "0x822A90", VA = "0x10823C90")]
    private void onOKClick()
    {
    }

    [Token(Token = "0x600BAC9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ResonanceUnitConfirmWindow()
    {
    }
  }
}

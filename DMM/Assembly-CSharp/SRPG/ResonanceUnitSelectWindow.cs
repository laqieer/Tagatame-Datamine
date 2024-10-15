// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceUnitSelectWindow
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
  [Token(Token = "0x200294C")]
  [AddComponentMenu("UI/Resonance/ResonanceUnitSelectWindow")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "共鳴ボタンクリック", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "共鳴確認window生成", FlowNode.PinTypes.Output, 100)]
  public class ResonanceUnitSelectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C6FD")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C6FE")]
    private const int PIN_IN_CLICK_RESONANCE = 2;
    [Token(Token = "0x400C6FF")]
    private const int PIN_OUT_RESONANCE_UNITCONFIRM = 100;
    [Token(Token = "0x400C700")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit contentExhibit;
    [Token(Token = "0x400C701")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400C702")]
    [FieldOffset(Offset = "0x14")]
    private UnitData unitData;
    [Token(Token = "0x400C703")]
    [FieldOffset(Offset = "0x18")]
    private List<ResonanceUnitSelectWindowModel> resonanceUnitSelectWindowModel;

    [Token(Token = "0x600BACA")]
    [Address(RVA = "0x823D90", Offset = "0x822B90", VA = "0x10823D90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BACB")]
    [Address(RVA = "0x824010", Offset = "0x822E10", VA = "0x10824010")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BACC")]
    [Address(RVA = "0x824540", Offset = "0x823340", VA = "0x10824540")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BACD")]
    [Address(RVA = "0x824120", Offset = "0x822F20", VA = "0x10824120")]
    private void OnClickResonance()
    {
    }

    [Token(Token = "0x600BACE")]
    [Address(RVA = "0x824290", Offset = "0x823090", VA = "0x10824290")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x600BACF")]
    [Address(RVA = "0x824640", Offset = "0x823440", VA = "0x10824640")]
    public ResonanceUnitSelectWindow()
    {
    }
  }
}

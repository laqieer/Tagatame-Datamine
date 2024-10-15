// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialSlotComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A3F")]
  [FlowNode.Pin(200, "アニメーション終了", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(1, "アニメーション再生", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "アニメーション強制終了", FlowNode.PinTypes.Input, 2)]
  public class RunePridePotentialSlotComponent : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CD5E")]
    private const int PIN_INPUT_ANIM_START = 1;
    [Token(Token = "0x400CD5F")]
    private const int PIN_INPUT_ANIM_FORCE_END = 2;
    [Token(Token = "0x400CD60")]
    private const int PIN_OUTPUT_ANIM_END = 200;
    [Token(Token = "0x400CD61")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList exhibitList;
    [Token(Token = "0x400CD62")]
    [FieldOffset(Offset = "0x10")]
    private int slotNum;
    [Token(Token = "0x400CD63")]
    [FieldOffset(Offset = "0x14")]
    private string iname;
    [Token(Token = "0x400CD64")]
    [FieldOffset(Offset = "0x18")]
    private Action<int, RunePridePotentialBonusWindow.SlotStatus, bool> callbackSelect;
    [Token(Token = "0x400CD65")]
    [FieldOffset(Offset = "0x1C")]
    private Action<string> callbackLotteryDetail;
    [Token(Token = "0x400CD66")]
    [FieldOffset(Offset = "0x20")]
    private RunePridePotentialBonusParameterModel model;
    [Token(Token = "0x400CD67")]
    [FieldOffset(Offset = "0x24")]
    private RunePridePotentialBonusWindow.SlotStatus slotStatus;
    [Token(Token = "0x400CD68")]
    [FieldOffset(Offset = "0x28")]
    private UnitData currentUnit;
    [Token(Token = "0x400CD69")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Image evoStatusGauge;
    [Token(Token = "0x400CD6A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject animSoundEffect;
    [Token(Token = "0x400CD6B")]
    [FieldOffset(Offset = "0x34")]
    [Space(10f)]
    [SerializeField]
    private float animTime;
    [Token(Token = "0x400CD6C")]
    [FieldOffset(Offset = "0x38")]
    private float percentage;
    [Token(Token = "0x400CD6D")]
    [FieldOffset(Offset = "0x3C")]
    private float startPercentage;
    [Token(Token = "0x400CD6E")]
    [FieldOffset(Offset = "0x40")]
    private bool isAnim;
    [Token(Token = "0x400CD6F")]
    [FieldOffset(Offset = "0x41")]
    private bool forceEnd;

    [Token(Token = "0x600C09B")]
    [Address(RVA = "0x891980", Offset = "0x890780", VA = "0x10891980", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C09C")]
    [Address(RVA = "0x891A60", Offset = "0x890860", VA = "0x10891A60")]
    public void Initialize(
      UnitData _unitData,
      int _slotNum,
      string _bonusIname,
      string _iname,
      RunePridePotentialBonusWindow.SlotStatus _state,
      bool isSelected,
      Action<int, RunePridePotentialBonusWindow.SlotStatus, bool> _callbackSelect,
      Action<string> _callbackLotteryDetail)
    {
    }

    [Token(Token = "0x600C09D")]
    [Address(RVA = "0x892120", Offset = "0x890F20", VA = "0x10892120")]
    private void Render()
    {
    }

    [Token(Token = "0x600C09E")]
    [Address(RVA = "0x892010", Offset = "0x890E10", VA = "0x10892010")]
    public void OnClickLotteryDetail()
    {
    }

    [Token(Token = "0x600C09F")]
    [Address(RVA = "0x892060", Offset = "0x890E60", VA = "0x10892060")]
    public void OnSelect()
    {
    }

    [Token(Token = "0x600C0A0")]
    [Address(RVA = "0x892030", Offset = "0x890E30", VA = "0x10892030")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x600C0A1")]
    [Address(RVA = "0x8920C0", Offset = "0x890EC0", VA = "0x108920C0")]
    private float PowerPercentage(
      int val,
      RunePridePotentialStatusLotteryData lottery,
      ParamTypes types)
    {
      return new float();
    }

    [Token(Token = "0x600C0A2")]
    [Address(RVA = "0x8921A0", Offset = "0x890FA0", VA = "0x108921A0")]
    public void StartGaugeAnim()
    {
    }

    [Token(Token = "0x600C0A3")]
    [Address(RVA = "0x8919F0", Offset = "0x8907F0", VA = "0x108919F0")]
    private IEnumerator GaugeAnim() => (IEnumerator) null;

    [Token(Token = "0x600C0A4")]
    [Address(RVA = "0x892220", Offset = "0x891020", VA = "0x10892220")]
    public RunePridePotentialSlotComponent()
    {
    }
  }
}

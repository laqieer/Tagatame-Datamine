// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusUnitListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022E4")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "水晶選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "絞り込み実行", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "選択初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "フィルター実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "データエラー", FlowNode.PinTypes.Output, 201)]
  public class CrystalSetBonusUnitListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B69")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009B6A")]
    private const int PIN_INPUT_SELECT_CRYSTAL = 2;
    [Token(Token = "0x4009B6B")]
    private const int PIN_INPUT_EXECUTE_FILTER = 3;
    [Token(Token = "0x4009B6C")]
    private const int PIN_INPUT_SELECT_CLEAR = 10;
    [Token(Token = "0x4009B6D")]
    private const int PIN_OUTPUT_FILTER_SET = 101;
    [Token(Token = "0x4009B6E")]
    private const int PIN_OUTPUT_ERROR = 201;
    [Token(Token = "0x4009B6F")]
    public const string KEY_CRYSTAL_ICON = "KEY_CRYSTAL_ICON";
    [Token(Token = "0x4009B70")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x4009B71")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleHaveOnly;
    [Token(Token = "0x4009B72")]
    [FieldOffset(Offset = "0x14")]
    private List<CrystalParam> mCrystalParamsList;
    [Token(Token = "0x4009B73")]
    [FieldOffset(Offset = "0x18")]
    private List<CrystalSetBonusUnitListWindowModel> mModels;
    [Token(Token = "0x4009B74")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsHaveOnly;
    [Token(Token = "0x4009B75")]
    [FieldOffset(Offset = "0x20")]
    private List<string> SelectCrystalIname;

    [Token(Token = "0x60095E1")]
    [Address(RVA = "0x58A9D0", Offset = "0x5897D0", VA = "0x1058A9D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60095E2")]
    [Address(RVA = "0x58AE70", Offset = "0x589C70", VA = "0x1058AE70")]
    private void Init()
    {
    }

    [Token(Token = "0x60095E3")]
    [Address(RVA = "0x58B100", Offset = "0x589F00", VA = "0x1058B100")]
    private void Refresh(ContentExhibit.EKey key = ContentExhibit.EKey.ResetScrollPos)
    {
    }

    [Token(Token = "0x60095E4")]
    [Address(RVA = "0x58B0D0", Offset = "0x589ED0", VA = "0x1058B0D0")]
    private void OnChageValueHaveOnly(bool isOn)
    {
    }

    [Token(Token = "0x60095E5")]
    [Address(RVA = "0x58B4C0", Offset = "0x58A2C0", VA = "0x1058B4C0")]
    private void SelectClear()
    {
    }

    [Token(Token = "0x60095E6")]
    [Address(RVA = "0x58AD10", Offset = "0x589B10", VA = "0x1058AD10")]
    private void ExecuteFilter()
    {
    }

    [Token(Token = "0x60095E7")]
    [Address(RVA = "0x58B530", Offset = "0x58A330", VA = "0x1058B530")]
    public void SelectCrystal()
    {
    }

    [Token(Token = "0x60095E8")]
    [Address(RVA = "0x58B680", Offset = "0x58A480", VA = "0x1058B680")]
    public CrystalSetBonusUnitListWindow()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDisassemblySettingDetailView
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
  [Token(Token = "0x2002972")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(11, "マイナスボタン", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(12, "プラスボタン", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(14, "刻印種類クリック", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(21, "一括CLEAR", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(13, "Statusチェックボックスクリック", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(23, "一括選択", FlowNode.PinTypes.Input, 23)]
  [FlowNode.Pin(24, "タブ選択", FlowNode.PinTypes.Input, 24)]
  [FlowNode.Pin(25, "キャンセルボタン", FlowNode.PinTypes.Input, 25)]
  [FlowNode.Pin(101, "保存API発行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "キャンセル", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(22, "OKボタン", FlowNode.PinTypes.Input, 22)]
  public class RuneDisassemblySettingDetailView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C7C9")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C7CA")]
    private const int PIN_IN_BUTTON_MINUS = 11;
    [Token(Token = "0x400C7CB")]
    private const int PIN_IN_BUTTON_PLUS = 12;
    [Token(Token = "0x400C7CC")]
    private const int PIN_IN_CLICK_CHECKBOX = 13;
    [Token(Token = "0x400C7CD")]
    private const int PIN_IN_CLICK_SETEFF = 14;
    [Token(Token = "0x400C7CE")]
    private const int PIN_IN_BUTTON_CLEAR = 21;
    [Token(Token = "0x400C7CF")]
    private const int PIN_IN_BUTTON_OK = 22;
    [Token(Token = "0x400C7D0")]
    private const int PIN_IN_BUTTON_ALLSELECT = 23;
    [Token(Token = "0x400C7D1")]
    private const int PIN_IN_TAB_SELECT = 24;
    [Token(Token = "0x400C7D2")]
    private const int PIN_IN_BUTTON_CANCEL = 25;
    [Token(Token = "0x400C7D3")]
    private const int PIN_OUTPUT_API = 101;
    [Token(Token = "0x400C7D4")]
    private const int PIN_OUTPUT_CANCEL = 201;
    [Token(Token = "0x400C7D5")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400C7D6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼SerializeValueBehaviour")]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400C7D7")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼タブ")]
    [SerializeField]
    private GameObject templateTab;
    [Token(Token = "0x400C7D8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform parentTab;
    [Token(Token = "0x400C7D9")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼刻印ステータス")]
    [SerializeField]
    private GameObject templateStatus;
    [Token(Token = "0x400C7DA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform parentStatus;
    [Token(Token = "0x400C7DB")]
    [FieldOffset(Offset = "0x20")]
    [HeaderBar("▼刻印種類")]
    [SerializeField]
    private GameObject templateEff;
    [Token(Token = "0x400C7DC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform parentEff;
    [Token(Token = "0x400C7DD")]
    [FieldOffset(Offset = "0x28")]
    private List<RuneDisassemblySettingDetailModel> _tabModels;
    [Token(Token = "0x400C7DE")]
    [FieldOffset(Offset = "0x2C")]
    private List<ExhibitList> _tabExhibitList;
    [Token(Token = "0x400C7DF")]
    [FieldOffset(Offset = "0x30")]
    private List<RuneDisassemblySettingDetailModel> _statusModels;
    [Token(Token = "0x400C7E0")]
    [FieldOffset(Offset = "0x34")]
    private List<ExhibitList> _statusExhibitList;
    [Token(Token = "0x400C7E1")]
    [FieldOffset(Offset = "0x38")]
    private List<RuneDisassemblySettingDetailModel> _effModels;
    [Token(Token = "0x400C7E2")]
    [FieldOffset(Offset = "0x3C")]
    private List<ExhibitList> _effExhibitList;
    [Token(Token = "0x400C7E3")]
    [FieldOffset(Offset = "0x40")]
    private AutoRuneDisassemblyParam selectParamData;
    [Token(Token = "0x400C7E4")]
    [FieldOffset(Offset = "0x44")]
    private RuneDisassemblySettingDetailModel selectTabModel;
    [Token(Token = "0x400C7E5")]
    [FieldOffset(Offset = "0x48")]
    private bool isChangeData;

    [Token(Token = "0x600BB8E")]
    [Address(RVA = "0x8353D0", Offset = "0x8341D0", VA = "0x108353D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BB8F")]
    [Address(RVA = "0x837C70", Offset = "0x836A70", VA = "0x10837C70")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB90")]
    [Address(RVA = "0x836200", Offset = "0x835000", VA = "0x10836200")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BB91")]
    [Address(RVA = "0x8374C0", Offset = "0x8362C0", VA = "0x108374C0")]
    private void ResetAll()
    {
    }

    [Token(Token = "0x600BB92")]
    [Address(RVA = "0x836BE0", Offset = "0x8359E0", VA = "0x10836BE0")]
    private void OnMinusButton()
    {
    }

    [Token(Token = "0x600BB93")]
    [Address(RVA = "0x836D10", Offset = "0x835B10", VA = "0x10836D10")]
    private void OnPlusButton()
    {
    }

    [Token(Token = "0x600BB94")]
    [Address(RVA = "0x836990", Offset = "0x835790", VA = "0x10836990")]
    private void OnClickCheckBox()
    {
    }

    [Token(Token = "0x600BB95")]
    [Address(RVA = "0x836AD0", Offset = "0x8358D0", VA = "0x10836AD0")]
    private void OnClickSetEff()
    {
    }

    [Token(Token = "0x600BB96")]
    [Address(RVA = "0x836950", Offset = "0x835750", VA = "0x10836950")]
    private void OnClearButton()
    {
    }

    [Token(Token = "0x600BB97")]
    [Address(RVA = "0x836840", Offset = "0x835640", VA = "0x10836840")]
    private void OnAllSelect()
    {
    }

    [Token(Token = "0x600BB98")]
    [Address(RVA = "0x836E20", Offset = "0x835C20", VA = "0x10836E20")]
    private void OnTabSelect()
    {
    }

    [Token(Token = "0x600BB99")]
    [Address(RVA = "0x836CF0", Offset = "0x835AF0", VA = "0x10836CF0")]
    private void OnOKButton()
    {
    }

    [Token(Token = "0x600BB9A")]
    [Address(RVA = "0x836880", Offset = "0x835680", VA = "0x10836880")]
    private void OnCancelButton()
    {
    }

    [Token(Token = "0x600BB9B")]
    [Address(RVA = "0x8375F0", Offset = "0x8363F0", VA = "0x108375F0")]
    private void SaveOptionData()
    {
    }

    [Token(Token = "0x600BB9C")]
    [Address(RVA = "0x835C60", Offset = "0x834A60", VA = "0x10835C60")]
    private void CreateSettingDetail()
    {
    }

    [Token(Token = "0x600BB9D")]
    [Address(RVA = "0x8373C0", Offset = "0x8361C0", VA = "0x108373C0")]
    private void RefreshTab()
    {
    }

    [Token(Token = "0x600BB9E")]
    [Address(RVA = "0x8372C0", Offset = "0x8360C0", VA = "0x108372C0")]
    private void RefreshStatus()
    {
    }

    [Token(Token = "0x600BB9F")]
    [Address(RVA = "0x8371C0", Offset = "0x835FC0", VA = "0x108371C0")]
    private void RefreshEff()
    {
    }

    [Token(Token = "0x600BBA0")]
    [Address(RVA = "0x835980", Offset = "0x834780", VA = "0x10835980")]
    private void AllSelectChange(bool isValue)
    {
    }

    [Token(Token = "0x600BBA1")]
    [Address(RVA = "0x836690", Offset = "0x835490", VA = "0x10836690")]
    private bool IsSetData() => new bool();

    [Token(Token = "0x600BBA2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDisassemblySettingDetailView()
    {
    }
  }
}

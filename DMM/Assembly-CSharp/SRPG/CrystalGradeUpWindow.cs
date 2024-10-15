// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalGradeUpWindow
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
  [Token(Token = "0x20022C6")]
  [FlowNode.Pin(1001, "強制的に閉じる", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "実行ボタンon", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(120, "確認の上で強化実行", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(101, "強化開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(121, "本当に強化するか", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(111, "Setup失敗", FlowNode.PinTypes.Output, 111)]
  public class CrystalGradeUpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009AD5")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009AD6")]
    private const int PIN_INPUT_OK = 100;
    [Token(Token = "0x4009AD7")]
    private const int PIN_INPUT_OK_AFTER_CONFIRM = 120;
    [Token(Token = "0x4009AD8")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x4009AD9")]
    private const int PIN_OUTPUT_EXECUTE = 101;
    [Token(Token = "0x4009ADA")]
    private const int PIN_OUTPUT_FAILED_SETUP = 111;
    [Token(Token = "0x4009ADB")]
    private const int PIN_OUTPUT_SHOW_CONFIRM = 121;
    [Token(Token = "0x4009ADC")]
    private const int PIN_OUTPUT_FORCE_CLOSE = 1001;
    [Token(Token = "0x4009ADD")]
    private const string SVB_SELECT_ICON_OBJ = "crystal_icon";
    [Token(Token = "0x4009ADE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList GradeUpWindowExhibitList;
    [Token(Token = "0x4009ADF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalScrollList GradeUpScrollList;
    [Token(Token = "0x4009AE0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button GradeUpOk;
    [Token(Token = "0x4009AE1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour SelectItemTemplate;
    [Token(Token = "0x4009AE2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform SelectFrameRoot;
    [Token(Token = "0x4009AE3")]
    [FieldOffset(Offset = "0x20")]
    private CrystalGradeUpWindowModel mGradeUpWindowModel;
    [Token(Token = "0x4009AE4")]
    [FieldOffset(Offset = "0x24")]
    private CrystalData mData;
    [Token(Token = "0x4009AE5")]
    [FieldOffset(Offset = "0x28")]
    private List<CrystalData> mSelectDatas;
    [Token(Token = "0x4009AE6")]
    [FieldOffset(Offset = "0x2C")]
    private CrystalData mSelectDataCache;
    [Token(Token = "0x4009AE7")]
    [FieldOffset(Offset = "0x30")]
    private int mSelectMax;
    [Token(Token = "0x4009AE8")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> mItems;
    [Token(Token = "0x4009AE9")]
    [FieldOffset(Offset = "0x38")]
    private List<CrystalIcon> mIconList;

    [Token(Token = "0x600954E")]
    [Address(RVA = "0x583750", Offset = "0x582550", VA = "0x10583750")]
    private void Start()
    {
    }

    [Token(Token = "0x600954F")]
    [Address(RVA = "0x5820F0", Offset = "0x580EF0", VA = "0x105820F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009550")]
    [Address(RVA = "0x5834D0", Offset = "0x5822D0", VA = "0x105834D0")]
    public void SetUp(CrystalData _data)
    {
    }

    [Token(Token = "0x6009551")]
    [Address(RVA = "0x582260", Offset = "0x581060", VA = "0x10582260")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009552")]
    [Address(RVA = "0x5825A0", Offset = "0x5813A0", VA = "0x105825A0")]
    private void MakeScrollList(int select_num = 1)
    {
    }

    [Token(Token = "0x6009553")]
    [Address(RVA = "0x583290", Offset = "0x582090", VA = "0x10583290")]
    private void SetUpDisplayMaterialIcon(int select_num = 1)
    {
    }

    [Token(Token = "0x6009554")]
    [Address(RVA = "0x582EF0", Offset = "0x581CF0", VA = "0x10582EF0")]
    private void SetSelectList()
    {
    }

    [Token(Token = "0x6009555")]
    [Address(RVA = "0x5823E0", Offset = "0x5811E0", VA = "0x105823E0")]
    private void ItemSelect()
    {
    }

    [Token(Token = "0x6009556")]
    [Address(RVA = "0x582C70", Offset = "0x581A70", VA = "0x10582C70")]
    private void ResetDispIcon(List<CrystalData> datas, int select_max = 1)
    {
    }

    [Token(Token = "0x6009557")]
    [Address(RVA = "0x582DC0", Offset = "0x581BC0", VA = "0x10582DC0")]
    private void SendRequest()
    {
    }

    [Token(Token = "0x6009558")]
    [Address(RVA = "0x582AA0", Offset = "0x5818A0", VA = "0x10582AA0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009559")]
    [Address(RVA = "0x5827F0", Offset = "0x5815F0", VA = "0x105827F0")]
    private void OnSelectOk(bool is_matching_check = true)
    {
    }

    [Token(Token = "0x600955A")]
    [Address(RVA = "0x5822E0", Offset = "0x5810E0", VA = "0x105822E0")]
    private bool IsContainEquipedCrystal() => new bool();

    [Token(Token = "0x600955B")]
    [Address(RVA = "0x5838F0", Offset = "0x5826F0", VA = "0x105838F0")]
    public CrystalGradeUpWindow()
    {
    }
  }
}

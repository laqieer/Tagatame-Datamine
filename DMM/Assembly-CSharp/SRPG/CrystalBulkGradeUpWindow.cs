// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalBulkGradeUpWindow
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
  [Token(Token = "0x20022BD")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "実行ボタンon", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(200, "確認の上で強化実行", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(300, "詳細表示開始", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(401, "強化開始", FlowNode.PinTypes.Output, 401)]
  [FlowNode.Pin(501, "本当に強化するか", FlowNode.PinTypes.Output, 501)]
  [FlowNode.Pin(601, "詳細ウィンドウボタン", FlowNode.PinTypes.Output, 601)]
  [FlowNode.Pin(701, "詳細表示", FlowNode.PinTypes.Output, 701)]
  [FlowNode.Pin(1001, "例外エラー", FlowNode.PinTypes.Output, 1001)]
  public class CrystalBulkGradeUpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009ABA")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009ABB")]
    private const int PIN_INPUT_OK = 100;
    [Token(Token = "0x4009ABC")]
    private const int PIN_INPUT_OK_AFTER_CONFIRM = 200;
    [Token(Token = "0x4009ABD")]
    private const int PIN_INPUT_SHOW_DETAIL = 300;
    [Token(Token = "0x4009ABE")]
    private const int PIN_OUTPUT_EXECUTE = 401;
    [Token(Token = "0x4009ABF")]
    private const int PIN_OUTPUT_SHOW_CONFIRM = 501;
    [Token(Token = "0x4009AC0")]
    private const int PIN_OUTPUT_OPEN_DETAIL = 601;
    [Token(Token = "0x4009AC1")]
    private const int PIN_OUTPUT_SHOW_DETAIL = 701;
    [Token(Token = "0x4009AC2")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x4009AC3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit BulkWindowContentExhibit;
    [Token(Token = "0x4009AC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SRPG_Button OkButton;
    [Token(Token = "0x4009AC5")]
    [FieldOffset(Offset = "0x14")]
    private List<CrystalBulkGradeUpWindowModel> mGradeUpWindowModels;
    [Token(Token = "0x4009AC6")]
    [FieldOffset(Offset = "0x18")]
    private List<CrystalData> mDetailDatas;

    [Token(Token = "0x600952A")]
    [Address(RVA = "0x57B170", Offset = "0x579F70", VA = "0x1057B170", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600952B")]
    [Address(RVA = "0x57C4C0", Offset = "0x57B2C0", VA = "0x1057C4C0")]
    public void SetUp()
    {
    }

    [Token(Token = "0x600952C")]
    [Address(RVA = "0x57B250", Offset = "0x57A050", VA = "0x1057B250")]
    private void Draw()
    {
    }

    [Token(Token = "0x600952D")]
    [Address(RVA = "0x57C230", Offset = "0x57B030", VA = "0x1057C230")]
    private void SetToggleOnAttach(ContentNode node, CrystalBulkGradeUpWindowModel model)
    {
    }

    [Token(Token = "0x600952E")]
    [Address(RVA = "0x57BE50", Offset = "0x57AC50", VA = "0x1057BE50")]
    public void OnToggleFunc(CrystalIcon icon)
    {
    }

    [Token(Token = "0x600952F")]
    [Address(RVA = "0x57B570", Offset = "0x57A370", VA = "0x1057B570")]
    private JSON_CrystalUpgrade[] MakeRequestArray() => (JSON_CrystalUpgrade[]) null;

    [Token(Token = "0x6009530")]
    [Address(RVA = "0x57C130", Offset = "0x57AF30", VA = "0x1057C130")]
    private void SendRequest()
    {
    }

    [Token(Token = "0x6009531")]
    [Address(RVA = "0x57BA70", Offset = "0x57A870", VA = "0x1057BA70")]
    public void OnClickDetailParent(CrystalIcon icon)
    {
    }

    [Token(Token = "0x6009532")]
    [Address(RVA = "0x57B810", Offset = "0x57A610", VA = "0x1057B810")]
    public void OnClickDetailChildren(CrystalIcon icon)
    {
    }

    [Token(Token = "0x6009533")]
    [Address(RVA = "0x57C0B0", Offset = "0x57AEB0", VA = "0x1057C0B0")]
    private void SendDetailDatas()
    {
    }

    [Token(Token = "0x6009534")]
    [Address(RVA = "0x57B310", Offset = "0x57A110", VA = "0x1057B310")]
    private bool IsContainEquipedCrystal() => new bool();

    [Token(Token = "0x6009535")]
    [Address(RVA = "0x57BC80", Offset = "0x57AA80", VA = "0x1057BC80")]
    private void OnSelectOk(bool is_matching_check = true)
    {
    }

    [Token(Token = "0x6009536")]
    [Address(RVA = "0x57C880", Offset = "0x57B680", VA = "0x1057C880")]
    public CrystalBulkGradeUpWindow()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_CostSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FEE")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "コスト決定", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "代価コスト決定", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(151, "通信完了", FlowNode.PinTypes.Input, 151)]
  [FlowNode.Pin(199, "確認画面へ", FlowNode.PinTypes.Output, 199)]
  [FlowNode.Pin(209, "武具詳細へ", FlowNode.PinTypes.Output, 209)]
  public class ArtiStoneEffect_CostSelect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087AE")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40087AF")]
    private const int PIN_INPUT_REFRESH_LIST = 10;
    [Token(Token = "0x40087B0")]
    private const int PIN_INPUT_COST = 100;
    [Token(Token = "0x40087B1")]
    private const int PIN_INPUT_OTHER_COST = 101;
    [Token(Token = "0x40087B2")]
    private const int PIN_INPUT_OPEN_REQ_FIN = 151;
    [Token(Token = "0x40087B3")]
    private const int PIN_OUTPUT_CHECK = 199;
    [Token(Token = "0x40087B4")]
    private const int PIN_OUTPUT_DETAIL = 209;
    [Token(Token = "0x40087B5")]
    public const string SVB_KEY_ARTIFACT_STONE_SELECT = "SVB_KEY_ARTIFACT_STONE_SELECT";
    [Token(Token = "0x40087B6")]
    public const string SVB_KEY_ARTIFACT_STONE_TARGET_ID = "SVB_KEY_ARTIFACT_STONE_TARGET_ID";
    [Token(Token = "0x40087B7")]
    public const string SVB_KEY_ARTIFACT_STONE_COST_DATA_LIST = "SVB_KEY_ARTIFACT_STONE_COST_DATA_LIST";
    [Token(Token = "0x40087B8")]
    public const string SVB_KEY_ARTIFACT_STONE_COST_ID_LIST = "SVB_KEY_ARTIFACT_STONE_COST_ID_LIST";
    [Token(Token = "0x40087B9")]
    public const string SVB_KEY_ARTIFACT_STONE_IS_OTHER_COST = "SVB_KEY_ARTIFACT_STONE_IS_OTHER_COST";
    [Token(Token = "0x40087BA")]
    public const string SVB_KEY_ARTIFACT_STONE_NEW_STATUS_INAME = "SVB_KEY_ARTIFACT_STONE_NEW_STATUS_INAME";
    [Token(Token = "0x40087BB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x40087BC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibiList;
    [Token(Token = "0x40087BD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ArtifactScrollList mArtifactList;
    [Token(Token = "0x40087BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Color32 mWordColor;
    [Token(Token = "0x40087BF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Color32 mWordColorMinus;
    [Token(Token = "0x40087C0")]
    [FieldOffset(Offset = "0x20")]
    private ArtiStoneEffect_CostSelectModel mModel;
    [Token(Token = "0x40087C1")]
    [FieldOffset(Offset = "0x0")]
    public static bool IsRetryFlag;

    [Token(Token = "0x60083C2")]
    [Address(RVA = "0x445DF0", Offset = "0x444BF0", VA = "0x10445DF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083C3")]
    [Address(RVA = "0x4461E0", Offset = "0x444FE0", VA = "0x104461E0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60083C4")]
    [Address(RVA = "0x446110", Offset = "0x444F10", VA = "0x10446110")]
    public void InitializeModel(ArtifactData artifact)
    {
    }

    [Token(Token = "0x60083C5")]
    [Address(RVA = "0x446080", Offset = "0x444E80", VA = "0x10446080")]
    public void InitializeList()
    {
    }

    [Token(Token = "0x60083C6")]
    [Address(RVA = "0x4466B0", Offset = "0x4454B0", VA = "0x104466B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60083C7")]
    [Address(RVA = "0x446520", Offset = "0x445320", VA = "0x10446520")]
    public void RefreshList()
    {
    }

    [Token(Token = "0x60083C8")]
    [Address(RVA = "0x445EE0", Offset = "0x444CE0", VA = "0x10445EE0")]
    private void CostSetupSVB(bool isOtherCost = false)
    {
    }

    [Token(Token = "0x60083C9")]
    [Address(RVA = "0x4463D0", Offset = "0x4451D0", VA = "0x104463D0")]
    public void OnArtifactDetail(ArtifactIconNode node)
    {
    }

    [Token(Token = "0x60083CA")]
    [Address(RVA = "0x446760", Offset = "0x445560", VA = "0x10446760")]
    public ArtiStoneEffect_CostSelect()
    {
    }
  }
}

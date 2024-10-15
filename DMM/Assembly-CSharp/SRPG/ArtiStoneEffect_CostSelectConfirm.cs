// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_CostSelectConfirm
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
  [Token(Token = "0x2001FEF")]
  [FlowNode.Pin(152, "アイテム詳細", FlowNode.PinTypes.Output, 152)]
  [FlowNode.Pin(151, "武具詳細", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(111, "開放API", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(11, "決定", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(121, "再抽選API", FlowNode.PinTypes.Output, 121)]
  public class ArtiStoneEffect_CostSelectConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087C2")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40087C3")]
    private const int PIN_INPUT_OK = 11;
    [Token(Token = "0x40087C4")]
    private const int PIN_OUTPUT_OPEN_API = 111;
    [Token(Token = "0x40087C5")]
    private const int PIN_OUTPUT_LOTTERY_API = 121;
    [Token(Token = "0x40087C6")]
    private const int PIN_OUTPUT_ARTIFACT_DETAIL = 151;
    [Token(Token = "0x40087C7")]
    private const int PIN_OUTPUT_ITEM_DETAIL = 152;
    [Token(Token = "0x40087C8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40087C9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x40087CA")]
    [FieldOffset(Offset = "0x14")]
    private ArtiStoneEffect_CostSelectConfirmModel mModel;

    [Token(Token = "0x60083CB")]
    [Address(RVA = "0x4457B0", Offset = "0x4445B0", VA = "0x104457B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083CC")]
    [Address(RVA = "0x445A50", Offset = "0x444850", VA = "0x10445A50")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60083CD")]
    [Address(RVA = "0x445990", Offset = "0x444790", VA = "0x10445990")]
    public void InitializeModel(
      ArtifactData targetArtifact,
      List<ArtifactData> costArtifactList,
      bool isCommomCost)
    {
    }

    [Token(Token = "0x60083CE")]
    [Address(RVA = "0x445D40", Offset = "0x444B40", VA = "0x10445D40")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60083CF")]
    [Address(RVA = "0x445DC0", Offset = "0x444BC0", VA = "0x10445DC0")]
    private void SelectAPI()
    {
    }

    [Token(Token = "0x60083D0")]
    [Address(RVA = "0x445890", Offset = "0x444690", VA = "0x10445890")]
    public void ArtifactDetail(ArtifactIconBlockContentNode content)
    {
    }

    [Token(Token = "0x60083D1")]
    [Address(RVA = "0x445C70", Offset = "0x444A70", VA = "0x10445C70")]
    public void ItemDetail(ArtifactIconBlockContentNode content)
    {
    }

    [Token(Token = "0x60083D2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_CostSelectConfirm()
    {
    }
  }
}

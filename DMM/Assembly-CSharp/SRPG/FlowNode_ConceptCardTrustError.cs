// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardTrustError
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A9")]
  [FlowNode.Pin(10, "警告チェック開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1006, "条件なし", FlowNode.PinTypes.Output, 1006)]
  [FlowNode.Pin(1001, "境界値または限界突破が最大の素材が含まれている", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.NodeType("UI/FlowNode_ConceptCardTrustError", 32741)]
  [FlowNode.Pin(1000, "全部条件を満たしている", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1003, "素材に最大数値のものが含まれており、ベースの最大数値を超えている", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1004, "境界値数値が0より大きく未完のものがある", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(1002, "ベースの境界値または限界突破が最大を超えている", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1005, "ダイアログ登録処理", FlowNode.PinTypes.Output, 1005)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1011, "回数確認NO", FlowNode.PinTypes.Output, 1011)]
  [FlowNode.Pin(1010, "回数確認OK", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(11, "ビジョンクリア回数チェック開始", FlowNode.PinTypes.Input, 11)]
  public class FlowNode_ConceptCardTrustError : FlowNode
  {
    [Token(Token = "0x400488E")]
    private const int INPUT_WARNINGCHECK = 10;
    [Token(Token = "0x400488F")]
    private const int INPUT_TRUSTBONUSCHECK = 11;
    [Token(Token = "0x4004890")]
    private const int OUTPUT_ALLERROR = 1000;
    [Token(Token = "0x4004891")]
    private const int OUTPUT_MAXERROE = 1001;
    [Token(Token = "0x4004892")]
    private const int OUTPUT_BASERROR = 1002;
    [Token(Token = "0x4004893")]
    private const int OUTPUT_MAXBASERROR = 1003;
    [Token(Token = "0x4004894")]
    private const int OUTPUT_TRUSTBONUSERROR = 1004;
    [Token(Token = "0x4004895")]
    private const int OUTPUT_OPENDIALOG = 1005;
    [Token(Token = "0x4004896")]
    private const int OUTPUT_SUCCESS = 1006;
    [Token(Token = "0x4004897")]
    private const int OUTPUT_TRUSTBONUSOK = 1010;
    [Token(Token = "0x4004898")]
    private const int OUTPUT_TRUSTBONUSNO = 1011;

    [Token(Token = "0x6005256")]
    [Address(RVA = "0x12701A0", Offset = "0x126EFA0", VA = "0x112701A0")]
    private void OnConfirmYes(GameObject go)
    {
    }

    [Token(Token = "0x6005257")]
    [Address(RVA = "0x1270180", Offset = "0x126EF80", VA = "0x11270180")]
    private void OnConfirmNo(GameObject go)
    {
    }

    [Token(Token = "0x6005258")]
    [Address(RVA = "0x126FBB0", Offset = "0x126E9B0", VA = "0x1126FBB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005259")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardTrustError()
    {
    }
  }
}

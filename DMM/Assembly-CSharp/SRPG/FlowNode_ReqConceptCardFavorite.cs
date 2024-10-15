// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014D3")]
  [FlowNode.Pin(1010, "お気に入り設定OFF完了", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(110, "お気に入りOFF", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(100, "お気に入りON", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardFavorite", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1000, "お気に入り設定ON完了", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_ReqConceptCardFavorite : FlowNode_Network
  {
    [Token(Token = "0x4004C61")]
    private const int INPUT_FAVORITE_ON = 100;
    [Token(Token = "0x4004C62")]
    private const int INPUT_FAVORITE_OFF = 110;
    [Token(Token = "0x4004C63")]
    private const int OUTPUT_FAVORITE_ON = 1000;
    [Token(Token = "0x4004C64")]
    private const int OUTPUT_FAVORITE_OFF = 1010;
    [Token(Token = "0x4004C65")]
    [FieldOffset(Offset = "0x20")]
    private int mOutPutPinId;

    [Token(Token = "0x60056B7")]
    [Address(RVA = "0x12C25C0", Offset = "0x12C13C0", VA = "0x112C25C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056B8")]
    [Address(RVA = "0x12C27E0", Offset = "0x12C15E0", VA = "0x112C27E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056B9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardFavorite()
    {
    }

    [Token(Token = "0x20014D4")]
    public class Json_ConceptCardFavorite
    {
      [Token(Token = "0x4004C66")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ConceptCard concept_card;

      [Token(Token = "0x60056BA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardFavorite()
      {
      }
    }
  }
}

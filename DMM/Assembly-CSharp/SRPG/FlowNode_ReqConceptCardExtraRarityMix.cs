// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardExtraRarityMix
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001329")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardExtraRarityMix", 32741)]
  public class FlowNode_ReqConceptCardExtraRarityMix : FlowNode_Network
  {
    [Token(Token = "0x400470B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400470C")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x400470D")]
    public const string KEY_REQUEASTDATA = "KEY_REQUEASTDATA";
    [Token(Token = "0x400470E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x60050C0")]
    [Address(RVA = "0x125A540", Offset = "0x1259340", VA = "0x1125A540", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x60050C1")]
    [Address(RVA = "0x125A6A0", Offset = "0x12594A0", VA = "0x1125A6A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050C2")]
    [Address(RVA = "0x125AC40", Offset = "0x1259A40", VA = "0x1125AC40")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x60050C3")]
    [Address(RVA = "0x125A850", Offset = "0x1259650", VA = "0x1125A850", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050C4")]
    [Address(RVA = "0x125A4F0", Offset = "0x12592F0", VA = "0x1125A4F0")]
    private ReqConceptCardExtraRarityMix.Response DummyResponse()
    {
      return (ReqConceptCardExtraRarityMix.Response) null;
    }

    [Token(Token = "0x60050C5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardExtraRarityMix()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGetPremiumLoginBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001513")]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "リクエストを出して取得", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "すでに取得している", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "プレミアムログインボーナス情報をリクエスト", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Login/ReqGetPremiumLoginBonus", 32741)]
  public class FlowNode_ReqGetPremiumLoginBonus : FlowNode_Network
  {
    [Token(Token = "0x4004D37")]
    private const int INPUT_GET_PREMIUM_LOGINBONUS = 1;
    [Token(Token = "0x4004D38")]
    private const int OUTPUT_AlREADY_GET_LOGINBONUS = 101;
    [Token(Token = "0x4004D39")]
    private const int OUTPUT_REQUEST_GET_LOGINBONUS = 102;
    [Token(Token = "0x4004D3A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string LoadProductID;
    [Token(Token = "0x4004D3B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool IsSelectSelectedProductID;

    [Token(Token = "0x6005772")]
    [Address(RVA = "0x12CF210", Offset = "0x12CE010", VA = "0x112CF210", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005773")]
    [Address(RVA = "0x12CF420", Offset = "0x12CE220", VA = "0x112CF420", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005774")]
    [Address(RVA = "0x12CF6B0", Offset = "0x12CE4B0", VA = "0x112CF6B0")]
    public FlowNode_ReqGetPremiumLoginBonus()
    {
    }
  }
}

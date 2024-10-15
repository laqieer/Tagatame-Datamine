// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BuyGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200136F")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(4, "購入をキャンセル", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(3, "購入回数制限", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "コインが足りない", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("System/Buy/BuyGold", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_BuyGold : FlowNode_Network
  {
    [Token(Token = "0x40047B3")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40047B4")]
    private const int PIN_OUT_SUCCESS = 1;
    [Token(Token = "0x40047B5")]
    private const int PIN_OUT_COST_SHORT = 2;
    [Token(Token = "0x40047B6")]
    private const int PIN_OUT_BUY_LIMIT = 3;
    [Token(Token = "0x40047B7")]
    private const int PIN_OUT_CANCEL = 4;
    [Token(Token = "0x40047B8")]
    [FieldOffset(Offset = "0x0")]
    public static GameObject ConfirmBoxObj;
    [Token(Token = "0x40047B9")]
    [FieldOffset(Offset = "0x20")]
    public bool Confirm;
    [Token(Token = "0x40047BA")]
    [FieldOffset(Offset = "0x21")]
    public bool ShowResult;

    [Token(Token = "0x6005182")]
    [Address(RVA = "0x1267630", Offset = "0x1266430", VA = "0x11267630", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005183")]
    [Address(RVA = "0x1267F30", Offset = "0x1266D30", VA = "0x11267F30")]
    private void OutOfCoin()
    {
    }

    [Token(Token = "0x6005184")]
    [Address(RVA = "0x1267E20", Offset = "0x1266C20", VA = "0x11267E20")]
    private void OutOfBuyCount()
    {
    }

    [Token(Token = "0x6005185")]
    [Address(RVA = "0x1267960", Offset = "0x1266760", VA = "0x11267960")]
    private void OnBuy(GameObject go)
    {
    }

    [Token(Token = "0x6005186")]
    [Address(RVA = "0x1268170", Offset = "0x1266F70", VA = "0x11268170")]
    private void SendRequest()
    {
    }

    [Token(Token = "0x6005187")]
    [Address(RVA = "0x1268350", Offset = "0x1267150", VA = "0x11268350")]
    private void Success()
    {
    }

    [Token(Token = "0x6005188")]
    [Address(RVA = "0x1267980", Offset = "0x1266780", VA = "0x11267980", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005189")]
    [Address(RVA = "0x1268410", Offset = "0x1267210", VA = "0x11268410")]
    private int getRequiredCoin() => new int();

    [Token(Token = "0x600518A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_BuyGold()
    {
    }
  }
}

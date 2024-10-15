// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCoinShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014C3")]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Shop/ReqCoinShop", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_ReqCoinShop : FlowNode_Network
  {
    [Token(Token = "0x4004C33")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqCoinShop.Mode mode;

    [Token(Token = "0x600568A")]
    [Address(RVA = "0x12C0010", Offset = "0x12BEE10", VA = "0x112C0010", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600568B")]
    [Address(RVA = "0x12C00B0", Offset = "0x12BEEB0", VA = "0x112C00B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600568C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCoinShop()
    {
    }

    [Token(Token = "0x20014C4")]
    private enum Mode
    {
      [Token(Token = "0x4004C35")] GetShopList,
      [Token(Token = "0x4004C36")] GetCoinNum,
    }

    [Token(Token = "0x20014C5")]
    private class JSON_CoinNum
    {
      [Token(Token = "0x4004C37")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] item;
      [Token(Token = "0x4004C38")]
      [FieldOffset(Offset = "0xC")]
      public FlowNode_ReqCoinShop.JSON_NewCoin newcoin;

      [Token(Token = "0x600568D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_CoinNum()
      {
      }
    }

    [Token(Token = "0x20014C6")]
    private class JSON_NewCoin
    {
      [Token(Token = "0x4004C39")]
      [FieldOffset(Offset = "0x8")]
      public long period;

      [Token(Token = "0x600568E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_NewCoin()
      {
      }
    }
  }
}

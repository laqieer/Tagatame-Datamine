// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCoinConvert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BF")]
  [FlowNode.NodeType("System/Shop/ReqCoinConvert", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "新旧コインのコンバートが実行された", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "新コインのコンバートが実行された", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "旧コインのコンバートが実行された", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(4, "コインはコンバートされなかった", FlowNode.PinTypes.Output, 4)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "次に進む", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqCoinConvert : FlowNode_Network
  {
    [Token(Token = "0x4004C23")]
    private const int CONVERTED_NEW_OLD = 1;
    [Token(Token = "0x4004C24")]
    private const int CONVERTED_NEW = 2;
    [Token(Token = "0x4004C25")]
    private const int CONVERTED_OLD = 3;
    [Token(Token = "0x4004C26")]
    private const int DO_NOTHING = 4;
    [Token(Token = "0x4004C27")]
    private const int NEXT = 10;

    [Token(Token = "0x6005684")]
    [Address(RVA = "0x12BFCC0", Offset = "0x12BEAC0", VA = "0x112BFCC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005685")]
    [Address(RVA = "0x12BFD60", Offset = "0x12BEB60", VA = "0x112BFD60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005686")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCoinConvert()
    {
    }

    [Token(Token = "0x20014C0")]
    private class JSON_ConvertedCoin
    {
      [Token(Token = "0x4004C28")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqCoinConvert.JSON_OldCoin oldcoin;
      [Token(Token = "0x4004C29")]
      [FieldOffset(Offset = "0xC")]
      public FlowNode_ReqCoinConvert.JSON_NewCoin newcoin;
      [Token(Token = "0x4004C2A")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] item;

      [Token(Token = "0x6005687")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ConvertedCoin()
      {
      }
    }

    [Token(Token = "0x20014C1")]
    private class JSON_NewCoin
    {
      [Token(Token = "0x4004C2B")]
      [FieldOffset(Offset = "0x8")]
      public int coin;
      [Token(Token = "0x4004C2C")]
      [FieldOffset(Offset = "0xC")]
      public int stone;
      [Token(Token = "0x4004C2D")]
      [FieldOffset(Offset = "0x10")]
      public int stock;
      [Token(Token = "0x4004C2E")]
      [FieldOffset(Offset = "0x14")]
      public int period;
      [Token(Token = "0x4004C2F")]
      [FieldOffset(Offset = "0x18")]
      public int convdate;

      [Token(Token = "0x6005688")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_NewCoin()
      {
      }
    }

    [Token(Token = "0x20014C2")]
    private class JSON_OldCoin
    {
      [Token(Token = "0x4004C30")]
      [FieldOffset(Offset = "0x8")]
      public int coin;
      [Token(Token = "0x4004C31")]
      [FieldOffset(Offset = "0xC")]
      public int stone;
      [Token(Token = "0x4004C32")]
      [FieldOffset(Offset = "0x10")]
      public int convdate;

      [Token(Token = "0x6005689")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_OldCoin()
      {
      }
    }
  }
}

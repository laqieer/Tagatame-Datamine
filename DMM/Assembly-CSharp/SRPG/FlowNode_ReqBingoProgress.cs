// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBingoProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200149F")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/ReqBingo/ReqBingoProgress", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqBingoProgress : FlowNode_Network
  {
    [Token(Token = "0x6005609")]
    [Address(RVA = "0x12BB760", Offset = "0x12BA560", VA = "0x112BB760", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600560A")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600560B")]
    [Address(RVA = "0x12BB870", Offset = "0x12BA670", VA = "0x112BB870", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600560C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBingoProgress()
    {
    }

    [Token(Token = "0x20014A0")]
    [MessagePackObject(true)]
    public class JSON_BingoResponse
    {
      [Token(Token = "0x4004BF3")]
      [FieldOffset(Offset = "0x8")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600560D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_BingoResponse()
      {
      }
    }

    [Token(Token = "0x20014A1")]
    [MessagePackObject(true)]
    public class MP_BingoResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BF4")]
      [FieldOffset(Offset = "0x28")]
      public FlowNode_ReqBingoProgress.JSON_BingoResponse body;

      [Token(Token = "0x600560E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_BingoResponse()
      {
      }
    }
  }
}

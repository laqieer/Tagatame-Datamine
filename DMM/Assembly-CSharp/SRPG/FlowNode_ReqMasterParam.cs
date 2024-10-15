// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200153D")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("System/Master/ReqMasterParam", 32741)]
  public class FlowNode_ReqMasterParam : FlowNode_Network
  {
    [Token(Token = "0x4004DA0")]
    [FieldOffset(Offset = "0x20")]
    private DateTime nowTime;

    [Token(Token = "0x60057DA")]
    [Address(RVA = "0x12D54F0", Offset = "0x12D42F0", VA = "0x112D54F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057DB")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60057DC")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x60057DD")]
    [Address(RVA = "0x12D5920", Offset = "0x12D4720", VA = "0x112D5920", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057DE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMasterParam()
    {
    }

    [Token(Token = "0x200153E")]
    [MessagePackObject(true)]
    public class MP_MasterParam : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004DA1")]
      [FieldOffset(Offset = "0x28")]
      public JSON_MasterParam body;

      [Token(Token = "0x60057DF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_MasterParam()
      {
      }
    }
  }
}

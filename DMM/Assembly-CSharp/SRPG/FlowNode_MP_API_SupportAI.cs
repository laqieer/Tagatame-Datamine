// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_SupportAI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001778")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/API/MultiPlaySupport", 32741)]
  [FlowNode.Pin(1, "Get List", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Set Support", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_SupportAI : FlowNode_Network
  {
    [Token(Token = "0x400545B")]
    private const int PIN_IN_GET_LIST = 1;
    [Token(Token = "0x400545C")]
    private const int PIN_IN_SET_SUPPORT = 2;
    [Token(Token = "0x400545D")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400545E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool GetSupportIsUpdate;
    [Token(Token = "0x400545F")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_MP_API_SupportAI.API SelectedAPI;

    [Token(Token = "0x6005F31")]
    [Address(RVA = "0x1337100", Offset = "0x1335F00", VA = "0x11337100", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F32")]
    [Address(RVA = "0x1337210", Offset = "0x1336010", VA = "0x11337210")]
    private IEnumerator Request_GetList() => (IEnumerator) null;

    [Token(Token = "0x6005F33")]
    [Address(RVA = "0x1337280", Offset = "0x1336080", VA = "0x11337280")]
    private IEnumerator Request_SetSupport() => (IEnumerator) null;

    [Token(Token = "0x6005F34")]
    [Address(RVA = "0x1337850", Offset = "0x1336650", VA = "0x11337850")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F35")]
    [Address(RVA = "0x13371A0", Offset = "0x1335FA0", VA = "0x113371A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F36")]
    [Address(RVA = "0x13372F0", Offset = "0x13360F0", VA = "0x113372F0")]
    private void Response_GetList(WWWResult www)
    {
    }

    [Token(Token = "0x6005F37")]
    [Address(RVA = "0x13376C0", Offset = "0x13364C0", VA = "0x113376C0")]
    private void Response_SetSuuport(WWWResult www)
    {
    }

    [Token(Token = "0x6005F38")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_SupportAI()
    {
    }

    [Token(Token = "0x2001779")]
    private enum API
    {
      [Token(Token = "0x4005461")] NONE,
      [Token(Token = "0x4005462")] GET_LIST,
      [Token(Token = "0x4005463")] SET_SUPPORT,
    }

    [Token(Token = "0x200177A")]
    [MessagePackObject(true)]
    public class MP_Response_GetList : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005464")]
      [FieldOffset(Offset = "0x28")]
      public ReqMultiSupportList.Response body;

      [Token(Token = "0x6005F39")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_GetList()
      {
      }
    }
  }
}

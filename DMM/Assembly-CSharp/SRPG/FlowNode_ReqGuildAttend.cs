// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildAttend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A8")]
  [FlowNode.Pin(101, "報酬受け取り成功", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Guild/Req/Attend", 32741)]
  [FlowNode.Pin(110, "出席不可", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(200, "加入日は出席不可", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "出席期間外", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(102, "報酬受け取り済み", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildAttend : FlowNode_Network
  {
    [Token(Token = "0x4005247")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005248")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005249")]
    private const int PIN_OUT_SUCCESSED = 102;
    [Token(Token = "0x400524A")]
    private const int PIN_OUT_CAN_NOT_ATTENDED = 110;
    [Token(Token = "0x400524B")]
    private const int PIN_OUT_NOT_ATTEND_JOIN_DAY = 200;
    [Token(Token = "0x400524C")]
    private const int PIN_OUT_OUT_OF_ATTEND_PERIOD = 201;
    [Token(Token = "0x400524D")]
    [FieldOffset(Offset = "0x0")]
    private static ReqGuildAttend.Response mKeepResponse;

    [Token(Token = "0x6005CCF")]
    [Address(RVA = "0x130B0E0", Offset = "0x1309EE0", VA = "0x1130B0E0")]
    public static ReqGuildAttend.Response GetResponse() => (ReqGuildAttend.Response) null;

    [Token(Token = "0x6005CD0")]
    [Address(RVA = "0x130AFF0", Offset = "0x1309DF0", VA = "0x1130AFF0")]
    public static void Clear()
    {
    }

    [Token(Token = "0x6005CD1")]
    [Address(RVA = "0x130B110", Offset = "0x1309F10", VA = "0x1130B110", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CD2")]
    [Address(RVA = "0x130AFF0", Offset = "0x1309DF0", VA = "0x1130AFF0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005CD3")]
    [Address(RVA = "0x130B030", Offset = "0x1309E30", VA = "0x1130B030")]
    public ReqGuildAttend.RequestParam CreateRequest() => (ReqGuildAttend.RequestParam) null;

    [Token(Token = "0x6005CD4")]
    [Address(RVA = "0x130B930", Offset = "0x130A730", VA = "0x1130B930")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CD5")]
    [Address(RVA = "0x130B380", Offset = "0x130A180", VA = "0x1130B380", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CD6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildAttend()
    {
    }

    [Token(Token = "0x20016A9")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400524E")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildAttend.Response body;

      [Token(Token = "0x6005CD7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}

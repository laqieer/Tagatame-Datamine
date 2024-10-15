// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCustomApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001356")]
  [FlowNode.NodeType("Emergency/ReqCustomApi", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "RequestEx", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(12, "Failed_wait", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_ReqCustomApi : FlowNode_Network
  {
    [Token(Token = "0x4004784")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004785")]
    private const int PIN_IN_REQUEST_EX = 2;
    [Token(Token = "0x4004786")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x4004787")]
    private const int PIN_OUT_FAILED = 11;
    [Token(Token = "0x4004788")]
    private const int PIN_OUT_FAILED_WAIT = 12;
    [Token(Token = "0x4004789")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("リクエストするAPIのURL")]
    private string api_url;
    [Token(Token = "0x400478A")]
    [FieldOffset(Offset = "0x24")]
    [Header("リクエストに渡すbody(直接記述)")]
    [SerializeField]
    public string req_body;
    [Token(Token = "0x400478B")]
    [FieldOffset(Offset = "0x28")]
    [Header("リクエストに渡すbody(string配列)")]
    [SerializeField]
    private string[] req_params;
    [Token(Token = "0x400478C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Header("responseを格納するVariablesのkey配列")]
    private string[] res_keys;

    [Token(Token = "0x6005138")]
    [Address(RVA = "0x12759A0", Offset = "0x12747A0", VA = "0x112759A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005139")]
    [Address(RVA = "0x1275B60", Offset = "0x1274960", VA = "0x11275B60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600513A")]
    [Address(RVA = "0x1276000", Offset = "0x1274E00", VA = "0x11276000")]
    public FlowNode_ReqCustomApi()
    {
    }

    [Token(Token = "0x2001357")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400478D")]
      [FieldOffset(Offset = "0x28")]
      public ReqCustomApi.Response body;

      [Token(Token = "0x600513C")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}

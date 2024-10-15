// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MasterCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200142A")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("System/Master/Check", 32741)]
  public class FlowNode_MasterCheck : FlowNode_Network
  {
    [Token(Token = "0x4004A9C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004A9D")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005430")]
    [Address(RVA = "0x128E0F0", Offset = "0x128CEF0", VA = "0x1128E0F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005431")]
    [Address(RVA = "0x128E460", Offset = "0x128D260", VA = "0x1128E460")]
    private void Success()
    {
    }

    [Token(Token = "0x6005432")]
    [Address(RVA = "0x128E1E0", Offset = "0x128CFE0", VA = "0x1128E1E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005433")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MasterCheck()
    {
    }

    [Token(Token = "0x200142B")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004A9E")]
      [FieldOffset(Offset = "0x28")]
      public ReqkMasterCheck.Response body;

      [Token(Token = "0x6005434")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}

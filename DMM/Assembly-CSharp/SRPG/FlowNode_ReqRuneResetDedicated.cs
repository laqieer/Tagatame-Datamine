// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneResetDedicated
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001839")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Rune/Req/ResetDedicated", 32741)]
  public class FlowNode_ReqRuneResetDedicated : FlowNode_Network
  {
    [Token(Token = "0x40056E2")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056E3")]
    protected const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40056E4")]
    public const string KEY_RESET_DEDICATED_RUNE_ID = "KEY_RESET_DEDICATED_RUNE_ID";
    [Token(Token = "0x40056E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x60061C0")]
    [Address(RVA = "0x136A410", Offset = "0x1369210", VA = "0x1136A410")]
    public ReqRuneResetDedicated.RequestParam CreateRequestParam(SerializeValueList valueList)
    {
      return (ReqRuneResetDedicated.RequestParam) null;
    }

    [Token(Token = "0x60061C1")]
    [Address(RVA = "0x136A690", Offset = "0x1369490", VA = "0x1136A690", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061C2")]
    [Address(RVA = "0x136A4E0", Offset = "0x13692E0", VA = "0x1136A4E0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60061C3")]
    [Address(RVA = "0x136AAF0", Offset = "0x13698F0", VA = "0x1136AAF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061C4")]
    [Address(RVA = "0x136A710", Offset = "0x1369510", VA = "0x1136A710", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061C5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneResetDedicated()
    {
    }

    [Token(Token = "0x200183A")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40056E6")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneResetDedicated.Response body;

      [Token(Token = "0x60061C6")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFgGAuth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E9")]
  [FlowNode.Pin(2, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "AccountDeleted", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Auth/ReqFgGAuth", 32741)]
  public class FlowNode_ReqFgGAuth : FlowNode_Network
  {
    [Token(Token = "0x4004C9F")]
    private const int PIN_ID_REQUEST = 1;
    [Token(Token = "0x4004CA0")]
    private const int PIN_ID_SUCCESS = 2;
    [Token(Token = "0x4004CA1")]
    private const int PIN_ID_ACCOUNT_DELETED = 100;
    [Token(Token = "0x4004CA2")]
    [FieldOffset(Offset = "0x20")]
    private ReqFgGAuth.eAuthStatus mAuthStatusBefore;

    [Token(Token = "0x60056F8")]
    [Address(RVA = "0x12C6BD0", Offset = "0x12C59D0", VA = "0x112C6BD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056F9")]
    [Address(RVA = "0x12C6E90", Offset = "0x12C5C90", VA = "0x112C6E90")]
    private void Success(ReqFgGAuth.eAuthStatus authStatus)
    {
    }

    [Token(Token = "0x60056FA")]
    [Address(RVA = "0x12C6BB0", Offset = "0x12C59B0", VA = "0x112C6BB0")]
    private bool CheckStatusChanged(ReqFgGAuth.eAuthStatus status) => new bool();

    [Token(Token = "0x60056FB")]
    [Address(RVA = "0x12C6BF0", Offset = "0x12C59F0", VA = "0x112C6BF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056FC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFgGAuth()
    {
    }

    [Token(Token = "0x20014EA")]
    private class JSON_FgGAuth
    {
      [Token(Token = "0x4004CA3")]
      [FieldOffset(Offset = "0x8")]
      public int auth_status;
      [Token(Token = "0x4004CA4")]
      [FieldOffset(Offset = "0xC")]
      public string auth_url;

      [Token(Token = "0x60056FE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_FgGAuth()
      {
      }
    }
  }
}

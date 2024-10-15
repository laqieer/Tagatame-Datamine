// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHikkoshi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200152E")]
  [FlowNode.NodeType("Network/gauth_migrate", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "RequestFgG", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Success", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_ReqHikkoshi : FlowNode_Network
  {
    [Token(Token = "0x4004D80")]
    [FieldOffset(Offset = "0x20")]
    public string HikkoshiCodeInputFieldID;
    [Token(Token = "0x4004D81")]
    [FieldOffset(Offset = "0x24")]
    public string HikkoshiFgGMailAddress;
    [Token(Token = "0x4004D82")]
    [FieldOffset(Offset = "0x28")]
    public string HikkoshiFgGPassword;

    [Token(Token = "0x17000950")]
    private FlowNode_ReqHikkoshi.API m_Api
    {
      [Token(Token = "0x60057B6"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new FlowNode_ReqHikkoshi.API();
      }
      [Token(Token = "0x60057B7"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] set
      {
      }
    }

    [Token(Token = "0x60057B8")]
    [Address(RVA = "0x12D3F60", Offset = "0x12D2D60", VA = "0x112D3F60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057B9")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Success()
    {
    }

    [Token(Token = "0x60057BA")]
    [Address(RVA = "0x12C6F00", Offset = "0x12C5D00", VA = "0x112C6F00")]
    private void Failure(int pinID)
    {
    }

    [Token(Token = "0x60057BB")]
    [Address(RVA = "0x12D43D0", Offset = "0x12D31D0", VA = "0x112D43D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057BC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHikkoshi()
    {
    }

    [Token(Token = "0x200152F")]
    private enum API
    {
      [Token(Token = "0x4004D85")] Normal,
      [Token(Token = "0x4004D86")] FgG,
    }
  }
}

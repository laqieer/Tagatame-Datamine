// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetSessionID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F6")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Auth/GetSessionID", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_GetSessionID : FlowNode_Network
  {
    [Token(Token = "0x600538E")]
    [Address(RVA = "0x12819B0", Offset = "0x12807B0", VA = "0x112819B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600538F")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005390")]
    [Address(RVA = "0x1281A20", Offset = "0x1280820", VA = "0x11281A20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005391")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_GetSessionID()
    {
    }

    [Token(Token = "0x20013F7")]
    private class JSON_DeviceID
    {
      [Token(Token = "0x40049EF")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;

      [Token(Token = "0x6005392")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_DeviceID()
      {
      }
    }

    [Token(Token = "0x20013F8")]
    private class JSON_SessionID
    {
      [Token(Token = "0x40049F0")]
      [FieldOffset(Offset = "0x8")]
      public string sid;

      [Token(Token = "0x6005393")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_SessionID()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetAccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F1")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/Auth/GetAccessToken", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_GetAccessToken : FlowNode_Network
  {
    [Token(Token = "0x6005383")]
    [Address(RVA = "0x12812B0", Offset = "0x12800B0", VA = "0x112812B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005384")]
    [Address(RVA = "0x12813B0", Offset = "0x12801B0", VA = "0x112813B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005385")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_GetAccessToken()
    {
    }

    [Token(Token = "0x20013F2")]
    private class JSON_AccessToken
    {
      [Token(Token = "0x40049E7")]
      [FieldOffset(Offset = "0x8")]
      public string access_token;
      [Token(Token = "0x40049E8")]
      [FieldOffset(Offset = "0xC")]
      public int expires_in;

      [Token(Token = "0x6005386")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_AccessToken()
      {
      }
    }
  }
}

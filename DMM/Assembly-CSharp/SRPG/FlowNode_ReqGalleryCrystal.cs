// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGalleryCrystal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001341")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Crystal/Req/GalleryCrystal", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGalleryCrystal : FlowNode_Network
  {
    [Token(Token = "0x4004742")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004743")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005101")]
    [Address(RVA = "0x12607D0", Offset = "0x125F5D0", VA = "0x112607D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005102")]
    [Address(RVA = "0x1260BF0", Offset = "0x125F9F0", VA = "0x11260BF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005103")]
    [Address(RVA = "0x1260930", Offset = "0x125F730", VA = "0x11260930", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005104")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGalleryCrystal()
    {
    }

    [Token(Token = "0x2001342")]
    [Serializable]
    public class JSON_Body
    {
      [Token(Token = "0x4004744")]
      [FieldOffset(Offset = "0x8")]
      public string[] items;

      [Token(Token = "0x6005105")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Body()
      {
      }
    }
  }
}

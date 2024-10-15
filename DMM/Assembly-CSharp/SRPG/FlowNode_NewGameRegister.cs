// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NewGameRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001444")]
  [FlowNode.NodeType("System/NewGame/NewGameRegister", 32741)]
  [FlowNode.Pin(0, "Create New Account", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_NewGameRegister : FlowNode_Network
  {
    [Token(Token = "0x4004AFA")]
    [FieldOffset(Offset = "0x8")]
    public static string gPassword;

    [Token(Token = "0x17000931")]
    public static string gDeviceID
    {
      [Token(Token = "0x60054B1"), Address(RVA = "0x1293050", Offset = "0x1291E50", VA = "0x11293050")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60054B2"), Address(RVA = "0x12930D0", Offset = "0x1291ED0", VA = "0x112930D0")] set
      {
      }
    }

    [Token(Token = "0x17000932")]
    public static string gEmail
    {
      [Token(Token = "0x60054B3"), Address(RVA = "0x1293090", Offset = "0x1291E90", VA = "0x11293090")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60054B4"), Address(RVA = "0x1293130", Offset = "0x1291F30", VA = "0x11293130")] set
      {
      }
    }

    [Token(Token = "0x60054B5")]
    [Address(RVA = "0x1292D30", Offset = "0x1291B30", VA = "0x11292D30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054B6")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60054B7")]
    [Address(RVA = "0x1292E50", Offset = "0x1291C50", VA = "0x11292E50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60054B8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NewGameRegister()
    {
    }

    [Token(Token = "0x60054B9")]
    [Address(RVA = "0x1292FF0", Offset = "0x1291DF0", VA = "0x11292FF0")]
    static FlowNode_NewGameRegister()
    {
    }

    [Token(Token = "0x2001445")]
    private class JSON_DeviceID
    {
      [Token(Token = "0x4004AFB")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;

      [Token(Token = "0x60054BA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_DeviceID()
      {
      }
    }
  }
}

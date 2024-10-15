// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GscChainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013FE")]
  [FlowNode.Pin(20, "ChainMissing", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(0, "Register", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("GscSystem/GscChainData", 32741)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "RegistEmail", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "RegistPassword", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(14, "RegistDuplicate", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(21, "ChainEmail", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(1, "AddUser", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "ChainLocked", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(100, "Requested", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_GscChainData : FlowNode
  {
    [Token(Token = "0x40049FC")]
    private const int PIN_REGISTER = 0;
    [Token(Token = "0x40049FD")]
    private const int PIN_ADD_USER = 1;
    [Token(Token = "0x40049FE")]
    private const int PIN_SUCCESS = 10;
    [Token(Token = "0x40049FF")]
    private const int PIN_FAILED = 11;
    [Token(Token = "0x4004A00")]
    private const int PIN_REG_EMAIL = 12;
    [Token(Token = "0x4004A01")]
    private const int PIN_REG_PASSWORD = 13;
    [Token(Token = "0x4004A02")]
    private const int PIN_REG_DUPLICATE = 14;
    [Token(Token = "0x4004A03")]
    private const int PIN_CHN_MISSING = 20;
    [Token(Token = "0x4004A04")]
    private const int PIN_CHN_EMAIL = 21;
    [Token(Token = "0x4004A05")]
    private const int PIN_CHN_LOCKED = 22;
    [Token(Token = "0x4004A06")]
    private const int PIN_CHN_IDPASS = 23;
    [Token(Token = "0x4004A07")]
    private const int PIN_REQUESTED = 100;
    [Token(Token = "0x4004A08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text okyakusama_code_txt;
    [Token(Token = "0x4004A09")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text pass_txt;

    [Token(Token = "0x60053A2")]
    [Address(RVA = "0x1282980", Offset = "0x1281780", VA = "0x11282980", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053A3")]
    [Address(RVA = "0x1282C60", Offset = "0x1281A60", VA = "0x11282C60")]
    private void RegistResponse(RegisterEmailAddressAndPasswordResult res)
    {
    }

    [Token(Token = "0x60053A4")]
    [Address(RVA = "0x1282510", Offset = "0x1281310", VA = "0x11282510")]
    private void AddUserResponse(AddDeviceWithEmailAddressAndPasswordResult res)
    {
    }

    [Token(Token = "0x60053A5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GscChainData()
    {
    }
  }
}

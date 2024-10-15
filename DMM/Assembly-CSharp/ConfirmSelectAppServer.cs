// Decompiled with JetBrains decompiler
// Type: ConfirmSelectAppServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001A8")]
[FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
[AddComponentMenu("Debug/ConfirmSelectAppServer")]
public class ConfirmSelectAppServer : MonoBehaviour, IFlowInterface
{
  [Token(Token = "0x40007E1")]
  private const int PIN_IN_START = 1;
  [Token(Token = "0x40007E2")]
  private const int PIN_OUT_SUCCESS = 10;
  [Token(Token = "0x40007E3")]
  private const int PIN_OUT_FAILED = 11;
  [Token(Token = "0x40007E4")]
  private const string PASSWORD = "tagatameJP";
  [Token(Token = "0x40007E5")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject passwordDialog;
  [Token(Token = "0x40007E6")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private SRPG_InputField passwordInputFiled;
  [Token(Token = "0x40007E7")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private Dropdown serverNameDropdown;
  [Token(Token = "0x40007E8")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private SRPG_Button decideBtn;

  [Token(Token = "0x6000A09")]
  [Address(RVA = "0xF465B0", Offset = "0xF453B0", VA = "0x10F465B0", Slot = "4")]
  public void Activated(int pinID)
  {
  }

  [Token(Token = "0x6000A0A")]
  [Address(RVA = "0xF467E0", Offset = "0xF455E0", VA = "0x10F467E0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A0B")]
  [Address(RVA = "0x9C0F40", Offset = "0x9BFD40", VA = "0x109C0F40")]
  private void Confirm()
  {
  }

  [Token(Token = "0x6000A0C")]
  [Address(RVA = "0xF46680", Offset = "0xF45480", VA = "0x10F46680")]
  private void OnClick()
  {
  }

  [Token(Token = "0x6000A0D")]
  [Address(RVA = "0xF465D0", Offset = "0xF453D0", VA = "0x10F465D0")]
  private bool IsValidationPassword() => new bool();

  [Token(Token = "0x6000A0E")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
  private bool IsNeedPassword() => new bool();

  [Token(Token = "0x6000A0F")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ConfirmSelectAppServer()
  {
  }
}

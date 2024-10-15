// Decompiled with JetBrains decompiler
// Type: ShortcutMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200015F")]
[FlowNode.Pin(110, "InputOFF_Output", FlowNode.PinTypes.Output, 0)]
[AddComponentMenu("Common/ShortcutMenu")]
[FlowNode.Pin(111, "InputON_Output", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(101, "InputON", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(100, "InputOFF", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Close", FlowNode.PinTypes.Output, 0)]
public class ShortcutMenu : MonoBehaviour, IFlowInterface
{
  [Token(Token = "0x40006A1")]
  [FieldOffset(Offset = "0xC")]
  private RectTransform mRectTransform;
  [Token(Token = "0x40006A2")]
  [FieldOffset(Offset = "0x10")]
  public GameObject Badge_MenuOpen;
  [Token(Token = "0x40006A3")]
  [FieldOffset(Offset = "0x14")]
  public GameObject Badge_MenuClose;
  [Token(Token = "0x40006A4")]
  [FieldOffset(Offset = "0x18")]
  public GameObject Badge_Unit;
  [Token(Token = "0x40006A5")]
  [FieldOffset(Offset = "0x1C")]
  public GameObject Badge_Gift;
  [Token(Token = "0x40006A6")]
  [FieldOffset(Offset = "0x20")]
  public GameObject Badge_DailyMission;
  [Token(Token = "0x40006A7")]
  [FieldOffset(Offset = "0x24")]
  public GameObject Badge_ArtifactStoneEffect;
  [Token(Token = "0x40006A8")]
  [FieldOffset(Offset = "0x28")]
  private bool IsInput;

  [Token(Token = "0x600092E")]
  [Address(RVA = "0xE60850", Offset = "0xE5F650", VA = "0x10E60850")]
  private void Start()
  {
  }

  [Token(Token = "0x600092F")]
  [Address(RVA = "0xE60920", Offset = "0xE5F720", VA = "0x10E60920")]
  private void Update()
  {
  }

  [Token(Token = "0x6000930")]
  [Address(RVA = "0xE60800", Offset = "0xE5F600", VA = "0x10E60800", Slot = "4")]
  public void Activated(int pinID)
  {
  }

  [Token(Token = "0x6000931")]
  [Address(RVA = "0x5F8EB0", Offset = "0x5F7CB0", VA = "0x105F8EB0")]
  public ShortcutMenu()
  {
  }
}

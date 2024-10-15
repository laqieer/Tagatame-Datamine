// Decompiled with JetBrains decompiler
// Type: FlowNode_OptionNaviVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000234")]
[FlowNode.Pin(12, "放置ボイスOFF状態", FlowNode.PinTypes.Output, 12)]
[FlowNode.Pin(11, "放置ボイスON状態", FlowNode.PinTypes.Output, 11)]
[FlowNode.Pin(10, "設定完了", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(2, "放置ボイスOFFにする", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(1, "放置ボイスONにする", FlowNode.PinTypes.Input, 1)]
[FlowNode.NodeType("Opton/OptionNaviVoice", 32741)]
[FlowNode.Pin(3, "放置ボイスON状態か？", FlowNode.PinTypes.Input, 3)]
public class FlowNode_OptionNaviVoice : FlowNode
{
  [Token(Token = "0x4000978")]
  [FieldOffset(Offset = "0x18")]
  public string charaName;
  [Token(Token = "0x4000979")]
  [FieldOffset(Offset = "0x1C")]
  public string cueID;
  [Token(Token = "0x400097A")]
  private const int PIN_IN_NAVIVOICE_ON = 1;
  [Token(Token = "0x400097B")]
  private const int PIN_IN_NAVIVOICE_OFF = 2;
  [Token(Token = "0x400097C")]
  private const int PIN_IN_NAVIVOICE_CONFIRM = 3;
  [Token(Token = "0x400097D")]
  private const int PIN_OUT_NAVIVOICE_SUCCESS = 10;
  [Token(Token = "0x400097E")]
  private const int PIN_OUT_NAVIVOICE_TRUE = 11;
  [Token(Token = "0x400097F")]
  private const int PIN_OUT_NAVIVOICE_FALSE = 12;

  [Token(Token = "0x6000BC2")]
  [Address(RVA = "0x107CB80", Offset = "0x107B980", VA = "0x1107CB80", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BC3")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OptionNaviVoice()
  {
  }
}

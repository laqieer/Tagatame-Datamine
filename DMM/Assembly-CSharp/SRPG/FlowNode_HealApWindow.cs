// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_HealApWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001401")]
  [FlowNode.NodeType("UI/HealApWindow", 32741)]
  [FlowNode.Pin(106, "Adventure", FlowNode.PinTypes.Input, 106)]
  [FlowNode.Pin(104, "Quest", FlowNode.PinTypes.Input, 104)]
  [AddComponentMenu("")]
  [FlowNode.Pin(105, "HealCoin", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(103, "Home", FlowNode.PinTypes.Input, 103)]
  public class FlowNode_HealApWindow : FlowNode_GUI
  {
    [Token(Token = "0x4004A0B")]
    private const int PIN_INPUT_HOME = 103;
    [Token(Token = "0x4004A0C")]
    private const int PIN_INPUT_QUEST = 104;
    [Token(Token = "0x4004A0D")]
    private const int PIN_OUTPUT_HEALCOIN = 105;
    [Token(Token = "0x4004A0E")]
    private const int PIN_INPUT_ADVENTURE = 106;
    [Token(Token = "0x4004A0F")]
    [FieldOffset(Offset = "0x54")]
    private bool mIsQuest;
    [Token(Token = "0x4004A10")]
    [FieldOffset(Offset = "0x55")]
    private bool mIsAdventure;
    [Token(Token = "0x4004A11")]
    [FieldOffset(Offset = "0x58")]
    private HealAp mHealAp;

    [Token(Token = "0x60053AF")]
    [Address(RVA = "0x1283510", Offset = "0x1282310", VA = "0x11283510", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053B0")]
    [Address(RVA = "0x1283560", Offset = "0x1282360", VA = "0x11283560", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x60053B1")]
    [Address(RVA = "0x12834F0", Offset = "0x12822F0", VA = "0x112834F0")]
    public void HealCoin()
    {
    }

    [Token(Token = "0x60053B2")]
    [Address(RVA = "0x126B2F0", Offset = "0x126A0F0", VA = "0x1126B2F0")]
    public FlowNode_HealApWindow()
    {
    }
  }
}

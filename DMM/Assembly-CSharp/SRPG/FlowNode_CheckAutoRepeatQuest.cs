// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckAutoRepeatQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012E8")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("AutoRepeatQuest/Check", 32741)]
  [FlowNode.Pin(10, "自動周回中かチェック", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "自動周回中ではない", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "自動周回中です", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_CheckAutoRepeatQuest : FlowNode
  {
    [Token(Token = "0x4004663")]
    private const int PIN_INPUT_AUTOREPEAT_NOW = 10;
    [Token(Token = "0x4004664")]
    private const int PIN_OUTPUT_AUTOREPEAT_NOW = 100;
    [Token(Token = "0x4004665")]
    private const int PIN_OUTPUT_AUTOREPEAT_NOT_NOW = 110;

    [Token(Token = "0x6005002")]
    [Address(RVA = "0x124EFB0", Offset = "0x124DDB0", VA = "0x1124EFB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005003")]
    [Address(RVA = "0x124EF40", Offset = "0x124DD40", VA = "0x1124EF40")]
    private IEnumerator CheckAutoRepeatQuestNow() => (IEnumerator) null;

    [Token(Token = "0x6005004")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckAutoRepeatQuest()
    {
    }
  }
}

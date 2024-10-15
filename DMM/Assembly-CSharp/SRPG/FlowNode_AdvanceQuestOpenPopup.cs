// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceQuestOpenPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C9")]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/難易度、ボス解放ポップ", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_AdvanceQuestOpenPopup : FlowNode
  {
    [Token(Token = "0x4004607")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4004608")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x4004609")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<string> DifficultyTextKey;
    [Token(Token = "0x400460A")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsRunning;

    [Token(Token = "0x6004F9D")]
    [Address(RVA = "0x1249570", Offset = "0x1248370", VA = "0x11249570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004F9E")]
    [Address(RVA = "0x12490E0", Offset = "0x1247EE0", VA = "0x112490E0")]
    private List<QuestParam> GetOpenedDiffQuest() => (List<QuestParam>) null;

    [Token(Token = "0x6004F9F")]
    [Address(RVA = "0x1248FC0", Offset = "0x1247DC0", VA = "0x11248FC0")]
    private QuestParam GetOpenedBossQuest() => (QuestParam) null;

    [Token(Token = "0x6004FA0")]
    [Address(RVA = "0x1249490", Offset = "0x1248290", VA = "0x11249490")]
    private QuestParam GetOpenedSkipQuest() => (QuestParam) null;

    [Token(Token = "0x6004FA1")]
    [Address(RVA = "0x12495F0", Offset = "0x12483F0", VA = "0x112495F0")]
    private IEnumerator PopupMessageOpen() => (IEnumerator) null;

    [Token(Token = "0x6004FA2")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceQuestOpenPopup()
    {
    }
  }
}

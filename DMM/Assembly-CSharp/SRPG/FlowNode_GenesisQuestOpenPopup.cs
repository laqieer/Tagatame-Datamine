// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisQuestOpenPopup
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
  [Token(Token = "0x200168C")]
  [FlowNode.NodeType("Genesis/難易度、ボス解放ポップ", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_GenesisQuestOpenPopup : FlowNode
  {
    [Token(Token = "0x40051F7")]
    private const int PIN_IN = 1;
    [Token(Token = "0x40051F8")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x40051F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<string> DifficultyTextKey;
    [Token(Token = "0x40051FA")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsRunning;

    [Token(Token = "0x6005C7D")]
    [Address(RVA = "0x1307510", Offset = "0x1306310", VA = "0x11307510", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005C7E")]
    [Address(RVA = "0x1307AE0", Offset = "0x13068E0", VA = "0x11307AE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C7F")]
    [Address(RVA = "0x1307650", Offset = "0x1306450", VA = "0x11307650")]
    private List<QuestParam> GetOpenedDiffQuest() => (List<QuestParam>) null;

    [Token(Token = "0x6005C80")]
    [Address(RVA = "0x1307530", Offset = "0x1306330", VA = "0x11307530")]
    private QuestParam GetOpenedBossQuest() => (QuestParam) null;

    [Token(Token = "0x6005C81")]
    [Address(RVA = "0x1307A00", Offset = "0x1306800", VA = "0x11307A00")]
    private QuestParam GetOpenedSkipQuest() => (QuestParam) null;

    [Token(Token = "0x6005C82")]
    [Address(RVA = "0x1307B60", Offset = "0x1306960", VA = "0x11307B60")]
    private IEnumerator PopupMessageOpen() => (IEnumerator) null;

    [Token(Token = "0x6005C83")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisQuestOpenPopup()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PointQuestOpenPopup
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
  [Token(Token = "0x20017FC")]
  [FlowNode.NodeType("PointQuest/ポイントクエスト難易度解放ポップ", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_PointQuestOpenPopup : FlowNode
  {
    [Token(Token = "0x4005663")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005664")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x4005665")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<string> DifficultyTextKey;

    [Token(Token = "0x6006100")]
    [Address(RVA = "0x135BC20", Offset = "0x135AA20", VA = "0x1135BC20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006101")]
    [Address(RVA = "0x135B7B0", Offset = "0x135A5B0", VA = "0x1135B7B0")]
    private List<QuestParam> GetOpenedDiffQuest() => (List<QuestParam>) null;

    [Token(Token = "0x6006102")]
    [Address(RVA = "0x135BB50", Offset = "0x135A950", VA = "0x1135BB50")]
    private QuestParam GetOpenedSkipQuest() => (QuestParam) null;

    [Token(Token = "0x6006103")]
    [Address(RVA = "0x135BCE0", Offset = "0x135AAE0", VA = "0x1135BCE0")]
    private IEnumerator PopupMessageOpen() => (IEnumerator) null;

    [Token(Token = "0x6006104")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PointQuestOpenPopup()
    {
    }
  }
}

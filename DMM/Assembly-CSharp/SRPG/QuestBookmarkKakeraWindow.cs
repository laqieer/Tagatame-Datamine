// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkKakeraWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002874")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "クエスト選択", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/QuestBookmarkKakeraWindow")]
  public class QuestBookmarkKakeraWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C15F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform QuestListParent;
    [Token(Token = "0x400C160")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject QuestListItemTemplate;
    [Token(Token = "0x400C161")]
    [FieldOffset(Offset = "0x14")]
    private List<GameObject> mGainedQuests;

    [Token(Token = "0x600B6CB")]
    [Address(RVA = "0x7D3920", Offset = "0x7D2720", VA = "0x107D3920", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6CC")]
    [Address(RVA = "0x7D3C10", Offset = "0x7D2A10", VA = "0x107D3C10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B6CD")]
    [Address(RVA = "0x7D4130", Offset = "0x7D2F30", VA = "0x107D4130")]
    public void Refresh(UnitParam unit, IEnumerable<QuestParam> quests)
    {
    }

    [Token(Token = "0x600B6CE")]
    [Address(RVA = "0x7D3EE0", Offset = "0x7D2CE0", VA = "0x107D3EE0")]
    private void RefreshGainedQuests(UnitParam unit, IEnumerable<QuestParam> quests)
    {
    }

    [Token(Token = "0x600B6CF")]
    [Address(RVA = "0x7D3980", Offset = "0x7D2780", VA = "0x107D3980")]
    private void AddPanel(QuestParam questparam, QuestParam[] availableQuests)
    {
    }

    [Token(Token = "0x600B6D0")]
    [Address(RVA = "0x7D3C80", Offset = "0x7D2A80", VA = "0x107D3C80")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B6D1")]
    [Address(RVA = "0x7D41C0", Offset = "0x7D2FC0", VA = "0x107D41C0")]
    public QuestBookmarkKakeraWindow()
    {
    }
  }
}

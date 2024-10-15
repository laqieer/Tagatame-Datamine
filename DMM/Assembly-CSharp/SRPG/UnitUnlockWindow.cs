// Decompiled with JetBrains decompiler
// Type: SRPG.UnitUnlockWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D2A")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Unlock", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "Selected Quest", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/UnitUnlockWindow")]
  public class UnitUnlockWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E124")]
    [FieldOffset(Offset = "0xC")]
    public GameObject QuestList;
    [Token(Token = "0x400E125")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform QuestListParent;
    [Token(Token = "0x400E126")]
    [FieldOffset(Offset = "0x14")]
    public GameObject QuestListItemTemplate;
    [Token(Token = "0x400E127")]
    [FieldOffset(Offset = "0x18")]
    public Text TxtTitle;
    [Token(Token = "0x400E128")]
    [FieldOffset(Offset = "0x1C")]
    public Text TxtComment;
    [Token(Token = "0x400E129")]
    [FieldOffset(Offset = "0x20")]
    public Text TxtQuestNothing;
    [Token(Token = "0x400E12A")]
    [FieldOffset(Offset = "0x24")]
    public GameObject GOUnlockLimit;
    [Token(Token = "0x400E12B")]
    [FieldOffset(Offset = "0x28")]
    public Button BtnDecide;
    [Token(Token = "0x400E12C")]
    [FieldOffset(Offset = "0x2C")]
    public Button BtnCancel;
    [Token(Token = "0x400E12D")]
    [FieldOffset(Offset = "0x30")]
    private UnitParam UnlockUnit;
    [Token(Token = "0x400E12E")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> mGainedQuests;

    [Token(Token = "0x600D277")]
    [Address(RVA = "0x9D9FC0", Offset = "0x9D8DC0", VA = "0x109D9FC0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D278")]
    [Address(RVA = "0x9D8DC0", Offset = "0x9D7BC0", VA = "0x109D8DC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D279")]
    [Address(RVA = "0x9D9920", Offset = "0x9D8720", VA = "0x109D9920")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D27A")]
    [Address(RVA = "0x9D9400", Offset = "0x9D8200", VA = "0x109D9400")]
    private void RefreshGainedQuests(UnitParam unit)
    {
    }

    [Token(Token = "0x600D27B")]
    [Address(RVA = "0x9D9F10", Offset = "0x9D8D10", VA = "0x109D9F10")]
    private void SetScrollTop()
    {
    }

    [Token(Token = "0x600D27C")]
    [Address(RVA = "0x9D9090", Offset = "0x9D7E90", VA = "0x109D9090")]
    public void ClearPanel()
    {
    }

    [Token(Token = "0x600D27D")]
    [Address(RVA = "0x9D8DE0", Offset = "0x9D7BE0", VA = "0x109D8DE0")]
    private void AddPanel(QuestParam questparam, QuestParam[] availableQuests)
    {
    }

    [Token(Token = "0x600D27E")]
    [Address(RVA = "0x9D91A0", Offset = "0x9D7FA0", VA = "0x109D91A0")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600D27F")]
    [Address(RVA = "0x9DA040", Offset = "0x9D8E40", VA = "0x109DA040")]
    public UnitUnlockWindow()
    {
    }
  }
}

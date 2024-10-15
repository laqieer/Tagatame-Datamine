// Decompiled with JetBrains decompiler
// Type: SRPG.EventQuestPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200237C")]
  [FlowNode.Pin(1, "決定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/EventQuestPopup", 32741)]
  [FlowNode.Pin(100, "アンロック", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "戻る", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/EventQuestPopup")]
  [FlowNode.Pin(2, "キャンセル", FlowNode.PinTypes.Input, 1)]
  public class EventQuestPopup : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009FAE")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemLayout;
    [Token(Token = "0x4009FAF")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x4009FB0")]
    [FieldOffset(Offset = "0x14")]
    public Text Message;
    [Token(Token = "0x4009FB1")]
    [FieldOffset(Offset = "0x18")]
    public SRPG_Button BtnDecide;
    [Token(Token = "0x4009FB2")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_Button BtnCancel;
    [Token(Token = "0x4009FB3")]
    [FieldOffset(Offset = "0x20")]
    private ChapterParam Chapter;

    [Token(Token = "0x6009954")]
    [Address(RVA = "0x5D6930", Offset = "0x5D5730", VA = "0x105D6930", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009955")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009956")]
    [Address(RVA = "0x5D6E90", Offset = "0x5D5C90", VA = "0x105D6E90")]
    private void Start()
    {
    }

    [Token(Token = "0x6009957")]
    [Address(RVA = "0x5D6BE0", Offset = "0x5D59E0", VA = "0x105D6BE0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009958")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventQuestPopup()
    {
    }
  }
}

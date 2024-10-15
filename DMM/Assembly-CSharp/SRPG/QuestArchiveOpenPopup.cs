// Decompiled with JetBrains decompiler
// Type: SRPG.QuestArchiveOpenPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002871")]
  [AddComponentMenu("UI/QuestArchiveOpenPopup")]
  [FlowNode.NodeType("System/QuestArchiveOpenPopup", 32741)]
  [FlowNode.Pin(1, "決定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "キャンセル", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "開放", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "戻る", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "アイテムが足りない", FlowNode.PinTypes.Output, 102)]
  public class QuestArchiveOpenPopup : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C157")]
    [FieldOffset(Offset = "0xC")]
    public Text Message;
    [Token(Token = "0x400C158")]
    [FieldOffset(Offset = "0x10")]
    public SRPG_Button BtnDecide;
    [Token(Token = "0x400C159")]
    [FieldOffset(Offset = "0x14")]
    public SRPG_Button BtnCancel;
    [Token(Token = "0x400C15A")]
    [FieldOffset(Offset = "0x18")]
    private ArchiveParam mArchive;
    [Token(Token = "0x400C15B")]
    [FieldOffset(Offset = "0x1C")]
    private ChapterParam mChapter;

    [Token(Token = "0x600B6C2")]
    [Address(RVA = "0x7D2E30", Offset = "0x7D1C30", VA = "0x107D2E30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6C3")]
    [Address(RVA = "0x7D2F60", Offset = "0x7D1D60", VA = "0x107D2F60")]
    private void Start()
    {
    }

    [Token(Token = "0x600B6C4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestArchiveOpenPopup()
    {
    }
  }
}

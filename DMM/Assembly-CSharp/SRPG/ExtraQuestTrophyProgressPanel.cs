// Decompiled with JetBrains decompiler
// Type: SRPG.ExtraQuestTrophyProgressPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002865")]
  [FlowNode.Pin(10, "表示更新開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "表示更新完了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Quest/ExtraQuestTrophyProgressPanel")]
  public class ExtraQuestTrophyProgressPanel : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C0FF")]
    private const int PIN_INPUT_REFRESH_START = 10;
    [Token(Token = "0x400C100")]
    private const int PIN_OUTPUT_REFRESH_END = 100;
    [Token(Token = "0x400C101")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool mIsIgnoreCndsSkipTicket;
    [Token(Token = "0x400C102")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image[] mElementIcons_On;
    [Token(Token = "0x400C103")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image[] mElementIcons_Off;

    [Token(Token = "0x600B68E")]
    [Address(RVA = "0x7CC390", Offset = "0x7CB190", VA = "0x107CC390", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B68F")]
    [Address(RVA = "0x7CC970", Offset = "0x7CB770", VA = "0x107CC970")]
    public void Refresh(string quest_iname, bool is_ignore_cnds_skipticket = false)
    {
    }

    [Token(Token = "0x600B690")]
    [Address(RVA = "0x7CCAF0", Offset = "0x7CB8F0", VA = "0x107CCAF0")]
    private void Show()
    {
    }

    [Token(Token = "0x600B691")]
    [Address(RVA = "0x7CC4A0", Offset = "0x7CB2A0", VA = "0x107CC4A0")]
    private void Hide()
    {
    }

    [Token(Token = "0x600B692")]
    [Address(RVA = "0x7CC4D0", Offset = "0x7CB2D0", VA = "0x107CC4D0")]
    private void Refresh_ElementIcon(QuestParam quest)
    {
    }

    [Token(Token = "0x600B693")]
    [Address(RVA = "0x7CCA40", Offset = "0x7CB840", VA = "0x107CCA40")]
    private void SetEnableElementIcon(EElement element, bool is_enable)
    {
    }

    [Token(Token = "0x600B694")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ExtraQuestTrophyProgressPanel()
    {
    }
  }
}

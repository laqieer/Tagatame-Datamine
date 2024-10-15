// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200290B")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/RankingQuestButton")]
  [FlowNode.Pin(0, "Set ranking quest", FlowNode.PinTypes.Input, 0)]
  public class RankingQuestButton : MonoBehaviour, IGameParameter, IFlowInterface
  {
    [Token(Token = "0x400C5B6")]
    private const int PERIOD_STATE_ICON_INDEX_OPEN = 0;
    [Token(Token = "0x400C5B7")]
    private const int PERIOD_STATE_ICON_INDEX_WAIT = 1;
    [Token(Token = "0x400C5B8")]
    private const int PERIOD_STATE_ICON_INDEX_VISIBLE = 2;
    [Token(Token = "0x400C5B9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray m_PeriodStateIcon;
    [Token(Token = "0x400C5BA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_Time;

    [Token(Token = "0x600B9D4")]
    [Address(RVA = "0x811F30", Offset = "0x810D30", VA = "0x10811F30")]
    private void Start()
    {
    }

    [Token(Token = "0x600B9D5")]
    [Address(RVA = "0x811E60", Offset = "0x810C60", VA = "0x10811E60", Slot = "5")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9D6")]
    [Address(RVA = "0x811F40", Offset = "0x810D40", VA = "0x10811F40", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600B9D7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankingQuestButton()
    {
    }
  }
}

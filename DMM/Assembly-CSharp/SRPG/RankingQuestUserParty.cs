// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestUserParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002911")]
  [AddComponentMenu("UI/RankingQuestUserParty")]
  [FlowNode.Pin(100, "データ反映", FlowNode.PinTypes.Input, 100)]
  public class RankingQuestUserParty : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C5DB")]
    public const int INPUT_REFRECTION_DATA = 100;
    [Token(Token = "0x400C5DC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private QuestClearedPartyViewer m_PartyWindow;
    [Token(Token = "0x400C5DD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_MainScoreText;
    [Token(Token = "0x400C5DE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_MainScoreValue;
    [Token(Token = "0x400C5DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_MainScoreValueSuffix;
    [Token(Token = "0x400C5E0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text m_SubScoreText;
    [Token(Token = "0x400C5E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_SubScoreValue;

    [Token(Token = "0x600B9ED")]
    [Address(RVA = "0x813BD0", Offset = "0x8129D0", VA = "0x10813BD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9EE")]
    [Address(RVA = "0x813C10", Offset = "0x812A10", VA = "0x10813C10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B9EF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankingQuestUserParty()
    {
    }
  }
}

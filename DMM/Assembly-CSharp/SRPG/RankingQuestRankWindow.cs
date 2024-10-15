// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestRankWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200290F")]
  [AddComponentMenu("UI/RankingQuestRankWindow")]
  [FlowNode.Pin(300, "リストが選択された", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(200, "ランキングリスト更新完了", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "ランキングリスト更新", FlowNode.PinTypes.Input, 100)]
  public class RankingQuestRankWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C5C6")]
    public const int INPUT_LIST_UPDATE = 100;
    [Token(Token = "0x400C5C7")]
    public const int OUTPUT_LIST_UPDATED = 200;
    [Token(Token = "0x400C5C8")]
    public const int OUTPUT_LIST_SELECTED = 300;
    [Token(Token = "0x400C5C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RankingQuestRankList m_TargetList;
    [Token(Token = "0x400C5CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ScrollListController m_ScrollListController;
    [Token(Token = "0x400C5CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_RootObject;
    [Token(Token = "0x400C5CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_WindowTitleText;
    [Token(Token = "0x400C5CD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_OwnRankBanner;
    [Token(Token = "0x400C5CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject m_NotRegisteredText;
    [Token(Token = "0x400C5CF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject m_NotSummaryData;
    [Token(Token = "0x400C5D0")]
    [FieldOffset(Offset = "0x28")]
    private RankingQuestParam m_RankingQuestParam;

    [Token(Token = "0x600B9E4")]
    [Address(RVA = "0x813620", Offset = "0x812420", VA = "0x10813620")]
    private void Start()
    {
    }

    [Token(Token = "0x600B9E5")]
    [Address(RVA = "0x8130F0", Offset = "0x811EF0", VA = "0x108130F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9E6")]
    [Address(RVA = "0x8133F0", Offset = "0x8121F0", VA = "0x108133F0")]
    public void SetData(RankingQuestUserData[] data)
    {
    }

    [Token(Token = "0x600B9E7")]
    [Address(RVA = "0x813340", Offset = "0x812140", VA = "0x10813340")]
    public void SetData(RankingQuestUserData[] data, RankingQuestUserData ownData)
    {
    }

    [Token(Token = "0x600B9E8")]
    [Address(RVA = "0x813490", Offset = "0x812290", VA = "0x10813490")]
    private void SetOwnRankingData(RankingQuestUserData ownData)
    {
    }

    [Token(Token = "0x600B9E9")]
    [Address(RVA = "0x813240", Offset = "0x812040", VA = "0x10813240")]
    public void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B9EA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankingQuestRankWindow()
    {
    }
  }
}

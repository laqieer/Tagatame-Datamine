// Decompiled with JetBrains decompiler
// Type: SRPG.QuestDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002894")]
  [AddComponentMenu("UI/QuestDetail")]
  [FlowNode.Pin(10, "表示更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "表示更新(完了)", FlowNode.PinTypes.Output, 100)]
  public class QuestDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C22E")]
    private const int INPUT_REFRESH_UI = 10;
    [Token(Token = "0x400C22F")]
    private const int OUTPUT_REFRESH_UI = 100;
    [Token(Token = "0x400C230")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼ミッション報酬表示用オブジェクトの親")]
    private RectTransform m_ContentRoot;
    [Token(Token = "0x400C231")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HeaderBar("▼ミッション報酬表示用テンプレート")]
    private QuestMissionItem m_RewardItemTemplate;
    [Token(Token = "0x400C232")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private QuestMissionItem m_RewardUnitTemplate;
    [Token(Token = "0x400C233")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestMissionItem m_RewardArtifactTemplate;
    [Token(Token = "0x400C234")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private QuestMissionItem m_RewardCardTemplate;
    [Token(Token = "0x400C235")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestMissionItem m_RewardNothingTemplate;
    [Token(Token = "0x400C236")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [HeaderBar("▼ミッション報酬が何も設定されていない時に表示するオブジェクト")]
    private GameObject m_NoMissionText;
    [Token(Token = "0x400C237")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool m_RefreshOnStart;
    [Token(Token = "0x400C238")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼ミッションの表示順(デフォルト=ソートしない)")]
    [SerializeField]
    private QuestDetail.SortOrder m_SortOrder;
    [Token(Token = "0x400C239")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼勝利条件、クエスト情報、クエストミッション、入手アイテムへのアクセサ")]
    [SerializeField]
    public GameObject GoCondition;
    [Token(Token = "0x400C23A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public GameObject GoLimit;
    [Token(Token = "0x400C23B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public GameObject GoMission;
    [Token(Token = "0x400C23C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public GameObject GoDropList;
    [Token(Token = "0x400C23D")]
    [FieldOffset(Offset = "0x40")]
    private List<QuestDetail.ViewParam> m_ListItems;

    [Token(Token = "0x600B76A")]
    [Address(RVA = "0x7E34C0", Offset = "0x7E22C0", VA = "0x107E34C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B76B")]
    [Address(RVA = "0x7E2D50", Offset = "0x7E1B50", VA = "0x107E2D50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B76C")]
    [Address(RVA = "0x7E3280", Offset = "0x7E2080", VA = "0x107E3280")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B76D")]
    [Address(RVA = "0x7E2E20", Offset = "0x7E1C20", VA = "0x107E2E20")]
    private void CreateItems(QuestParam questParam)
    {
    }

    [Token(Token = "0x600B76E")]
    [Address(RVA = "0x7E3130", Offset = "0x7E1F30", VA = "0x107E3130")]
    private QuestMissionItem CreateRewardItem(QuestBonusObjective bonusObjective)
    {
      return (QuestMissionItem) null;
    }

    [Token(Token = "0x600B76F")]
    [Address(RVA = "0x7E3320", Offset = "0x7E2120", VA = "0x107E3320")]
    private void SortItems()
    {
    }

    [Token(Token = "0x600B770")]
    [Address(RVA = "0x7E2D80", Offset = "0x7E1B80", VA = "0x107E2D80")]
    private int Compare_AchievemedToUnachieved(
      QuestDetail.ViewParam viewParam1,
      QuestDetail.ViewParam viewParam2)
    {
      return new int();
    }

    [Token(Token = "0x600B771")]
    [Address(RVA = "0x7E2DD0", Offset = "0x7E1BD0", VA = "0x107E2DD0")]
    private int Compare_UnachievedToAchievemed(
      QuestDetail.ViewParam viewParam1,
      QuestDetail.ViewParam viewParam2)
    {
      return new int();
    }

    [Token(Token = "0x600B772")]
    [Address(RVA = "0x7E3620", Offset = "0x7E2420", VA = "0x107E3620")]
    public QuestDetail()
    {
    }

    [Token(Token = "0x2002895")]
    public enum SortOrder
    {
      [Token(Token = "0x400C23F")] None,
      [Token(Token = "0x400C240")] AchievemedToUnachieved,
      [Token(Token = "0x400C241")] UnachievedToAchievemed,
    }

    [Token(Token = "0x2002896")]
    private class ViewParam
    {
      [Token(Token = "0x400C242")]
      [FieldOffset(Offset = "0x8")]
      private QuestMissionItem m_ListItem;
      [Token(Token = "0x400C243")]
      [FieldOffset(Offset = "0xC")]
      private int m_MissionIndex;
      [Token(Token = "0x400C244")]
      [FieldOffset(Offset = "0x10")]
      private bool m_IsAchieved;

      [Token(Token = "0x1700190D")]
      public QuestMissionItem ListItem
      {
        [Token(Token = "0x600B775"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (QuestMissionItem) null;
        }
        [Token(Token = "0x600B776"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x1700190E")]
      public int MissionIndex
      {
        [Token(Token = "0x600B777"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600B778"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
        {
        }
      }

      [Token(Token = "0x1700190F")]
      public bool IsAchieved
      {
        [Token(Token = "0x600B779"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
        [Token(Token = "0x600B77A"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
        {
        }
      }

      [Token(Token = "0x600B77B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewParam()
      {
      }
    }
  }
}

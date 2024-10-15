// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021A5")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "表示更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "ギルドランキングを取得", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "メンバー別ランキングを取得", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/CombatPower/CombatPowerRanking")]
  public class CombatPowerRanking : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009333")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4009334")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x4009335")]
    private const int PIN_OUTPUT_REQUEST_GUILD_RANKING = 100;
    [Token(Token = "0x4009336")]
    private const int PIN_OUTPUT_REQUEST_MEMBER_RANKING = 101;
    [Token(Token = "0x4009337")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle m_AllPortTab;
    [Token(Token = "0x4009338")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle m_PortMembersTab;
    [Token(Token = "0x4009339")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button m_AllPortSelfItem;
    [Token(Token = "0x400933A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CombatPowerRanking.RankingUIRef m_AllPortObjects;
    [Token(Token = "0x400933B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private CombatPowerRanking.RankingUIRef m_PortMembersObjects;
    [Token(Token = "0x400933C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FlowNode_ReqGuildRanking m_RequestNodeGuildRanking;
    [Token(Token = "0x400933D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private FlowNode_ReqGuildRankingMembers m_RequestNodeGuildRankingMembers;
    [Token(Token = "0x400933E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SerializeValueBehaviour m_SerializeValue;
    [Token(Token = "0x400933F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private CombatPowerRanking.GvGRankingTab m_ActiveTabType;
    [Token(Token = "0x4009340")]
    [FieldOffset(Offset = "0x30")]
    private List<CombatPowerRankingViewGuild> m_GuildRankingData;
    [Token(Token = "0x4009341")]
    [FieldOffset(Offset = "0x34")]
    private List<CombatPowerRankingGuildMember> m_GuildMemberRankingData;
    [Token(Token = "0x4009342")]
    [FieldOffset(Offset = "0x38")]
    private CombatPowerRankingViewGuild m_GuildRankingDataSelf;
    [Token(Token = "0x4009343")]
    [FieldOffset(Offset = "0x0")]
    private static CombatPowerRanking s_instance;

    [Token(Token = "0x170013FE")]
    public static CombatPowerRanking Instance
    {
      [Token(Token = "0x6008D95"), Address(RVA = "0x517480", Offset = "0x516280", VA = "0x10517480")] get
      {
        return (CombatPowerRanking) null;
      }
    }

    [Token(Token = "0x6008D96")]
    [Address(RVA = "0x516340", Offset = "0x515140", VA = "0x10516340")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008D97")]
    [Address(RVA = "0x516880", Offset = "0x515680", VA = "0x10516880")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x170013FF")]
    private CombatPowerRanking.RankingUIRef ActiveRankingObject
    {
      [Token(Token = "0x6008D98"), Address(RVA = "0x517410", Offset = "0x516210", VA = "0x10517410")] get
      {
        return (CombatPowerRanking.RankingUIRef) null;
      }
    }

    [Token(Token = "0x17001400")]
    private ContentController ActiveContentController
    {
      [Token(Token = "0x6008D99"), Address(RVA = "0x5173C0", Offset = "0x5161C0", VA = "0x105173C0")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x17001401")]
    private ScrollRect ActiveScrollRect
    {
      [Token(Token = "0x6008D9A"), Address(RVA = "0x517430", Offset = "0x516230", VA = "0x10517430")] get
      {
        return (ScrollRect) null;
      }
    }

    [Token(Token = "0x6008D9B")]
    [Address(RVA = "0x516F40", Offset = "0x515D40", VA = "0x10516F40")]
    private void Start()
    {
    }

    [Token(Token = "0x6008D9C")]
    [Address(RVA = "0x5161C0", Offset = "0x514FC0", VA = "0x105161C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008D9D")]
    [Address(RVA = "0x516870", Offset = "0x515670", VA = "0x10516870")]
    private void Init()
    {
    }

    [Token(Token = "0x6008D9E")]
    [Address(RVA = "0x5169F0", Offset = "0x5157F0", VA = "0x105169F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008D9F")]
    [Address(RVA = "0x516190", Offset = "0x514F90", VA = "0x10516190")]
    private void ActivateRequestPin()
    {
    }

    [Token(Token = "0x6008DA0")]
    [Address(RVA = "0x516380", Offset = "0x515180", VA = "0x10516380")]
    private void CreateRanking()
    {
    }

    [Token(Token = "0x6008DA1")]
    [Address(RVA = "0x516DB0", Offset = "0x515BB0", VA = "0x10516DB0")]
    public void SetupGuildRankingData(ReqGuildRanking.Response json)
    {
    }

    [Token(Token = "0x6008DA2")]
    [Address(RVA = "0x516CA0", Offset = "0x515AA0", VA = "0x10516CA0")]
    public void SetupGuildMembersRankingData(ReqGuildRankingMembers.Response json)
    {
    }

    [Token(Token = "0x6008DA3")]
    [Address(RVA = "0x516C10", Offset = "0x515A10", VA = "0x10516C10")]
    private void SelectTab(CombatPowerRanking.GvGRankingTab tab)
    {
    }

    [Token(Token = "0x6008DA4")]
    [Address(RVA = "0x516B20", Offset = "0x515920", VA = "0x10516B20")]
    private void RequestRakingData()
    {
    }

    [Token(Token = "0x6008DA5")]
    [Address(RVA = "0x5168C0", Offset = "0x5156C0", VA = "0x105168C0")]
    private void OnGuildListItemClick(ViewGuildData guildData)
    {
    }

    [Token(Token = "0x6008DA6")]
    [Address(RVA = "0x516970", Offset = "0x515770", VA = "0x10516970")]
    private void OnGuildMemberListItemClick(CombatPowerRankingGuildMember memberData)
    {
    }

    [Token(Token = "0x6008DA7")]
    [Address(RVA = "0x5169C0", Offset = "0x5157C0", VA = "0x105169C0")]
    private void OnSelectTab(CombatPowerRanking.GvGRankingTab tabType)
    {
    }

    [Token(Token = "0x6008DA8")]
    [Address(RVA = "0x517310", Offset = "0x516110", VA = "0x10517310")]
    public CombatPowerRanking()
    {
    }

    [Token(Token = "0x20021A6")]
    private enum GvGRankingTab
    {
      [Token(Token = "0x4009345")] AllPort,
      [Token(Token = "0x4009346")] PortMembers,
    }

    [Token(Token = "0x20021A7")]
    [Serializable]
    private class RankingUIRef
    {
      [Token(Token = "0x4009347")]
      [FieldOffset(Offset = "0x8")]
      public GameObject m_RankingRoot;
      [Token(Token = "0x4009348")]
      [FieldOffset(Offset = "0xC")]
      public ScrollRect m_ScrollRect;
      [Token(Token = "0x4009349")]
      [FieldOffset(Offset = "0x10")]
      public ContentController m_ContentController;
      [Token(Token = "0x400934A")]
      [FieldOffset(Offset = "0x14")]
      private RectTransform m_ContentTransformCache;

      [Token(Token = "0x17001402")]
      public RectTransform ContentTransform
      {
        [Token(Token = "0x6008DAC"), Address(RVA = "0x51CC60", Offset = "0x51BA60", VA = "0x1051CC60")] get
        {
          return (RectTransform) null;
        }
      }

      [Token(Token = "0x6008DAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RankingUIRef()
      {
      }
    }

    [Token(Token = "0x20021A8")]
    public class GuildContentParam : ContentSource.Param
    {
      [Token(Token = "0x400934B")]
      [FieldOffset(Offset = "0x10")]
      public CombatPowerRankingViewGuild mGuildData;
      [Token(Token = "0x400934C")]
      [FieldOffset(Offset = "0x14")]
      public CombatPowerRanking.GuildContentParam.OnListItemClick onListItemClick;

      [Token(Token = "0x6008DAE")]
      [Address(RVA = "0x51C9D0", Offset = "0x51B7D0", VA = "0x1051C9D0", Slot = "12")]
      public override void OnEnable(ContentNode node)
      {
      }

      [Token(Token = "0x6008DAF")]
      [Address(RVA = "0x51C9A0", Offset = "0x51B7A0", VA = "0x1051C9A0", Slot = "19")]
      public override void OnClick(ContentNode node)
      {
      }

      [Token(Token = "0x6008DB0")]
      [Address(RVA = "0x51C8F0", Offset = "0x51B6F0", VA = "0x1051C8F0")]
      private void BindData(ContentNode node)
      {
      }

      [Token(Token = "0x6008DB1")]
      [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
      public GuildContentParam()
      {
      }

      [Token(Token = "0x20021A9")]
      public delegate void OnListItemClick(ViewGuildData guildData);
    }

    [Token(Token = "0x20021AA")]
    public class GuildMemberContentParam : ContentSource.Param
    {
      [Token(Token = "0x400934D")]
      [FieldOffset(Offset = "0x10")]
      public CombatPowerRankingGuildMember mMemberData;
      [Token(Token = "0x400934E")]
      [FieldOffset(Offset = "0x14")]
      public CombatPowerRanking.GuildMemberContentParam.OnListItemClick onListItemClick;

      [Token(Token = "0x6008DB6")]
      [Address(RVA = "0x51CB70", Offset = "0x51B970", VA = "0x1051CB70", Slot = "12")]
      public override void OnEnable(ContentNode node)
      {
      }

      [Token(Token = "0x6008DB7")]
      [Address(RVA = "0x51C9A0", Offset = "0x51B7A0", VA = "0x1051C9A0", Slot = "19")]
      public override void OnClick(ContentNode node)
      {
      }

      [Token(Token = "0x6008DB8")]
      [Address(RVA = "0x51CA90", Offset = "0x51B890", VA = "0x1051CA90")]
      private void BindData(ContentNode node)
      {
      }

      [Token(Token = "0x6008DB9")]
      [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
      public GuildMemberContentParam()
      {
      }

      [Token(Token = "0x20021AB")]
      public delegate void OnListItemClick(CombatPowerRankingGuildMember memberData);
    }
  }
}

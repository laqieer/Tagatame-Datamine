// Decompiled with JetBrains decompiler
// Type: SRPG.RecentPartyList
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
  [Token(Token = "0x200292F")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/RecentPartyList")]
  [FlowNode.Pin(100, "Output", FlowNode.PinTypes.Output, 100)]
  public class RecentPartyList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C65D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RecentPartyPanel PartyPanelTemplate;
    [Token(Token = "0x400C65E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject PartyPanelHolder;
    [Token(Token = "0x400C65F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text ErrorText;
    [Token(Token = "0x400C660")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect ScrollRect;
    [Token(Token = "0x400C661")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button PrevButton;
    [Token(Token = "0x400C662")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button NextButton;
    [Token(Token = "0x400C663")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject PageInfo;
    [Token(Token = "0x400C664")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text CurrentPage;
    [Token(Token = "0x400C665")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text MaxPage;
    [Token(Token = "0x400C666")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject CheckBox;
    [Token(Token = "0x400C667")]
    [FieldOffset(Offset = "0x34")]
    private List<RecentPartyPanel> m_RecentPartyPanels;
    [Token(Token = "0x400C668")]
    [FieldOffset(Offset = "0x38")]
    private List<RecentPartyList.ViewParam> m_ViewParams;
    [Token(Token = "0x400C669")]
    [FieldOffset(Offset = "0x3C")]
    private QuestParam m_CurrentQuest;
    [Token(Token = "0x400C66A")]
    [FieldOffset(Offset = "0x40")]
    private bool m_OwnedUnitOnly;
    [Token(Token = "0x400C66B")]
    [FieldOffset(Offset = "0x44")]
    private int m_CurrentPage;
    [Token(Token = "0x400C66C")]
    [FieldOffset(Offset = "0x48")]
    private int m_MaxPage;
    [Token(Token = "0x400C66D")]
    [FieldOffset(Offset = "0x4C")]
    private int m_UnitId;

    [Token(Token = "0x17001969")]
    private bool IsNoData
    {
      [Token(Token = "0x600BA4C"), Address(RVA = "0x81D620", Offset = "0x81C420", VA = "0x1081D620")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BA4D")]
    [Address(RVA = "0x81B7B0", Offset = "0x81A5B0", VA = "0x1081B7B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA4E")]
    [Address(RVA = "0x81C950", Offset = "0x81B750", VA = "0x1081C950")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BA4F")]
    [Address(RVA = "0x81CC30", Offset = "0x81BA30", VA = "0x1081CC30")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BA50")]
    [Address(RVA = "0x81C5E0", Offset = "0x81B3E0", VA = "0x1081C5E0")]
    private void DisableUnnecessaryUIOnError()
    {
    }

    [Token(Token = "0x600BA51")]
    [Address(RVA = "0x81C790", Offset = "0x81B590", VA = "0x1081C790")]
    private void EnableErrorText(string errorMessage)
    {
    }

    [Token(Token = "0x600BA52")]
    [Address(RVA = "0x81D380", Offset = "0x81C180", VA = "0x1081D380")]
    private void SetActiveUICoponent()
    {
    }

    [Token(Token = "0x600BA53")]
    [Address(RVA = "0x81C830", Offset = "0x81B630", VA = "0x1081C830")]
    private string GetClearedTime(string iso8601String) => (string) null;

    [Token(Token = "0x600BA54")]
    [Address(RVA = "0x81BA20", Offset = "0x81A820", VA = "0x1081BA20")]
    private RecentPartyPanel CreatePartyPanel(RecentPartyList.ViewParam viewParam, int index)
    {
      return (RecentPartyPanel) null;
    }

    [Token(Token = "0x600BA55")]
    [Address(RVA = "0x81B920", Offset = "0x81A720", VA = "0x1081B920")]
    private void CreatePanels()
    {
    }

    [Token(Token = "0x600BA56")]
    [Address(RVA = "0x81C440", Offset = "0x81B240", VA = "0x1081C440")]
    private void DestroyPanels()
    {
    }

    [Token(Token = "0x600BA57")]
    [Address(RVA = "0x81B840", Offset = "0x81A640", VA = "0x1081B840")]
    private void Connect()
    {
    }

    [Token(Token = "0x600BA58")]
    [Address(RVA = "0x81D1C0", Offset = "0x81BFC0", VA = "0x1081D1C0")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600BA59")]
    [Address(RVA = "0x81C260", Offset = "0x81B060", VA = "0x1081C260")]
    private void Deserialize(RecentPartyList.JSON_List[] winRecords)
    {
    }

    [Token(Token = "0x600BA5A")]
    [Address(RVA = "0x81BF80", Offset = "0x81AD80", VA = "0x1081BF80")]
    private UnitData[] Deserialize_Party(Json_Unit[] jsonUnit, JSON_PlayerBuff _playerBuff)
    {
      return (UnitData[]) null;
    }

    [Token(Token = "0x600BA5B")]
    [Address(RVA = "0x81C0E0", Offset = "0x81AEE0", VA = "0x1081C0E0")]
    private SupportData Deserialize_Support(Json_Support json) => (SupportData) null;

    [Token(Token = "0x600BA5C")]
    [Address(RVA = "0x81C140", Offset = "0x81AF40", VA = "0x1081C140")]
    private ItemData[] Deserialize_UsedItems(RecentPartyList.JSON_Item[] jsonItem)
    {
      return (ItemData[]) null;
    }

    [Token(Token = "0x600BA5D")]
    [Address(RVA = "0x81CA60", Offset = "0x81B860", VA = "0x1081CA60")]
    private void OnButtonClick(int index)
    {
    }

    [Token(Token = "0x600BA5E")]
    [Address(RVA = "0x81CC10", Offset = "0x81BA10", VA = "0x1081CC10")]
    public void OnToggleEnabled()
    {
    }

    [Token(Token = "0x600BA5F")]
    [Address(RVA = "0x81CBF0", Offset = "0x81B9F0", VA = "0x1081CBF0")]
    public void OnToggleDisabled()
    {
    }

    [Token(Token = "0x600BA60")]
    [Address(RVA = "0x81CBC0", Offset = "0x81B9C0", VA = "0x1081CBC0")]
    public void OnPrevButtonPressed()
    {
    }

    [Token(Token = "0x600BA61")]
    [Address(RVA = "0x81CB90", Offset = "0x81B990", VA = "0x1081CB90")]
    public void OnNextButtonPressed()
    {
    }

    [Token(Token = "0x600BA62")]
    [Address(RVA = "0x81D570", Offset = "0x81C370", VA = "0x1081D570")]
    public RecentPartyList()
    {
    }

    [Token(Token = "0x2002930")]
    public class JSON_Body
    {
      [Token(Token = "0x400C66E")]
      [FieldOffset(Offset = "0x8")]
      public RecentPartyList.JSON_List[] list;
      [Token(Token = "0x400C66F")]
      [FieldOffset(Offset = "0xC")]
      public RecentPartyList.JSON_Option option;

      [Token(Token = "0x600BA63")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Body()
      {
      }
    }

    [Token(Token = "0x2002931")]
    public class JSON_Option
    {
      [Token(Token = "0x400C670")]
      [FieldOffset(Offset = "0x8")]
      public int totalPage;

      [Token(Token = "0x600BA64")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Option()
      {
      }
    }

    [Token(Token = "0x2002932")]
    public class JSON_List
    {
      [Token(Token = "0x400C671")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400C672")]
      [FieldOffset(Offset = "0xC")]
      public int[] achieved;
      [Token(Token = "0x400C673")]
      [FieldOffset(Offset = "0x10")]
      public string created_at;
      [Token(Token = "0x400C674")]
      [FieldOffset(Offset = "0x14")]
      public RecentPartyList.JSON_Detail detail;

      [Token(Token = "0x600BA65")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_List()
      {
      }
    }

    [Token(Token = "0x2002933")]
    public class JSON_Detail
    {
      [Token(Token = "0x400C675")]
      [FieldOffset(Offset = "0x8")]
      public RecentPartyList.JSON_My my;
      [Token(Token = "0x400C676")]
      [FieldOffset(Offset = "0xC")]
      public Json_Support help;
      [Token(Token = "0x400C677")]
      [FieldOffset(Offset = "0x10")]
      public JSON_PlayerBuff player_buff;
      [Token(Token = "0x400C678")]
      [FieldOffset(Offset = "0x14")]
      public RecentPartyList.JSON_Item[] items;

      [Token(Token = "0x600BA66")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Detail()
      {
      }
    }

    [Token(Token = "0x2002934")]
    public class JSON_My
    {
      [Token(Token = "0x400C679")]
      [FieldOffset(Offset = "0x8")]
      public int lv;
      [Token(Token = "0x400C67A")]
      [FieldOffset(Offset = "0xC")]
      public string name;
      [Token(Token = "0x400C67B")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400C67C")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x600BA67")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_My()
      {
      }
    }

    [Token(Token = "0x2002935")]
    public class JSON_Item
    {
      [Token(Token = "0x400C67D")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400C67E")]
      [FieldOffset(Offset = "0xC")]
      public int num;

      [Token(Token = "0x600BA68")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Item()
      {
      }
    }

    [Token(Token = "0x2002936")]
    private class ViewParam
    {
      [Token(Token = "0x400C67F")]
      [FieldOffset(Offset = "0x8")]
      public UnitData[] m_Units;
      [Token(Token = "0x400C680")]
      [FieldOffset(Offset = "0xC")]
      public SupportData m_Support;
      [Token(Token = "0x400C681")]
      [FieldOffset(Offset = "0x10")]
      public ItemData[] m_UsedItems;
      [Token(Token = "0x400C682")]
      [FieldOffset(Offset = "0x14")]
      public int[] m_Achieves;
      [Token(Token = "0x400C683")]
      [FieldOffset(Offset = "0x18")]
      public string m_CreatedAt;
      [Token(Token = "0x400C684")]
      [FieldOffset(Offset = "0x1C")]
      public string m_Name;
      [Token(Token = "0x400C685")]
      [FieldOffset(Offset = "0x20")]
      public int m_Level;

      [Token(Token = "0x600BA69")]
      [Address(RVA = "0x82A690", Offset = "0x829490", VA = "0x1082A690")]
      public ViewParam()
      {
      }
    }
  }
}

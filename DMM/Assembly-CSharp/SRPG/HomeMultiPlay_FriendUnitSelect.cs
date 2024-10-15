// Decompiled with JetBrains decompiler
// Type: SRPG.HomeMultiPlay_FriendUnitSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002721")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "List Show", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/Multi/HomeMultiPlay_FriendUnitSelect")]
  [FlowNode.Pin(11, "Selected", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "Select", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(5, "Chat Disable", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(3, "List Hide", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Chat Enable", FlowNode.PinTypes.Input, 4)]
  public class HomeMultiPlay_FriendUnitSelect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B85E")]
    private const int PIN_IN_REFRESH_LIST = 1;
    [Token(Token = "0x400B85F")]
    private const int PIN_IN_LIST_SHOW = 2;
    [Token(Token = "0x400B860")]
    private const int PIN_IN_LIST_HIDE = 3;
    [Token(Token = "0x400B861")]
    private const int PIN_IN_CHAT_ENABLE = 4;
    [Token(Token = "0x400B862")]
    private const int PIN_IN_CHAT_DISABLE = 5;
    [Token(Token = "0x400B863")]
    private const int PIN_IN_SELECT_SUPPORT = 10;
    [Token(Token = "0x400B864")]
    private const int PIN_OUT_SELECTED_SUPPORT = 11;
    [Token(Token = "0x400B865")]
    private const float SUPPORT_REFRESH_LOCK_TIME = 10f;
    [Token(Token = "0x400B866")]
    private const string SVB_KEY_EMPTY = "empty";
    [Token(Token = "0x400B867")]
    private const string SVB_KEY_BODY = "body";
    [Token(Token = "0x400B868")]
    private const string SVB_KEY_UNIT_1 = "unit1";
    [Token(Token = "0x400B869")]
    private const string SVB_KEY_UNIT_2 = "unit2";
    [Token(Token = "0x400B86A")]
    private const string SVB_KEY_IS_FRIEND = "isFriend";
    [Token(Token = "0x400B86B")]
    private const string SVB_KEY_COST = "cost";
    [Token(Token = "0x400B86D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ListSingle;
    [Token(Token = "0x400B86E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ListPair;
    [Token(Token = "0x400B86F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ListItemTemplateSingle;
    [Token(Token = "0x400B870")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ListItemTemplatePair;
    [Token(Token = "0x400B871")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button RefreshButton;
    [Token(Token = "0x400B872")]
    [FieldOffset(Offset = "0x20")]
    private List<MultiSupportData> SupportList;
    [Token(Token = "0x400B873")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> ListItems;
    [Token(Token = "0x400B874")]
    [FieldOffset(Offset = "0x28")]
    private float SupportRefreshTime;

    [Token(Token = "0x1700183D")]
    public static HomeMultiPlay_FriendUnitSelect Instance
    {
      [Token(Token = "0x600AF70"), Address(RVA = "0x731AB0", Offset = "0x7308B0", VA = "0x10731AB0")] get
      {
        return (HomeMultiPlay_FriendUnitSelect) null;
      }
      [Token(Token = "0x600AF71"), Address(RVA = "0x731AE0", Offset = "0x7308E0", VA = "0x10731AE0")] private set
      {
      }
    }

    [Token(Token = "0x600AF72")]
    [Address(RVA = "0x7310E0", Offset = "0x72FEE0", VA = "0x107310E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AF73")]
    [Address(RVA = "0x7311B0", Offset = "0x72FFB0", VA = "0x107311B0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AF74")]
    [Address(RVA = "0x731990", Offset = "0x730790", VA = "0x10731990")]
    private void Update()
    {
    }

    [Token(Token = "0x600AF75")]
    [Address(RVA = "0x730FC0", Offset = "0x72FDC0", VA = "0x10730FC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF76")]
    [Address(RVA = "0x731910", Offset = "0x730710", VA = "0x10731910")]
    private void Start()
    {
    }

    [Token(Token = "0x600AF77")]
    [Address(RVA = "0x731810", Offset = "0x730610", VA = "0x10731810")]
    public void SetupSupportList(JSON_MultiSupport[] supports)
    {
    }

    [Token(Token = "0x600AF78")]
    [Address(RVA = "0x7311F0", Offset = "0x72FFF0", VA = "0x107311F0")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x600AF79")]
    [Address(RVA = "0x731520", Offset = "0x730320", VA = "0x10731520")]
    private void SelectSupport()
    {
    }

    [Token(Token = "0x600AF7A")]
    [Address(RVA = "0x731120", Offset = "0x72FF20", VA = "0x10731120")]
    private void ChatEnable(bool enable)
    {
    }

    [Token(Token = "0x600AF7B")]
    [Address(RVA = "0x731A00", Offset = "0x730800", VA = "0x10731A00")]
    public HomeMultiPlay_FriendUnitSelect()
    {
    }
  }
}

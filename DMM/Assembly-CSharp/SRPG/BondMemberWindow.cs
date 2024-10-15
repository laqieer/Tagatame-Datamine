// Decompiled with JetBrains decompiler
// Type: SRPG.BondMemberWindow
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
  [Token(Token = "0x20020C3")]
  [AddComponentMenu("UI/Bond/BondMemberWindow")]
  [FlowNode.Pin(2, "バフターゲット一覧 - 初期化", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "絆グループ一覧 - 初期化", FlowNode.PinTypes.Input, 1)]
  public class BondMemberWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008D60")]
    private const int PIN_INPUT_GROUP_MEMBER = 1;
    [Token(Token = "0x4008D61")]
    private const int PIN_INPUT_BUFF_TARGET = 2;
    [Token(Token = "0x4008D62")]
    private const int LIST_CONTENT_NUM_MAX = 4;
    [Token(Token = "0x4008D63")]
    [FieldOffset(Offset = "0xC")]
    private readonly Color UNIT_ICON_SVN_COLOR;
    [Token(Token = "0x4008D64")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mContentRoot;
    [Token(Token = "0x4008D65")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mContentParent;
    [Token(Token = "0x4008D66")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private UnitIcon mContentTemplate;
    [Token(Token = "0x4008D67")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mContentListRoot;
    [Token(Token = "0x4008D68")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform mContentListParent;
    [Token(Token = "0x4008D69")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitIcon mContentListTemplate;
    [Token(Token = "0x4008D6A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mPopupTitleTxt;
    [Token(Token = "0x4008D6B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mGroupNameRoot;
    [Token(Token = "0x4008D6C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mGroupName;
    [Token(Token = "0x4008D6D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mNotifyRoot;
    [Token(Token = "0x4008D6E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mNotifyText;
    [Token(Token = "0x4008D6F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mBuffArea;
    [Token(Token = "0x4008D70")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mBuffClear;
    [Token(Token = "0x4008D71")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text mGroupBuffLevelTxt;
    [Token(Token = "0x4008D72")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mGroupBuffNameTxt;
    [Token(Token = "0x4008D73")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mGroupBuffExpTxt;
    [Token(Token = "0x4008D74")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Material mUnitIconSVNFilter;

    [Token(Token = "0x600888F")]
    [Address(RVA = "0x49BDF0", Offset = "0x49ABF0", VA = "0x1049BDF0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008890")]
    [Address(RVA = "0x49B4F0", Offset = "0x49A2F0", VA = "0x1049B4F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008891")]
    [Address(RVA = "0x49BE50", Offset = "0x49AC50", VA = "0x1049BE50")]
    private void ViewUpdateBondGroup()
    {
    }

    [Token(Token = "0x6008892")]
    [Address(RVA = "0x49C180", Offset = "0x49AF80", VA = "0x1049C180")]
    private void ViewUpdateBuffTarget()
    {
    }

    [Token(Token = "0x6008893")]
    [Address(RVA = "0x49B520", Offset = "0x49A320", VA = "0x1049B520")]
    private void CreateList(
      List<string> unit_inames,
      bool is_member_detail,
      List<string> target_unit_inames)
    {
    }

    [Token(Token = "0x6008894")]
    [Address(RVA = "0x49C5A0", Offset = "0x49B3A0", VA = "0x1049C5A0")]
    public BondMemberWindow()
    {
    }
  }
}

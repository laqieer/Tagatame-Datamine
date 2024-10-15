// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A4E")]
  [FlowNode.Pin(1, "返却アイテム通信準備", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "初期化開始", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "リセット通信準備", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(101, "返却アイテム通信開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "初期化完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "リセット通信開始", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "代用品確認", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(4, "スクロール位置リセット", FlowNode.PinTypes.Input, 4)]
  public class RunePrideResetWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CDE0")]
    private const int PIN_INPUT_RESET_CHECK = 1;
    [Token(Token = "0x400CDE1")]
    private const int PIN_INPUT_INIT = 2;
    [Token(Token = "0x400CDE2")]
    private const int PIN_INPUT_RESET_START = 3;
    [Token(Token = "0x400CDE3")]
    private const int PIN_INPUT_RESETPOSITION = 4;
    [Token(Token = "0x400CDE4")]
    private const int PIN_OUTPUT_CONNECT_RETURN_ITEM = 101;
    [Token(Token = "0x400CDE5")]
    private const int PIN_OUTPUT_INIT_END = 102;
    [Token(Token = "0x400CDE6")]
    private const int PIN_OUTPUT_CONNECT_RESET = 103;
    [Token(Token = "0x400CDE7")]
    private const int PIN_OUTPUT_REPLEACE_CHECK = 104;
    [Token(Token = "0x400CDE8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CDE9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideReturnItemListView ReturnListView;
    [Token(Token = "0x400CDEA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RunePrideNeedItemListView NeedListView;
    [Token(Token = "0x400CDEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValue;
    [Token(Token = "0x400CDEC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ScrollRect ScrollHorizontal;
    [Token(Token = "0x400CDED")]
    [FieldOffset(Offset = "0x20")]
    private RunePrideResetWindowModel mModel;
    [Token(Token = "0x400CDEE")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mUnitData;
    [Token(Token = "0x400CDEF")]
    [FieldOffset(Offset = "0x28")]
    private string mTargetIname;
    [Token(Token = "0x400CDF0")]
    [FieldOffset(Offset = "0x2C")]
    private List<string> mSubInames;
    [Token(Token = "0x400CDF1")]
    [FieldOffset(Offset = "0x30")]
    private int mReplaceNum;

    [Token(Token = "0x600C10A")]
    [Address(RVA = "0x897420", Offset = "0x896220", VA = "0x10897420", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C10B")]
    [Address(RVA = "0x897400", Offset = "0x896200", VA = "0x10897400", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C10C")]
    [Address(RVA = "0x897660", Offset = "0x896460", VA = "0x10897660")]
    public void BranchCostConfirmBox()
    {
    }

    [Token(Token = "0x600C10D")]
    [Address(RVA = "0x898170", Offset = "0x896F70", VA = "0x10898170")]
    private void Init(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x600C10E")]
    [Address(RVA = "0x8980F0", Offset = "0x896EF0", VA = "0x108980F0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600C10F")]
    [Address(RVA = "0x897F90", Offset = "0x896D90", VA = "0x10897F90")]
    private void ConnectReturnItem()
    {
    }

    [Token(Token = "0x600C110")]
    [Address(RVA = "0x897E60", Offset = "0x896C60", VA = "0x10897E60")]
    private void ConnectResetBoard()
    {
    }

    [Token(Token = "0x600C111")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideResetWindow()
    {
    }
  }
}

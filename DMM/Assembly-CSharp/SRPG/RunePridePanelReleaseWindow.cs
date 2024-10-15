// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelReleaseWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A25")]
  [FlowNode.Pin(1002, "代用品確認", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1001, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "解放ボタンタップ", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "選択解除", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1000, "開放開始", FlowNode.PinTypes.Output, 1000)]
  public class RunePridePanelReleaseWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CCBD")]
    private const int PIN_INPUT_PANEL_SELECTED = 1;
    [Token(Token = "0x400CCBE")]
    private const int PIN_INPUT_PANEL_REMOVED = 2;
    [Token(Token = "0x400CCBF")]
    private const int PIN_INPUT_ENHANCE_BUTTON = 3;
    [Token(Token = "0x400CCC0")]
    private const int PIN_OUTPUT_ENHANCE_START = 1000;
    [Token(Token = "0x400CCC1")]
    private const int PIN_OUTPUT_CLOSE_WINDOW = 1001;
    [Token(Token = "0x400CCC2")]
    private const int PIN_OUTPUT_REPLACE_CHECK = 1002;
    [Token(Token = "0x400CCC3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ReleaseWindowExhibitList;
    [Token(Token = "0x400CCC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideParameterListView parameterListView;
    [Token(Token = "0x400CCC5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RunePrideNeedItemListView needItemView;
    [Token(Token = "0x400CCC6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValue;
    [Token(Token = "0x400CCC7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsReleasePanelOpen;
    [Token(Token = "0x400CCC8")]
    [FieldOffset(Offset = "0x1D")]
    private bool canOpen;
    [Token(Token = "0x400CCC9")]
    [FieldOffset(Offset = "0x20")]
    private UnitData currentUnit;
    [Token(Token = "0x400CCCA")]
    [FieldOffset(Offset = "0x24")]
    private string panelIname;
    [Token(Token = "0x400CCCB")]
    [FieldOffset(Offset = "0x28")]
    private int panelId;
    [Token(Token = "0x400CCCC")]
    [FieldOffset(Offset = "0x2C")]
    private List<int> panelIds;
    [Token(Token = "0x400CCCD")]
    [FieldOffset(Offset = "0x30")]
    private List<int> mSelectIds;
    [Token(Token = "0x400CCCE")]
    [FieldOffset(Offset = "0x34")]
    private List<RunePrideItemData> mSelectItemList;
    [Token(Token = "0x400CCCF")]
    [FieldOffset(Offset = "0x38")]
    private RunePrideBaseNeedItemWindowModel mModel;

    [Token(Token = "0x600C012")]
    [Address(RVA = "0x887260", Offset = "0x886060", VA = "0x10887260", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C013")]
    [Address(RVA = "0x8872A0", Offset = "0x8860A0", VA = "0x108872A0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C014")]
    [Address(RVA = "0x887C80", Offset = "0x886A80", VA = "0x10887C80")]
    public bool IsExistCostItemType(RaidRewardType type) => new bool();

    [Token(Token = "0x600C015")]
    [Address(RVA = "0x888010", Offset = "0x886E10", VA = "0x10888010")]
    public void MakeCostConfirmBox()
    {
    }

    [Token(Token = "0x600C016")]
    [Address(RVA = "0x888890", Offset = "0x887690", VA = "0x10888890")]
    public void PanelSelected(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C017")]
    [Address(RVA = "0x8887B0", Offset = "0x8875B0", VA = "0x108887B0")]
    private void PanelRemoved(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C018")]
    [Address(RVA = "0x887A60", Offset = "0x886860", VA = "0x10887A60")]
    private void ExhibitDraw()
    {
    }

    [Token(Token = "0x600C019")]
    [Address(RVA = "0x8875A0", Offset = "0x8863A0", VA = "0x108875A0")]
    private void AddParameterList()
    {
    }

    [Token(Token = "0x600C01A")]
    [Address(RVA = "0x889110", Offset = "0x887F10", VA = "0x10889110")]
    private void RemoveParameterList()
    {
    }

    [Token(Token = "0x600C01B")]
    [Address(RVA = "0x8873A0", Offset = "0x8861A0", VA = "0x108873A0")]
    private void AddNeedItem()
    {
    }

    [Token(Token = "0x600C01C")]
    [Address(RVA = "0x888D90", Offset = "0x887B90", VA = "0x10888D90")]
    private void RemoveNeedItem()
    {
    }

    [Token(Token = "0x600C01D")]
    [Address(RVA = "0x887730", Offset = "0x886530", VA = "0x10887730")]
    private void AddSelect()
    {
    }

    [Token(Token = "0x600C01E")]
    [Address(RVA = "0x889430", Offset = "0x888230", VA = "0x10889430")]
    private void RemoveSelect()
    {
    }

    [Token(Token = "0x600C01F")]
    [Address(RVA = "0x887D40", Offset = "0x886B40", VA = "0x10887D40")]
    public bool IsReleasePanel(string _panelIname, List<int> _list) => new bool();

    [Token(Token = "0x600C020")]
    [Address(RVA = "0x888540", Offset = "0x887340", VA = "0x10888540")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x600C021")]
    [Address(RVA = "0x887B60", Offset = "0x886960", VA = "0x10887B60")]
    private RunePridePanelContentsParam GetPanelContentsParam()
    {
      return (RunePridePanelContentsParam) null;
    }

    [Token(Token = "0x600C022")]
    [Address(RVA = "0x888C30", Offset = "0x887A30", VA = "0x10888C30")]
    private bool RefreshCurrentUnit() => new bool();

    [Token(Token = "0x600C023")]
    [Address(RVA = "0x889870", Offset = "0x888670", VA = "0x10889870")]
    public RunePridePanelReleaseWindow()
    {
    }
  }
}

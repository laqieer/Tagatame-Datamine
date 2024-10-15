// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalEquipSelectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022B8")]
  [FlowNode.Pin(102, "セットボーナス一覧展開", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "水晶装備", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/CrystalEquipSelectWindow")]
  [FlowNode.Pin(4, "名称検索入力", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "セットボーナス一覧", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "OKボタン押した", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "リスト更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "ウィンドウ閉じる", FlowNode.PinTypes.Output, 100)]
  public class CrystalEquipSelectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A88")]
    private const int PIN_INPUT_LIST_REFRESH = 1;
    [Token(Token = "0x4009A89")]
    private const int PIN_INPUT_OK_BUTTON = 2;
    [Token(Token = "0x4009A8A")]
    private const int PIN_INPUT_SET_BONUS_LIST = 3;
    [Token(Token = "0x4009A8B")]
    private const int PIN_INPUT_NAME_SEARCH_INPUT = 4;
    [Token(Token = "0x4009A8C")]
    private const int PIN_OUTPUT_CLOSE = 100;
    [Token(Token = "0x4009A8D")]
    private const int PIN_OUTPUT_EQUIP = 101;
    [Token(Token = "0x4009A8E")]
    private const int PIN_OUTPUT_SET_BONUS_LIST = 102;
    [Token(Token = "0x4009A8F")]
    private const string NAME_SEARCH_SELECT_UI_PATH = "UI/NameSearchBox/namesearch_select_crystal";
    [Token(Token = "0x4009A90")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x4009A91")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalIcon SelectIcon;
    [Token(Token = "0x4009A92")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalScrollList ScrollList;
    [Token(Token = "0x4009A93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CrystalStatusList StatusList;
    [Token(Token = "0x4009A94")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle ExcludeEquipToggle;
    [Token(Token = "0x4009A95")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform NameBoxParent;
    [Token(Token = "0x4009A96")]
    [FieldOffset(Offset = "0x24")]
    private CrystalEquipSelectWindowModel mModel;
    [Token(Token = "0x4009A97")]
    [FieldOffset(Offset = "0x28")]
    private CrystalData mData;
    [Token(Token = "0x4009A98")]
    [FieldOffset(Offset = "0x2C")]
    private int mSlotIndex;
    [Token(Token = "0x4009A99")]
    [FieldOffset(Offset = "0x30")]
    private UnitData mUnitData;
    [Token(Token = "0x4009A9A")]
    [FieldOffset(Offset = "0x34")]
    private CrystalData mSelectData;
    [Token(Token = "0x4009A9B")]
    [FieldOffset(Offset = "0x38")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x4009A9C")]
    [FieldOffset(Offset = "0x3C")]
    private string mNameSearchInput;
    [Token(Token = "0x4009A9D")]
    [FieldOffset(Offset = "0x40")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x6009500")]
    [Address(RVA = "0x57E050", Offset = "0x57CE50", VA = "0x1057E050", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009501")]
    [Address(RVA = "0x57E700", Offset = "0x57D500", VA = "0x1057E700")]
    public void Init(UnitData _unit, int _slot_index)
    {
    }

    [Token(Token = "0x6009502")]
    [Address(RVA = "0x57E290", Offset = "0x57D090", VA = "0x1057E290")]
    private void CreateList()
    {
    }

    [Token(Token = "0x6009503")]
    [Address(RVA = "0x57E5B0", Offset = "0x57D3B0", VA = "0x1057E5B0")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009504")]
    [Address(RVA = "0x57EBB0", Offset = "0x57D9B0", VA = "0x1057EBB0")]
    private void ListRefresh()
    {
    }

    [Token(Token = "0x6009505")]
    [Address(RVA = "0x57E210", Offset = "0x57D010", VA = "0x1057E210")]
    private void ChangeExcludeEquip(bool value = false)
    {
    }

    [Token(Token = "0x6009506")]
    [Address(RVA = "0x57EA00", Offset = "0x57D800", VA = "0x1057EA00")]
    private void ItemSelect()
    {
    }

    [Token(Token = "0x6009507")]
    [Address(RVA = "0x57EF60", Offset = "0x57DD60", VA = "0x1057EF60")]
    private void RemoveSelect()
    {
    }

    [Token(Token = "0x6009508")]
    [Address(RVA = "0x57EC40", Offset = "0x57DA40", VA = "0x1057EC40")]
    private void OnClickOK()
    {
    }

    [Token(Token = "0x6009509")]
    [Address(RVA = "0x57EC20", Offset = "0x57DA20", VA = "0x1057EC20")]
    private void OnClickAnothoerUnitEquipConfirmOk(GameObject go)
    {
    }

    [Token(Token = "0x600950A")]
    [Address(RVA = "0x57EC20", Offset = "0x57DA20", VA = "0x1057EC20")]
    private void OnClickSameInameConfirmOk(GameObject go)
    {
    }

    [Token(Token = "0x600950B")]
    [Address(RVA = "0x57EFB0", Offset = "0x57DDB0", VA = "0x1057EFB0")]
    private void SelectSetBonusListBtn()
    {
    }

    [Token(Token = "0x600950C")]
    [Address(RVA = "0x57F130", Offset = "0x57DF30", VA = "0x1057F130")]
    private void StartConnectCrystalEquip(bool _is_remove)
    {
    }

    [Token(Token = "0x600950D")]
    [Address(RVA = "0x57E630", Offset = "0x57D430", VA = "0x1057E630")]
    private JSON_CrystalUnitSetReq GetReplaceData() => (JSON_CrystalUnitSetReq) null;

    [Token(Token = "0x600950E")]
    [Address(RVA = "0x57E490", Offset = "0x57D290", VA = "0x1057E490")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600950F")]
    [Address(RVA = "0x57F060", Offset = "0x57DE60", VA = "0x1057F060")]
    public void SetNameSearchText()
    {
    }

    [Token(Token = "0x6009510")]
    [Address(RVA = "0x57F8A0", Offset = "0x57E6A0", VA = "0x1057F8A0")]
    public CrystalEquipSelectWindow()
    {
    }
  }
}

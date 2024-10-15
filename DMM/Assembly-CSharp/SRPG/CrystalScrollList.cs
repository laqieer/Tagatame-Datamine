// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalScrollList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002294")]
  [AddComponentMenu("UI/CrystalScrollList")]
  public class CrystalScrollList : MonoBehaviour
  {
    [Token(Token = "0x400999E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400999F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentController ContentController;
    [Token(Token = "0x40099A0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool IsHaveCountEnable;
    [Token(Token = "0x40099A1")]
    [FieldOffset(Offset = "0x18")]
    private CrystalScrollListModel mModel;
    [Token(Token = "0x40099A2")]
    [FieldOffset(Offset = "0x1C")]
    private List<CrystalListItemParam> mListItem;
    [Token(Token = "0x40099A3")]
    [FieldOffset(Offset = "0x20")]
    private List<CrystalListItemParam> mSelectItemList;
    [Token(Token = "0x40099A4")]
    [FieldOffset(Offset = "0x24")]
    private List<CrystalData> mDispDataList;
    [Token(Token = "0x40099A5")]
    [FieldOffset(Offset = "0x28")]
    private List<CrystalParam> mDispParamList;
    [Token(Token = "0x40099A6")]
    [FieldOffset(Offset = "0x2C")]
    private CrystalScrollList.ListType mType;
    [Token(Token = "0x40099A7")]
    [FieldOffset(Offset = "0x30")]
    private UnitData mUnitData;
    [Token(Token = "0x40099A8")]
    [FieldOffset(Offset = "0x34")]
    private UnityAction mCallback;
    [Token(Token = "0x40099A9")]
    [FieldOffset(Offset = "0x38")]
    private UnityAction mRemoveEquipCallback;
    [Token(Token = "0x40099AA")]
    [FieldOffset(Offset = "0x3C")]
    private bool mMultiSelect;
    [Token(Token = "0x40099AB")]
    [FieldOffset(Offset = "0x3D")]
    private bool mRemoveEquipDisp;
    [Token(Token = "0x40099AC")]
    [FieldOffset(Offset = "0x40")]
    private CrystalData.ESlotIndex mSelectIndex;
    [Token(Token = "0x40099AD")]
    [FieldOffset(Offset = "0x44")]
    private string mNameSearchString;
    [Token(Token = "0x40099AE")]
    [FieldOffset(Offset = "0x48")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x40099AF")]
    [FieldOffset(Offset = "0x4C")]
    private int mMultiSelectMax;
    [Token(Token = "0x40099B0")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsDispSelectedFrame;

    [Token(Token = "0x170014CD")]
    public CrystalScrollList.ListType Type
    {
      [Token(Token = "0x6009410"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new CrystalScrollList.ListType();
      }
    }

    [Token(Token = "0x170014CE")]
    public int MultiSelectMax
    {
      [Token(Token = "0x6009411"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170014CF")]
    public bool IsDispSelectedFrame
    {
      [Token(Token = "0x6009412"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009413")]
    [Address(RVA = "0x570EC0", Offset = "0x56FCC0", VA = "0x10570EC0")]
    public List<CrystalListItemParam> GetListItems() => (List<CrystalListItemParam>) null;

    [Token(Token = "0x6009414")]
    [Address(RVA = "0x5710F0", Offset = "0x56FEF0", VA = "0x105710F0")]
    public List<CrystalData> GetSelectDataList() => (List<CrystalData>) null;

    [Token(Token = "0x6009415")]
    [Address(RVA = "0x571290", Offset = "0x570090", VA = "0x10571290")]
    public List<CrystalParam> GetSelectParamList() => (List<CrystalParam>) null;

    [Token(Token = "0x6009416")]
    [Address(RVA = "0x571090", Offset = "0x56FE90", VA = "0x10571090")]
    public CrystalData GetSelectDataFirst() => (CrystalData) null;

    [Token(Token = "0x6009417")]
    [Address(RVA = "0x571050", Offset = "0x56FE50", VA = "0x10571050")]
    public int GetSelectCount() => new int();

    [Token(Token = "0x6009418")]
    [Address(RVA = "0x572430", Offset = "0x571230", VA = "0x10572430")]
    public void SetSelectList(List<CrystalData> _crystal_datas)
    {
    }

    [Token(Token = "0x6009419")]
    [Address(RVA = "0x572260", Offset = "0x571060", VA = "0x10572260")]
    public void SetList(
      CrystalScrollList.ListType _type,
      List<CrystalData> _crystal_datas,
      int _select_max,
      bool _is_selected_disp,
      UnityAction _item_callback)
    {
    }

    [Token(Token = "0x600941A")]
    [Address(RVA = "0x5722B0", Offset = "0x5710B0", VA = "0x105722B0")]
    public void SetList(
      CrystalScrollList.ListType _type,
      UnityAction _item_callback,
      UnityAction _remove_equip_callback = null,
      bool _is_remove_equip_disp = false,
      UnitData _unit_data = null,
      CrystalData _equip_data = null,
      CrystalData.ESlotIndex _select_index = CrystalData.ESlotIndex.NONE)
    {
    }

    [Token(Token = "0x600941B")]
    [Address(RVA = "0x571820", Offset = "0x570620", VA = "0x10571820")]
    public void ListRefresh()
    {
    }

    [Token(Token = "0x600941C")]
    [Address(RVA = "0x5716E0", Offset = "0x5704E0", VA = "0x105716E0")]
    public void ItemRefresh()
    {
    }

    [Token(Token = "0x600941D")]
    [Address(RVA = "0x5715D0", Offset = "0x5703D0", VA = "0x105715D0")]
    public void ItemRefreshByCrystalData(CrystalData _data)
    {
    }

    [Token(Token = "0x600941E")]
    [Address(RVA = "0x570430", Offset = "0x56F230", VA = "0x10570430")]
    private void CreateList()
    {
    }

    [Token(Token = "0x600941F")]
    [Address(RVA = "0x5703D0", Offset = "0x56F1D0", VA = "0x105703D0")]
    public void ClearSelect()
    {
    }

    [Token(Token = "0x6009420")]
    [Address(RVA = "0x571C50", Offset = "0x570A50", VA = "0x10571C50")]
    private void ReDrawItem(CrystalParam _param)
    {
    }

    [Token(Token = "0x6009421")]
    [Address(RVA = "0x571430", Offset = "0x570230", VA = "0x10571430")]
    public void ItemButtonEvent(CrystalListItemParam _param)
    {
    }

    [Token(Token = "0x6009422")]
    [Address(RVA = "0x571D40", Offset = "0x570B40", VA = "0x10571D40")]
    public void RemoveSelectData(CrystalData _data)
    {
    }

    [Token(Token = "0x6009423")]
    [Address(RVA = "0x572900", Offset = "0x571700", VA = "0x10572900")]
    private void UpdateSelectList(CrystalListItemParam _param)
    {
    }

    [Token(Token = "0x6009424")]
    [Address(RVA = "0x571D20", Offset = "0x570B20", VA = "0x10571D20")]
    public void RemoveEquipEvent()
    {
    }

    [Token(Token = "0x6009425")]
    [Address(RVA = "0x571E20", Offset = "0x570C20", VA = "0x10571E20")]
    public void SaleAllSelect()
    {
    }

    [Token(Token = "0x6009426")]
    [Address(RVA = "0x5720E0", Offset = "0x570EE0", VA = "0x105720E0")]
    public void SaleSelectListUpdate()
    {
    }

    [Token(Token = "0x6009427")]
    [Address(RVA = "0x5725B0", Offset = "0x5713B0", VA = "0x105725B0")]
    private void Sort()
    {
    }

    [Token(Token = "0x6009428")]
    [Address(RVA = "0x570E30", Offset = "0x56FC30", VA = "0x10570E30")]
    private void Filter()
    {
    }

    [Token(Token = "0x6009429")]
    [Address(RVA = "0x570930", Offset = "0x56F730", VA = "0x10570930")]
    private void EquipFilter()
    {
    }

    [Token(Token = "0x600942A")]
    [Address(RVA = "0x570A40", Offset = "0x56F840", VA = "0x10570A40")]
    private void EquipmentSort()
    {
    }

    [Token(Token = "0x600942B")]
    [Address(RVA = "0x5708B0", Offset = "0x56F6B0", VA = "0x105708B0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600942C")]
    [Address(RVA = "0x572400", Offset = "0x571200", VA = "0x10572400")]
    public void SetNameSearchText(string _input, SearchUtility.CONDITIONS _type)
    {
    }

    [Token(Token = "0x600942D")]
    [Address(RVA = "0x572A50", Offset = "0x571850", VA = "0x10572A50")]
    public CrystalScrollList()
    {
    }

    [Token(Token = "0x2002295")]
    public enum ListType
    {
      [Token(Token = "0x40099B2")] ALL,
      [Token(Token = "0x40099B3")] SALE,
      [Token(Token = "0x40099B4")] EQUIP,
      [Token(Token = "0x40099B5")] RANKUP,
      [Token(Token = "0x40099B6")] GRADEUP,
      [Token(Token = "0x40099B7")] GALLERY,
      [Token(Token = "0x40099B8")] GACHA,
    }
  }
}

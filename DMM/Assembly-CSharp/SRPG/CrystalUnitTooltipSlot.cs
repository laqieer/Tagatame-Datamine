// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalUnitTooltipSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022A3")]
  public class CrystalUnitTooltipSlot : MonoBehaviour
  {
    [Token(Token = "0x40099D4")]
    [FieldOffset(Offset = "0xC")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string CRYSTAL_EQUIP_WINDOW_PREFAB_PATH;
    [Token(Token = "0x40099D5")]
    [FieldOffset(Offset = "0x10")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string CRYSTAL_LOCK_TOOLTIP_PREFAB_PATH;
    [Token(Token = "0x40099D6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalEquipSlot CrystalSlot;
    [Token(Token = "0x40099D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ToolTipObj;
    [Token(Token = "0x40099D8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject HideIcon;
    [Token(Token = "0x40099D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsHideFlag;
    [Token(Token = "0x40099DA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private UnitToolTipWindowEx mToolTipWindowEx;
    [Token(Token = "0x40099DB")]
    [FieldOffset(Offset = "0x28")]
    private UnitData mUnit;
    [Token(Token = "0x40099DC")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsEditMode;
    [Token(Token = "0x40099DD")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsHideMode;
    [Token(Token = "0x40099DE")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mWindowObj;
    [Token(Token = "0x40099DF")]
    [FieldOffset(Offset = "0x34")]
    private Tooltip mCrystalSlotLockTooltip;
    [Token(Token = "0x40099E0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Vector2 mCrystalLockTextPos;

    [Token(Token = "0x600944F")]
    [Address(RVA = "0x574080", Offset = "0x572E80", VA = "0x10574080")]
    private void Start()
    {
    }

    [Token(Token = "0x6009450")]
    [Address(RVA = "0x574080", Offset = "0x572E80", VA = "0x10574080")]
    private void InitializeSlots()
    {
    }

    [Token(Token = "0x6009451")]
    [Address(RVA = "0x574130", Offset = "0x572F30", VA = "0x10574130")]
    public void Initialize(bool isHide = false)
    {
    }

    [Token(Token = "0x6009452")]
    [Address(RVA = "0x574430", Offset = "0x573230", VA = "0x10574430")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009453")]
    [Address(RVA = "0x5749B0", Offset = "0x5737B0", VA = "0x105749B0")]
    public void Refresh(bool editMode)
    {
    }

    [Token(Token = "0x6009454")]
    [Address(RVA = "0x574A30", Offset = "0x573830", VA = "0x10574A30")]
    public void Refresh(UnitData unitData, bool editMode)
    {
    }

    [Token(Token = "0x6009455")]
    [Address(RVA = "0x5747A0", Offset = "0x5735A0", VA = "0x105747A0")]
    private void RefreshSlots(
      CrystalEquipSlot _slot,
      CrystalData _data,
      bool _is_lock,
      bool _is_edit)
    {
    }

    [Token(Token = "0x6009456")]
    [Address(RVA = "0x574480", Offset = "0x573280", VA = "0x10574480")]
    private void OnEquipCardSlot(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x6009457")]
    [Address(RVA = "0x574140", Offset = "0x572F40", VA = "0x10574140")]
    private void OnCloseEquipCrystalWindow()
    {
    }

    [Token(Token = "0x6009458")]
    [Address(RVA = "0x573DD0", Offset = "0x572BD0", VA = "0x10573DD0")]
    private void CreateCrystalDisableTooltip()
    {
    }

    [Token(Token = "0x6009459")]
    [Address(RVA = "0x574C00", Offset = "0x573A00", VA = "0x10574C00")]
    public CrystalUnitTooltipSlot()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.RuneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029B6")]
  [AddComponentMenu("UI/Rune/RuneManager")]
  public class RuneManager : MonoBehaviour
  {
    [Token(Token = "0x400CA33")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneInventory mRuneInventory;
    [Token(Token = "0x400CA34")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneSlotSelector mRuneSlotSelector;
    [Token(Token = "0x400CA35")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEbaleSetEff mRuneDrawEbaleSetEff;
    [Token(Token = "0x400CA36")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool mIsReplaseRune;
    [Token(Token = "0x400CA37")]
    public const string PREFAB_PATH_RUNE_SELECTABLE_LIST_WINDOW = "UI/Rune/RuneSelectableListWindow";
    [Token(Token = "0x400CA38")]
    public const string PREFAB_PATH_RUNE_EQUIP_WINDOW = "UI/Rune/RuneEquipWindow";
    [Token(Token = "0x400CA39")]
    public const string PREFAB_PATH_RUNE_ENHANCE_WINDOW = "UI/Rune/RuneEnhanceWindow";
    [Token(Token = "0x400CA3A")]
    public const string PREFAB_PATH_RUNE_ENHANCE_EFFECT = "UI/Rune/RuneEnhanceEffect";
    [Token(Token = "0x400CA3B")]
    public const string PREFAB_PATH_RUNE_EVO_WINDOW = "UI/Rune/RuneEvoWindow";
    [Token(Token = "0x400CA3C")]
    public const string PREFAB_PATH_RUNE_DISASSEMBLY_WINDOW = "UI/Rune/RuneDisassemblyWindow";
    [Token(Token = "0x400CA3D")]
    public const string PREFAB_PATH_RUNE_DISASSEMBLY_EFF_WINDOW = "UI/Rune/RuneDisassemblyEffect";
    [Token(Token = "0x400CA3E")]
    public const string PREFAB_PATH_RUNE_RESET_STATUS_WINDOW = "UI/Rune/RuneResetStatusWindow";
    [Token(Token = "0x400CA3F")]
    public const string PREFAB_PATH_RUNE_EVO_EFFECT = "UI/Rune/RuneEvoEffect";
    [Token(Token = "0x400CA40")]
    public const string PREFAB_PATH_RUNE_PARAM_ENH_EFFECT = "UI/Rune/RuneEnhanceStatusEvoEffect";
    [Token(Token = "0x400CA41")]
    public const string PREFAB_PATH_RUNEPRIDE_RELEASE_WINDOW = "UI/RunePride/RunePrideReleaseConfirmWindow";
    [Token(Token = "0x400CA42")]
    public const string PREFAB_PATH_RUNEPRIDE_PARAMETER_WINDOW = "UI/RunePride/RunePrideEnhanceWindow";
    [Token(Token = "0x400CA43")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400CA44")]
    [FieldOffset(Offset = "0x20")]
    private List<BindRuneData> mPlayerRuneList;
    [Token(Token = "0x400CA45")]
    [FieldOffset(Offset = "0x24")]
    private RuneSelectableListWindow mRuneSelectableListWindow;
    [Token(Token = "0x400CA46")]
    [FieldOffset(Offset = "0x28")]
    private BindRuneData[] mEquipSelectedRune;
    [Token(Token = "0x400CA47")]
    [FieldOffset(Offset = "0x2C")]
    private RuneEquipWindow[] mRuneEquipWindow;
    [Token(Token = "0x400CA48")]
    [FieldOffset(Offset = "0x30")]
    private RuneEnhanceWindow mRuneEnhanceWindow;
    [Token(Token = "0x400CA49")]
    [FieldOffset(Offset = "0x34")]
    private RuneEnhanceEffectWindow mRuneEnhanceEffectWindow;
    [Token(Token = "0x400CA4A")]
    [FieldOffset(Offset = "0x38")]
    private RuneEvoWindow mRuneEvoWindow;
    [Token(Token = "0x400CA4B")]
    [FieldOffset(Offset = "0x3C")]
    private RuneEvoEffectWindow mRuneEvoEffectWindow;
    [Token(Token = "0x400CA4C")]
    [FieldOffset(Offset = "0x40")]
    private RuneDisassemblyWindow mRuneDisassemblyWindow;
    [Token(Token = "0x400CA4D")]
    [FieldOffset(Offset = "0x44")]
    private RuneDisassemblyEffectWindow mRuneDisassemblyEffectWindow;
    [Token(Token = "0x400CA4E")]
    [FieldOffset(Offset = "0x48")]
    private RuneResetStatusWindow mRuneResetStatusWindow;
    [Token(Token = "0x400CA4F")]
    [FieldOffset(Offset = "0x4C")]
    private RuneParamEnhEvoEffectWindow mRuneParamEnhEvoEffectWindow;
    [Token(Token = "0x400CA50")]
    [FieldOffset(Offset = "0x50")]
    private RunePrideReleaseWindow mRunePrideReleaseWindow;
    [Token(Token = "0x400CA51")]
    [FieldOffset(Offset = "0x54")]
    private RunePrideParameterWindow mRunePrideParameterWindow;
    [Token(Token = "0x400CA52")]
    [FieldOffset(Offset = "0x58")]
    private RuneManager.Mode mMode;
    [Token(Token = "0x400CA53")]
    [FieldOffset(Offset = "0x5C")]
    private RuneEnhanceSettings mEnhanceSettings;
    [Token(Token = "0x400CA54")]
    [FieldOffset(Offset = "0x60")]
    public RuneManager.DrawType mDrawType;
    [Token(Token = "0x400CA55")]
    [FieldOffset(Offset = "0x64")]
    private UnitOverWriteCache mUnitOverWriteCacheData;
    [Token(Token = "0x400CA56")]
    [FieldOffset(Offset = "0x0")]
    private static RuneManager mInstance;
    [Token(Token = "0x400CA57")]
    [FieldOffset(Offset = "0x68")]
    public bool IsDisableUnitLoad;

    [Token(Token = "0x17001998")]
    public RuneSelectableListWindow RuneSelectableListWindow
    {
      [Token(Token = "0x600BD8E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (RuneSelectableListWindow) null;
      }
    }

    [Token(Token = "0x17001999")]
    public RuneEnhanceSettings EnhanceSettings
    {
      [Token(Token = "0x600BD8F"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (RuneEnhanceSettings) null;
      }
    }

    [Token(Token = "0x1700199A")]
    public UnitOverWriteCache UnitOverWriteCacheData
    {
      [Token(Token = "0x600BD90"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return (UnitOverWriteCache) null;
      }
    }

    [Token(Token = "0x1700199B")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x600BD91"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x1700199C")]
    public static RuneManager Instance
    {
      [Token(Token = "0x600BD92"), Address(RVA = "0x853F90", Offset = "0x852D90", VA = "0x10853F90")] get
      {
        return (RuneManager) null;
      }
    }

    [Token(Token = "0x600BD93")]
    [Address(RVA = "0x8507E0", Offset = "0x84F5E0", VA = "0x108507E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BD94")]
    [Address(RVA = "0x851130", Offset = "0x84FF30", VA = "0x10851130")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BD95")]
    [Address(RVA = "0x850F40", Offset = "0x84FD40", VA = "0x10850F40")]
    public BindRuneData FindRune(RuneData rune) => (BindRuneData) null;

    [Token(Token = "0x600BD96")]
    [Address(RVA = "0x853B30", Offset = "0x852930", VA = "0x10853B30")]
    public void SetDoEquipment(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BD97")]
    [Address(RVA = "0x853BE0", Offset = "0x8529E0", VA = "0x10853BE0")]
    public void SetDoUnEquipment(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BD98")]
    [Address(RVA = "0x853B90", Offset = "0x852990", VA = "0x10853B90")]
    public void SetDoUnEquipmentAll()
    {
    }

    [Token(Token = "0x600BD99")]
    [Address(RVA = "0x852B90", Offset = "0x851990", VA = "0x10852B90")]
    public void RefreshRuneEquipFinished()
    {
    }

    [Token(Token = "0x600BD9A")]
    [Address(RVA = "0x8530C0", Offset = "0x851EC0", VA = "0x108530C0")]
    public void RefreshSelectableList()
    {
    }

    [Token(Token = "0x600BD9B")]
    [Address(RVA = "0x8510E0", Offset = "0x84FEE0", VA = "0x108510E0")]
    private bool IsRuneOwnerIsCurrentUnit(BindRuneData runeData) => new bool();

    [Token(Token = "0x600BD9C")]
    [Address(RVA = "0x8528D0", Offset = "0x8516D0", VA = "0x108528D0")]
    public void RefreshRuneEnhanceFinished()
    {
    }

    [Token(Token = "0x600BD9D")]
    [Address(RVA = "0x852C30", Offset = "0x851A30", VA = "0x10852C30")]
    public void RefreshRuneEvoFinished(BindRuneData before_rune, BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600BD9E")]
    [Address(RVA = "0x852480", Offset = "0x851280", VA = "0x10852480")]
    public void RefreshRuneContinueReinforcementFinished(
      BindRuneData before_rune,
      BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600BD9F")]
    [Address(RVA = "0x852560", Offset = "0x851360", VA = "0x10852560")]
    public void RefreshRuneDisassemblyFinished(ReqRuneDisassembly.Response res)
    {
    }

    [Token(Token = "0x600BDA0")]
    [Address(RVA = "0x852DD0", Offset = "0x851BD0", VA = "0x10852DD0")]
    public void RefreshRuneParamEnhFinished()
    {
    }

    [Token(Token = "0x600BDA1")]
    [Address(RVA = "0x851010", Offset = "0x84FE10", VA = "0x10851010")]
    public void Initialize(UnitData unit)
    {
    }

    [Token(Token = "0x600BDA2")]
    [Address(RVA = "0x853C40", Offset = "0x852A40", VA = "0x10853C40")]
    public void SetupBindRuneList()
    {
    }

    [Token(Token = "0x600BDA3")]
    [Address(RVA = "0x853140", Offset = "0x851F40", VA = "0x10853140")]
    public void RefreshUnit(bool is_play_equip_effect = true)
    {
    }

    [Token(Token = "0x600BDA4")]
    [Address(RVA = "0x853310", Offset = "0x852110", VA = "0x10853310")]
    public void ResetUnit(UnitData unit)
    {
    }

    [Token(Token = "0x600BDA5")]
    [Address(RVA = "0x8539C0", Offset = "0x8527C0", VA = "0x108539C0")]
    public void SelectedRuneSlot(RuneSlotIndex slot_index)
    {
    }

    [Token(Token = "0x600BDA6")]
    [Address(RVA = "0x8537B0", Offset = "0x8525B0", VA = "0x108537B0")]
    public void SelectedFilterSlot(RuneSlotIndex slot_index)
    {
    }

    [Token(Token = "0x600BDA7")]
    [Address(RVA = "0x851350", Offset = "0x850150", VA = "0x10851350")]
    public void OpenDisassembly()
    {
    }

    [Token(Token = "0x600BDA8")]
    [Address(RVA = "0x8508B0", Offset = "0x84F6B0", VA = "0x108508B0")]
    public void CloseDisassembly()
    {
    }

    [Token(Token = "0x600BDA9")]
    [Address(RVA = "0x853910", Offset = "0x852710", VA = "0x10853910")]
    public void SelectedRuneAsEquip(BindRuneData rune)
    {
    }

    [Token(Token = "0x600BDAA")]
    [Address(RVA = "0x8535D0", Offset = "0x8523D0", VA = "0x108535D0")]
    public void SelectedEnhance(BindRuneData rune_data, bool is_bulk = false)
    {
    }

    [Token(Token = "0x600BDAB")]
    [Address(RVA = "0x8536C0", Offset = "0x8524C0", VA = "0x108536C0")]
    public void SelectedEvolution(BindRuneData rune_data, bool is_bulk = false)
    {
    }

    [Token(Token = "0x600BDAC")]
    [Address(RVA = "0x853830", Offset = "0x852630", VA = "0x10853830")]
    public void SelectedResetStatus(
      BindRuneData rune_data,
      bool _is_enhance_evo = false,
      int _evo_slot_num = 0)
    {
    }

    [Token(Token = "0x600BDAD")]
    [Address(RVA = "0x850CD0", Offset = "0x84FAD0", VA = "0x10850CD0")]
    public void CloseRuneWindow()
    {
    }

    [Token(Token = "0x600BDAE")]
    [Address(RVA = "0x852390", Offset = "0x851190", VA = "0x10852390")]
    public void RefreshEquipWindow()
    {
    }

    [Token(Token = "0x600BDAF")]
    [Address(RVA = "0x853340", Offset = "0x852140", VA = "0x10853340")]
    public void SelectRunePride()
    {
    }

    [Token(Token = "0x600BDB0")]
    public static T CreatePopupWindow<T>(string path) => (T) null;

    [Token(Token = "0x600BDB1")]
    [Address(RVA = "0x851AE0", Offset = "0x8508E0", VA = "0x10851AE0")]
    private void OpenRuneEquipWindow(BindRuneData selected_rune)
    {
    }

    [Token(Token = "0x600BDB2")]
    [Address(RVA = "0x850AD0", Offset = "0x84F8D0", VA = "0x10850AD0")]
    private void CloseRuneEquipWindow()
    {
    }

    [Token(Token = "0x600BDB3")]
    [Address(RVA = "0x852320", Offset = "0x851120", VA = "0x10852320")]
    private void OpenRuneUnEquipWindow(BindRuneData selected_rune)
    {
    }

    [Token(Token = "0x600BDB4")]
    [Address(RVA = "0x850C90", Offset = "0x84FA90", VA = "0x10850C90")]
    private void CloseRuneUnEquipWindow()
    {
    }

    [Token(Token = "0x600BDB5")]
    [Address(RVA = "0x8515F0", Offset = "0x8503F0", VA = "0x108515F0")]
    private void OpenOnlyRuneEquipWindow(BindRuneData selected_rune, RuneManager.RuneEquip equip)
    {
    }

    [Token(Token = "0x600BDB6")]
    [Address(RVA = "0x850990", Offset = "0x84F790", VA = "0x10850990")]
    private void CloseOnlyRuneEquipWindow(RuneManager.RuneEquip equip)
    {
    }

    [Token(Token = "0x600BDB7")]
    [Address(RVA = "0x850E40", Offset = "0x84FC40", VA = "0x10850E40")]
    private void DestroyRuneEquipWindow()
    {
    }

    [Token(Token = "0x600BDB8")]
    [Address(RVA = "0x851500", Offset = "0x850300", VA = "0x10851500")]
    private void OpenOnlyRuneEnhanceWindow(BindRuneData selected_rune, bool is_bulk = false)
    {
    }

    [Token(Token = "0x600BDB9")]
    [Address(RVA = "0x851A00", Offset = "0x850800", VA = "0x10851A00")]
    private void OpenRuneEnhanceResultWindow(
      BindRuneData before_rune,
      BindRuneData after_rune,
      float _before_gauge)
    {
    }

    [Token(Token = "0x600BDBA")]
    [Address(RVA = "0x851790", Offset = "0x850590", VA = "0x10851790")]
    private void OpenOnlyRuneEvoWindow(BindRuneData selected_rune, bool is_bulk = false)
    {
    }

    [Token(Token = "0x600BDBB")]
    [Address(RVA = "0x851CE0", Offset = "0x850AE0", VA = "0x10851CE0")]
    private void OpenRuneEvoResultWindow(BindRuneData before_rune, BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600BDBC")]
    [Address(RVA = "0x852180", Offset = "0x850F80", VA = "0x10852180")]
    private void OpenRuneSelectableListWindow(
      RuneSelectableListWindow.OnSelectedEvent selected_callback)
    {
    }

    [Token(Token = "0x600BDBD")]
    [Address(RVA = "0x850C10", Offset = "0x84FA10", VA = "0x10850C10")]
    private void CloseRuneSelectableListWindow()
    {
    }

    [Token(Token = "0x600BDBE")]
    [Address(RVA = "0x851930", Offset = "0x850730", VA = "0x10851930")]
    private void OpenRuneDisassemblyWindow()
    {
    }

    [Token(Token = "0x600BDBF")]
    [Address(RVA = "0x850A50", Offset = "0x84F850", VA = "0x10850A50")]
    private void CloseRuneDisassemblyWindow()
    {
    }

    [Token(Token = "0x600BDC0")]
    [Address(RVA = "0x851880", Offset = "0x850680", VA = "0x10851880")]
    private void OpenRuneDisassemblyResultWindow()
    {
    }

    [Token(Token = "0x600BDC1")]
    [Address(RVA = "0x8520B0", Offset = "0x850EB0", VA = "0x108520B0")]
    private void OpenRuneResetStatusWindow(
      BindRuneData rune_data,
      bool _is_enhance_evo = false,
      int _evo_slot_num = 0)
    {
    }

    [Token(Token = "0x600BDC2")]
    [Address(RVA = "0x850B90", Offset = "0x84F990", VA = "0x10850B90")]
    private void CloseRuneResetStatusWindow()
    {
    }

    [Token(Token = "0x600BDC3")]
    [Address(RVA = "0x851DB0", Offset = "0x850BB0", VA = "0x10851DB0")]
    private void OpenRuneParamEnhEvoEffectWindow(BindRuneData before_rune, BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600BDC4")]
    [Address(RVA = "0x851FE0", Offset = "0x850DE0", VA = "0x10851FE0")]
    private void OpenRunePrideReleaseWindow()
    {
    }

    [Token(Token = "0x600BDC5")]
    [Address(RVA = "0x851E80", Offset = "0x850C80", VA = "0x10851E80")]
    private void OpenRunePrideParameterWindow()
    {
    }

    [Token(Token = "0x600BDC6")]
    [Address(RVA = "0x850B10", Offset = "0x84F910", VA = "0x10850B10")]
    private void CloseRunePrideParameterWindow()
    {
    }

    [Token(Token = "0x600BDC7")]
    [Address(RVA = "0x853E70", Offset = "0x852C70", VA = "0x10853E70")]
    public RuneManager()
    {
    }

    [Token(Token = "0x20029B7")]
    public enum RuneEquip
    {
      [Token(Token = "0x400CA59")] UnEquip,
      [Token(Token = "0x400CA5A")] Equip,
      [Token(Token = "0x400CA5B")] NonEquip,
      [Token(Token = "0x400CA5C")] Max,
    }

    [Token(Token = "0x20029B8")]
    public enum Mode
    {
      [Token(Token = "0x400CA5E")] Equip,
      [Token(Token = "0x400CA5F")] Disassembly,
      [Token(Token = "0x400CA60")] Enhance,
      [Token(Token = "0x400CA61")] Evolution,
      [Token(Token = "0x400CA62")] ResetStatus,
    }

    [Token(Token = "0x20029B9")]
    public enum DrawType
    {
      [Token(Token = "0x400CA64")] ENHANCE,
      [Token(Token = "0x400CA65")] TOOLTIP,
    }
  }
}

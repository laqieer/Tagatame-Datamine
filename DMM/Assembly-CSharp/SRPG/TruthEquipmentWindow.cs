// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B95")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "強化ポップアップ表示", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(102, "強化成功", FlowNode.PinTypes.Input, 102)]
  [AddComponentMenu("UI/TruthEquipment/TruthEquipmentWindow")]
  [FlowNode.Pin(1000, "強化実行", FlowNode.PinTypes.Output, 1000)]
  public class TruthEquipmentWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D5E1")]
    public const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400D5E2")]
    public const int PIN_IN_LVUP_OPEN = 100;
    [Token(Token = "0x400D5E3")]
    public const int PIN_IN_LVUP_SUCCESS = 102;
    [Token(Token = "0x400D5E4")]
    public const int PIN_OUT_LVUP_START = 1000;
    [Token(Token = "0x400D5E5")]
    private const string ENHANCE_BTN_HIGHLIGHT = "hilit";
    [Token(Token = "0x400D5E6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour m_SerializeValueBehaviour;
    [Token(Token = "0x400D5E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_ActivateWhenTEPEnable;
    [Token(Token = "0x400D5E8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_ActivateWhenTEPDisable;
    [Token(Token = "0x400D5E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TruthEquipmentIcon m_TruthEquipmentIcon;
    [Token(Token = "0x400D5EA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StatusList m_StatusList;
    [Token(Token = "0x400D5EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TruthEquipmentAbilityList m_AbilityList;
    [Token(Token = "0x400D5EC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject m_EnableLvupObject;
    [Token(Token = "0x400D5ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject m_DisableLvupObject;
    [Token(Token = "0x400D5EE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private FlowNode_ReqTruthEquipmentLvup m_LvupRequestNode;
    [Token(Token = "0x400D5EF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect[] m_ScrollResetOnRefresh;
    [Token(Token = "0x400D5F0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Animator m_EnhanceButtonAnimator;
    [Token(Token = "0x400D5F1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PREFAB_PATH_CONFIRM_WINDOW;
    [Token(Token = "0x400D5F2")]
    [FieldOffset(Offset = "0x3C")]
    private TruthEquipmentLvupWindow m_TruthEquipmentLvupWindow;
    [Token(Token = "0x400D5F3")]
    [FieldOffset(Offset = "0x40")]
    private TruthEquipmentLvupWindow2 m_TruthEquipmentLvupWindow2;
    [Token(Token = "0x400D5F4")]
    [FieldOffset(Offset = "0x44")]
    private Coroutine m_LoadingEnhanceWindow;
    [Token(Token = "0x400D5F5")]
    [FieldOffset(Offset = "0x48")]
    private long m_PrevUnitUniqueID;
    [Token(Token = "0x400D5F6")]
    [FieldOffset(Offset = "0x0")]
    private static UnitData s_SelectedUnit;

    [Token(Token = "0x600C817")]
    [Address(RVA = "0x90FF20", Offset = "0x90ED20", VA = "0x1090FF20")]
    public static void SetUnitData(UnitData unitData)
    {
    }

    [Token(Token = "0x600C818")]
    [Address(RVA = "0x90F310", Offset = "0x90E110", VA = "0x1090F310", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C819")]
    [Address(RVA = "0x90F570", Offset = "0x90E370", VA = "0x1090F570")]
    public void OnRefresh()
    {
    }

    [Token(Token = "0x600C81A")]
    [Address(RVA = "0x90F410", Offset = "0x90E210", VA = "0x1090F410")]
    private void OnEnhanceWindowOpen()
    {
    }

    [Token(Token = "0x600C81B")]
    [Address(RVA = "0x90FB20", Offset = "0x90E920", VA = "0x1090FB20")]
    private IEnumerator OpenConfirmWindowAsync() => (IEnumerator) null;

    [Token(Token = "0x600C81C")]
    [Address(RVA = "0x90F490", Offset = "0x90E290", VA = "0x1090F490")]
    private void OnLvupButtonClicked(int _add_level = 1)
    {
    }

    [Token(Token = "0x600C81D")]
    [Address(RVA = "0x90F510", Offset = "0x90E310", VA = "0x1090F510")]
    private void OnLvupSuccess()
    {
    }

    [Token(Token = "0x600C81E")]
    [Address(RVA = "0x90FCF0", Offset = "0x90EAF0", VA = "0x1090FCF0")]
    private void RefreshIcon(UnitData unitData)
    {
    }

    [Token(Token = "0x600C81F")]
    [Address(RVA = "0x90FDC0", Offset = "0x90EBC0", VA = "0x1090FDC0")]
    private void RefreshStatus(UnitData unitData)
    {
    }

    [Token(Token = "0x600C820")]
    [Address(RVA = "0x90FD80", Offset = "0x90EB80", VA = "0x1090FD80")]
    private void RefreshLearnAbility(UnitData unitData)
    {
    }

    [Token(Token = "0x600C821")]
    [Address(RVA = "0x90FB90", Offset = "0x90E990", VA = "0x1090FB90")]
    private void RefreshEnableObject(UnitData unitData)
    {
    }

    [Token(Token = "0x600C822")]
    [Address(RVA = "0x90FC40", Offset = "0x90EA40", VA = "0x1090FC40")]
    private void RefreshEnhanceButtonState(UnitData unitData)
    {
    }

    [Token(Token = "0x600C823")]
    [Address(RVA = "0x90FE80", Offset = "0x90EC80", VA = "0x1090FE80")]
    private void ResetScrollRectsPosition()
    {
    }

    [Token(Token = "0x600C824")]
    [Address(RVA = "0x90FF60", Offset = "0x90ED60", VA = "0x1090FF60")]
    public TruthEquipmentWindow()
    {
    }
  }
}

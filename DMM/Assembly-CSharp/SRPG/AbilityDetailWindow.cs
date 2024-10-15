// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityDetailWindow
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
  [Token(Token = "0x2001F28")]
  [FlowNode.Pin(2, "変更前のスキルを非表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "変更前のスキルを表示", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/AbilityDetailWindow")]
  public class AbilityDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400831E")]
    public const int INPUT_ENABLE_BASE_SKILL = 1;
    [Token(Token = "0x400831F")]
    public const int INPUT_DIABLE_BASE_SKILL = 2;
    [Token(Token = "0x4008320")]
    [FieldOffset(Offset = "0x0")]
    private static UnitData BindUnit;
    [Token(Token = "0x4008321")]
    [FieldOffset(Offset = "0x4")]
    private static AbilityParam BindAbility;
    [Token(Token = "0x4008322")]
    [FieldOffset(Offset = "0xC")]
    public Transform SkillLayoutParent;
    [Token(Token = "0x4008323")]
    [FieldOffset(Offset = "0x10")]
    public GameObject SkillTemplate;
    [Token(Token = "0x4008324")]
    [FieldOffset(Offset = "0x14")]
    public GameObject SkillLockedTemplate;
    [Token(Token = "0x4008325")]
    [FieldOffset(Offset = "0x18")]
    [StringIsGameObjectID]
    public string UnlockCondTextId;
    [Token(Token = "0x4008326")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject SkillUnlockCondWindow;
    [Token(Token = "0x4008327")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Selectable m_ShowBaseToggle;
    [Token(Token = "0x4008328")]
    [FieldOffset(Offset = "0x8")]
    public static bool IsEnableSkillChange;
    [Token(Token = "0x4008329")]
    [FieldOffset(Offset = "0x9")]
    public static bool IsDeriveBaseAbilityDisable;
    [Token(Token = "0x400832A")]
    [FieldOffset(Offset = "0x24")]
    private List<SkillDeriveList> m_SkillDeriveList;

    [Token(Token = "0x6007F91")]
    [Address(RVA = "0x402460", Offset = "0x401260", VA = "0x10402460")]
    public static void SetBindObject(UnitData udata)
    {
    }

    [Token(Token = "0x6007F92")]
    [Address(RVA = "0x4023F0", Offset = "0x4011F0", VA = "0x104023F0")]
    public static void SetBindAbility(AbilityParam ability)
    {
    }

    [Token(Token = "0x6007F93")]
    [Address(RVA = "0x400B10", Offset = "0x3FF910", VA = "0x10400B10")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007F94")]
    [Address(RVA = "0x400C80", Offset = "0x3FFA80", VA = "0x10400C80")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007F95")]
    [Address(RVA = "0x400C40", Offset = "0x3FFA40", VA = "0x10400C40")]
    private void OnDestory()
    {
    }

    [Token(Token = "0x6007F96")]
    [Address(RVA = "0x4005C0", Offset = "0x3FF3C0", VA = "0x104005C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007F97")]
    [Address(RVA = "0x4024D0", Offset = "0x4012D0", VA = "0x104024D0")]
    private void SwitchBaseSkillEnable(bool enable)
    {
    }

    [Token(Token = "0x6007F98")]
    [Address(RVA = "0x400F10", Offset = "0x3FFD10", VA = "0x10400F10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6007F99")]
    [Address(RVA = "0x400600", Offset = "0x3FF400", VA = "0x10400600")]
    private void AddAdditionalSkills(
      List<AbilityDetailWindow.ViewContentParam> vc_param_list)
    {
    }

    [Token(Token = "0x6007F9A")]
    [Address(RVA = "0x400900", Offset = "0x3FF700", VA = "0x10400900")]
    private static void AddSkillParam(
      List<AbilityDetailWindow.ViewContentParam> viewContentParams,
      SkillParam skillParam,
      SkillDeriveParam skillDeriveParam,
      int unlockLv = 0)
    {
    }

    [Token(Token = "0x6007F9B")]
    [Address(RVA = "0x400C90", Offset = "0x3FFA90", VA = "0x10400C90")]
    public void OnOpenSkillUnlockCondWindow(GameObject button)
    {
    }

    [Token(Token = "0x6007F9C")]
    [Address(RVA = "0x402600", Offset = "0x401400", VA = "0x10402600")]
    public AbilityDetailWindow()
    {
    }

    [Token(Token = "0x2001F29")]
    public class ViewContentParam
    {
      [Token(Token = "0x400832B")]
      [FieldOffset(Offset = "0x8")]
      public SkillParam m_SkillParam;
      [Token(Token = "0x400832C")]
      [FieldOffset(Offset = "0xC")]
      public List<SkillDeriveParam> m_SkillDeriveParams;
      [Token(Token = "0x400832D")]
      [FieldOffset(Offset = "0x10")]
      public int m_UnLockLv;

      [Token(Token = "0x6007F9D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewContentParam()
      {
      }
    }
  }
}

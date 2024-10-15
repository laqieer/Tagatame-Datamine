// Decompiled with JetBrains decompiler
// Type: SRPG.TargetPlate
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
  [Token(Token = "0x2000E0E")]
  [AddComponentMenu("Battle/TargetPlate")]
  public class TargetPlate : MonoBehaviour
  {
    [Token(Token = "0x40029EC")]
    [FieldOffset(Offset = "0xC")]
    public GameObject NextTargetArrow;
    [Token(Token = "0x40029ED")]
    [FieldOffset(Offset = "0x10")]
    public GameObject PrevTargetArrow;
    [Token(Token = "0x40029EE")]
    [FieldOffset(Offset = "0x14")]
    public GameObject AttackInfoPlate;
    [Token(Token = "0x40029EF")]
    [FieldOffset(Offset = "0x18")]
    public GameObject HealValue;
    [Token(Token = "0x40029F0")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject HealOutPut;
    [Token(Token = "0x40029F1")]
    [FieldOffset(Offset = "0x20")]
    public GameObject DamageValue;
    [Token(Token = "0x40029F2")]
    [FieldOffset(Offset = "0x24")]
    public GameObject DamageOutPut;
    [Token(Token = "0x40029F3")]
    [FieldOffset(Offset = "0x28")]
    public GameObject CriticalRate;
    [Token(Token = "0x40029F4")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject CriticalRateOutPut;
    [Token(Token = "0x40029F5")]
    [FieldOffset(Offset = "0x30")]
    public GameObject HitRate;
    [Token(Token = "0x40029F6")]
    [FieldOffset(Offset = "0x34")]
    public GameObject HitRateOutPut;
    [Token(Token = "0x40029F7")]
    [FieldOffset(Offset = "0x38")]
    public GradientGauge HpGauge;
    [Token(Token = "0x40029F8")]
    [FieldOffset(Offset = "0x3C")]
    public GradientGauge MpGauge;
    [Token(Token = "0x40029F9")]
    [FieldOffset(Offset = "0x40")]
    public GradientGauge HpMaxGauge;
    [Token(Token = "0x40029FA")]
    [FieldOffset(Offset = "0x44")]
    public StatusEffect StatusEffects;
    [Token(Token = "0x40029FB")]
    [FieldOffset(Offset = "0x48")]
    public GameObject GoElement;
    [Token(Token = "0x40029FC")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject GoLvIcon;
    [Token(Token = "0x40029FD")]
    [FieldOffset(Offset = "0x50")]
    public GameObject GoLvText;
    [Token(Token = "0x40029FE")]
    [FieldOffset(Offset = "0x54")]
    public GameObject GoHpGuage;
    [Token(Token = "0x40029FF")]
    [FieldOffset(Offset = "0x58")]
    public GameObject GoMpGuage;
    [Token(Token = "0x4002A00")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject GoCTGuage;
    [Token(Token = "0x4002A01")]
    [FieldOffset(Offset = "0x60")]
    public GameObject GoCondHit;
    [Token(Token = "0x4002A02")]
    [FieldOffset(Offset = "0x64")]
    public Text TextCondName;
    [Token(Token = "0x4002A03")]
    [FieldOffset(Offset = "0x68")]
    public ImageArray ImageCondIcon;
    [Token(Token = "0x4002A04")]
    [FieldOffset(Offset = "0x6C")]
    public Text TextCondPer;
    [Token(Token = "0x4002A05")]
    [FieldOffset(Offset = "0x70")]
    public CanvasGroup[] CgCanTouchs;
    [Token(Token = "0x4002A06")]
    [FieldOffset(Offset = "0x74")]
    private List<LogSkill.Target.CondHit> mCondHitLists;
    [Token(Token = "0x4002A07")]
    [FieldOffset(Offset = "0x78")]
    private int mCondHitIndex;
    [Token(Token = "0x4002A08")]
    private const float COND_HIT_CHANGE_TIME = 1f;
    [Token(Token = "0x4002A09")]
    [FieldOffset(Offset = "0x7C")]
    private float mCondHitPassedTime;
    [Token(Token = "0x4002A0A")]
    [FieldOffset(Offset = "0x80")]
    public GameObject ProtectIcon;
    [Token(Token = "0x4002A0B")]
    [FieldOffset(Offset = "0x84")]
    private Unit mSelectedUnit;
    [Token(Token = "0x4002A0C")]
    [FieldOffset(Offset = "0x88")]
    private WindowController mWindowController;
    [Token(Token = "0x4002A0D")]
    [FieldOffset(Offset = "0x8C")]
    private CanvasGroup mTargetCg;
    [Token(Token = "0x4002A0E")]
    [FieldOffset(Offset = "0x90")]
    private TargetPlate.GaugeParam mHpGaugeParam;
    [Token(Token = "0x4002A0F")]
    [FieldOffset(Offset = "0x94")]
    public GameObject GimmickDescription;
    [Token(Token = "0x4002A10")]
    [FieldOffset(Offset = "0x98")]
    public GameObject FlipButton;
    [Token(Token = "0x4002A11")]
    [FieldOffset(Offset = "0x9C")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoHpGaugeNormal;
    [Token(Token = "0x4002A12")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject GoHpGaugeBoss;

    [Token(Token = "0x17000413")]
    public Unit SelectedUnit
    {
      [Token(Token = "0x6003997"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000414")]
    public WindowController WindowController
    {
      [Token(Token = "0x6003998"), Address(RVA = "0x10BA050", Offset = "0x10B8E50", VA = "0x110BA050")] get
      {
        return (WindowController) null;
      }
    }

    [Token(Token = "0x6003999")]
    [Address(RVA = "0x10B8550", Offset = "0x10B7350", VA = "0x110B8550")]
    private void SetActive(GameObject targetObject, bool isActive)
    {
    }

    [Token(Token = "0x600399A")]
    [Address(RVA = "0x10B9840", Offset = "0x10B8640", VA = "0x110B9840")]
    private void SetTextValue(GameObject targetObject, string value)
    {
    }

    [Token(Token = "0x17000415")]
    private CanvasGroup TargetCg
    {
      [Token(Token = "0x600399B"), Address(RVA = "0x10B9FD0", Offset = "0x10B8DD0", VA = "0x110B9FD0")] get
      {
        return (CanvasGroup) null;
      }
    }

    [Token(Token = "0x600399C")]
    [Address(RVA = "0x10B9D60", Offset = "0x10B8B60", VA = "0x110B9D60")]
    private void Update()
    {
    }

    [Token(Token = "0x600399D")]
    [Address(RVA = "0x10B8880", Offset = "0x10B7680", VA = "0x110B8880")]
    private void SetCondHit(List<LogSkill.Target.CondHit> cond_hit_lists = null)
    {
    }

    [Token(Token = "0x600399E")]
    [Address(RVA = "0x10B7DB0", Offset = "0x10B6BB0", VA = "0x110B7DB0")]
    private void DispCondHit(int ch_idx)
    {
    }

    [Token(Token = "0x600399F")]
    [Address(RVA = "0x10BA0F0", Offset = "0x10B8EF0", VA = "0x110BA0F0")]
    private void reflectBreakObj(Unit unit)
    {
    }

    [Token(Token = "0x60039A0")]
    [Address(RVA = "0x10B91D0", Offset = "0x10B7FD0", VA = "0x110B91D0")]
    public void SetNoAction(Unit unit, List<LogSkill.Target.CondHit> cond_hit_lists = null)
    {
    }

    [Token(Token = "0x60039A1")]
    [Address(RVA = "0x10B85C0", Offset = "0x10B73C0", VA = "0x110B85C0")]
    public void SetAttackAction(
      Unit unit,
      int damageValue,
      int criticalRate,
      int hitRate,
      List<LogSkill.Target.CondHit> cond_hit_lists)
    {
    }

    [Token(Token = "0x60039A2")]
    [Address(RVA = "0x10B95A0", Offset = "0x10B83A0", VA = "0x110B95A0")]
    public void SetSkillAction(
      Unit unit,
      int damageValue,
      int criticalRate,
      int hitRate,
      List<LogSkill.Target.CondHit> cond_hit_lists)
    {
    }

    [Token(Token = "0x60039A3")]
    [Address(RVA = "0x10B8D50", Offset = "0x10B7B50", VA = "0x110B8D50")]
    public void SetHealAction(Unit unit, int healValue, int criticalRate, int hitRate)
    {
    }

    [Token(Token = "0x60039A4")]
    [Address(RVA = "0x10B9900", Offset = "0x10B8700", VA = "0x110B9900")]
    public void SetTrick(TrickParam trick_param)
    {
    }

    [Token(Token = "0x60039A5")]
    [Address(RVA = "0x10B94E0", Offset = "0x10B82E0", VA = "0x110B94E0")]
    public void SetProtectAction(bool isProtect)
    {
    }

    [Token(Token = "0x60039A6")]
    [Address(RVA = "0x10BA310", Offset = "0x10B9110", VA = "0x110BA310")]
    private void toggleTargetArrow(
      ButtonExt.ButtonClickEvent listener,
      bool active,
      bool isNextArrow)
    {
    }

    [Token(Token = "0x60039A7")]
    [Address(RVA = "0x10B7CA0", Offset = "0x10B6AA0", VA = "0x110B7CA0")]
    public void ActivateNextTargetArrow(ButtonExt.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x60039A8")]
    [Address(RVA = "0x10B7CC0", Offset = "0x10B6AC0", VA = "0x110B7CC0")]
    public void ActivatePrevTargetArrow(ButtonExt.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x60039A9")]
    [Address(RVA = "0x10B7D70", Offset = "0x10B6B70", VA = "0x110B7D70")]
    public void DeactivateNextTargetArrow(ButtonExt.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x60039AA")]
    [Address(RVA = "0x10B7D90", Offset = "0x10B6B90", VA = "0x110B7D90")]
    public void DeactivatePrevTargetArrow(ButtonExt.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x60039AB")]
    [Address(RVA = "0x10B91A0", Offset = "0x10B7FA0", VA = "0x110B91A0")]
    public void SetNextTargetArrowActive(bool active)
    {
    }

    [Token(Token = "0x60039AC")]
    [Address(RVA = "0x10B94B0", Offset = "0x10B82B0", VA = "0x110B94B0")]
    public void SetPrevTargetArrowActive(bool active)
    {
    }

    [Token(Token = "0x60039AD")]
    [Address(RVA = "0x10B8FE0", Offset = "0x10B7DE0", VA = "0x110B8FE0")]
    public void SetHpGaugeParam(
      EUnitSide Side,
      long CurrentHp,
      long MaxHp,
      int YosokuDamageHp = 0,
      int YosokuHealHp = 0,
      bool is_max_damage = false)
    {
    }

    [Token(Token = "0x60039AE")]
    [Address(RVA = "0x10B8A00", Offset = "0x10B7800", VA = "0x110B8A00")]
    private void SetGaugeParamInternal(
      ref TargetPlate.GaugeParam Gauge,
      TargetPlate.EGaugeType Type,
      long CurrentValue,
      long MaxValue,
      int PlusValue)
    {
    }

    [Token(Token = "0x60039AF")]
    [Address(RVA = "0x10B9C20", Offset = "0x10B8A20", VA = "0x110B9C20")]
    private void UpdateGauge(
      TargetPlate.GaugeParam param,
      GradientGauge gauge,
      GradientGauge max_gauge = null)
    {
    }

    [Token(Token = "0x60039B0")]
    [Address(RVA = "0x10B9D40", Offset = "0x10B8B40", VA = "0x110B9D40")]
    public void UpdateHpGauge()
    {
    }

    [Token(Token = "0x60039B1")]
    [Address(RVA = "0x10B8510", Offset = "0x10B7310", VA = "0x110B8510")]
    public void ResetHpGauge(EUnitSide Side, long CurrentHp, long MaxHp)
    {
    }

    [Token(Token = "0x60039B2")]
    [Address(RVA = "0x10B9B60", Offset = "0x10B8960", VA = "0x110B9B60")]
    private void ToggleGimmickDescription(bool Active)
    {
    }

    [Token(Token = "0x60039B3")]
    [Address(RVA = "0x10B8130", Offset = "0x10B6F30", VA = "0x110B8130")]
    public void OpenGimmickDescription()
    {
    }

    [Token(Token = "0x60039B4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void CloseGimmickDescription()
    {
    }

    [Token(Token = "0x60039B5")]
    [Address(RVA = "0x10B81E0", Offset = "0x10B6FE0", VA = "0x110B81E0")]
    public void Open()
    {
    }

    [Token(Token = "0x60039B6")]
    [Address(RVA = "0x10B7CE0", Offset = "0x10B6AE0", VA = "0x110B7CE0")]
    public void Close()
    {
    }

    [Token(Token = "0x60039B7")]
    [Address(RVA = "0x10B8090", Offset = "0x10B6E90", VA = "0x110B8090")]
    public void ForceClose(bool isHide = true)
    {
    }

    [Token(Token = "0x60039B8")]
    [Address(RVA = "0x10B80F0", Offset = "0x10B6EF0", VA = "0x110B80F0")]
    public void HideButton()
    {
    }

    [Token(Token = "0x60039B9")]
    [Address(RVA = "0x10B8980", Offset = "0x10B7780", VA = "0x110B8980")]
    public void SetEnableFlipButton(bool is_enable)
    {
    }

    [Token(Token = "0x60039BA")]
    [Address(RVA = "0x10B8440", Offset = "0x10B7240", VA = "0x110B8440")]
    public void ReflectBossGauge()
    {
    }

    [Token(Token = "0x60039BB")]
    [Address(RVA = "0x10B9F20", Offset = "0x10B8D20", VA = "0x110B9F20")]
    public TargetPlate()
    {
    }

    [Token(Token = "0x2000E0F")]
    private enum EGaugeType
    {
      [Token(Token = "0x4002A14")] PLAYER_HP = 1,
      [Token(Token = "0x4002A15")] PLAYER_MP = 2,
      [Token(Token = "0x4002A16")] ENEMY_HP = 10, // 0x0000000A
      [Token(Token = "0x4002A17")] ENEMY_MP = 11, // 0x0000000B
      [Token(Token = "0x4002A18")] NEUTRAL_HP = 20, // 0x00000014
      [Token(Token = "0x4002A19")] NEUTRAL_MP = 21, // 0x00000015
    }

    [Token(Token = "0x2000E10")]
    private class GaugeParam
    {
      [Token(Token = "0x4002A1A")]
      [FieldOffset(Offset = "0x8")]
      public Color32[] Colors;
      [Token(Token = "0x4002A1B")]
      [FieldOffset(Offset = "0x10")]
      public long Current;
      [Token(Token = "0x4002A1C")]
      [FieldOffset(Offset = "0x18")]
      public long Max;
      [Token(Token = "0x4002A1D")]
      [FieldOffset(Offset = "0x20")]
      public float MaxValue;

      [Token(Token = "0x60039BC")]
      [Address(RVA = "0x10B79F0", Offset = "0x10B67F0", VA = "0x110B79F0")]
      public GaugeParam()
      {
      }
    }
  }
}

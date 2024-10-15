// Decompiled with JetBrains decompiler
// Type: SRPG.UnitInventoryJobIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C3D")]
  [AddComponentMenu("UI/UnitInventoryJobIcon")]
  public class UnitInventoryJobIcon : MonoBehaviour
  {
    [Token(Token = "0x400DB06")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ANIM_PARAM_JOB_ICON_UNLOCK_BOOL;
    [Token(Token = "0x400DB07")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string ANIM_PARAM_JOB_ICON_HILIT_BOOL;
    [Token(Token = "0x400DB08")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string ANIM_PARAM_JOB_ICON_DISABLED_BOOL;
    [Token(Token = "0x400DB09")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string ANIM_PARAM_JOB_ICON_ON_BOOL;
    [Token(Token = "0x400DB0A")]
    [FieldOffset(Offset = "0xC")]
    private float SINGLE_ICON_HALF_SIZE_COEF;
    [Token(Token = "0x400DB0B")]
    [FieldOffset(Offset = "0x10")]
    private int JOB_ICON_ROW_COUNT_MAX;
    [Token(Token = "0x400DB0C")]
    [FieldOffset(Offset = "0x14")]
    public UnitInventoryJobIcon.eViewMode mMode;
    [Token(Token = "0x400DB0D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button base_job_icon_button;
    [Token(Token = "0x400DB0E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button cc_job_icon_button;
    [Token(Token = "0x400DB0F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject active_job_indicator;
    [Token(Token = "0x400DB10")]
    [FieldOffset(Offset = "0x24")]
    private List<SRPG_Button> mCcJobIconButtonList;

    [Token(Token = "0x17001B1A")]
    public SRPG_Button BaseJobIconButton
    {
      [Token(Token = "0x600CCE7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (SRPG_Button) null;
      }
    }

    [Token(Token = "0x17001B1B")]
    public List<SRPG_Button> CcJobButtonList
    {
      [Token(Token = "0x600CCE8"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<SRPG_Button>) null;
      }
    }

    [Token(Token = "0x17001B1C")]
    public float Width
    {
      [Token(Token = "0x600CCE9"), Address(RVA = "0x97C1B0", Offset = "0x97AFB0", VA = "0x1097C1B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001B1D")]
    public float HalfWidth
    {
      [Token(Token = "0x600CCEA"), Address(RVA = "0x97BF80", Offset = "0x97AD80", VA = "0x1097BF80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001B1E")]
    public bool IsSingleIcon
    {
      [Token(Token = "0x600CCEB"), Address(RVA = "0x97C0B0", Offset = "0x97AEB0", VA = "0x1097C0B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CCEC")]
    [Address(RVA = "0x97B340", Offset = "0x97A140", VA = "0x1097B340")]
    public void ResetParam()
    {
    }

    [Token(Token = "0x600CCED")]
    [Address(RVA = "0x97BA20", Offset = "0x97A820", VA = "0x1097BA20")]
    public void SetParam(
      UnitData unit,
      int[] job_indexes,
      bool is_avtive_job,
      UnitInventoryJobIcon.eViewMode mode)
    {
    }

    [Token(Token = "0x600CCEE")]
    [Address(RVA = "0x97B6C0", Offset = "0x97A4C0", VA = "0x1097B6C0")]
    private void SetIcon(SRPG_Button slot, UnitData unit, int job_data_index, bool is_cc_icon)
    {
    }

    [Token(Token = "0x600CCEF")]
    [Address(RVA = "0x97B550", Offset = "0x97A350", VA = "0x1097B550")]
    private void SetAnimationParam(
      Animator anim,
      bool is_activated,
      bool unlockable,
      bool is_disabled,
      bool is_hilit)
    {
    }

    [Token(Token = "0x600CCF0")]
    [Address(RVA = "0x97BDA0", Offset = "0x97ABA0", VA = "0x1097BDA0")]
    public void SetSelectIconAnim(bool is_on)
    {
    }

    [Token(Token = "0x600CCF1")]
    [Address(RVA = "0x97B2C0", Offset = "0x97A0C0", VA = "0x1097B2C0")]
    public bool IsDisabledBaseJobIcon() => new bool();

    [Token(Token = "0x600CCF2")]
    [Address(RVA = "0x97BF00", Offset = "0x97AD00", VA = "0x1097BF00")]
    public UnitInventoryJobIcon()
    {
    }

    [Token(Token = "0x600CCF3")]
    [Address(RVA = "0x97BE20", Offset = "0x97AC20", VA = "0x1097BE20")]
    static UnitInventoryJobIcon()
    {
    }

    [Token(Token = "0x2002C3E")]
    public enum eViewMode
    {
      [Token(Token = "0x400DB12")] NONE,
      [Token(Token = "0x400DB13")] UNIT_DETAIL,
      [Token(Token = "0x400DB14")] UNIT_VIEWER,
    }
  }
}

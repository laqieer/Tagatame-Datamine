// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactDetailAbilityItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF5")]
  [AddComponentMenu("UI/ArtifactDetailAbilityItem")]
  public class ArtifactDetailAbilityItem : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IHoldGesture
  {
    [Token(Token = "0x400880E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUnitIcon;
    [Token(Token = "0x400880F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mJobIcon;
    [Token(Token = "0x4008810")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mDisableMask;
    [Token(Token = "0x4008811")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mLockImage;
    [Token(Token = "0x4008812")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mConditionsText;
    [Token(Token = "0x4008813")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mLineVertical;
    [Token(Token = "0x4008814")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mLineHorizontal;
    [Token(Token = "0x4008815")]
    [FieldOffset(Offset = "0x28")]
    private AbilityParam mAbilityParam;
    [Token(Token = "0x4008816")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsEnable;
    [Token(Token = "0x4008817")]
    [FieldOffset(Offset = "0x2D")]
    private bool mHasDeriveAbility;

    [Token(Token = "0x170012E2")]
    public bool IsEnable
    {
      [Token(Token = "0x60083F7"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012E3")]
    public bool HasDeriveAbility
    {
      [Token(Token = "0x60083F8"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60083F9")]
    [Address(RVA = "0x448D80", Offset = "0x447B80", VA = "0x10448D80")]
    public void Setup(
      AbilityParam ability_param,
      bool is_derive_ability,
      bool is_enable,
      bool is_locked,
      bool has_derive_ability)
    {
    }

    [Token(Token = "0x60083FA")]
    [Address(RVA = "0x448D40", Offset = "0x447B40", VA = "0x10448D40")]
    public void SetActive(bool is_active)
    {
    }

    [Token(Token = "0x60083FB")]
    [Address(RVA = "0x448C90", Offset = "0x447A90", VA = "0x10448C90")]
    public void SetActiveLine(bool is_active)
    {
    }

    [Token(Token = "0x60083FC")]
    [Address(RVA = "0x448B60", Offset = "0x447960", VA = "0x10448B60")]
    public void DestoryLastLine()
    {
    }

    [Token(Token = "0x60083FD")]
    [Address(RVA = "0x448BE0", Offset = "0x4479E0", VA = "0x10448BE0", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x60083FE")]
    [Address(RVA = "0x448C00", Offset = "0x447A00", VA = "0x10448C00", Slot = "5")]
    public void OnPointerHoldStart()
    {
    }

    [Token(Token = "0x60083FF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public void OnPointerHoldEnd()
    {
    }

    [Token(Token = "0x6008400")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactDetailAbilityItem()
    {
    }
  }
}

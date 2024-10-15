// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityListItemEvents
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
  [Token(Token = "0x2002BAC")]
  public class UnitAbilityListItemEvents : ListItemEvents
  {
    [Token(Token = "0x400D67A")]
    [FieldOffset(Offset = "0x38")]
    private UnitAbilityListItemEvents.ListItemTouchController mTouchController;
    [Token(Token = "0x400D67B")]
    [FieldOffset(Offset = "0x3C")]
    public ListItemEvents.ListItemEvent OnRankUp;
    [Token(Token = "0x400D67C")]
    [FieldOffset(Offset = "0x40")]
    public ListItemEvents.ListItemEvent OnRankUpBtnPress;
    [Token(Token = "0x400D67D")]
    [FieldOffset(Offset = "0x44")]
    public ListItemEvents.ListItemEvent OnRankUpBtnUp;
    [Token(Token = "0x400D67E")]
    [FieldOffset(Offset = "0x48")]
    [HelpBox("アビリティをランクアップ可能であればこのゲームオブジェクトを選択可能にします。")]
    public Selectable RankupButton;
    [Token(Token = "0x400D67F")]
    [FieldOffset(Offset = "0x4C")]
    public RectTransform AbilityPoint;
    [Token(Token = "0x400D680")]
    [FieldOffset(Offset = "0x50")]
    public GameObject LabelLevel;
    [Token(Token = "0x400D681")]
    [FieldOffset(Offset = "0x54")]
    public GameObject LabelLevelMax;
    [Token(Token = "0x400D682")]
    [FieldOffset(Offset = "0x58")]
    private float mLastUpdateTime;

    [Token(Token = "0x17001A93")]
    public UnitAbilityListItemEvents.ListItemTouchController ItemTouchController
    {
      [Token(Token = "0x600C8B3"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (UnitAbilityListItemEvents.ListItemTouchController) null;
      }
    }

    [Token(Token = "0x600C8B4")]
    [Address(RVA = "0x916040", Offset = "0x914E40", VA = "0x10916040")]
    private void Start()
    {
    }

    [Token(Token = "0x600C8B5")]
    [Address(RVA = "0x915EB0", Offset = "0x914CB0", VA = "0x10915EB0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C8B6")]
    [Address(RVA = "0x915D60", Offset = "0x914B60", VA = "0x10915D60")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600C8B7")]
    [Address(RVA = "0x915F90", Offset = "0x914D90", VA = "0x10915F90")]
    private void OnRankUpCountChange(int count)
    {
    }

    [Token(Token = "0x600C8B8")]
    [Address(RVA = "0x915FB0", Offset = "0x914DB0", VA = "0x10915FB0")]
    private void RankUpPress(
      UnitAbilityListItemEvents.ListItemTouchController controller)
    {
    }

    [Token(Token = "0x600C8B9")]
    [Address(RVA = "0x915FE0", Offset = "0x914DE0", VA = "0x10915FE0")]
    private void RankUpUp(
      UnitAbilityListItemEvents.ListItemTouchController controller)
    {
    }

    [Token(Token = "0x600C8BA")]
    [Address(RVA = "0x916010", Offset = "0x914E10", VA = "0x10916010")]
    public void RankUp(
      UnitAbilityListItemEvents.ListItemTouchController controller)
    {
    }

    [Token(Token = "0x600C8BB")]
    [Address(RVA = "0x916460", Offset = "0x915260", VA = "0x10916460")]
    public void UpdateItemStates()
    {
    }

    [Token(Token = "0x600C8BC")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public UnitAbilityListItemEvents()
    {
    }

    [Token(Token = "0x2002BAD")]
    public class ListItemTouchController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
      [Token(Token = "0x400D683")]
      [FieldOffset(Offset = "0xC")]
      public UnitAbilityListItemEvents.ListItemTouchController.DelegateOnPointerDown OnPointerDownFunc;
      [Token(Token = "0x400D684")]
      [FieldOffset(Offset = "0x10")]
      public UnitAbilityListItemEvents.ListItemTouchController.DelegateOnPointerUp OnPointerUpFunc;
      [Token(Token = "0x400D685")]
      [FieldOffset(Offset = "0x14")]
      public UnitAbilityListItemEvents.ListItemTouchController.DelegateRankUp RankUpFunc;
      [Token(Token = "0x400D686")]
      [FieldOffset(Offset = "0x18")]
      public float HoldDuration;
      [Token(Token = "0x400D687")]
      [FieldOffset(Offset = "0x1C")]
      public float HoldSpan;
      [Token(Token = "0x400D688")]
      [FieldOffset(Offset = "0x20")]
      public bool Holding;
      [Token(Token = "0x400D689")]
      [FieldOffset(Offset = "0x21")]
      public bool IsFirstDownFunc;
      [Token(Token = "0x400D68A")]
      [FieldOffset(Offset = "0x0")]
      private static readonly float FirstSpan;
      [Token(Token = "0x400D68B")]
      [FieldOffset(Offset = "0x4")]
      private static readonly float SecondSpanMax;
      [Token(Token = "0x400D68C")]
      [FieldOffset(Offset = "0x8")]
      private static readonly float SecondSpanMin;
      [Token(Token = "0x400D68D")]
      [FieldOffset(Offset = "0xC")]
      private static readonly float SecondSpanOffset;
      [Token(Token = "0x400D68E")]
      [FieldOffset(Offset = "0x24")]
      private Vector2 mDragStartPos;

      [Token(Token = "0x600C8BD")]
      [Address(RVA = "0x90BE30", Offset = "0x90AC30", VA = "0x1090BE30", Slot = "4")]
      public void OnPointerDown(PointerEventData eventData)
      {
      }

      [Token(Token = "0x600C8BE")]
      [Address(RVA = "0x90BE90", Offset = "0x90AC90", VA = "0x1090BE90")]
      public void OnPointerUp()
      {
      }

      [Token(Token = "0x600C8BF")]
      [Address(RVA = "0x90BDE0", Offset = "0x90ABE0", VA = "0x1090BDE0")]
      public void OnDestroy()
      {
      }

      [Token(Token = "0x600C8C0")]
      [Address(RVA = "0x90BF30", Offset = "0x90AD30", VA = "0x1090BF30")]
      public void UpdatePress(float deltaTime)
      {
      }

      [Token(Token = "0x600C8C1")]
      [Address(RVA = "0x90BEC0", Offset = "0x90ACC0", VA = "0x1090BEC0")]
      public void StatusReset()
      {
      }

      [Token(Token = "0x600C8C2")]
      [Address(RVA = "0x90C170", Offset = "0x90AF70", VA = "0x1090C170")]
      public ListItemTouchController()
      {
      }

      [Token(Token = "0x600C8C3")]
      [Address(RVA = "0x90C110", Offset = "0x90AF10", VA = "0x1090C110")]
      static ListItemTouchController()
      {
      }

      [Token(Token = "0x2002BAE")]
      public delegate void DelegateOnPointerDown(
        UnitAbilityListItemEvents.ListItemTouchController controller);

      [Token(Token = "0x2002BAF")]
      public delegate void DelegateOnPointerUp(
        UnitAbilityListItemEvents.ListItemTouchController controller);

      [Token(Token = "0x2002BB0")]
      public delegate void DelegateRankUp(
        UnitAbilityListItemEvents.ListItemTouchController controller);
    }
  }
}

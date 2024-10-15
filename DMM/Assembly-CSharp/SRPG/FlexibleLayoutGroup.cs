// Decompiled with JetBrains decompiler
// Type: SRPG.FlexibleLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023BF")]
  [ExecuteInEditMode]
  [DisallowMultipleComponent]
  [AddComponentMenu("UI/FlexibleLayoutGroup")]
  [RequireComponent(typeof (RectTransform))]
  public class FlexibleLayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
  {
    [Token(Token = "0x400A170")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectOffset m_Padding;
    [Token(Token = "0x400A171")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Vector2 m_Spacing;
    [Token(Token = "0x400A172")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlexibleLayoutGroup.Axis m_StartAxis;
    [Token(Token = "0x400A173")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    [SerializeField]
    private float m_LineSpace;
    [Token(Token = "0x400A174")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private float m_ColumnSpace;
    [Token(Token = "0x400A175")]
    [FieldOffset(Offset = "0x24")]
    private List<RectTransform> m_RectChildren;
    [Token(Token = "0x400A176")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 m_TotalMinSize;
    [Token(Token = "0x400A177")]
    [FieldOffset(Offset = "0x30")]
    private Vector2 m_TotalPreferredSize;
    [Token(Token = "0x400A178")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 m_TotalFlexibleSize;
    [Token(Token = "0x400A179")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform m_RectTransform;

    [Token(Token = "0x1700157F")]
    private List<RectTransform> rectChildren
    {
      [Token(Token = "0x6009AB7"), Address(RVA = "0x5EC910", Offset = "0x5EB710", VA = "0x105EC910")] get
      {
        return (List<RectTransform>) null;
      }
    }

    [Token(Token = "0x17001580")]
    private RectTransform rectTransform
    {
      [Token(Token = "0x6009AB8"), Address(RVA = "0x5EC980", Offset = "0x5EB780", VA = "0x105EC980")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17001581")]
    private bool isRootLayoutGroup
    {
      [Token(Token = "0x6009AB9"), Address(RVA = "0x5EC780", Offset = "0x5EB580", VA = "0x105EC780")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001582")]
    public virtual float minWidth
    {
      [Token(Token = "0x6009ABA"), Address(RVA = "0x5EC8B0", Offset = "0x5EB6B0", VA = "0x105EC8B0", Slot = "28")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001583")]
    public virtual float preferredWidth
    {
      [Token(Token = "0x6009ABB"), Address(RVA = "0x5EC8F0", Offset = "0x5EB6F0", VA = "0x105EC8F0", Slot = "29")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001584")]
    public virtual float flexibleWidth
    {
      [Token(Token = "0x6009ABC"), Address(RVA = "0x5EC760", Offset = "0x5EB560", VA = "0x105EC760", Slot = "30")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001585")]
    public virtual float minHeight
    {
      [Token(Token = "0x6009ABD"), Address(RVA = "0x5EC890", Offset = "0x5EB690", VA = "0x105EC890", Slot = "31")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001586")]
    public virtual float preferredHeight
    {
      [Token(Token = "0x6009ABE"), Address(RVA = "0x5EC8D0", Offset = "0x5EB6D0", VA = "0x105EC8D0", Slot = "32")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001587")]
    public virtual float flexibleHeight
    {
      [Token(Token = "0x6009ABF"), Address(RVA = "0x5EC740", Offset = "0x5EB540", VA = "0x105EC740", Slot = "33")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001588")]
    public virtual int layoutPriority
    {
      [Token(Token = "0x6009AC0"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "34")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009AC1")]
    [Address(RVA = "0x5EB7F0", Offset = "0x5EA5F0", VA = "0x105EB7F0")]
    protected float GetTotalMinSize(int axis) => new float();

    [Token(Token = "0x6009AC2")]
    [Address(RVA = "0x5EB810", Offset = "0x5EA610", VA = "0x105EB810")]
    protected float GetTotalPreferredSize(int axis) => new float();

    [Token(Token = "0x6009AC3")]
    [Address(RVA = "0x5EB7D0", Offset = "0x5EA5D0", VA = "0x105EB7D0")]
    protected float GetTotalFlexibleSize(int axis) => new float();

    [Token(Token = "0x6009AC4")]
    [Address(RVA = "0x5EB5A0", Offset = "0x5EA3A0", VA = "0x105EB5A0", Slot = "35")]
    public virtual void CalculateLayoutInputHorizontal()
    {
    }

    [Token(Token = "0x6009AC5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "36")]
    public virtual void CalculateLayoutInputVertical()
    {
    }

    [Token(Token = "0x6009AC6")]
    [Address(RVA = "0x5EBAE0", Offset = "0x5EA8E0", VA = "0x105EBAE0", Slot = "37")]
    public virtual void SetLayoutHorizontal()
    {
    }

    [Token(Token = "0x6009AC7")]
    [Address(RVA = "0x5EBAE0", Offset = "0x5EA8E0", VA = "0x105EBAE0", Slot = "38")]
    public virtual void SetLayoutVertical()
    {
    }

    [Token(Token = "0x6009AC8")]
    [Address(RVA = "0x5EC5E0", Offset = "0x5EB3E0", VA = "0x105EC5E0")]
    protected FlexibleLayoutGroup()
    {
    }

    [Token(Token = "0x6009AC9")]
    [Address(RVA = "0x5EB9E0", Offset = "0x5EA7E0", VA = "0x105EB9E0")]
    private void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
    {
    }

    [Token(Token = "0x6009ACA")]
    [Address(RVA = "0x5EBAF0", Offset = "0x5EA8F0", VA = "0x105EBAF0")]
    private void UpdateLayout()
    {
    }

    [Token(Token = "0x6009ACB")]
    [Address(RVA = "0x5EB8A0", Offset = "0x5EA6A0", VA = "0x105EB8A0", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x6009ACC")]
    [Address(RVA = "0x5EB840", Offset = "0x5EA640", VA = "0x105EB840", Slot = "7")]
    protected override void OnDisable()
    {
    }

    [Token(Token = "0x6009ACD")]
    [Address(RVA = "0x5EB830", Offset = "0x5EA630", VA = "0x105EB830", Slot = "13")]
    protected override void OnDidApplyAnimationProperties()
    {
    }

    [Token(Token = "0x6009ACE")]
    [Address(RVA = "0x5EB8C0", Offset = "0x5EA6C0", VA = "0x105EB8C0", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x6009ACF")]
    [Address(RVA = "0x5EB830", Offset = "0x5EA630", VA = "0x105EB830", Slot = "39")]
    protected virtual void OnTransformChildrenChanged()
    {
    }

    [Token(Token = "0x6009AD0")]
    [Address(RVA = "0x5EBA70", Offset = "0x5EA870", VA = "0x105EBA70")]
    protected void SetDirty()
    {
    }

    [Token(Token = "0x20023C0")]
    public enum Constraint
    {
      [Token(Token = "0x400A17B")] Flexible,
      [Token(Token = "0x400A17C")] FixedColumnCount,
      [Token(Token = "0x400A17D")] FixedRowCount,
    }

    [Token(Token = "0x20023C1")]
    public enum Corner
    {
      [Token(Token = "0x400A17F")] UpperLeft,
      [Token(Token = "0x400A180")] UpperRight,
      [Token(Token = "0x400A181")] LowerLeft,
      [Token(Token = "0x400A182")] LowerRight,
    }

    [Token(Token = "0x20023C2")]
    public enum Axis
    {
      [Token(Token = "0x400A184")] Horizontal,
      [Token(Token = "0x400A185")] Vertical,
    }
  }
}

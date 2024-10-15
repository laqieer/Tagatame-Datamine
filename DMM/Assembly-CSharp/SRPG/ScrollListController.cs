// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollListController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A76")]
  [AddComponentMenu("UI/ScrollListController")]
  public class ScrollListController : MonoBehaviour
  {
    [Token(Token = "0x400CEBF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform m_ItemBase;
    [Token(Token = "0x400CEC0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Range(0.0f, 30f)]
    protected int m_ItemCnt;
    [Token(Token = "0x400CEC1")]
    [FieldOffset(Offset = "0x14")]
    public ScrollListController.OnItemPositionChange OnItemUpdate;
    [Token(Token = "0x400CEC2")]
    [FieldOffset(Offset = "0x18")]
    public ScrollListController.OnAfterStartUpEvent OnAfterStartup;
    [Token(Token = "0x400CEC3")]
    [FieldOffset(Offset = "0x1C")]
    public ScrollListController.OnUpdateEvent OnUpdateItemEvent;
    [Token(Token = "0x400CEC4")]
    [FieldOffset(Offset = "0x20")]
    public List<RectTransform> m_ItemList;
    [Token(Token = "0x400CEC5")]
    [FieldOffset(Offset = "0x24")]
    private List<Vector2> m_ItemPos;
    [Token(Token = "0x400CEC6")]
    [FieldOffset(Offset = "0x28")]
    private float m_PrevPosition;
    [Token(Token = "0x400CEC7")]
    [FieldOffset(Offset = "0x2C")]
    private int m_CurrentItemID;
    [Token(Token = "0x400CEC8")]
    [FieldOffset(Offset = "0x30")]
    public ScrollListController.Direction m_Direction;
    [Token(Token = "0x400CEC9")]
    [FieldOffset(Offset = "0x34")]
    public ScrollListController.Mode m_ScrollMode;
    [Token(Token = "0x400CECA")]
    [FieldOffset(Offset = "0x38")]
    public float Space;
    [Token(Token = "0x400CECB")]
    [FieldOffset(Offset = "0x3C")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x400CECC")]
    [FieldOffset(Offset = "0x40")]
    private float m_ItemScale;

    [Token(Token = "0x170019EA")]
    protected RectTransform GetRectTransForm
    {
      [Token(Token = "0x600C1EB"), Address(RVA = "0x8A2370", Offset = "0x8A1170", VA = "0x108A2370")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170019EB")]
    public float AnchoredPosition
    {
      [Token(Token = "0x600C1EC"), Address(RVA = "0x8A22D0", Offset = "0x8A10D0", VA = "0x108A22D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170019EC")]
    public float ItemScale
    {
      [Token(Token = "0x600C1ED"), Address(RVA = "0x8A23F0", Offset = "0x8A11F0", VA = "0x108A23F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170019ED")]
    public float ScrollDir
    {
      [Token(Token = "0x600C1EE"), Address(RVA = "0x8A24B0", Offset = "0x8A12B0", VA = "0x108A24B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170019EE")]
    public List<RectTransform> ItemList
    {
      [Token(Token = "0x600C1EF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<RectTransform>) null;
      }
    }

    [Token(Token = "0x170019EF")]
    public List<Vector2> ItemPosList
    {
      [Token(Token = "0x600C1F0"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<Vector2>) null;
      }
    }

    [Token(Token = "0x600C1F1")]
    [Address(RVA = "0x8A0F70", Offset = "0x89FD70", VA = "0x108A0F70", Slot = "4")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x600C1F2")]
    [Address(RVA = "0x8A1BB0", Offset = "0x8A09B0", VA = "0x108A1BB0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C1F3")]
    [Address(RVA = "0x8A15C0", Offset = "0x8A03C0", VA = "0x108A15C0")]
    public void UpdateList()
    {
    }

    [Token(Token = "0x600C1F4")]
    [Address(RVA = "0x8A0A90", Offset = "0x89F890", VA = "0x108A0A90")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C1F5")]
    [Address(RVA = "0x8A08A0", Offset = "0x89F6A0", VA = "0x108A08A0")]
    public void ClearItem()
    {
    }

    [Token(Token = "0x600C1F6")]
    [Address(RVA = "0x8A09C0", Offset = "0x89F7C0", VA = "0x108A09C0")]
    public bool MovePos(float goal, float move) => new bool();

    [Token(Token = "0x600C1F7")]
    [Address(RVA = "0x8A21A0", Offset = "0x8A0FA0", VA = "0x108A21A0")]
    public ScrollListController()
    {
    }

    [Token(Token = "0x2002A77")]
    [Serializable]
    public class OnItemPositionChange : UnityEvent<int, GameObject>
    {
      [Token(Token = "0x600C1F8")]
      [Address(RVA = "0x8A6450", Offset = "0x8A5250", VA = "0x108A6450")]
      public OnItemPositionChange()
      {
      }
    }

    [Token(Token = "0x2002A78")]
    [Serializable]
    public class OnAfterStartUpEvent : UnityEvent<bool>
    {
      [Token(Token = "0x600C1F9")]
      [Address(RVA = "0x8A6410", Offset = "0x8A5210", VA = "0x108A6410")]
      public OnAfterStartUpEvent()
      {
      }
    }

    [Token(Token = "0x2002A79")]
    [Serializable]
    public class OnUpdateEvent : UnityEvent<List<RectTransform>>
    {
      [Token(Token = "0x600C1FA")]
      [Address(RVA = "0x8A6490", Offset = "0x8A5290", VA = "0x108A6490")]
      public OnUpdateEvent()
      {
      }
    }

    [Token(Token = "0x2002A7A")]
    public enum Direction
    {
      [Token(Token = "0x400CECE")] Vertical,
      [Token(Token = "0x400CECF")] Horizontal,
    }

    [Token(Token = "0x2002A7B")]
    public enum Mode
    {
      [Token(Token = "0x400CED1")] Normal,
      [Token(Token = "0x400CED2")] Reverse,
    }
  }
}

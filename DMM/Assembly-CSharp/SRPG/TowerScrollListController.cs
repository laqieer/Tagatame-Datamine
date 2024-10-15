// Decompiled with JetBrains decompiler
// Type: SRPG.TowerScrollListController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B64")]
  [AddComponentMenu("UI/TowerScrollListController")]
  [FlowNode.Pin(0, "背景ロード完了", FlowNode.PinTypes.Output, 0)]
  public class TowerScrollListController : MonoBehaviour
  {
    [Token(Token = "0x400D478")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform m_ItemBase;
    [Token(Token = "0x400D479")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    internal TowerScrollListController.ScrollMode m_ScrollMode;
    [Token(Token = "0x400D47A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Range(0.0f, 30f)]
    protected int m_ItemCnt;
    [Token(Token = "0x400D47B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float m_Margin;
    [Token(Token = "0x400D47C")]
    [FieldOffset(Offset = "0x1C")]
    public List<RectTransform> m_ItemList;
    [Token(Token = "0x400D47D")]
    [FieldOffset(Offset = "0x20")]
    private float m_PrevPosition;
    [Token(Token = "0x400D47E")]
    [FieldOffset(Offset = "0x24")]
    private int m_CurrentItemID;
    [Token(Token = "0x400D47F")]
    [FieldOffset(Offset = "0x28")]
    public TowerScrollListController.Direction m_Direction;
    [Token(Token = "0x400D480")]
    [FieldOffset(Offset = "0x2C")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x400D481")]
    [FieldOffset(Offset = "0x30")]
    public TowerScrollListController.OnItemPositionChange OnItemUpdate;
    [Token(Token = "0x400D482")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RectTransform Cursor;
    [Token(Token = "0x400D483")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollAutoFit m_ScrollAutoFit;
    [Token(Token = "0x400D484")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private SyncScroll m_ScrollBG;
    [Token(Token = "0x400D485")]
    [FieldOffset(Offset = "0x40")]
    public Selectable PageUpButton;
    [Token(Token = "0x400D486")]
    [FieldOffset(Offset = "0x44")]
    public Selectable PageDownButton;
    [Token(Token = "0x400D487")]
    [FieldOffset(Offset = "0x48")]
    public TowerScrollListController.ListItemFocusEvent OnListItemFocus;
    [Token(Token = "0x400D488")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mChallengeButton;
    [Token(Token = "0x400D489")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Animator FadeAnimator;
    [Token(Token = "0x400D48A")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private RawImage Bg;
    [Token(Token = "0x400D48B")]
    [FieldOffset(Offset = "0x0")]
    private static string BGTexturePath;
    [Token(Token = "0x400D48C")]
    [FieldOffset(Offset = "0x4")]
    private static string FloorBGTexturePath;
    [Token(Token = "0x400D48D")]
    [FieldOffset(Offset = "0x8")]
    private static string LockFloorBGTexturePath;
    [Token(Token = "0x400D48E")]
    [FieldOffset(Offset = "0x58")]
    private float m_ItemScale;

    [Token(Token = "0x17001A5D")]
    public float Margin
    {
      [Token(Token = "0x600C6CD"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001A5E")]
    protected RectTransform GetRectTransForm
    {
      [Token(Token = "0x600C6CE"), Address(RVA = "0x8F9550", Offset = "0x8F8350", VA = "0x108F9550")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17001A5F")]
    public float ItemScale
    {
      [Token(Token = "0x600C6CF"), Address(RVA = "0x8F95F0", Offset = "0x8F83F0", VA = "0x108F95F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001A60")]
    public float ItemScaleMargin
    {
      [Token(Token = "0x600C6D0"), Address(RVA = "0x8F95D0", Offset = "0x8F83D0", VA = "0x108F95D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C6D1")]
    [Address(RVA = "0x8F7A50", Offset = "0x8F6850", VA = "0x108F7A50")]
    internal static void SetAnchor(
      RectTransform rt,
      TowerScrollListController.ScrollMode scrollMode)
    {
    }

    [Token(Token = "0x600C6D2")]
    [Address(RVA = "0x8F7FC0", Offset = "0x8F6DC0", VA = "0x108F7FC0")]
    internal static void SetItemAnchor(
      RectTransform rt,
      TowerScrollListController.ScrollMode scrollMode)
    {
    }

    [Token(Token = "0x600C6D3")]
    [Address(RVA = "0x8F7BB0", Offset = "0x8F69B0", VA = "0x108F7BB0")]
    internal void SetAnchor(TowerScrollListController.ScrollMode scrollMode)
    {
    }

    [Token(Token = "0x600C6D4")]
    [Address(RVA = "0x8F8400", Offset = "0x8F7200", VA = "0x108F8400", Slot = "4")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x17001A61")]
    private float AnchoredPosition
    {
      [Token(Token = "0x600C6D5"), Address(RVA = "0x8F94B0", Offset = "0x8F82B0", VA = "0x108F94B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C6D6")]
    [Address(RVA = "0x8F7EE0", Offset = "0x8F6CE0", VA = "0x108F7EE0")]
    public void SetAnchoredPosition(float position)
    {
    }

    [Token(Token = "0x600C6D7")]
    [Address(RVA = "0x8F75E0", Offset = "0x8F63E0", VA = "0x108F75E0")]
    private void OnScrollStop()
    {
    }

    [Token(Token = "0x600C6D8")]
    [Address(RVA = "0x8F6AB0", Offset = "0x8F58B0", VA = "0x108F6AB0")]
    private void FocusUpdate()
    {
    }

    [Token(Token = "0x600C6D9")]
    [Address(RVA = "0x8F6E20", Offset = "0x8F5C20", VA = "0x108F6E20")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600C6DA")]
    [Address(RVA = "0x8F7190", Offset = "0x8F5F90", VA = "0x108F7190")]
    private void MovePosition(float scrollDir)
    {
    }

    [Token(Token = "0x600C6DB")]
    [Address(RVA = "0x8F8C20", Offset = "0x8F7A20", VA = "0x108F8C20")]
    public void UpdateList()
    {
    }

    [Token(Token = "0x600C6DC")]
    [Address(RVA = "0x8F6A40", Offset = "0x8F5840", VA = "0x108F6A40")]
    public void ChangeScrollMode(TowerScrollListController.ScrollMode scrollMode)
    {
    }

    [Token(Token = "0x600C6DD")]
    [Address(RVA = "0x8F91E0", Offset = "0x8F7FE0", VA = "0x108F91E0")]
    private void _SetScrollTo(float pos)
    {
    }

    [Token(Token = "0x600C6DE")]
    [Address(RVA = "0x8F8140", Offset = "0x8F6F40", VA = "0x108F8140")]
    public void SetScrollTo(float pos)
    {
    }

    [Token(Token = "0x600C6DF")]
    [Address(RVA = "0x8F7990", Offset = "0x8F6790", VA = "0x108F7990")]
    public void PageUp(int value)
    {
    }

    [Token(Token = "0x600C6E0")]
    [Address(RVA = "0x8F78D0", Offset = "0x8F66D0", VA = "0x108F78D0")]
    public void PageDown(int value)
    {
    }

    [Token(Token = "0x17001A62")]
    private Vector2 ScrollDir
    {
      [Token(Token = "0x600C6E1"), Address(RVA = "0x8F96B0", Offset = "0x8F84B0", VA = "0x108F96B0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x600C6E2")]
    [Address(RVA = "0x8F7120", Offset = "0x8F5F20", VA = "0x108F7120")]
    public IEnumerator LoadTowerBG(TowerQuestListItem[] tower_quest_list) => (IEnumerator) null;

    [Token(Token = "0x600C6E3")]
    [Address(RVA = "0x8F8180", Offset = "0x8F6F80", VA = "0x108F8180")]
    public void SetTowerImage(
      LoadRequest floor_req,
      int index,
      string image_name,
      TowerQuestListItem[] tower_quest_list)
    {
    }

    [Token(Token = "0x600C6E4")]
    [Address(RVA = "0x8F93C0", Offset = "0x8F81C0", VA = "0x108F93C0")]
    public TowerScrollListController()
    {
    }

    [Token(Token = "0x600C6E5")]
    [Address(RVA = "0x8F9310", Offset = "0x8F8110", VA = "0x108F9310")]
    static TowerScrollListController()
    {
    }

    [Token(Token = "0x2002B65")]
    [Serializable]
    public class OnItemPositionChange : UnityEvent<int, GameObject>
    {
      [Token(Token = "0x600C6E6")]
      [Address(RVA = "0x8F5ED0", Offset = "0x8F4CD0", VA = "0x108F5ED0")]
      public OnItemPositionChange()
      {
      }
    }

    [Token(Token = "0x2002B66")]
    public enum Direction
    {
      [Token(Token = "0x400D490")] Vertical,
      [Token(Token = "0x400D491")] Horizontal,
    }

    [Token(Token = "0x2002B67")]
    public enum ScrollMode
    {
      [Token(Token = "0x400D493")] Normal,
      [Token(Token = "0x400D494")] Reverse,
    }

    [Token(Token = "0x2002B68")]
    [SerializeField]
    public class ListItemFocusEvent : UnityEvent<GameObject>
    {
      [Token(Token = "0x600C6E7")]
      [Address(RVA = "0x8F5E90", Offset = "0x8F4C90", VA = "0x108F5E90")]
      public ListItemFocusEvent()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollClamped_JobIcons
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
  [Token(Token = "0x2002A69")]
  [AddComponentMenu("UI/ScrollClamped_JobIcons")]
  public class ScrollClamped_JobIcons : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400CE5D")]
    [FieldOffset(Offset = "0xC")]
    private float FRAME_OUT_POSITION_VALUE;
    [Token(Token = "0x400CE5E")]
    [FieldOffset(Offset = "0x10")]
    private float JOB_ICON_DISP_EFFECT_TIME;
    [Token(Token = "0x400CE5F")]
    [FieldOffset(Offset = "0x14")]
    private float MIN_SCALE_DOUBLE;
    [Token(Token = "0x400CE60")]
    [FieldOffset(Offset = "0x18")]
    private float MIN_SCALE_SINGLE;
    [Token(Token = "0x400CE61")]
    [FieldOffset(Offset = "0x1C")]
    private float VELOCITY_MAX;
    [Token(Token = "0x400CE62")]
    [FieldOffset(Offset = "0x20")]
    private float AUTOFIT_BEGIN_VELOCITY;
    [Token(Token = "0x400CE63")]
    [FieldOffset(Offset = "0x24")]
    public float Space;
    [Token(Token = "0x400CE64")]
    [FieldOffset(Offset = "0x28")]
    public int Max;
    [Token(Token = "0x400CE65")]
    [FieldOffset(Offset = "0x2C")]
    public RectTransform ViewObj;
    [Token(Token = "0x400CE66")]
    [FieldOffset(Offset = "0x30")]
    public ScrollAutoFit AutoFit;
    [Token(Token = "0x400CE67")]
    [FieldOffset(Offset = "0x34")]
    public Button back;
    [Token(Token = "0x400CE68")]
    [FieldOffset(Offset = "0x38")]
    private JobIconScrollListController mController;
    [Token(Token = "0x400CE69")]
    [FieldOffset(Offset = "0x3C")]
    private float mOffset;
    [Token(Token = "0x400CE6A")]
    [FieldOffset(Offset = "0x40")]
    private float mStartPos;
    [Token(Token = "0x400CE6B")]
    [FieldOffset(Offset = "0x44")]
    private float mCenter;
    [Token(Token = "0x400CE6C")]
    [FieldOffset(Offset = "0x48")]
    private int mSelectIdx;
    [Token(Token = "0x400CE6D")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsSelected;
    [Token(Token = "0x400CE6E")]
    [FieldOffset(Offset = "0x4D")]
    private bool mIsImmediateFocusNow;
    [Token(Token = "0x400CE6F")]
    [FieldOffset(Offset = "0x50")]
    private float mDefaultAutoFitTime;
    [Token(Token = "0x400CE70")]
    [FieldOffset(Offset = "0x54")]
    private WindowController mWindowController;
    [Token(Token = "0x400CE71")]
    [FieldOffset(Offset = "0x58")]
    private bool mIsNeedAutoFit;
    [Token(Token = "0x400CE72")]
    [FieldOffset(Offset = "0x59")]
    private bool mIsPreDragging;
    [Token(Token = "0x400CE73")]
    [FieldOffset(Offset = "0x5A")]
    private bool mIsFocusNow;
    [Token(Token = "0x400CE74")]
    [FieldOffset(Offset = "0x5C")]
    private Vector2 mDragStartLocalPosition;
    [Token(Token = "0x400CE75")]
    [FieldOffset(Offset = "0x64")]
    private Vector3 mDefaultViewportLocalPosition;
    [Token(Token = "0x400CE76")]
    [FieldOffset(Offset = "0x70")]
    private float mJobIconDispEffectTime;
    [Token(Token = "0x400CE77")]
    [FieldOffset(Offset = "0x74")]
    public ScrollClamped_JobIcons.FrameOutItem OnFrameOutItem;

    [Token(Token = "0x170019E4")]
    private WindowController WinController
    {
      [Token(Token = "0x600C196"), Address(RVA = "0x89D110", Offset = "0x89BF10", VA = "0x1089D110")] get
      {
        return (WindowController) null;
      }
    }

    [Token(Token = "0x170019E5")]
    private bool IsNeedAutoFit
    {
      [Token(Token = "0x600C197"), Address(RVA = "0x287F60", Offset = "0x286D60", VA = "0x10287F60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C198"), Address(RVA = "0x89D190", Offset = "0x89BF90", VA = "0x1089D190")] set
      {
      }
    }

    [Token(Token = "0x600C199")]
    [Address(RVA = "0x89CC20", Offset = "0x89BA20", VA = "0x1089CC20")]
    public void Start()
    {
    }

    [Token(Token = "0x600C19A")]
    [Address(RVA = "0x89CED0", Offset = "0x89BCD0", VA = "0x1089CED0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C19B")]
    [Address(RVA = "0x89BD70", Offset = "0x89AB70", VA = "0x1089BD70")]
    private void CheckNeedExecAutoFocus()
    {
    }

    [Token(Token = "0x600C19C")]
    [Address(RVA = "0x89C560", Offset = "0x89B360", VA = "0x1089C560")]
    private void ImmediateFocus()
    {
    }

    [Token(Token = "0x600C19D")]
    [Address(RVA = "0x89CE90", Offset = "0x89BC90", VA = "0x1089CE90")]
    private void UpdateIsNeedAutoFitFlagByWheel()
    {
    }

    [Token(Token = "0x600C19E")]
    [Address(RVA = "0x89CDA0", Offset = "0x89BBA0", VA = "0x1089CDA0")]
    private void UpdateIsNeedAutoFitFlagByDrag()
    {
    }

    [Token(Token = "0x600C19F")]
    [Address(RVA = "0x89C6B0", Offset = "0x89B4B0", VA = "0x1089C6B0")]
    private void OnScrollStop()
    {
    }

    [Token(Token = "0x600C1A0")]
    [Address(RVA = "0x89C730", Offset = "0x89B530", VA = "0x1089C730", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C1A1")]
    [Address(RVA = "0x89C840", Offset = "0x89B640", VA = "0x1089C840", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C1A2")]
    [Address(RVA = "0x89C650", Offset = "0x89B450", VA = "0x1089C650")]
    public void OnItemPositionAreaOver(GameObject obj)
    {
    }

    [Token(Token = "0x600C1A3")]
    [Address(RVA = "0x89C890", Offset = "0x89B690", VA = "0x1089C890")]
    public void OnUpdateScale(List<JobIconScrollListController.ItemData> items)
    {
    }

    [Token(Token = "0x600C1A4")]
    [Address(RVA = "0x89C620", Offset = "0x89B420", VA = "0x1089C620")]
    public void OnClick(GameObject obj)
    {
    }

    [Token(Token = "0x600C1A5")]
    [Address(RVA = "0x89BFE0", Offset = "0x89ADE0", VA = "0x1089BFE0")]
    public GameObject Focus(
      List<GameObject> objects,
      bool is_immediate = false,
      bool is_hide = false,
      float focus_time = 0.0f)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600C1A6")]
    [Address(RVA = "0x89C1B0", Offset = "0x89AFB0", VA = "0x1089C1B0")]
    public void Focus(GameObject obj, bool is_immediate = false, bool is_hide = false, float focus_time = 0.0f)
    {
    }

    [Token(Token = "0x600C1A7")]
    [Address(RVA = "0x89D0C0", Offset = "0x89BEC0", VA = "0x1089D0C0")]
    public ScrollClamped_JobIcons()
    {
    }

    [Token(Token = "0x2002A6A")]
    public delegate void FrameOutItem(GameObject target, int index);
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollAutoFit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A63")]
  [FlowNode.Pin(1, "無効化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "有効化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "無効化完了", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "有効化完了", FlowNode.PinTypes.Output, 2)]
  public class ScrollAutoFit : SRPG_ScrollRect, IFlowInterface
  {
    [Token(Token = "0x400CE44")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    [HideInInspector]
    public bool UseAutoFit;
    [Token(Token = "0x400CE45")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    [HideInInspector]
    public float FitTime;
    [Token(Token = "0x400CE46")]
    [FieldOffset(Offset = "0x12C")]
    [HideInInspector]
    [SerializeField]
    public float ItemScale;
    [Token(Token = "0x400CE47")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    [HideInInspector]
    public bool HorizontalMode;
    [Token(Token = "0x400CE48")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public float Offset;
    [Token(Token = "0x400CE49")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public bool UseMoveRange;
    [Token(Token = "0x400CE4A")]
    [FieldOffset(Offset = "0x13C")]
    private ScrollAutoFit.State mState;
    [Token(Token = "0x400CE4B")]
    [FieldOffset(Offset = "0x140")]
    private float mStartPos;
    [Token(Token = "0x400CE4C")]
    [FieldOffset(Offset = "0x144")]
    private float mEndPos;
    [Token(Token = "0x400CE4D")]
    [FieldOffset(Offset = "0x148")]
    private float mScrollAnimTime;
    [Token(Token = "0x400CE4E")]
    [FieldOffset(Offset = "0x14C")]
    private bool isDragging;
    [Token(Token = "0x400CE4F")]
    [FieldOffset(Offset = "0x150")]
    private RectTransform rectTransform;
    [Token(Token = "0x400CE50")]
    [FieldOffset(Offset = "0x154")]
    private int mStartIdx;
    [Token(Token = "0x400CE51")]
    [FieldOffset(Offset = "0x158")]
    private Vector2 mStartDragPos;
    [Token(Token = "0x400CE52")]
    [FieldOffset(Offset = "0x160")]
    private bool mForceScroll;
    [Token(Token = "0x400CE53")]
    [FieldOffset(Offset = "0x164")]
    public ScrollAutoFit.ScrollStopEvent OnScrollStop;
    [Token(Token = "0x400CE54")]
    [FieldOffset(Offset = "0x168")]
    public ScrollAutoFit.ScrollBeginEvent OnScrollBegin;
    [Token(Token = "0x400CE55")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    public ScrollAutoFit.ContentChangedEvent OnContentChanged;

    [Token(Token = "0x170019DE")]
    public ScrollAutoFit.State CurrentState
    {
      [Token(Token = "0x600C174"), Address(RVA = "0x5B2840", Offset = "0x5B1640", VA = "0x105B2840")] get
      {
        return new ScrollAutoFit.State();
      }
    }

    [Token(Token = "0x170019DF")]
    public Rect rect
    {
      [Token(Token = "0x600C175"), Address(RVA = "0x89BCE0", Offset = "0x89AAE0", VA = "0x1089BCE0")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x600C176")]
    [Address(RVA = "0x89AC90", Offset = "0x899A90", VA = "0x1089AC90", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600C177")]
    [Address(RVA = "0x89B500", Offset = "0x89A300", VA = "0x1089B500", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C178")]
    [Address(RVA = "0x89B240", Offset = "0x89A040", VA = "0x1089B240", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C179")]
    [Address(RVA = "0x89B1C0", Offset = "0x899FC0", VA = "0x1089B1C0")]
    private void OnContentChangedListner(Vector2 value)
    {
    }

    [Token(Token = "0x170019E0")]
    public int DragStartIdx
    {
      [Token(Token = "0x600C17A"), Address(RVA = "0x3495B0", Offset = "0x3483B0", VA = "0x103495B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C17B"), Address(RVA = "0x89BD20", Offset = "0x89AB20", VA = "0x1089BD20")] set
      {
      }
    }

    [Token(Token = "0x170019E1")]
    public Vector2 DragStartPos
    {
      [Token(Token = "0x600C17C"), Address(RVA = "0x89BC40", Offset = "0x89AA40", VA = "0x1089BC40")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x600C17D"), Address(RVA = "0x89BD40", Offset = "0x89AB40", VA = "0x1089BD40")] set
      {
      }
    }

    [Token(Token = "0x170019E2")]
    public bool IsDrag
    {
      [Token(Token = "0x600C17E"), Address(RVA = "0x89BC70", Offset = "0x89AA70", VA = "0x1089BC70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019E3")]
    public bool IsMove
    {
      [Token(Token = "0x600C17F"), Address(RVA = "0x89BC80", Offset = "0x89AA80", VA = "0x1089BC80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C180")]
    [Address(RVA = "0x89B660", Offset = "0x89A460", VA = "0x1089B660")]
    private void Update()
    {
    }

    [Token(Token = "0x600C181")]
    [Address(RVA = "0x89B5F0", Offset = "0x89A3F0", VA = "0x1089B5F0")]
    private void UpdateWait()
    {
    }

    [Token(Token = "0x600C182")]
    [Address(RVA = "0x89B110", Offset = "0x899F10", VA = "0x1089B110", Slot = "44")]
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C183")]
    [Address(RVA = "0x89B2D0", Offset = "0x89A0D0", VA = "0x1089B2D0", Slot = "45")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C184")]
    [Address(RVA = "0x89B4A0", Offset = "0x89A2A0", VA = "0x1089B4A0")]
    public void SetScrollTo(float pos)
    {
    }

    [Token(Token = "0x600C185")]
    [Address(RVA = "0x89B410", Offset = "0x89A210", VA = "0x1089B410")]
    public void SetScrollTo(int index)
    {
    }

    [Token(Token = "0x600C186")]
    [Address(RVA = "0x89B320", Offset = "0x89A120", VA = "0x1089B320")]
    public void SetScrollToHorizontal(float pos)
    {
    }

    [Token(Token = "0x600C187")]
    [Address(RVA = "0x89B380", Offset = "0x89A180", VA = "0x1089B380")]
    public void SetScrollToHorizontal(int index)
    {
    }

    [Token(Token = "0x600C188")]
    [Address(RVA = "0x89AC40", Offset = "0x899A40", VA = "0x1089AC40", Slot = "61")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C189")]
    [Address(RVA = "0x89AE30", Offset = "0x899C30", VA = "0x1089AE30")]
    public int GetCurrent() => new int();

    [Token(Token = "0x600C18A")]
    [Address(RVA = "0x89B5E0", Offset = "0x89A3E0", VA = "0x1089B5E0")]
    public void Step()
    {
    }

    [Token(Token = "0x600C18B")]
    [Address(RVA = "0x89B020", Offset = "0x899E20", VA = "0x1089B020")]
    private void MoveContentRange()
    {
    }

    [Token(Token = "0x600C18C")]
    [Address(RVA = "0x89AD40", Offset = "0x899B40", VA = "0x1089AD40")]
    private bool CheckSetScrollPos() => new bool();

    [Token(Token = "0x600C18D")]
    [Address(RVA = "0x89AEA0", Offset = "0x899CA0", VA = "0x1089AEA0")]
    private float GetNearIconPos() => new float();

    [Token(Token = "0x600C18E")]
    [Address(RVA = "0x89BB40", Offset = "0x89A940", VA = "0x1089BB40")]
    public ScrollAutoFit()
    {
    }

    [Token(Token = "0x2002A64")]
    public enum State
    {
      [Token(Token = "0x400CE57")] Wait,
      [Token(Token = "0x400CE58")] Dragging,
      [Token(Token = "0x400CE59")] DragEnd,
      [Token(Token = "0x400CE5A")] Scrolling,
    }

    [Token(Token = "0x2002A65")]
    [SerializeField]
    public class ScrollStopEvent : UnityEvent
    {
      [Token(Token = "0x600C18F")]
      [Address(RVA = "0x89BD60", Offset = "0x89AB60", VA = "0x1089BD60")]
      public ScrollStopEvent()
      {
      }
    }

    [Token(Token = "0x2002A66")]
    [SerializeField]
    public class ScrollBeginEvent : UnityEvent
    {
      [Token(Token = "0x600C190")]
      [Address(RVA = "0x89BD60", Offset = "0x89AB60", VA = "0x1089BD60")]
      public ScrollBeginEvent()
      {
      }
    }

    [Token(Token = "0x2002A67")]
    [Serializable]
    public class ContentChangedEvent : UnityEvent<float>
    {
      [Token(Token = "0x600C191")]
      [Address(RVA = "0x8918E0", Offset = "0x8906E0", VA = "0x108918E0")]
      public ContentChangedEvent()
      {
      }
    }
  }
}

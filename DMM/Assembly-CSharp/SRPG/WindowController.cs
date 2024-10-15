// Decompiled with JetBrains decompiler
// Type: SRPG.WindowController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D35")]
  [FlowNode.Pin(21, "Closed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Opened", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(6, "Unlock", FlowNode.PinTypes.Input, 6)]
  [AddComponentMenu("UI/WindowController")]
  [FlowNode.Pin(5, "Lock", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(20, "Close", FlowNode.PinTypes.Input, 2)]
  public class WindowController : UIBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E158")]
    [FieldOffset(Offset = "0xC")]
    public WindowController.WindowStateChangeEvent OnWindowStateChange;
    [Token(Token = "0x400E159")]
    [FieldOffset(Offset = "0x10")]
    public Transform Body;
    [Token(Token = "0x400E15A")]
    [FieldOffset(Offset = "0x14")]
    public string StateInt;
    [Token(Token = "0x400E15B")]
    [FieldOffset(Offset = "0x18")]
    public string StateBool;
    [Token(Token = "0x400E15C")]
    [FieldOffset(Offset = "0x1C")]
    public bool InvertState;
    [Token(Token = "0x400E15D")]
    [FieldOffset(Offset = "0x1D")]
    public bool StartOpened;
    [Token(Token = "0x400E15E")]
    [FieldOffset(Offset = "0x1E")]
    public bool UpdateCollision;
    [Token(Token = "0x400E15F")]
    [FieldOffset(Offset = "0x1F")]
    public bool AutoSwap;
    [Token(Token = "0x400E160")]
    [FieldOffset(Offset = "0x20")]
    public bool ToggleCanvas;
    [Token(Token = "0x400E161")]
    [FieldOffset(Offset = "0x24")]
    public string OpenedState;
    [Token(Token = "0x400E162")]
    [FieldOffset(Offset = "0x28")]
    public string ClosedState;
    [Token(Token = "0x400E163")]
    [FieldOffset(Offset = "0x2C")]
    private bool mHasCanvasStack;
    [Token(Token = "0x400E164")]
    [FieldOffset(Offset = "0x2D")]
    private bool mDesiredState;
    [Token(Token = "0x400E165")]
    [FieldOffset(Offset = "0x30")]
    private Animator mAnimator;
    [Token(Token = "0x400E166")]
    [FieldOffset(Offset = "0x34")]
    private bool mOpened;
    [Token(Token = "0x400E167")]
    [FieldOffset(Offset = "0x35")]
    private bool mPollState;
    [Token(Token = "0x400E168")]
    [FieldOffset(Offset = "0x38")]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400E169")]
    [FieldOffset(Offset = "0x3C")]
    private bool mSwappedOut;
    [Token(Token = "0x400E16A")]
    [FieldOffset(Offset = "0x3D")]
    private bool mJustOpened;
    [Token(Token = "0x400E16B")]
    [FieldOffset(Offset = "0x3E")]
    private bool mJustClosed;

    [Token(Token = "0x600D2A9")]
    [Address(RVA = "0x9DC1A0", Offset = "0x9DAFA0", VA = "0x109DC1A0")]
    public static void OpenIfAvailable(Component c)
    {
    }

    [Token(Token = "0x600D2AA")]
    [Address(RVA = "0x9DBEF0", Offset = "0x9DACF0", VA = "0x109DBEF0")]
    public static void CloseIfAvailable(Component c)
    {
    }

    [Token(Token = "0x600D2AB")]
    [Address(RVA = "0x9DC4C0", Offset = "0x9DB2C0", VA = "0x109DC4C0")]
    private void UpdateAnimator(bool visible)
    {
    }

    [Token(Token = "0x17001B9C")]
    public bool IsOpened
    {
      [Token(Token = "0x600D2AC"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001B9D")]
    public bool IsClosed
    {
      [Token(Token = "0x600D2AD"), Address(RVA = "0x9DC790", Offset = "0x9DB590", VA = "0x109DC790")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D2AE")]
    [Address(RVA = "0x9DC220", Offset = "0x9DB020", VA = "0x109DC220")]
    public void Open()
    {
    }

    [Token(Token = "0x600D2AF")]
    [Address(RVA = "0x9DBF90", Offset = "0x9DAD90", VA = "0x109DBF90")]
    public void Close()
    {
    }

    [Token(Token = "0x600D2B0")]
    [Address(RVA = "0x9DBFD0", Offset = "0x9DADD0", VA = "0x109DBFD0")]
    public void ForceClose()
    {
    }

    [Token(Token = "0x600D2B1")]
    [Address(RVA = "0x9DC020", Offset = "0x9DAE20", VA = "0x109DC020")]
    public void ForceOpen()
    {
    }

    [Token(Token = "0x600D2B2")]
    [Address(RVA = "0x9DC090", Offset = "0x9DAE90", VA = "0x109DC090")]
    public bool IsOpening() => new bool();

    [Token(Token = "0x600D2B3")]
    [Address(RVA = "0x9DC070", Offset = "0x9DAE70", VA = "0x109DC070")]
    public bool IsClosing() => new bool();

    [Token(Token = "0x600D2B4")]
    [Address(RVA = "0x9DBD80", Offset = "0x9DAB80", VA = "0x109DBD80", Slot = "17")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D2B5")]
    [Address(RVA = "0x9DC410", Offset = "0x9DB210", VA = "0x109DC410")]
    private void SwapWindow(bool visible)
    {
    }

    [Token(Token = "0x600D2B6")]
    [Address(RVA = "0x9DC280", Offset = "0x9DB080", VA = "0x109DC280")]
    private void SetCanvas(bool visible)
    {
    }

    [Token(Token = "0x600D2B7")]
    [Address(RVA = "0x9DC340", Offset = "0x9DB140", VA = "0x109DC340")]
    public void SetCollision(bool collide)
    {
    }

    [Token(Token = "0x600D2B8")]
    [Address(RVA = "0x9DBE10", Offset = "0x9DAC10", VA = "0x109DBE10", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600D2B9")]
    [Address(RVA = "0x9DC3C0", Offset = "0x9DB1C0", VA = "0x109DC3C0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600D2BA")]
    [Address(RVA = "0x9DC0E0", Offset = "0x9DAEE0", VA = "0x109DC0E0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600D2BB")]
    [Address(RVA = "0x9DC530", Offset = "0x9DB330", VA = "0x109DC530")]
    private void Update()
    {
    }

    [Token(Token = "0x600D2BC")]
    [Address(RVA = "0x9DC180", Offset = "0x9DAF80", VA = "0x109DC180")]
    public void OnOpen()
    {
    }

    [Token(Token = "0x600D2BD")]
    [Address(RVA = "0x9DC0C0", Offset = "0x9DAEC0", VA = "0x109DC0C0")]
    public void OnClose()
    {
    }

    [Token(Token = "0x600D2BE")]
    [Address(RVA = "0x9DC6E0", Offset = "0x9DB4E0", VA = "0x109DC6E0")]
    public WindowController()
    {
    }

    [Token(Token = "0x2002D36")]
    public delegate void WindowStateChangeEvent(GameObject go, bool visible);
  }
}

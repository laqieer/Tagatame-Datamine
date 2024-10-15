// Decompiled with JetBrains decompiler
// Type: SRPG.SwipeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021BE")]
  [FlowNode.Pin(1, "スワイプ完了", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "左スワイプ", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "右スワイプ", FlowNode.PinTypes.Output, 11)]
  public class SwipeController : 
    TouchController,
    IFlowInterface,
    IPointerClickHandler,
    IEventSystemHandler
  {
    [Token(Token = "0x40093E8")]
    private const int PIN_INPUT_SWIPE_FINISH = 1;
    [Token(Token = "0x40093E9")]
    private const int PIN_OUT_LEFT_SWIPE = 10;
    [Token(Token = "0x40093EA")]
    private const int PIN_OUT_RIGHT_SWIPE = 11;
    [Token(Token = "0x40093EB")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private RectTransform MoveObj;
    [Token(Token = "0x40093EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float JugdeNum;
    [Token(Token = "0x40093ED")]
    [FieldOffset(Offset = "0x5C")]
    private bool mSwipeFlag;
    [Token(Token = "0x40093EE")]
    [FieldOffset(Offset = "0x5D")]
    private bool mSwipeAnimFlag;
    [Token(Token = "0x40093EF")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 mStartPos;

    [Token(Token = "0x6008E2E")]
    [Address(RVA = "0x51EB80", Offset = "0x51D980", VA = "0x1051EB80", Slot = "7")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008E2F")]
    [Address(RVA = "0x51EC50", Offset = "0x51DA50", VA = "0x1051EC50")]
    private void Start()
    {
    }

    [Token(Token = "0x6008E30")]
    [Address(RVA = "0x51EE40", Offset = "0x51DC40", VA = "0x1051EE40")]
    private void Update()
    {
    }

    [Token(Token = "0x6008E31")]
    [Address(RVA = "0x51EDA0", Offset = "0x51DBA0", VA = "0x1051EDA0")]
    private void SwipeLeft()
    {
    }

    [Token(Token = "0x6008E32")]
    [Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x1051EDF0")]
    private void SwipeRight()
    {
    }

    [Token(Token = "0x6008E33")]
    [Address(RVA = "0x51ECE0", Offset = "0x51DAE0", VA = "0x1051ECE0")]
    private void SwipeEnd()
    {
    }

    [Token(Token = "0x6008E34")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    public void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6008E35")]
    [Address(RVA = "0x51F020", Offset = "0x51DE20", VA = "0x1051F020")]
    public SwipeController()
    {
    }
  }
}

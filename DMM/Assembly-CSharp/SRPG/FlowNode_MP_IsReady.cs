// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_IsReady
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D5")]
  [FlowNode.Pin(403, "Can challenge Floor", FlowNode.PinTypes.Input, 403)]
  [FlowNode.Pin(404, "Not set Same Unit", FlowNode.PinTypes.Input, 404)]
  [FlowNode.Pin(405, "Can Solo", FlowNode.PinTypes.Input, 405)]
  [FlowNode.Pin(200, "Room is Full", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(402, "Can Conditions self", FlowNode.PinTypes.Input, 402)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(401, "Can Conditions others", FlowNode.PinTypes.Input, 401)]
  [FlowNode.NodeType("MultiPlay/Room/MultiPlayIsReady", 32741)]
  [FlowNode.Pin(301, "Is Enough AP Tower", FlowNode.PinTypes.Input, 301)]
  [FlowNode.Pin(300, "Is Enough AP", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(102, "Is Ready except Host", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(101, "Is Ready All", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(100, "Is Ready Self", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(400, "Is not Duplicate place", FlowNode.PinTypes.Input, 400)]
  public class FlowNode_MP_IsReady : FlowNode
  {
    [Token(Token = "0x40055BA")]
    private const int PIN_IN_IS_READY_SELF = 100;
    [Token(Token = "0x40055BB")]
    private const int PIN_IN_IS_READY_ALL = 101;
    [Token(Token = "0x40055BC")]
    private const int PIN_IN_IS_READY_OTHER = 102;
    [Token(Token = "0x40055BD")]
    private const int PIN_IN_IS_FULL = 200;
    [Token(Token = "0x40055BE")]
    private const int PIN_IN_ENOUGH_AP = 300;
    [Token(Token = "0x40055BF")]
    private const int PIN_IN_ENOUGH_AP_MT = 301;
    [Token(Token = "0x40055C0")]
    private const int PIN_IN_NOT_DUPLICATE = 400;
    [Token(Token = "0x40055C1")]
    private const int PIN_IN_CAN_CONDITIONS_OTHER = 401;
    [Token(Token = "0x40055C2")]
    private const int PIN_IN_CAN_CONDITIONS_SELF = 402;
    [Token(Token = "0x40055C3")]
    private const int PIN_IN_CAN_CHALLENGE = 403;
    [Token(Token = "0x40055C4")]
    private const int PIN_IN_SAME_UNIT = 404;
    [Token(Token = "0x40055C5")]
    private const int PIN_IN_CAN_SOLO = 405;
    [Token(Token = "0x40055C6")]
    private const int PIN_OUT_YES = 1;
    [Token(Token = "0x40055C7")]
    private const int PIN_OUT_NO = 2;

    [Token(Token = "0x600607D")]
    [Address(RVA = "0x134C530", Offset = "0x134B330", VA = "0x1134C530", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600607E")]
    [Address(RVA = "0x134C4F0", Offset = "0x134B2F0", VA = "0x1134C4F0")]
    private bool IsReadySelf() => new bool();

    [Token(Token = "0x600607F")]
    [Address(RVA = "0x134C370", Offset = "0x134B170", VA = "0x1134C370")]
    private bool IsReadyAll() => new bool();

    [Token(Token = "0x6006080")]
    [Address(RVA = "0x134C400", Offset = "0x134B200", VA = "0x1134C400")]
    private bool IsReadyOther() => new bool();

    [Token(Token = "0x6006081")]
    [Address(RVA = "0x134CBF0", Offset = "0x134B9F0", VA = "0x1134CBF0")]
    private bool RoomIsFull() => new bool();

    [Token(Token = "0x6006082")]
    [Address(RVA = "0x134C040", Offset = "0x134AE40", VA = "0x1134C040")]
    private bool EnoughAP() => new bool();

    [Token(Token = "0x6006083")]
    [Address(RVA = "0x134BF10", Offset = "0x134AD10", VA = "0x1134BF10")]
    private bool EnoughAPTower() => new bool();

    [Token(Token = "0x6006084")]
    [Address(RVA = "0x134C150", Offset = "0x134AF50", VA = "0x1134C150")]
    private bool IsNotDuplicate() => new bool();

    [Token(Token = "0x6006085")]
    [Address(RVA = "0x134BB10", Offset = "0x134A910", VA = "0x1134BB10")]
    private bool CanConditionsOther() => new bool();

    [Token(Token = "0x6006086")]
    [Address(RVA = "0x134BCE0", Offset = "0x134AAE0", VA = "0x1134BCE0")]
    private bool CanConditionsSelf() => new bool();

    [Token(Token = "0x6006087")]
    [Address(RVA = "0x134B9E0", Offset = "0x134A7E0", VA = "0x1134B9E0")]
    private bool CanChallenge() => new bool();

    [Token(Token = "0x6006088")]
    [Address(RVA = "0x134CC20", Offset = "0x134BA20", VA = "0x1134CC20")]
    private bool SameUnit() => new bool();

    [Token(Token = "0x6006089")]
    [Address(RVA = "0x134BE50", Offset = "0x134AC50", VA = "0x1134BE50")]
    private bool CanSolo() => new bool();

    [Token(Token = "0x600608A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_IsReady()
    {
    }
  }
}

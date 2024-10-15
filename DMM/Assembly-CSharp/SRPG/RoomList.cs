// Decompiled with JetBrains decompiler
// Type: SRPG.RoomList
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
  [Token(Token = "0x200295C")]
  [FlowNode.Pin(3, "選択可能ものを表示", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("Multi/参加募集中の部屋一覧")]
  [FlowNode.Pin(0, "ノーマル表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "イベント表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "現状表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "選択可能な部屋がない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "選択可能な部屋がある", FlowNode.PinTypes.Output, 201)]
  public class RoomList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C748")]
    private const int PININ_DRAW_NORMAL = 0;
    [Token(Token = "0x400C749")]
    private const int PININ_DRAW_EVENT = 1;
    [Token(Token = "0x400C74A")]
    private const int PININ_DRAW_CURRENT = 2;
    [Token(Token = "0x400C74B")]
    private const int PININ_DRAW_SELECTABLE = 3;
    [Token(Token = "0x400C74C")]
    private const int PINOUT_SELECTED = 101;
    [Token(Token = "0x400C74D")]
    private const int PINOUT_ROOM_EXISTS = 200;
    [Token(Token = "0x400C74E")]
    private const int PINOUT_ROOM_NOT_EXISTS = 201;
    [Token(Token = "0x400C74F")]
    [FieldOffset(Offset = "0xC")]
    private readonly Color EnableColor;
    [Token(Token = "0x400C750")]
    [FieldOffset(Offset = "0x1C")]
    private readonly Color DisableColor;
    [Token(Token = "0x400C751")]
    [FieldOffset(Offset = "0x2C")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C752")]
    [FieldOffset(Offset = "0x30")]
    [Description("詳細画面として使用するゲームオブジェクト")]
    public GameObject DetailTemplate;
    [Token(Token = "0x400C753")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400C754")]
    [FieldOffset(Offset = "0x38")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C755")]
    [FieldOffset(Offset = "0x3C")]
    private List<GameObject> mRoomList;

    [Token(Token = "0x600BB0C")]
    [Address(RVA = "0x82C1C0", Offset = "0x82AFC0", VA = "0x1082C1C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BB0D")]
    [Address(RVA = "0x82C270", Offset = "0x82B070", VA = "0x1082C270")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BB0E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB0F")]
    [Address(RVA = "0x82D1D0", Offset = "0x82BFD0", VA = "0x1082D1D0")]
    public void Refresh(bool isEvent, bool isSelect = false)
    {
    }

    [Token(Token = "0x600BB10")]
    [Address(RVA = "0x82C380", Offset = "0x82B180", VA = "0x1082C380")]
    private bool IsChooseRoom(MultiPlayAPIRoom room) => new bool();

    [Token(Token = "0x600BB11")]
    [Address(RVA = "0x82C8E0", Offset = "0x82B6E0", VA = "0x1082C8E0")]
    private void RefreshItems(bool isSelect)
    {
    }

    [Token(Token = "0x600BB12")]
    [Address(RVA = "0x82D330", Offset = "0x82C130", VA = "0x1082D330")]
    private void SetSelectablParam(GameObject obj, MultiPlayAPIRoom room, bool isChoose)
    {
    }

    [Token(Token = "0x600BB13")]
    [Address(RVA = "0x82C660", Offset = "0x82B460", VA = "0x1082C660")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600BB14")]
    [Address(RVA = "0x82C4C0", Offset = "0x82B2C0", VA = "0x1082C4C0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600BB15")]
    [Address(RVA = "0x82C560", Offset = "0x82B360", VA = "0x1082C560")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600BB16")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600BB17")]
    [Address(RVA = "0x82D620", Offset = "0x82C420", VA = "0x1082D620")]
    public RoomList()
    {
    }

    [Token(Token = "0x200295D")]
    private enum MultiTowerFilterMode
    {
      [Token(Token = "0x400C757")] Default,
      [Token(Token = "0x400C758")] Cleared,
      [Token(Token = "0x400C759")] NotClear,
    }
  }
}

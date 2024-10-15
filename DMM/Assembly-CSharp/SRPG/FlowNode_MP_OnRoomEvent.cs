// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_OnRoomEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D9")]
  [FlowNode.Pin(211, "Room change Comment", FlowNode.PinTypes.Output, 211)]
  [FlowNode.Pin(212, "Room change Quest", FlowNode.PinTypes.Output, 212)]
  [FlowNode.Pin(213, "Room change Battle Speed", FlowNode.PinTypes.Output, 213)]
  [FlowNode.Pin(215, "Room change Pass code", FlowNode.PinTypes.Output, 215)]
  [FlowNode.Pin(221, "Room Out Host", FlowNode.PinTypes.Output, 221)]
  [FlowNode.Pin(103, "All Players Ready", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(232, "Room is only Self", FlowNode.PinTypes.Output, 232)]
  [FlowNode.Pin(251, "Npc Matching", FlowNode.PinTypes.Output, 251)]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "Room Start", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(231, "Room is Full Member", FlowNode.PinTypes.Output, 231)]
  [FlowNode.Pin(104, "All Player not Ready", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(214, "Room change Auto Allowed", FlowNode.PinTypes.Output, 214)]
  [FlowNode.Pin(101, "Disconnected", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/Room/OnRoomEvent", 58751)]
  [FlowNode.Pin(1, "Ignore On", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Ignore FullMember On", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "Ignore FullMember Off", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(2, "Ignore Off", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "Player Change", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(61, "Npc Match", FlowNode.PinTypes.Input, 61)]
  [FlowNode.Pin(71, "Room Exit Wait On", FlowNode.PinTypes.Input, 71)]
  [FlowNode.Pin(72, "Room Exit Wait Off", FlowNode.PinTypes.Input, 72)]
  [FlowNode.Pin(51, "Reset", FlowNode.PinTypes.Input, 51)]
  public class FlowNode_MP_OnRoomEvent : FlowNodePersistent
  {
    [Token(Token = "0x40055CE")]
    private const int PIN_IN_IGNORE_ON = 1;
    [Token(Token = "0x40055CF")]
    private const int PIN_IN_IGNORE_OFF = 2;
    [Token(Token = "0x40055D0")]
    private const int PIN_IN_IGNORE_ON_FULL_MEMBER = 11;
    [Token(Token = "0x40055D1")]
    private const int PIN_IN_IGNORE_OFF_FULL_MEMBER = 12;
    [Token(Token = "0x40055D2")]
    private const int PIN_IN_RESET = 51;
    [Token(Token = "0x40055D3")]
    private const int PIN_IN_NPC_MATCH = 61;
    [Token(Token = "0x40055D4")]
    private const int PIN_IN_ROOM_EXIT_WAIT_ON = 71;
    [Token(Token = "0x40055D5")]
    private const int PIN_IN_ROOM_EXIT_WAIT_OFF = 72;
    [Token(Token = "0x40055D6")]
    private const int PIN_OUT_ON_DISCONNECTED = 101;
    [Token(Token = "0x40055D7")]
    private const int PIN_OUT_ON_PLAYER_CHANGE = 102;
    [Token(Token = "0x40055D8")]
    private const int PIN_OUT_ON_ALL_PLAYERS_READY = 103;
    [Token(Token = "0x40055D9")]
    private const int PIN_OUT_ON_ALL_PLAYERS_NOT_READY = 104;
    [Token(Token = "0x40055DA")]
    private const int PIN_OUT_ON_ROOM_START = 201;
    [Token(Token = "0x40055DB")]
    private const int PIN_OUT_ON_ROOM_CHANGE_COMMENT = 211;
    [Token(Token = "0x40055DC")]
    private const int PIN_OUT_ON_ROOM_CHANGE_QUEST = 212;
    [Token(Token = "0x40055DD")]
    private const int PIN_OUT_ON_ROOM_CHANGE_BTL_SPEED = 213;
    [Token(Token = "0x40055DE")]
    private const int PIN_OUT_ON_ROOM_CHANGE_AUTO_ALLOWED = 214;
    [Token(Token = "0x40055DF")]
    private const int PIN_OUT_ON_ROOM_CHANGE_PASS_CODE = 215;
    [Token(Token = "0x40055E0")]
    private const int PIN_OUT_ON_ROOM_OUT_HOST = 221;
    [Token(Token = "0x40055E1")]
    private const int PIN_OUT_ON_ROOM_FULL_MEMBER = 231;
    [Token(Token = "0x40055E2")]
    private const int PIN_OUT_ON_ROOM_ONLY_SELF = 232;
    [Token(Token = "0x40055E3")]
    private const int PIN_OUT_ON_NPC_MATCHING = 251;
    [Token(Token = "0x40055E4")]
    [FieldOffset(Offset = "0x18")]
    private bool isIgnore;
    [Token(Token = "0x40055E5")]
    [FieldOffset(Offset = "0x19")]
    private bool isIgnoreFullMember;
    [Token(Token = "0x40055E6")]
    [FieldOffset(Offset = "0x1A")]
    private bool isAction;
    [Token(Token = "0x40055E7")]
    [FieldOffset(Offset = "0x1C")]
    private string roomPass;
    [Token(Token = "0x40055E8")]
    [FieldOffset(Offset = "0x20")]
    private string roomComment;
    [Token(Token = "0x40055E9")]
    [FieldOffset(Offset = "0x24")]
    private string questIname;
    [Token(Token = "0x40055EA")]
    [FieldOffset(Offset = "0x28")]
    private int memberCount;
    [Token(Token = "0x40055EB")]
    [FieldOffset(Offset = "0x2C")]
    private int battleSpeed;
    [Token(Token = "0x40055EC")]
    [FieldOffset(Offset = "0x30")]
    private bool isAutoAllowed;
    [Token(Token = "0x40055ED")]
    [FieldOffset(Offset = "0x34")]
    private List<PhotonPlayerData> supports;
    [Token(Token = "0x40055EE")]
    [FieldOffset(Offset = "0x38")]
    private List<UnityAction> ignoreActions;
    [Token(Token = "0x40055EF")]
    [FieldOffset(Offset = "0x3C")]
    private List<UnityAction> ignoreFullActions;

    [Token(Token = "0x170009B4")]
    private bool isBusy
    {
      [Token(Token = "0x6006099"), Address(RVA = "0x1350F30", Offset = "0x134FD30", VA = "0x11350F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600609A")]
    [Address(RVA = "0x1350930", Offset = "0x134F730", VA = "0x11350930")]
    private void Start()
    {
    }

    [Token(Token = "0x600609B")]
    [Address(RVA = "0x1350240", Offset = "0x134F040", VA = "0x11350240", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600609C")]
    [Address(RVA = "0x1350BC0", Offset = "0x134F9C0", VA = "0x11350BC0")]
    private void Update()
    {
    }

    [Token(Token = "0x600609D")]
    [Address(RVA = "0x1350740", Offset = "0x134F540", VA = "0x11350740")]
    private void OnLeaveRoom()
    {
    }

    [Token(Token = "0x600609E")]
    [Address(RVA = "0x134FB60", Offset = "0x134E960", VA = "0x1134FB60")]
    private void OnChangeRoomProperty()
    {
    }

    [Token(Token = "0x600609F")]
    [Address(RVA = "0x1350480", Offset = "0x134F280", VA = "0x11350480")]
    private void OnJoinPlayer(PhotonPlayerParameter playerParam)
    {
    }

    [Token(Token = "0x60060A0")]
    [Address(RVA = "0x1350570", Offset = "0x134F370", VA = "0x11350570")]
    private void OnLeavePlayer(PhotonPlayerParameter playerParam)
    {
    }

    [Token(Token = "0x60060A1")]
    [Address(RVA = "0x134FA70", Offset = "0x134E870", VA = "0x1134FA70")]
    private void OnChangePlayerProperty(PhotonPlayerParameter playerParam)
    {
    }

    [Token(Token = "0x60060A2")]
    [Address(RVA = "0x134EE40", Offset = "0x134DC40", VA = "0x1134EE40")]
    private void ChangePlayerList()
    {
    }

    [Token(Token = "0x60060A3")]
    [Address(RVA = "0x134F8E0", Offset = "0x134E6E0", VA = "0x1134F8E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060A4")]
    [Address(RVA = "0x1350850", Offset = "0x134F650", VA = "0x11350850")]
    private void Reset()
    {
    }

    [Token(Token = "0x60060A5")]
    [Address(RVA = "0x134F120", Offset = "0x134DF20", VA = "0x1134F120")]
    private void NpcMatch()
    {
    }

    [Token(Token = "0x60060A6")]
    [Address(RVA = "0x1350DF0", Offset = "0x134FBF0", VA = "0x11350DF0")]
    public FlowNode_MP_OnRoomEvent()
    {
    }
  }
}

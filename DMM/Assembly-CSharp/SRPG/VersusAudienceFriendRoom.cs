// Decompiled with JetBrains decompiler
// Type: SRPG.VersusAudienceFriendRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002748")]
  [FlowNode.Pin(104, "WAIT_AUDIENCE", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "DISBANDED", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(103, "START_AUDIENCE", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "AUDIENCE_DISABLE", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "FORCE_LEAVE", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "NETWORK_ABORT", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "IGNORE_CONNECT_OFF", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "IGNORE_CONNECT_ON", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Multi/Versus/VersusAudienceFriendRoom")]
  public class VersusAudienceFriendRoom : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B971")]
    private const int PIN_IN_IGNORE_CONNECT_ON = 1;
    [Token(Token = "0x400B972")]
    private const int PIN_IN_IGNORE_CONNECT_OFF = 2;
    [Token(Token = "0x400B973")]
    private const int PIN_IN_NETWORK_ABORT = 11;
    [Token(Token = "0x400B974")]
    private const int PIN_OUT_FORCE_LEAVE = 101;
    [Token(Token = "0x400B975")]
    private const int PIN_OUT_AUDIENCE_DISABLE = 102;
    [Token(Token = "0x400B976")]
    private const int PIN_OUT_START_AUDIENCE = 103;
    [Token(Token = "0x400B977")]
    private const int PIN_OUT_WAIT_AUDIENCE = 104;
    [Token(Token = "0x400B978")]
    private const int PIN_OUT_DISBANDED = 105;
    [Token(Token = "0x400B979")]
    [FieldOffset(Offset = "0xC")]
    private readonly float UPDATE_INTERVAL;
    [Token(Token = "0x400B97A")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RoomObj;
    [Token(Token = "0x400B97B")]
    [FieldOffset(Offset = "0x14")]
    public Text AudienceTxt;
    [Token(Token = "0x400B97C")]
    [FieldOffset(Offset = "0x18")]
    private float mUpdateTime;
    [Token(Token = "0x400B97D")]
    [FieldOffset(Offset = "0x1C")]
    private bool mFinishWait;
    [Token(Token = "0x400B97E")]
    [FieldOffset(Offset = "0x1D")]
    private bool IsChangeList;
    [Token(Token = "0x400B97F")]
    [FieldOffset(Offset = "0x1E")]
    private bool mIgnoreConnect;

    [Token(Token = "0x600B038")]
    [Address(RVA = "0x74DA50", Offset = "0x74C850", VA = "0x1074DA50")]
    private void Start()
    {
    }

    [Token(Token = "0x600B039")]
    [Address(RVA = "0x74D7B0", Offset = "0x74C5B0", VA = "0x1074D7B0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B03A")]
    [Address(RVA = "0x74D830", Offset = "0x74C630", VA = "0x1074D830")]
    private void Refresh(PhotonRoomParameter room = null)
    {
    }

    [Token(Token = "0x600B03B")]
    [Address(RVA = "0x74D6D0", Offset = "0x74C4D0", VA = "0x1074D6D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B03C")]
    [Address(RVA = "0x74D7A0", Offset = "0x74C5A0", VA = "0x1074D7A0")]
    private void OnChangeRoomList()
    {
    }

    [Token(Token = "0x600B03D")]
    [Address(RVA = "0x74DAE0", Offset = "0x74C8E0", VA = "0x1074DAE0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B03E")]
    [Address(RVA = "0x74D710", Offset = "0x74C510", VA = "0x1074D710")]
    public void NetworkAbort()
    {
    }

    [Token(Token = "0x600B03F")]
    [Address(RVA = "0x74DD10", Offset = "0x74CB10", VA = "0x1074DD10")]
    public VersusAudienceFriendRoom()
    {
    }
  }
}

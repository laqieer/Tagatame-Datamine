// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerMatchInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200275F")]
  [FlowNode.Pin(20, "TowerMatchDetail", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(115, "FindDraftRoom", FlowNode.PinTypes.Output, 115)]
  [AddComponentMenu("UI/Multi/Versus/VersusTowerMatchInfo")]
  [FlowNode.Pin(12, "AlreadyStartFriendMode", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "AudienceDisable", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Search", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(15, "FindRoom", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(16, "NotFindRoom", FlowNode.PinTypes.Output, 16)]
  public class VersusTowerMatchInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BA06")]
    [FieldOffset(Offset = "0xC")]
    private readonly string PVP_URL;
    [Token(Token = "0x400BA07")]
    private const int PIN_INPUT_SEARCH = 1;
    [Token(Token = "0x400BA08")]
    private const int PIN_OUTPUT_AUDIENCE_DISABLE = 11;
    [Token(Token = "0x400BA09")]
    private const int PIN_OUTPUT_ALREADY_START_FRIEND_MODE = 12;
    [Token(Token = "0x400BA0A")]
    private const int PIN_OUTPUT_FIND_ROOM = 15;
    [Token(Token = "0x400BA0B")]
    private const int PIN_OUTPUT_NOT_FIND_ROOM = 16;
    [Token(Token = "0x400BA0C")]
    private const int PIN_OUTPUT_TOWERMATCH_DETAIL = 20;
    [Token(Token = "0x400BA0D")]
    private const int PIN_OUTPUT_FIND_DRAFT_ROOM = 115;
    [Token(Token = "0x400BA0E")]
    [FieldOffset(Offset = "0x10")]
    public GameObject template;
    [Token(Token = "0x400BA0F")]
    [FieldOffset(Offset = "0x14")]
    public GameObject winbonus;
    [Token(Token = "0x400BA10")]
    [FieldOffset(Offset = "0x18")]
    public GameObject keyrateup;
    [Token(Token = "0x400BA11")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject parent;
    [Token(Token = "0x400BA12")]
    [FieldOffset(Offset = "0x20")]
    public GameObject keyinfo;
    [Token(Token = "0x400BA13")]
    [FieldOffset(Offset = "0x24")]
    public GameObject keyname;
    [Token(Token = "0x400BA14")]
    [FieldOffset(Offset = "0x28")]
    public GameObject lastfloor;
    [Token(Token = "0x400BA15")]
    [FieldOffset(Offset = "0x2C")]
    public Text nowKey;
    [Token(Token = "0x400BA16")]
    [FieldOffset(Offset = "0x30")]
    public Text maxKey;
    [Token(Token = "0x400BA17")]
    [FieldOffset(Offset = "0x34")]
    public Text floor;
    [Token(Token = "0x400BA18")]
    [FieldOffset(Offset = "0x38")]
    public Text bonusRate;
    [Token(Token = "0x400BA19")]
    [FieldOffset(Offset = "0x3C")]
    public Text winCnt;
    [Token(Token = "0x400BA1A")]
    [FieldOffset(Offset = "0x40")]
    public Text endAt;
    [Token(Token = "0x400BA1B")]
    [FieldOffset(Offset = "0x44")]
    public Button detailBtn;
    [Token(Token = "0x400BA1C")]
    [FieldOffset(Offset = "0x48")]
    private bool isRoomListRefreshed;

    [Token(Token = "0x600B0AE")]
    [Address(RVA = "0x7546F0", Offset = "0x7534F0", VA = "0x107546F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B0AF")]
    [Address(RVA = "0x753AC0", Offset = "0x7528C0", VA = "0x10753AC0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B0B0")]
    [Address(RVA = "0x753970", Offset = "0x752770", VA = "0x10753970")]
    private void OnChangedRoomList()
    {
    }

    [Token(Token = "0x600B0B1")]
    [Address(RVA = "0x753B40", Offset = "0x752940", VA = "0x10753B40")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B0B2")]
    [Address(RVA = "0x753980", Offset = "0x752780", VA = "0x10753980")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x600B0B3")]
    [Address(RVA = "0x753900", Offset = "0x752700", VA = "0x10753900", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B0B4")]
    [Address(RVA = "0x754680", Offset = "0x753480", VA = "0x10754680")]
    private IEnumerator Search() => (IEnumerator) null;

    [Token(Token = "0x600B0B5")]
    [Address(RVA = "0x754850", Offset = "0x753650", VA = "0x10754850")]
    public VersusTowerMatchInfo()
    {
    }
  }
}

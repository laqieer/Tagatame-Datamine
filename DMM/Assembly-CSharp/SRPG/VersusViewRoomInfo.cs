// Decompiled with JetBrains decompiler
// Type: SRPG.VersusViewRoomInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002766")]
  [AddComponentMenu("UI/Multi/Versus/VersusViewRoomInfo")]
  [FlowNode.Pin(3, "JoinFriendRoom", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Select Reset", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class VersusViewRoomInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BA44")]
    [FieldOffset(Offset = "0xC")]
    private readonly string FREE_SUFFIX;
    [Token(Token = "0x400BA45")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Player1P;
    [Token(Token = "0x400BA46")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Player2P;
    [Token(Token = "0x400BA47")]
    [FieldOffset(Offset = "0x18")]
    public Image RoomType;
    [Token(Token = "0x400BA48")]
    [FieldOffset(Offset = "0x1C")]
    public Image RoomIcon;
    [Token(Token = "0x400BA49")]
    [FieldOffset(Offset = "0x20")]
    public Image MapThumnail;
    [Token(Token = "0x400BA4A")]
    [FieldOffset(Offset = "0x24")]
    public Sprite FreeMatch;
    [Token(Token = "0x400BA4B")]
    [FieldOffset(Offset = "0x28")]
    public Sprite TowerMatch;
    [Token(Token = "0x400BA4C")]
    [FieldOffset(Offset = "0x2C")]
    public Sprite FreeIcon;
    [Token(Token = "0x400BA4D")]
    [FieldOffset(Offset = "0x30")]
    public Sprite TowerIcon;
    [Token(Token = "0x400BA4E")]
    [FieldOffset(Offset = "0x34")]
    public Text MapName;
    [Token(Token = "0x400BA4F")]
    [FieldOffset(Offset = "0x38")]
    public Text MapDetail;

    [Token(Token = "0x600B0CA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B0CB")]
    [Address(RVA = "0x756CB0", Offset = "0x755AB0", VA = "0x10756CB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B0CC")]
    [Address(RVA = "0x756C10", Offset = "0x755A10", VA = "0x10756C10")]
    public void OnClickRoomInfo()
    {
    }

    [Token(Token = "0x600B0CD")]
    [Address(RVA = "0x756BA0", Offset = "0x7559A0", VA = "0x10756BA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B0CE")]
    [Address(RVA = "0x7571A0", Offset = "0x755FA0", VA = "0x107571A0")]
    public VersusViewRoomInfo()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ChatPlayerWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002160")]
  [FlowNode.Pin(1, "Add Block", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Remove Block", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/ChatPlayerWindow")]
  [FlowNode.Pin(11, "Output Remove Block", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Output Add Block", FlowNode.PinTypes.Output, 10)]
  public class ChatPlayerWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400919C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text UserName;
    [Token(Token = "0x400919D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BitmapText UserLv;
    [Token(Token = "0x400919E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text LastLogin;
    [Token(Token = "0x400919F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Add;
    [Token(Token = "0x40091A0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject Remove;
    [Token(Token = "0x40091A1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject FriendAdd;
    [Token(Token = "0x40091A2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject FriendRemove;
    [Token(Token = "0x40091A3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject Award;
    [Token(Token = "0x40091A4")]
    [FieldOffset(Offset = "0x2C")]
    private ChatPlayerData mPlayer;

    [Token(Token = "0x170013CE")]
    public ChatPlayerData Player
    {
      [Token(Token = "0x6008C4E"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (ChatPlayerData) null;
      }
      [Token(Token = "0x6008C4F"), Address(RVA = "0x5000C0", Offset = "0x4FEEC0", VA = "0x105000C0")] set
      {
      }
    }

    [Token(Token = "0x6008C50")]
    [Address(RVA = "0x4FF740", Offset = "0x4FE540", VA = "0x104FF740", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008C51")]
    [Address(RVA = "0x4FF790", Offset = "0x4FE590", VA = "0x104FF790")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008C52")]
    [Address(RVA = "0x4FF920", Offset = "0x4FE720", VA = "0x104FF920")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008C53")]
    [Address(RVA = "0x4FF800", Offset = "0x4FE600", VA = "0x104FF800")]
    private void DummyUserData()
    {
    }

    [Token(Token = "0x6008C54")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChatPlayerWindow()
    {
    }
  }
}

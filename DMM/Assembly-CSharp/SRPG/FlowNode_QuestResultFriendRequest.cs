// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_QuestResultFriendRequest
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
  [Token(Token = "0x2001466")]
  [FlowNode.Pin(101, "Finished", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(104, "Can not request", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "Can request", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(100, "Executed", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Quest/FriendRequest", 32741)]
  [FlowNode.Pin(2, "Create Prefab for All", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "Can request friend", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "Next one", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_QuestResultFriendRequest : FlowNode
  {
    [Token(Token = "0x4004B71")]
    private const int PIN_IN_START = 0;
    [Token(Token = "0x4004B72")]
    private const int PIN_IN_NEXT = 1;
    [Token(Token = "0x4004B73")]
    private const int PIN_IN_ALL = 2;
    [Token(Token = "0x4004B74")]
    private const int PIN_IN_CAN_REQUEST = 3;
    [Token(Token = "0x4004B75")]
    private const int PIN_OUT_EXCEUTED = 100;
    [Token(Token = "0x4004B76")]
    private const int PIN_OUT_FINISHED = 101;
    [Token(Token = "0x4004B77")]
    private const int PIN_OUT_CAN_REQUEST = 103;
    [Token(Token = "0x4004B78")]
    private const int PIN_OUT_CANNNOT_REQUEST = 104;
    [Token(Token = "0x4004B79")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Template;
    [Token(Token = "0x4004B7A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button OkButton;
    [Token(Token = "0x4004B7B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject TitleText_Normal;
    [Token(Token = "0x4004B7C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject TitleText_RaidRescue;
    [Token(Token = "0x4004B7D")]
    [FieldOffset(Offset = "0x28")]
    private int mCurrentIndex;
    [Token(Token = "0x4004B7E")]
    [FieldOffset(Offset = "0x2C")]
    private List<FriendWindowItem> FriendItemList;

    [Token(Token = "0x17000935")]
    private bool IsOrdeal
    {
      [Token(Token = "0x600554F"), Address(RVA = "0x129B750", Offset = "0x129A550", VA = "0x1129B750")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005550")]
    [Address(RVA = "0x129AF10", Offset = "0x1299D10", VA = "0x1129AF10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005551")]
    [Address(RVA = "0x129B2F0", Offset = "0x129A0F0", VA = "0x1129B2F0")]
    private int SearchTargetIndex(int startIndex) => new int();

    [Token(Token = "0x6005552")]
    [Address(RVA = "0x129AFE0", Offset = "0x1299DE0", VA = "0x1129AFE0")]
    private void Output()
    {
    }

    [Token(Token = "0x6005553")]
    [Address(RVA = "0x129AC00", Offset = "0x1299A00", VA = "0x1129AC00")]
    private SupportData CreateSupportData(PhotonPlayerData player) => (SupportData) null;

    [Token(Token = "0x6005554")]
    [Address(RVA = "0x1299D70", Offset = "0x1298B70", VA = "0x11299D70")]
    private void CheckFriend()
    {
    }

    [Token(Token = "0x6005555")]
    [Address(RVA = "0x129ADB0", Offset = "0x1299BB0", VA = "0x1129ADB0")]
    private bool IsDupricateFriend(string checkFUID, List<string> addedFUIDList) => new bool();

    [Token(Token = "0x6005556")]
    [Address(RVA = "0x1299F90", Offset = "0x1298D90", VA = "0x11299F90")]
    public void CreateFriendItem()
    {
    }

    [Token(Token = "0x6005557")]
    [Address(RVA = "0x129B600", Offset = "0x129A400", VA = "0x1129B600")]
    public void SetInteractable()
    {
    }

    [Token(Token = "0x6005558")]
    [Address(RVA = "0x129B6E0", Offset = "0x129A4E0", VA = "0x1129B6E0")]
    public FlowNode_QuestResultFriendRequest()
    {
    }
  }
}

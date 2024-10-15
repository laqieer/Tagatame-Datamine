// Decompiled with JetBrains decompiler
// Type: SRPG.FriendWindowItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002403")]
  [AddComponentMenu("UI/FriendWindowItem")]
  public class FriendWindowItem : MonoBehaviour
  {
    [Token(Token = "0x400A2B9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x400A2BA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle block;
    [Token(Token = "0x400A2BB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject FriendMark;
    [Token(Token = "0x400A2BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject BlockMark;
    [Token(Token = "0x400A2BD")]
    [FieldOffset(Offset = "0x1C")]
    [NonSerialized]
    public FlowNode_QuestResultFriendRequest FriendRequest;
    [Token(Token = "0x400A2BE")]
    [FieldOffset(Offset = "0x20")]
    [NonSerialized]
    public string TargetFUID;
    [Token(Token = "0x400A2BF")]
    [FieldOffset(Offset = "0x24")]
    [NonSerialized]
    public SupportData Support;
    [Token(Token = "0x400A2C0")]
    [FieldOffset(Offset = "0x28")]
    [NonSerialized]
    public bool CanBlock;
    [Token(Token = "0x400A2C1")]
    [FieldOffset(Offset = "0x2C")]
    private MultiFuid m_Friend;

    [Token(Token = "0x170015CA")]
    public bool IsOn
    {
      [Token(Token = "0x6009CAC"), Address(RVA = "0x5F8EF0", Offset = "0x5F7CF0", VA = "0x105F8EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015CB")]
    public bool Interactable
    {
      [Token(Token = "0x6009CAD"), Address(RVA = "0x5F8F10", Offset = "0x5F7D10", VA = "0x105F8F10")] set
      {
      }
    }

    [Token(Token = "0x170015CC")]
    public bool IsBlockOn
    {
      [Token(Token = "0x6009CAE"), Address(RVA = "0x5F8ED0", Offset = "0x5F7CD0", VA = "0x105F8ED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009CAF")]
    [Address(RVA = "0x5F8D40", Offset = "0x5F7B40", VA = "0x105F8D40")]
    private void Start()
    {
    }

    [Token(Token = "0x6009CB0")]
    [Address(RVA = "0x5F8A50", Offset = "0x5F7850", VA = "0x105F8A50")]
    public void Refresh(bool on = false)
    {
    }

    [Token(Token = "0x6009CB1")]
    [Address(RVA = "0x5F89B0", Offset = "0x5F77B0", VA = "0x105F89B0")]
    private void RefreshBlockMark(bool _active)
    {
    }

    [Token(Token = "0x6009CB2")]
    [Address(RVA = "0x5F8EB0", Offset = "0x5F7CB0", VA = "0x105F8EB0")]
    public FriendWindowItem()
    {
    }
  }
}

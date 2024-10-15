// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023DC")]
  [AddComponentMenu("UI/FriendPresentBadge")]
  public class FriendPresentBadge : MonoBehaviour
  {
    [Token(Token = "0x400A241")]
    [FieldOffset(Offset = "0xC")]
    public GameObject BadgeObject;
    [Token(Token = "0x400A242")]
    [FieldOffset(Offset = "0x10")]
    [BitMask]
    public GameManager.BadgeTypes BadgeType;

    [Token(Token = "0x6009BEC")]
    [Address(RVA = "0x5F4FB0", Offset = "0x5F3DB0", VA = "0x105F4FB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009BED")]
    [Address(RVA = "0x5F5020", Offset = "0x5F3E20", VA = "0x105F5020")]
    private void Update()
    {
    }

    [Token(Token = "0x6009BEE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public FriendPresentBadge()
    {
    }
  }
}

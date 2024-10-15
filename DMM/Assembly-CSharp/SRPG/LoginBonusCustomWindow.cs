// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusCustomWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026E5")]
  [AddComponentMenu("UI/LoginBonusCustomWindow")]
  public class LoginBonusCustomWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B6E9")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemList;
    [Token(Token = "0x400B6EA")]
    [FieldOffset(Offset = "0x10")]
    public ListItemEvents Item_Normal;
    [Token(Token = "0x400B6EB")]
    [FieldOffset(Offset = "0x14")]
    public ListItemEvents Item_Taken;
    [Token(Token = "0x400B6EC")]
    [FieldOffset(Offset = "0x18")]
    public Json_LoginBonus[] DebugItems;
    [Token(Token = "0x400B6ED")]
    [FieldOffset(Offset = "0x1C")]
    public int DebugBonusCount;
    [Token(Token = "0x400B6EE")]
    [FieldOffset(Offset = "0x20")]
    private int mLoginBonusCount;
    [Token(Token = "0x400B6EF")]
    [FieldOffset(Offset = "0x24")]
    public RectTransform TodayBadge;
    [Token(Token = "0x400B6F0")]
    [FieldOffset(Offset = "0x28")]
    public RectTransform TommorowBadge;
    [Token(Token = "0x400B6F1")]
    [FieldOffset(Offset = "0x2C")]
    public LoginBonusVIPBadge VIPBadge;
    [Token(Token = "0x400B6F2")]
    [FieldOffset(Offset = "0x30")]
    public string CheckName;
    [Token(Token = "0x400B6F3")]
    [FieldOffset(Offset = "0x34")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400B6F4")]
    [FieldOffset(Offset = "0x38")]
    private ItemData mCurrentItem;
    [Token(Token = "0x400B6F5")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ItemInfo;
    [Token(Token = "0x400B6F6")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ItemBg;
    [Token(Token = "0x400B6F7")]
    [FieldOffset(Offset = "0x44")]
    public GameObject PieceInfo;
    [Token(Token = "0x400B6F8")]
    [FieldOffset(Offset = "0x48")]
    public GameObject PieceBg;

    [Token(Token = "0x600AE34")]
    [Address(RVA = "0x720070", Offset = "0x71EE70", VA = "0x10720070")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE35")]
    [Address(RVA = "0x720750", Offset = "0x71F550", VA = "0x10720750")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE36")]
    [Address(RVA = "0x7205B0", Offset = "0x71F3B0", VA = "0x107205B0")]
    private void ShowDetailWindow(ListItemEvents item)
    {
    }

    [Token(Token = "0x600AE37")]
    [Address(RVA = "0x720F90", Offset = "0x71FD90", VA = "0x10720F90")]
    private IEnumerator WaitLoadAsync() => (IEnumerator) null;

    [Token(Token = "0x600AE38")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE39")]
    [Address(RVA = "0x720230", Offset = "0x71F030", VA = "0x10720230")]
    private void FlipTodaysItem()
    {
    }

    [Token(Token = "0x600AE3A")]
    [Address(RVA = "0x720FE0", Offset = "0x71FDE0", VA = "0x10720FE0")]
    public LoginBonusCustomWindow()
    {
    }
  }
}

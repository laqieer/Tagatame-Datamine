// Decompiled with JetBrains decompiler
// Type: SRPG.FriendList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D8")]
  [AddComponentMenu("UI/リスト/宿屋で表示するフレンドリスト")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class FriendList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A22B")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A22C")]
    [FieldOffset(Offset = "0x10")]
    [Description("リストが空のときに表示するゲームオブジェクト")]
    public GameObject ItemEmpty;
    [Token(Token = "0x400A22D")]
    [FieldOffset(Offset = "0x14")]
    [Description("表示するフレンドの種類")]
    public FriendStates FriendType;
    [Token(Token = "0x400A22E")]
    [FieldOffset(Offset = "0x18")]
    [Description("ソート用プルダウン")]
    public Pulldown SortPulldown;
    [Token(Token = "0x400A22F")]
    [FieldOffset(Offset = "0x1C")]
    private string[] mSortString;
    [Token(Token = "0x400A230")]
    [FieldOffset(Offset = "0x20")]
    private FriendList.eSortType mSortType;
    [Token(Token = "0x400A231")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> mItems;
    [Token(Token = "0x400A232")]
    [FieldOffset(Offset = "0x28")]
    private CanvasGroup mCanvasGroup;

    [Token(Token = "0x6009BD9")]
    [Address(RVA = "0x5F2450", Offset = "0x5F1250", VA = "0x105F2450", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009BDA")]
    [Address(RVA = "0x5F2470", Offset = "0x5F1270", VA = "0x105F2470")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009BDB")]
    [Address(RVA = "0x5F2ED0", Offset = "0x5F1CD0", VA = "0x105F2ED0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009BDC")]
    [Address(RVA = "0x5F2F40", Offset = "0x5F1D40", VA = "0x105F2F40")]
    private void Update()
    {
    }

    [Token(Token = "0x6009BDD")]
    [Address(RVA = "0x5F2C80", Offset = "0x5F1A80", VA = "0x105F2C80")]
    private void SortPulldownInit()
    {
    }

    [Token(Token = "0x6009BDE")]
    [Address(RVA = "0x5F2940", Offset = "0x5F1740", VA = "0x105F2940")]
    private void SortByEntryDate(List<FriendData> lists)
    {
    }

    [Token(Token = "0x6009BDF")]
    [Address(RVA = "0x5F2AA0", Offset = "0x5F18A0", VA = "0x105F2AA0")]
    private void SortByLastLogin(List<FriendData> lists)
    {
    }

    [Token(Token = "0x6009BE0")]
    [Address(RVA = "0x5F2B90", Offset = "0x5F1990", VA = "0x105F2B90")]
    private void SortByPlayerLevel(List<FriendData> lists)
    {
    }

    [Token(Token = "0x6009BE1")]
    [Address(RVA = "0x5F31D0", Offset = "0x5F1FD0", VA = "0x105F31D0")]
    private void entryItems()
    {
    }

    [Token(Token = "0x6009BE2")]
    [Address(RVA = "0x5F26E0", Offset = "0x5F14E0", VA = "0x105F26E0")]
    private void OnSortChange(int idx)
    {
    }

    [Token(Token = "0x6009BE3")]
    [Address(RVA = "0x5F2780", Offset = "0x5F1580", VA = "0x105F2780")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009BE4")]
    [Address(RVA = "0x5F2580", Offset = "0x5F1380", VA = "0x105F2580")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x6009BE5")]
    [Address(RVA = "0x5F3020", Offset = "0x5F1E20", VA = "0x105F3020")]
    public FriendList()
    {
    }

    [Token(Token = "0x20023D9")]
    private enum eSortType
    {
      [Token(Token = "0x400A239")] DEFAULT = 0,
      [Token(Token = "0x400A235")] ENTRY_DATE = 0,
      [Token(Token = "0x400A234")] MIN = 0,
      [Token(Token = "0x400A236")] LAST_LOGIN = 1,
      [Token(Token = "0x400A237")] PLAYER_LEVEL = 2,
      [Token(Token = "0x400A238")] MAX = 3,
    }
  }
}

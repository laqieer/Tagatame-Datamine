// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026EC")]
  [FlowNode.Pin(11, "Take Bonus", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(12, "Last Day", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(20, "詳細表示(アイテム)", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(22, "補填可能なアイコンをタップ", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "詳細表示(真理念装)", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(10, "Load Complete", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("UI/LoginBonusWindow")]
  public class LoginBonusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B705")]
    private const int PIN_OT_SELECT_ITEM = 20;
    [Token(Token = "0x400B706")]
    private const int PIN_OT_SELECT_CONCEPTCARD = 21;
    [Token(Token = "0x400B707")]
    private const int PIN_OT_SELECT_RECOVER = 22;
    [Token(Token = "0x400B708")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemList;
    [Token(Token = "0x400B709")]
    [FieldOffset(Offset = "0x10")]
    public GameObject[] PositionList;
    [Token(Token = "0x400B70A")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    public ListItemEvents Item_Normal;
    [Token(Token = "0x400B70B")]
    [FieldOffset(Offset = "0x18")]
    public ListItemEvents Item_Taken;
    [Token(Token = "0x400B70C")]
    [FieldOffset(Offset = "0x1C")]
    public Json_LoginBonus[] DebugItems;
    [Token(Token = "0x400B70D")]
    [FieldOffset(Offset = "0x20")]
    public int DebugBonusCount;
    [Token(Token = "0x400B70E")]
    [FieldOffset(Offset = "0x24")]
    private int mLoginBonusCount;
    [Token(Token = "0x400B70F")]
    [FieldOffset(Offset = "0x28")]
    public GameObject BonusParticleEffect;
    [Token(Token = "0x400B710")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼演出時のアイコン表示用オブジェクト")]
    public GameObject TodayItem;
    [Token(Token = "0x400B711")]
    [FieldOffset(Offset = "0x30")]
    public GameObject TommorowItem;
    [Token(Token = "0x400B712")]
    [FieldOffset(Offset = "0x34")]
    public Text Today;
    [Token(Token = "0x400B713")]
    [FieldOffset(Offset = "0x38")]
    public Text Tommorow;
    [Token(Token = "0x400B714")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject TommorowRow;
    [Token(Token = "0x400B715")]
    [FieldOffset(Offset = "0x40")]
    public GameObject VIPBonusRow;
    [Token(Token = "0x400B716")]
    [FieldOffset(Offset = "0x44")]
    public RectTransform TodayBadge;
    [Token(Token = "0x400B717")]
    [FieldOffset(Offset = "0x48")]
    public RectTransform TommorowBadge;
    [Token(Token = "0x400B718")]
    [FieldOffset(Offset = "0x4C")]
    public LoginBonusVIPBadge VIPBadge;
    [Token(Token = "0x400B719")]
    [FieldOffset(Offset = "0x50")]
    public string CheckName;
    [Token(Token = "0x400B71A")]
    [FieldOffset(Offset = "0x54")]
    public string[] DisabledFirstDayNames;
    [Token(Token = "0x400B71B")]
    [FieldOffset(Offset = "0x58")]
    public string TableID;
    [Token(Token = "0x400B71C")]
    [FieldOffset(Offset = "0x5C")]
    public string TodayTextID;
    [Token(Token = "0x400B71D")]
    [FieldOffset(Offset = "0x60")]
    public string TommorowTextID1;
    [Token(Token = "0x400B71E")]
    [FieldOffset(Offset = "0x64")]
    public string TommorowTextID2;
    [Token(Token = "0x400B71F")]
    [FieldOffset(Offset = "0x68")]
    public string LastDayTextID;
    [Token(Token = "0x400B720")]
    [FieldOffset(Offset = "0x6C")]
    public bool IsConfigWindow;
    [Token(Token = "0x400B721")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    [HeaderBar("毎月ログボのタイトル月")]
    private Text TitleMonthText;
    [Token(Token = "0x400B722")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("月のログイン総数")]
    [SerializeField]
    private Text LoginTotalCount;
    [Token(Token = "0x400B723")]
    [FieldOffset(Offset = "0x78")]
    [HeaderBar("月の残り補填可能数")]
    [SerializeField]
    private Text RecoverRemain;
    [Token(Token = "0x400B724")]
    [FieldOffset(Offset = "0x7C")]
    [HeaderBar("月の補填可能最大数")]
    [SerializeField]
    private Text RecoverMax;
    [Token(Token = "0x400B725")]
    [FieldOffset(Offset = "0x80")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x600AE4C")]
    [Address(RVA = "0x7286A0", Offset = "0x7274A0", VA = "0x107286A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE4D")]
    [Address(RVA = "0x728E40", Offset = "0x727C40", VA = "0x10728E40")]
    private string MakeTodayText(GiftRecieveItemData todaysBonusItem) => (string) null;

    [Token(Token = "0x600AE4E")]
    [Address(RVA = "0x729040", Offset = "0x727E40", VA = "0x10729040")]
    private string MakeTomorrowText(
      GiftRecieveItemData todaysBonusItem,
      GiftRecieveItemData tomorrowBonusItem)
    {
      return (string) null;
    }

    [Token(Token = "0x600AE4F")]
    [Address(RVA = "0x728D70", Offset = "0x727B70", VA = "0x10728D70")]
    private string MakeLastText() => (string) null;

    [Token(Token = "0x600AE50")]
    [Address(RVA = "0x728860", Offset = "0x727660", VA = "0x10728860")]
    private void DisableFirstDayHiddenOject(GameObject parent)
    {
    }

    [Token(Token = "0x600AE51")]
    [Address(RVA = "0x729560", Offset = "0x728360", VA = "0x10729560")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE52")]
    [Address(RVA = "0x72A7E0", Offset = "0x7295E0", VA = "0x1072A7E0")]
    private IEnumerator WaitLoadAsync() => (IEnumerator) null;

    [Token(Token = "0x600AE53")]
    [Address(RVA = "0x728680", Offset = "0x727480", VA = "0x10728680", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE54")]
    [Address(RVA = "0x728990", Offset = "0x727790", VA = "0x10728990")]
    private void FlipTodaysItem()
    {
    }

    [Token(Token = "0x600AE55")]
    [Address(RVA = "0x729240", Offset = "0x728040", VA = "0x10729240")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AE56")]
    [Address(RVA = "0x72A850", Offset = "0x729650", VA = "0x1072A850")]
    public LoginBonusWindow()
    {
    }
  }
}

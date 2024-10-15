// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusWindowMonthly
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
  [Token(Token = "0x20026E1")]
  [FlowNode.Pin(11, "詳細表示(アイテム)", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(13, "補填表示", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/LoginBonus/LoginBonusWindowMonthly")]
  [FlowNode.Pin(12, "詳細表示(真理念装)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(10, "LoadComplete", FlowNode.PinTypes.Output, 10)]
  public class LoginBonusWindowMonthly : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B6C6")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400B6C7")]
    private const int PIN_OT_LOAD_COMPLETE = 10;
    [Token(Token = "0x400B6C8")]
    private const int PIN_OT_SELECT_ITEM = 11;
    [Token(Token = "0x400B6C9")]
    private const int PIN_OT_SELECT_CONCEPTCARD = 12;
    [Token(Token = "0x400B6CA")]
    private const int PIN_OT_SELECT_RECOVER = 13;
    [Token(Token = "0x400B6CB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemList;
    [Token(Token = "0x400B6CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ScrollRect ScrollLayout;
    [Token(Token = "0x400B6CD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [HeaderBar("アイコン表示用オブジェクト")]
    private ListItemEvents Item_Normal;
    [Token(Token = "0x400B6CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ListItemEvents Item_Taken;
    [Token(Token = "0x400B6CF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RectTransform TodayBadge;
    [Token(Token = "0x400B6D0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform TommorowBadge;
    [Token(Token = "0x400B6D1")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("表示したいログボのID")]
    public string TableID;
    [Token(Token = "0x400B6D2")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("スタンプアニメーションオブジェクト名")]
    public string CheckName;
    [Token(Token = "0x400B6D3")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("コンフィグからの呼び出しか")]
    public bool IsConfigWindow;
    [Token(Token = "0x400B6D4")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("MonthlyLoginBonusUI")]
    [SerializeField]
    private Text TitleMonthText;
    [Token(Token = "0x400B6D5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text LoginTotalCountText;
    [Token(Token = "0x400B6D6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text RecoverRemainText;
    [Token(Token = "0x400B6D7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text RecoverMaxText;
    [Token(Token = "0x400B6D8")]
    [FieldOffset(Offset = "0x40")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400B6D9")]
    [FieldOffset(Offset = "0x44")]
    private bool mIsCanRecover;

    [Token(Token = "0x600AE1B")]
    [Address(RVA = "0x724F00", Offset = "0x723D00", VA = "0x10724F00")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE1C")]
    [Address(RVA = "0x726390", Offset = "0x725190", VA = "0x10726390")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE1D")]
    [Address(RVA = "0x725550", Offset = "0x724350", VA = "0x10725550")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AE1E")]
    [Address(RVA = "0x7263A0", Offset = "0x7251A0", VA = "0x107263A0")]
    private IEnumerator WaitLoadAsync(float forced_scroll_val = -1f) => (IEnumerator) null;

    [Token(Token = "0x600AE1F")]
    [Address(RVA = "0x725070", Offset = "0x723E70", VA = "0x10725070")]
    private void ClearItems()
    {
    }

    [Token(Token = "0x600AE20")]
    [Address(RVA = "0x725230", Offset = "0x724030", VA = "0x10725230")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AE21")]
    [Address(RVA = "0x724ED0", Offset = "0x723CD0", VA = "0x10724ED0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE22")]
    [Address(RVA = "0x726410", Offset = "0x725210", VA = "0x10726410")]
    public LoginBonusWindowMonthly()
    {
    }
  }
}

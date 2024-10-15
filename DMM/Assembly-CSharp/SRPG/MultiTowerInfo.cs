// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerInfo
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
  [Token(Token = "0x20027A8")]
  [AddComponentMenu("UI/MultiTowerInfo")]
  [FlowNode.Pin(10, "部屋一覧から階層選択完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(4, "再描画(階層状況反映)", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "部屋一覧から閉じた", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "部屋一覧から階層決定", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "階層選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "マルチタワートップ", FlowNode.PinTypes.Input, 0)]
  public class MultiTowerInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BB66")]
    private const int PININ_MULTI_TOWER_TOP = 0;
    [Token(Token = "0x400BB67")]
    private const int PININ_SELECT_FLOOR = 1;
    [Token(Token = "0x400BB68")]
    private const int PININ_SELECT_FLOOR_FROM_LIST = 2;
    [Token(Token = "0x400BB69")]
    private const int PININ_CLOSE_LIST = 3;
    [Token(Token = "0x400BB6A")]
    private const int PININ_REFRESH = 4;
    [Token(Token = "0x400BB6B")]
    private const int PINOUT_SELECTED_FLOOR = 10;
    [Token(Token = "0x400BB6C")]
    [FieldOffset(Offset = "0xC")]
    private readonly int OFFSET;
    [Token(Token = "0x400BB6D")]
    [FieldOffset(Offset = "0x10")]
    public ScrollAutoFit AutoFit;
    [Token(Token = "0x400BB6E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject QuestInfo;
    [Token(Token = "0x400BB6F")]
    [FieldOffset(Offset = "0x18")]
    public Button ScrollUp;
    [Token(Token = "0x400BB70")]
    [FieldOffset(Offset = "0x1C")]
    public Button ScrollDw;
    [Token(Token = "0x400BB71")]
    [FieldOffset(Offset = "0x20")]
    public SRPG_Button Make;
    [Token(Token = "0x400BB72")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button OK;
    [Token(Token = "0x400BB73")]
    [FieldOffset(Offset = "0x28")]
    public RectTransform ListRect;
    [Token(Token = "0x400BB74")]
    [FieldOffset(Offset = "0x2C")]
    public ScrollListController ScrollList;
    [Token(Token = "0x400BB75")]
    [FieldOffset(Offset = "0x30")]
    public RectTransform Cursor;
    [Token(Token = "0x400BB76")]
    [FieldOffset(Offset = "0x34")]
    private bool IsMultiTowerTop;
    [Token(Token = "0x400BB77")]
    [FieldOffset(Offset = "0x38")]
    private int max_tower_floor_num;
    [Token(Token = "0x400BB78")]
    [FieldOffset(Offset = "0x3C")]
    public Text RewardText;
    [Token(Token = "0x400BB79")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ItemRoot;
    [Token(Token = "0x400BB7A")]
    [FieldOffset(Offset = "0x44")]
    public GameObject ArtifactRoot;
    [Token(Token = "0x400BB7B")]
    [FieldOffset(Offset = "0x48")]
    public GameObject CoinRoot;
    [Token(Token = "0x400BB7C")]
    [FieldOffset(Offset = "0x4C")]
    public Text QuestAP;
    [Token(Token = "0x400BB7D")]
    [FieldOffset(Offset = "0x50")]
    public Text ChangeQuestAP;
    [Token(Token = "0x400BB7E")]
    [FieldOffset(Offset = "0x54")]
    public GameObject PassButton;
    [Token(Token = "0x400BB7F")]
    [FieldOffset(Offset = "0x58")]
    private bool mIsActivatePinAfterSelectedFloor;

    [Token(Token = "0x1700188F")]
    public List<RectTransform> ItemList
    {
      [Token(Token = "0x600B206"), Address(RVA = "0x7640D0", Offset = "0x762ED0", VA = "0x107640D0")] get
      {
        return (List<RectTransform>) null;
      }
    }

    [Token(Token = "0x17001890")]
    public bool MultiTowerTop
    {
      [Token(Token = "0x600B207"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B208")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B209")]
    [Address(RVA = "0x7631C0", Offset = "0x761FC0", VA = "0x107631C0")]
    public void Init()
    {
    }

    [Token(Token = "0x600B20A")]
    [Address(RVA = "0x763E80", Offset = "0x762C80", VA = "0x10763E80")]
    private void Update()
    {
    }

    [Token(Token = "0x600B20B")]
    [Address(RVA = "0x763650", Offset = "0x762450", VA = "0x10763650")]
    private void OnScrollStop()
    {
    }

    [Token(Token = "0x600B20C")]
    [Address(RVA = "0x763A20", Offset = "0x762820", VA = "0x10763A20")]
    private void Setup(int idx)
    {
    }

    [Token(Token = "0x600B20D")]
    [Address(RVA = "0x764060", Offset = "0x762E60", VA = "0x10764060")]
    private void _SetScrollTo(float pos)
    {
    }

    [Token(Token = "0x600B20E")]
    [Address(RVA = "0x763FF0", Offset = "0x762DF0", VA = "0x10763FF0")]
    private void _SetScrollToQuick(float pos)
    {
    }

    [Token(Token = "0x600B20F")]
    [Address(RVA = "0x762CD0", Offset = "0x761AD0", VA = "0x10762CD0")]
    public float Clamp(float pos) => new float();

    [Token(Token = "0x600B210")]
    [Address(RVA = "0x763760", Offset = "0x762560", VA = "0x10763760")]
    public void OnScrollUp(int val)
    {
    }

    [Token(Token = "0x600B211")]
    [Address(RVA = "0x7635A0", Offset = "0x7623A0", VA = "0x107635A0")]
    public void OnScrollDw(int val)
    {
    }

    [Token(Token = "0x600B212")]
    [Address(RVA = "0x7634E0", Offset = "0x7622E0", VA = "0x107634E0")]
    public void OnCurrentScroll()
    {
    }

    [Token(Token = "0x600B213")]
    [Address(RVA = "0x763900", Offset = "0x762700", VA = "0x10763900")]
    private void ScrollToFloor(int index)
    {
    }

    [Token(Token = "0x600B214")]
    [Address(RVA = "0x763870", Offset = "0x762670", VA = "0x10763870")]
    private void ScrollToFloorQuick(int index)
    {
    }

    [Token(Token = "0x600B215")]
    [Address(RVA = "0x7637F0", Offset = "0x7625F0", VA = "0x107637F0")]
    public void OnTapFloor(int floor)
    {
    }

    [Token(Token = "0x600B216")]
    [Address(RVA = "0x762DE0", Offset = "0x761BE0", VA = "0x10762DE0")]
    private void FocusUpdate()
    {
    }

    [Token(Token = "0x600B217")]
    [Address(RVA = "0x762DD0", Offset = "0x761BD0", VA = "0x10762DD0")]
    public int ConvertFloor(int floor) => new int();

    [Token(Token = "0x600B218")]
    [Address(RVA = "0x762A20", Offset = "0x761820", VA = "0x10762A20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B219")]
    [Address(RVA = "0x763630", Offset = "0x762430", VA = "0x10763630")]
    public void OnScrollStart()
    {
    }

    [Token(Token = "0x600B21A")]
    [Address(RVA = "0x763970", Offset = "0x762770", VA = "0x10763970")]
    public void SetButtonIntractable(bool intaractable)
    {
    }

    [Token(Token = "0x600B21B")]
    [Address(RVA = "0x763120", Offset = "0x761F20", VA = "0x10763120")]
    public int GetCanCharengeFloor() => new int();

    [Token(Token = "0x600B21C")]
    [Address(RVA = "0x7640B0", Offset = "0x762EB0", VA = "0x107640B0")]
    public MultiTowerInfo()
    {
    }
  }
}

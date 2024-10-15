// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryCrystalListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022A6")]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "NextPage", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "PrevPage", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "SelectIcon", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "詳細ポップへ", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ソート設定変更ダイアログ表示", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "フィルター設定変更ダイアログ表示", FlowNode.PinTypes.Output, 103)]
  public class GalleryCrystalListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40099E7")]
    private const string SVB_KEY_GALLERY_ITEM = "GALLERY_ITEM";
    [Token(Token = "0x40099E8")]
    private const int PIN_IN_INIT = 0;
    [Token(Token = "0x40099E9")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x40099EA")]
    private const int PIN_IN_NEXT_PAGE = 2;
    [Token(Token = "0x40099EB")]
    private const int PIN_IN_PREV_PAGE = 3;
    [Token(Token = "0x40099EC")]
    private const int PIN_IN_SELECT_ICON = 10;
    [Token(Token = "0x40099ED")]
    private const int PIN_OUT_DETAIL = 101;
    [Token(Token = "0x40099EE")]
    private const int OUTPUT_SORT_SETTING = 102;
    [Token(Token = "0x40099EF")]
    private const int OUTPUT_FILTER_SETTING = 103;
    [Token(Token = "0x40099F0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40099F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GridLayoutGroup mParent;
    [Token(Token = "0x40099F2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GalleryCrystalListItem ItemTemplate;
    [Token(Token = "0x40099F3")]
    [FieldOffset(Offset = "0x18")]
    private int mCurrentPage;
    [Token(Token = "0x40099F4")]
    [FieldOffset(Offset = "0x1C")]
    private int mPageMax;
    [Token(Token = "0x40099F5")]
    [FieldOffset(Offset = "0x20")]
    private GalleryCrystalListModel mModel;
    [Token(Token = "0x40099F6")]
    [FieldOffset(Offset = "0x24")]
    private List<CrystalParam> mCrystalParams;
    [Token(Token = "0x40099F7")]
    [FieldOffset(Offset = "0x28")]
    private List<GalleryCrystalListItem> mListItems;
    [Token(Token = "0x40099F8")]
    [FieldOffset(Offset = "0x2C")]
    private string[] mGalleyItems;
    [Token(Token = "0x40099F9")]
    [FieldOffset(Offset = "0x30")]
    private int mPageContentMax;
    [Token(Token = "0x40099FA")]
    [FieldOffset(Offset = "0x0")]
    private static GalleryCrystalListWindow mInstance;

    [Token(Token = "0x170014D0")]
    public static GalleryCrystalListWindow Instance
    {
      [Token(Token = "0x600945F"), Address(RVA = "0x57A9A0", Offset = "0x5797A0", VA = "0x1057A9A0")] get
      {
        return (GalleryCrystalListWindow) null;
      }
    }

    [Token(Token = "0x170014D1")]
    public CrystalParam CurrentCrystalParam
    {
      [Token(Token = "0x6009460"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (CrystalParam) null;
      }
      [Token(Token = "0x6009461"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x6009462")]
    [Address(RVA = "0x57A840", Offset = "0x579640", VA = "0x1057A840")]
    private void Start()
    {
    }

    [Token(Token = "0x6009463")]
    [Address(RVA = "0x57A610", Offset = "0x579410", VA = "0x1057A610")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009464")]
    [Address(RVA = "0x579D50", Offset = "0x578B50", VA = "0x10579D50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009465")]
    [Address(RVA = "0x57A820", Offset = "0x579620", VA = "0x1057A820")]
    public void SetGalleyItems(string[] items)
    {
    }

    [Token(Token = "0x6009466")]
    [Address(RVA = "0x57A170", Offset = "0x578F70", VA = "0x1057A170")]
    private void Init()
    {
    }

    [Token(Token = "0x6009467")]
    [Address(RVA = "0x57A010", Offset = "0x578E10", VA = "0x1057A010")]
    private void IconRefresh()
    {
    }

    [Token(Token = "0x6009468")]
    [Address(RVA = "0x57A5E0", Offset = "0x5793E0", VA = "0x1057A5E0")]
    private void NextPage()
    {
    }

    [Token(Token = "0x6009469")]
    [Address(RVA = "0x57A650", Offset = "0x579450", VA = "0x1057A650")]
    private void PrevPage()
    {
    }

    [Token(Token = "0x600946A")]
    [Address(RVA = "0x57A680", Offset = "0x579480", VA = "0x1057A680")]
    private void SelectIcon()
    {
    }

    [Token(Token = "0x600946B")]
    [Address(RVA = "0x579DE0", Offset = "0x578BE0", VA = "0x10579DE0")]
    private int GetCellCount() => new int();

    [Token(Token = "0x600946C")]
    [Address(RVA = "0x57A8B0", Offset = "0x5796B0", VA = "0x1057A8B0")]
    public GalleryCrystalListWindow()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.GachaPickupSelectWindow
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
  [Token(Token = "0x200240F")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "決定ボタンをタップ", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(11, "確認", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "決定", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("UI/Gacha/GachaPickupSelectWindow")]
  public class GachaPickupSelectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A304")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400A305")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400A306")]
    private const int PIN_IN_DECIDE = 3;
    [Token(Token = "0x400A307")]
    private const int PIN_OUT_NOT_SELECTED = 10;
    [Token(Token = "0x400A308")]
    private const int PIN_OUT_CONFIRM = 11;
    [Token(Token = "0x400A309")]
    private const int PIN_OUT_DECIDE = 12;
    [Token(Token = "0x400A30A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mPickupUnitList;
    [Token(Token = "0x400A30B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentController mContentControllerUnit;
    [Token(Token = "0x400A30C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mPickupCardList;
    [Token(Token = "0x400A30D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentController mContentControllerCard;
    [Token(Token = "0x400A30E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform SelectedListParent;
    [Token(Token = "0x400A30F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject SelectedListItem;
    [Token(Token = "0x400A310")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x400A311")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CrystalScrollList mPickupCrystalList;
    [Token(Token = "0x400A312")]
    [FieldOffset(Offset = "0x2C")]
    private List<GachaDropData> mDropDatas;
    [Token(Token = "0x400A313")]
    [FieldOffset(Offset = "0x30")]
    private List<GachaPickupIconParam> mIconParams;
    [Token(Token = "0x400A314")]
    [FieldOffset(Offset = "0x34")]
    private List<GachaDropData> mSelectedDatas;
    [Token(Token = "0x400A315")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mSelectedLists;
    [Token(Token = "0x400A316")]
    [FieldOffset(Offset = "0x3C")]
    private ContentController mMainContentController;
    [Token(Token = "0x400A317")]
    [FieldOffset(Offset = "0x40")]
    private int mSelectMax;
    [Token(Token = "0x400A318")]
    [FieldOffset(Offset = "0x44")]
    private GachaPickupSelectType mSelectType;
    [Token(Token = "0x400A319")]
    [FieldOffset(Offset = "0x48")]
    private GachaDropData.Type mPickupType;
    [Token(Token = "0x400A31A")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsInteractable;

    [Token(Token = "0x6009CF8")]
    [Address(RVA = "0x6029A0", Offset = "0x6017A0", VA = "0x106029A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009CF9")]
    [Address(RVA = "0x602B20", Offset = "0x601920", VA = "0x10602B20")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009CFA")]
    [Address(RVA = "0x602CC0", Offset = "0x601AC0", VA = "0x10602CC0")]
    public void Init()
    {
    }

    [Token(Token = "0x6009CFB")]
    [Address(RVA = "0x603730", Offset = "0x602530", VA = "0x10603730")]
    private void Initalize()
    {
    }

    [Token(Token = "0x6009CFC")]
    [Address(RVA = "0x603310", Offset = "0x602110", VA = "0x10603310")]
    private void InitalizeCrystalScrollList()
    {
    }

    [Token(Token = "0x6009CFD")]
    [Address(RVA = "0x6030C0", Offset = "0x601EC0", VA = "0x106030C0")]
    private void InitalizeContentController()
    {
    }

    [Token(Token = "0x6009CFE")]
    [Address(RVA = "0x604110", Offset = "0x602F10", VA = "0x10604110")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009CFF")]
    [Address(RVA = "0x6038E0", Offset = "0x6026E0", VA = "0x106038E0")]
    public void OnClickNodeSelectedList(GachaDropIconNode node)
    {
    }

    [Token(Token = "0x6009D00")]
    [Address(RVA = "0x603990", Offset = "0x602790", VA = "0x10603990")]
    public void OnClickNode(GachaDropIconNode node)
    {
    }

    [Token(Token = "0x6009D01")]
    [Address(RVA = "0x6043F0", Offset = "0x6031F0", VA = "0x106043F0")]
    private void SetSelectPickupData(GachaDropData select)
    {
    }

    [Token(Token = "0x6009D02")]
    [Address(RVA = "0x603490", Offset = "0x602290", VA = "0x10603490")]
    private void InitalizeSelectedList()
    {
    }

    [Token(Token = "0x6009D03")]
    [Address(RVA = "0x603E80", Offset = "0x602C80", VA = "0x10603E80")]
    private void RefreshSelectedList()
    {
    }

    [Token(Token = "0x6009D04")]
    [Address(RVA = "0x604310", Offset = "0x603110", VA = "0x10604310")]
    private void ResetSelectedListIcon()
    {
    }

    [Token(Token = "0x6009D05")]
    [Address(RVA = "0x603A40", Offset = "0x602840", VA = "0x10603A40")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6009D06")]
    [Address(RVA = "0x603B80", Offset = "0x602980", VA = "0x10603B80")]
    private void OnSelectCrystal()
    {
    }

    [Token(Token = "0x6009D07")]
    [Address(RVA = "0x602BC0", Offset = "0x6019C0", VA = "0x10602BC0")]
    private CrystalData[] CreateCrystalDataList() => (CrystalData[]) null;

    [Token(Token = "0x6009D08")]
    [Address(RVA = "0x602BA0", Offset = "0x6019A0", VA = "0x10602BA0")]
    private CrystalData[] CreateCrystalDataListForSelectedList() => (CrystalData[]) null;

    [Token(Token = "0x6009D09")]
    [Address(RVA = "0x602BE0", Offset = "0x6019E0", VA = "0x10602BE0")]
    private CrystalData[] CreateCrystalDataList(List<GachaDropData> crystalList)
    {
      return (CrystalData[]) null;
    }

    [Token(Token = "0x6009D0A")]
    [Address(RVA = "0x604550", Offset = "0x603350", VA = "0x10604550")]
    public GachaPickupSelectWindow()
    {
    }
  }
}

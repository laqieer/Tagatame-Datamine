// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSkinSelectWindow
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
  [Token(Token = "0x2002CF2")]
  [AddComponentMenu("UI/UnitSkinSelectWindow")]
  [FlowNode.Pin(104, "全ジョブ設定：完了", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(1, "選択確認：決定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(103, "外す：完了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(105, "閉じる：完了", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(3, "外す", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "選択確認：取消", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(5, "閉じる", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(101, "決定：完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(4, "全ジョブ設定", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(102, "取消：完了", FlowNode.PinTypes.Output, 102)]
  public class UnitSkinSelectWindow : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400DF70")]
    public const int PIN_IN_SELECT = 1;
    [Token(Token = "0x400DF71")]
    public const int PIN_IN_CANCEL = 2;
    [Token(Token = "0x400DF72")]
    public const int PIN_IN_REMOVE = 3;
    [Token(Token = "0x400DF73")]
    public const int PIN_IN_SET_ALL = 4;
    [Token(Token = "0x400DF74")]
    public const int PIN_IN_CLOSE_WINDOW = 5;
    [Token(Token = "0x400DF75")]
    public const int PIN_OUT_SELECT = 101;
    [Token(Token = "0x400DF76")]
    public const int PIN_OUT_CANCEL = 102;
    [Token(Token = "0x400DF77")]
    public const int PIN_OUT_REMOVE = 103;
    [Token(Token = "0x400DF78")]
    public const int PIN_OUT_SET_ALL = 104;
    [Token(Token = "0x400DF79")]
    public const int PIN_OUT_CLOSE_WINDOW = 105;
    [Token(Token = "0x400DF7A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform ListItemParent;
    [Token(Token = "0x400DF7B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject ListItemTemplate;
    [Token(Token = "0x400DF7C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject SelectConfirmTemplate;
    [Token(Token = "0x400DF7D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject DefaultOverlayParent;
    [Token(Token = "0x400DF7E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject SettingOverlay;
    [Token(Token = "0x400DF7F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject PointingOverlay;
    [Token(Token = "0x400DF80")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject RemoveButton;
    [Token(Token = "0x400DF81")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text RemoveName;
    [Token(Token = "0x400DF82")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SRPG_Button DecideButton;
    [Token(Token = "0x400DF83")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text TitleSkinName;
    [Token(Token = "0x400DF84")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text TitleSkinDesc;
    [Token(Token = "0x400DF85")]
    [FieldOffset(Offset = "0x4C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DF86")]
    [FieldOffset(Offset = "0x50")]
    private GameObject mPointingItem;
    [Token(Token = "0x400DF87")]
    [FieldOffset(Offset = "0x54")]
    private GameObject mDecidedItem;
    [Token(Token = "0x400DF88")]
    [FieldOffset(Offset = "0x58")]
    private ArtifactParam mConfirmSkin;
    [Token(Token = "0x400DF89")]
    [FieldOffset(Offset = "0x5C")]
    private List<GameObject> mSkins;
    [Token(Token = "0x400DF8A")]
    [FieldOffset(Offset = "0x60")]
    public UnitSkinSelectWindow.SkinSelectEvent OnSkinSelect;
    [Token(Token = "0x400DF8B")]
    [FieldOffset(Offset = "0x64")]
    public UnitSkinSelectWindow.SkinDecideEvent OnSkinDecide;
    [Token(Token = "0x400DF8C")]
    [FieldOffset(Offset = "0x68")]
    public UnitSkinSelectWindow.SkinDecideEvent OnSkinDecideAll;
    [Token(Token = "0x400DF8D")]
    [FieldOffset(Offset = "0x6C")]
    public UnitSkinSelectWindow.SkinRemoveEvent OnSkinRemove;
    [Token(Token = "0x400DF8E")]
    [FieldOffset(Offset = "0x70")]
    public UnitSkinSelectWindow.SkinRemoveEvent OnSkinRemoveAll;
    [Token(Token = "0x400DF8F")]
    [FieldOffset(Offset = "0x74")]
    public UnitSkinSelectWindow.SkinSelectEvent OnDecide;
    [Token(Token = "0x400DF90")]
    [FieldOffset(Offset = "0x78")]
    public UnitSkinSelectWindow.SkinCloseEvent OnSkinClose;

    [Token(Token = "0x600D12D")]
    [Address(RVA = "0x9C3730", Offset = "0x9C2530", VA = "0x109C3730", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600D12E")]
    [Address(RVA = "0x9C2670", Offset = "0x9C1470", VA = "0x109C2670")]
    private void CreateSkinList()
    {
    }

    [Token(Token = "0x600D12F")]
    [Address(RVA = "0x9C2340", Offset = "0x9C1140", VA = "0x109C2340")]
    private GameObject CreateSkinListItem(ArtifactParam skinParam, bool isSelectable)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600D130")]
    [Address(RVA = "0x9C2B20", Offset = "0x9C1920", VA = "0x109C2B20")]
    private void DestroySkinList()
    {
    }

    [Token(Token = "0x600D131")]
    [Address(RVA = "0x9C2130", Offset = "0x9C0F30", VA = "0x109C2130", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D132")]
    [Address(RVA = "0x9C3020", Offset = "0x9C1E20", VA = "0x109C3020")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600D133")]
    [Address(RVA = "0x9C2E50", Offset = "0x9C1C50", VA = "0x109C2E50")]
    private void OnSelectAll(GameObject go)
    {
    }

    [Token(Token = "0x600D134")]
    [Address(RVA = "0x9C2DE0", Offset = "0x9C1BE0", VA = "0x109C2DE0")]
    private void OnRemoveSelect(GameObject go)
    {
    }

    [Token(Token = "0x600D135")]
    [Address(RVA = "0x9C2CF0", Offset = "0x9C1AF0", VA = "0x109C2CF0")]
    private void OnRemoveAll(GameObject go)
    {
    }

    [Token(Token = "0x600D136")]
    [Address(RVA = "0x9C2CC0", Offset = "0x9C1AC0", VA = "0x109C2CC0")]
    public void OnClose()
    {
    }

    [Token(Token = "0x600D137")]
    [Address(RVA = "0x9C3640", Offset = "0x9C2440", VA = "0x109C3640")]
    public void Setup(UnitData unitData)
    {
    }

    [Token(Token = "0x600D138")]
    [Address(RVA = "0x9C3100", Offset = "0x9C1F00", VA = "0x109C3100")]
    private void RefreshRemoveButton()
    {
    }

    [Token(Token = "0x600D139")]
    [Address(RVA = "0x9C3410", Offset = "0x9C2210", VA = "0x109C3410")]
    private void SetDefaultOverlay()
    {
    }

    [Token(Token = "0x600D13A")]
    [Address(RVA = "0x9C3330", Offset = "0x9C2130", VA = "0x109C3330")]
    private void SetDecidedOverlay(GameObject parent)
    {
    }

    [Token(Token = "0x600D13B")]
    [Address(RVA = "0x9C3480", Offset = "0x9C2280", VA = "0x109C3480")]
    private void SetPointingOverLay(GameObject parent)
    {
    }

    [Token(Token = "0x600D13C")]
    [Address(RVA = "0x9C3560", Offset = "0x9C2360", VA = "0x109C3560")]
    private void SetSelectedSkinText(ArtifactParam param)
    {
    }

    [Token(Token = "0x600D13D")]
    [Address(RVA = "0x9C2A80", Offset = "0x9C1880", VA = "0x109C2A80")]
    private void DecideButtonInteractive(bool interactive)
    {
    }

    [Token(Token = "0x600D13E")]
    [Address(RVA = "0x9C2C50", Offset = "0x9C1A50", VA = "0x109C2C50")]
    private ArtifactParam[] MergeSkinArray(ArtifactParam[] array1, ArtifactParam[] array2)
    {
      return (ArtifactParam[]) null;
    }

    [Token(Token = "0x600D13F")]
    [Address(RVA = "0x7B5270", Offset = "0x7B4070", VA = "0x107B5270")]
    public void SendCloseEvent()
    {
    }

    [Token(Token = "0x600D140")]
    [Address(RVA = "0x9C38B0", Offset = "0x9C26B0", VA = "0x109C38B0")]
    public UnitSkinSelectWindow()
    {
    }

    [Token(Token = "0x2002CF3")]
    public delegate void SkinSelectEvent(ArtifactParam artifact);

    [Token(Token = "0x2002CF4")]
    public delegate void SkinDecideEvent(ArtifactParam artifact);

    [Token(Token = "0x2002CF5")]
    public delegate void SkinRemoveEvent();

    [Token(Token = "0x2002CF6")]
    public delegate void SkinCloseEvent();
  }
}

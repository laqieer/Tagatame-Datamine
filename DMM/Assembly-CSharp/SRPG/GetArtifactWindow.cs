// Decompiled with JetBrains decompiler
// Type: SRPG.GetArtifactWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024FF")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "武具更新", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GetArtifactWindow")]
  [FlowNode.Pin(2, "名称検索", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "武具選択", FlowNode.PinTypes.Output, 100)]
  public class GetArtifactWindow : SRPG_FixedList, IFlowInterface
  {
    [Token(Token = "0x400A90F")]
    private const int INPUT_REFRESH = 1;
    [Token(Token = "0x400A910")]
    private const int INPUT_NAME_SERACH = 2;
    [Token(Token = "0x400A911")]
    private const int OUTPUT_SELECT = 100;
    [Token(Token = "0x400A912")]
    private const int OUTPUT_UPDATE = 101;
    [Token(Token = "0x400A913")]
    [FieldOffset(Offset = "0x64")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400A914")]
    [FieldOffset(Offset = "0x68")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A915")]
    [FieldOffset(Offset = "0x6C")]
    private ArtifactSelectListItemData[] mArtifactListItem;
    [Token(Token = "0x400A916")]
    [FieldOffset(Offset = "0x70")]
    private List<ArtifactData> mArtifactDataList;
    [Token(Token = "0x400A917")]
    [FieldOffset(Offset = "0x0")]
    private static string s_SelectedConceptCardID;
    [Token(Token = "0x400A918")]
    [FieldOffset(Offset = "0x74")]
    public Transform mNameBoxParent;
    [Token(Token = "0x400A919")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_select_artifact";
    [Token(Token = "0x400A91A")]
    [FieldOffset(Offset = "0x78")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x400A91B")]
    [FieldOffset(Offset = "0x7C")]
    private string mNameSearchInput;
    [Token(Token = "0x400A91C")]
    [FieldOffset(Offset = "0x80")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x600A27A")]
    [Address(RVA = "0x649850", Offset = "0x648650", VA = "0x10649850", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600A27B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600A27C")]
    [Address(RVA = "0x6496F0", Offset = "0x6484F0", VA = "0x106496F0", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A27D")]
    [Address(RVA = "0x64A1F0", Offset = "0x648FF0", VA = "0x1064A1F0")]
    public void SetUp(ArtifactSelectListItemData[] data)
    {
    }

    [Token(Token = "0x600A27E")]
    [Address(RVA = "0x649FB0", Offset = "0x648DB0", VA = "0x10649FB0")]
    public void Refresh(ArtifactData[] artifact_datas)
    {
    }

    [Token(Token = "0x600A27F")]
    [Address(RVA = "0x649CD0", Offset = "0x648AD0", VA = "0x10649CD0", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x600A280")]
    [Address(RVA = "0x6499F0", Offset = "0x6487F0", VA = "0x106499F0", Slot = "27")]
    public override void BindData()
    {
    }

    [Token(Token = "0x600A281")]
    [Address(RVA = "0x649F20", Offset = "0x648D20", VA = "0x10649F20", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600A282")]
    [Address(RVA = "0x649D30", Offset = "0x648B30", VA = "0x10649D30")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600A283")]
    [Address(RVA = "0x649E50", Offset = "0x648C50", VA = "0x10649E50")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x600A284")]
    [Address(RVA = "0x64A0A0", Offset = "0x648EA0", VA = "0x1064A0A0")]
    public void SetNameSearchInfo()
    {
    }

    [Token(Token = "0x600A285")]
    [Address(RVA = "0x64A4E0", Offset = "0x6492E0", VA = "0x1064A4E0")]
    public GetArtifactWindow()
    {
    }

    [Token(Token = "0x600A286")]
    [Address(RVA = "0x64A490", Offset = "0x649290", VA = "0x1064A490")]
    static GetArtifactWindow()
    {
    }
  }
}

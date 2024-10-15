// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiFilterWindow
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
  [Token(Token = "0x2002ACE")]
  [AddComponentMenu("UI/SortFilter/ArtiFilterWindow")]
  [FlowNode.Pin(5, "全クリア", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "フィルター更新する", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "キャンセルする", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "全選択", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(101, "フィルター更新された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "キャンセルされた", FlowNode.PinTypes.Output, 102)]
  public class ArtiFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D0C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400D0CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoTabParent;
    [Token(Token = "0x400D0CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ArtiFilterItemTab TemplateTab;
    [Token(Token = "0x400D0CC")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private ArtiFilterCategory TemplateCateoryRarity;
    [Token(Token = "0x400D0CD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ArtiFilterCategory TemplateCateoryEquipType;
    [Token(Token = "0x400D0CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ArtiFilterCategory TemplateCateoryArmsType;
    [Token(Token = "0x400D0CF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ArtiFilterCategory TemplateCateoryParameter;
    [Token(Token = "0x400D0D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArtiFilterCategory TemplateCateoryOther;
    [Token(Token = "0x400D0D1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Space(5f)]
    private ScrollRect SrController;
    [Token(Token = "0x400D0D2")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400D0D3")]
    private const int PIN_IN_UPDATE = 2;
    [Token(Token = "0x400D0D4")]
    private const int PIN_IN_CANCEL = 3;
    [Token(Token = "0x400D0D5")]
    private const int PIN_IN_ALL_SET = 4;
    [Token(Token = "0x400D0D6")]
    private const int PIN_IN_ALL_CLR = 5;
    [Token(Token = "0x400D0D7")]
    private const int PIN_OUT_UPDATED = 101;
    [Token(Token = "0x400D0D8")]
    private const int PIN_OUT_CANCELED = 102;
    [Token(Token = "0x400D0D9")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, ArtiFilterItemTab> mTabDict;
    [Token(Token = "0x400D0DA")]
    [FieldOffset(Offset = "0x34")]
    private string mCurrentTabName;
    [Token(Token = "0x400D0DB")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<string, ArtiFilterCategory> mCategoryDict;
    [Token(Token = "0x400D0DC")]
    [FieldOffset(Offset = "0x3C")]
    private IEnumerator mToggleFadeAnimation;

    [Token(Token = "0x600C37B")]
    [Address(RVA = "0x8BB370", Offset = "0x8BA170", VA = "0x108BB370")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C37C")]
    [Address(RVA = "0x8BB9E0", Offset = "0x8BA7E0", VA = "0x108BB9E0")]
    private void Init()
    {
    }

    [Token(Token = "0x600C37D")]
    [Address(RVA = "0x8BC820", Offset = "0x8BB620", VA = "0x108BC820")]
    private void SelectTab(string tab_name, bool is_init = false)
    {
    }

    [Token(Token = "0x600C37E")]
    [Address(RVA = "0x8BCA60", Offset = "0x8BB860", VA = "0x108BCA60")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600C37F")]
    [Address(RVA = "0x8BC9E0", Offset = "0x8BB7E0", VA = "0x108BC9E0")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600C380")]
    [Address(RVA = "0x8BCA20", Offset = "0x8BB820", VA = "0x108BCA20")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600C381")]
    [Address(RVA = "0x8BB3C0", Offset = "0x8BA1C0", VA = "0x108BB3C0")]
    private bool ContainsActiveFilterInTab(string tab_name) => new bool();

    [Token(Token = "0x600C382")]
    [Address(RVA = "0x8BC450", Offset = "0x8BB250", VA = "0x108BC450")]
    private void OnTapTabItem(bool val, ArtiFilterItemTab item)
    {
    }

    [Token(Token = "0x600C383")]
    [Address(RVA = "0x8BB840", Offset = "0x8BA640", VA = "0x108BB840")]
    private void FilterAllSet()
    {
    }

    [Token(Token = "0x600C384")]
    [Address(RVA = "0x8BB6A0", Offset = "0x8BA4A0", VA = "0x108BB6A0")]
    private void FilterAllClr()
    {
    }

    [Token(Token = "0x600C385")]
    [Address(RVA = "0x8BC270", Offset = "0x8BB070", VA = "0x108BC270")]
    private void LoadPrefs()
    {
    }

    [Token(Token = "0x600C386")]
    [Address(RVA = "0x8BC4F0", Offset = "0x8BB2F0", VA = "0x108BC4F0")]
    private void SavePrefs()
    {
    }

    [Token(Token = "0x600C387")]
    [Address(RVA = "0x8BD010", Offset = "0x8BBE10", VA = "0x108BD010")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x600C388")]
    [Address(RVA = "0x8BA720", Offset = "0x8B9520", VA = "0x108BA720", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C389")]
    [Address(RVA = "0x8BA7B0", Offset = "0x8B95B0", VA = "0x108BA7B0")]
    public static FilterUtility.FilterPrefs ArtiFilterLoadPrefs()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x600C38A")]
    [Address(RVA = "0x8BAB60", Offset = "0x8B9960", VA = "0x108BAB60")]
    public static bool ArtiFilterMatchCondition(
      FilterUtility.FilterPrefs filter,
      ArtifactParam artifact_param,
      ArtifactData artifact_data = null,
      bool is_artifact_scene = false)
    {
      return new bool();
    }

    [Token(Token = "0x600C38B")]
    [Address(RVA = "0x8BB1B0", Offset = "0x8B9FB0", VA = "0x108BB1B0")]
    public static void ArtiFilterUnitRemove(
      FilterUtility.FilterPrefs filter,
      ref List<ArtifactData> artifact_datas,
      bool is_artifact_scene)
    {
    }

    [Token(Token = "0x600C38C")]
    [Address(RVA = "0x8BD1D0", Offset = "0x8BBFD0", VA = "0x108BD1D0")]
    public ArtiFilterWindow()
    {
    }
  }
}

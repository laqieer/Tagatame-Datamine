// Decompiled with JetBrains decompiler
// Type: SRPG.NameSearchBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B1")]
  [FlowNode.Pin(61, "タイプ", FlowNode.PinTypes.Input, 61)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "更新：実行", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "文字：リセット", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(51, "入力", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(31, "開く", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(151, "入力：完了", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(161, "タイプ：完了", FlowNode.PinTypes.Output, 161)]
  [FlowNode.Pin(121, "開く", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(112, "更新：終了", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "更新：依頼", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(41, "閉じる", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(122, "閉じる", FlowNode.PinTypes.Output, 122)]
  public class NameSearchBox : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BBD8")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400BBD9")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400BBDA")]
    private const int PIN_IN_RESET = 21;
    [Token(Token = "0x400BBDB")]
    private const int PIN_IN_OPEN = 31;
    [Token(Token = "0x400BBDC")]
    private const int PIN_IN_CLOSE = 41;
    [Token(Token = "0x400BBDD")]
    private const int PIN_IN_INPUT = 51;
    [Token(Token = "0x400BBDE")]
    private const int PIN_IN_TYPE = 61;
    [Token(Token = "0x400BBDF")]
    private const int PIN_OUT_REFRESH = 111;
    [Token(Token = "0x400BBE0")]
    private const int PIN_OUT_REFRESH_END = 112;
    [Token(Token = "0x400BBE1")]
    private const int PIN_OUT_OPEN = 121;
    [Token(Token = "0x400BBE2")]
    private const int PIN_OUT_CLOSE = 122;
    [Token(Token = "0x400BBE3")]
    private const int PIN_OUT_INPUT = 151;
    [Token(Token = "0x400BBE4")]
    private const int PIN_OUT_TYPE = 161;
    [Token(Token = "0x400BBE5")]
    private const string TEXT_PLACE_HOLDER_ARTIFACT = "sys.NAMESEARCHBOX_PLACE_HOLDER_ARTIFACT_TEXT";
    [Token(Token = "0x400BBE6")]
    private const string TEXT_PLACE_HOLDER_CONCEPTCARD = "sys.NAMESEARCHBOX_PLACE_HOLDER_CONCEPTCARD_TEXT";
    [Token(Token = "0x400BBE7")]
    private const string TEXT_PLACE_HOLDER_UNIT = "sys.NAMESEARCHBOX_PLACE_HOLDER_UNIT_TEXT";
    [Token(Token = "0x400BBE8")]
    private const string TEXT_PLACE_HOLDER_CRYSTAL = "sys.NAMESEARCHBOX_PLACE_HOLDER_CRYSTAL_TEXT";
    [Token(Token = "0x400BBE9")]
    private const string TEXT_PLACE_HOLDER_ITEM = "sys.NAMESEARCHBOX_PLACE_HOLDER_ITEM_TEXT";
    [Token(Token = "0x400BBEA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BBEB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NameSearchInputField mInputField;
    [Token(Token = "0x400BBEC")]
    [FieldOffset(Offset = "0x14")]
    private NameSearchBoxModel mNameSearchBoxModel;
    [Token(Token = "0x400BBED")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsListRefresh;

    [Token(Token = "0x600B23F")]
    [Address(RVA = "0x7A62B0", Offset = "0x7A50B0", VA = "0x107A62B0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600B240")]
    [Address(RVA = "0x7A6460", Offset = "0x7A5260", VA = "0x107A6460")]
    public void ResetNameSearchBox()
    {
    }

    [Token(Token = "0x600B241")]
    [Address(RVA = "0x7A5CD0", Offset = "0x7A4AD0", VA = "0x107A5CD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B242")]
    [Address(RVA = "0x7A6370", Offset = "0x7A5170", VA = "0x107A6370")]
    public void InputFieldSelect()
    {
    }

    [Token(Token = "0x600B243")]
    [Address(RVA = "0x7A5FE0", Offset = "0x7A4DE0", VA = "0x107A5FE0")]
    public void ChangePlaceHolderText(NameSearchBox.TYPE type)
    {
    }

    [Token(Token = "0x600B244")]
    [Address(RVA = "0x7A6420", Offset = "0x7A5220", VA = "0x107A6420")]
    public void OpenWindow()
    {
    }

    [Token(Token = "0x600B245")]
    [Address(RVA = "0x7A6220", Offset = "0x7A5020", VA = "0x107A6220")]
    public void CloseWindow()
    {
    }

    [Token(Token = "0x600B246")]
    [Address(RVA = "0x7A6250", Offset = "0x7A5050", VA = "0x107A6250")]
    public string GetNameSearchString() => (string) null;

    [Token(Token = "0x600B247")]
    [Address(RVA = "0x7A65B0", Offset = "0x7A53B0", VA = "0x107A65B0")]
    public void SetNameSearchString()
    {
    }

    [Token(Token = "0x600B248")]
    [Address(RVA = "0x7A6510", Offset = "0x7A5310", VA = "0x107A6510")]
    public void ResetNameSearchString()
    {
    }

    [Token(Token = "0x600B249")]
    [Address(RVA = "0x7A6290", Offset = "0x7A5090", VA = "0x107A6290")]
    public SearchUtility.CONDITIONS GetNameSearchType() => new SearchUtility.CONDITIONS();

    [Token(Token = "0x600B24A")]
    [Address(RVA = "0x7A6710", Offset = "0x7A5510", VA = "0x107A6710")]
    public void SetNameSearchType(SearchUtility.CONDITIONS type)
    {
    }

    [Token(Token = "0x600B24B")]
    [Address(RVA = "0x7A6670", Offset = "0x7A5470", VA = "0x107A6670")]
    public void SetNameSearchText(string _search_text)
    {
    }

    [Token(Token = "0x600B24C")]
    [Address(RVA = "0x7A6400", Offset = "0x7A5200", VA = "0x107A6400")]
    private void ListRefresh()
    {
    }

    [Token(Token = "0x600B24D")]
    [Address(RVA = "0x7A6730", Offset = "0x7A5530", VA = "0x107A6730")]
    private void Setup()
    {
    }

    [Token(Token = "0x600B24E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NameSearchBox()
    {
    }

    [Token(Token = "0x20027B2")]
    public enum TYPE
    {
      [Token(Token = "0x400BBEF")] NONE,
      [Token(Token = "0x400BBF0")] ARTIFACT,
      [Token(Token = "0x400BBF1")] CONCEPTCARD,
      [Token(Token = "0x400BBF2")] UNIT,
      [Token(Token = "0x400BBF3")] CRYSTAL,
      [Token(Token = "0x400BBF4")] ITEM,
    }
  }
}

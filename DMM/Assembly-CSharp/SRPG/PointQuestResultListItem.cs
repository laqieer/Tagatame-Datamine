// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestResultListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002836")]
  [FlowNode.Pin(1, "表示切り替え", FlowNode.PinTypes.Input, 1)]
  public class PointQuestResultListItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BFBC")]
    private const int PIN_INPUT_CHANGE_BUTTON = 1;
    [Token(Token = "0x400BFBD")]
    private const string TRIANGLE_OFF_KEY = "sys.POINTQUEST_RESULT_TRIANGLE_OFF";
    [Token(Token = "0x400BFBE")]
    private const string TRIANGLE_ON_KEY = "sys.POINTQUEST_RESULT_TRIANGLE_ON";
    [Token(Token = "0x400BFBF")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼表示切り替えボタン")]
    private Button ChangeButton;
    [Token(Token = "0x400BFC0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HeaderBar("▼大項目用")]
    private GameObject MajorObj;
    [Token(Token = "0x400BFC1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TriangleOffObj;
    [Token(Token = "0x400BFC2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject TriangleOnObj;
    [Token(Token = "0x400BFC3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400BFC4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text PointText;
    [Token(Token = "0x400BFC5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text UnitText;
    [Token(Token = "0x400BFC6")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼スキップチケット用")]
    [SerializeField]
    private GameObject SkipObj;
    [Token(Token = "0x400BFC7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text SkipNum;
    [Token(Token = "0x400BFC8")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼演出用")]
    [SerializeField]
    private Animator SlideAnim;
    [Token(Token = "0x400BFC9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject SeObj;
    [Token(Token = "0x400BFCA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string EndAnimStateName;
    [Token(Token = "0x400BFCB")]
    [FieldOffset(Offset = "0x3C")]
    private PointQuestResultSubListItem mSubList;

    [Token(Token = "0x600B57D")]
    [Address(RVA = "0x7BE740", Offset = "0x7BD540", VA = "0x107BE740", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B57E")]
    [Address(RVA = "0x7BEA00", Offset = "0x7BD800", VA = "0x107BEA00")]
    public void SetUpMajorItem(
      string _title_key,
      string _point_text,
      string _unit_key,
      bool _is_interactable,
      PointQuestResultSubListItem _item)
    {
    }

    [Token(Token = "0x600B57F")]
    [Address(RVA = "0x7BEBD0", Offset = "0x7BD9D0", VA = "0x107BEBD0")]
    public void SetUpSkipItem(string _skip_num)
    {
    }

    [Token(Token = "0x600B580")]
    [Address(RVA = "0x7BE760", Offset = "0x7BD560", VA = "0x107BE760")]
    private void ChangeDisplayObj()
    {
    }

    [Token(Token = "0x600B581")]
    [Address(RVA = "0x7BEC80", Offset = "0x7BDA80", VA = "0x107BEC80")]
    public void StartAnim()
    {
    }

    [Token(Token = "0x600B582")]
    [Address(RVA = "0x7BE910", Offset = "0x7BD710", VA = "0x107BE910")]
    public void ForceEndAnim()
    {
    }

    [Token(Token = "0x600B583")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestResultListItem()
    {
    }
  }
}

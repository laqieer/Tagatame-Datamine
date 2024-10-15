// Decompiled with JetBrains decompiler
// Type: SRPG.ExternalLinkButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B0")]
  [AddComponentMenu("UI/ExternalLinkButton")]
  [FlowNode.Pin(1, "ボタンクリック", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ボタンクリック処理終了", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "リスト表示", FlowNode.PinTypes.Output, 3)]
  public class ExternalLinkButton : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A127")]
    private const int PIN_INPUT_BUTTON_CLICK_START = 1;
    [Token(Token = "0x400A128")]
    private const int PIN_OUTPUT_BUTTON_CLICK_FINISH = 2;
    [Token(Token = "0x400A129")]
    private const int PIN_OUTPUT_DISPLAY_LIST = 3;
    [Token(Token = "0x400A12A")]
    [FieldOffset(Offset = "0x0")]
    public static string SVB_OBJECT_KEY;
    [Token(Token = "0x400A12B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExternalLinkButton.eDisplayType DisplayType;
    [Token(Token = "0x400A12C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour SVBData;
    [Token(Token = "0x400A12D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool isDisplayIOS;
    [Token(Token = "0x400A12E")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    private bool isDisplayANDROID;
    [Token(Token = "0x400A12F")]
    [FieldOffset(Offset = "0x16")]
    [SerializeField]
    private bool isDisplayDMM;
    [Token(Token = "0x400A130")]
    [FieldOffset(Offset = "0x18")]
    private GameManager mGameManager;
    [Token(Token = "0x400A131")]
    [FieldOffset(Offset = "0x1C")]
    private bool mDisplayFlag;
    [Token(Token = "0x400A132")]
    [FieldOffset(Offset = "0x20")]
    private List<ExternalVideoLinkParam> mParamList;

    [Token(Token = "0x6009A77")]
    [Address(RVA = "0x5E8E20", Offset = "0x5E7C20", VA = "0x105E8E20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009A78")]
    [Address(RVA = "0x5E9250", Offset = "0x5E8050", VA = "0x105E9250")]
    private void Start()
    {
    }

    [Token(Token = "0x6009A79")]
    [Address(RVA = "0x5E9080", Offset = "0x5E7E80", VA = "0x105E9080")]
    public void SetUp(UnitParam _unit_param = null)
    {
    }

    [Token(Token = "0x6009A7A")]
    [Address(RVA = "0x5E8E40", Offset = "0x5E7C40", VA = "0x105E8E40")]
    private void AddParam(ExternalVideoLinkParam.ePlaceType _type)
    {
    }

    [Token(Token = "0x6009A7B")]
    [Address(RVA = "0x5E8F00", Offset = "0x5E7D00", VA = "0x105E8F00")]
    private void OnClickButton()
    {
    }

    [Token(Token = "0x6009A7C")]
    [Address(RVA = "0x5E9540", Offset = "0x5E8340", VA = "0x105E9540")]
    public ExternalLinkButton()
    {
    }

    [Token(Token = "0x6009A7D")]
    [Address(RVA = "0x5E94F0", Offset = "0x5E82F0", VA = "0x105E94F0")]
    static ExternalLinkButton()
    {
    }

    [Token(Token = "0x20023B1")]
    public enum eDisplayType
    {
      [Token(Token = "0x400A134")] None,
      [Token(Token = "0x400A135")] ConceptCard,
      [Token(Token = "0x400A136")] Artifact,
      [Token(Token = "0x400A137")] Unit,
      [Token(Token = "0x400A138")] Quest,
    }
  }
}

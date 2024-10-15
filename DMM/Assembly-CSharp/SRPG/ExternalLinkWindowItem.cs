// Decompiled with JetBrains decompiler
// Type: SRPG.ExternalLinkWindowItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B3")]
  [AddComponentMenu("UI/ExternalLinkWindowItem")]
  [FlowNode.Pin(1, "外部サイトに飛ばす", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ボタン処理終了", FlowNode.PinTypes.Output, 2)]
  public class ExternalLinkWindowItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A13F")]
    private const int PIN_INPUT_CLICK_ITEM = 1;
    [Token(Token = "0x400A140")]
    private const int PIN_OUTPUT_CLICK_FINISH = 2;
    [Token(Token = "0x400A141")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400A142")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text MainText;
    [Token(Token = "0x400A143")]
    [FieldOffset(Offset = "0x14")]
    private ExternalVideoLinkParam mParam;

    [Token(Token = "0x6009A81")]
    [Address(RVA = "0x5E95B0", Offset = "0x5E83B0", VA = "0x105E95B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009A82")]
    [Address(RVA = "0x5E9680", Offset = "0x5E8480", VA = "0x105E9680")]
    public void SetUp(ExternalVideoLinkParam _param)
    {
    }

    [Token(Token = "0x6009A83")]
    [Address(RVA = "0x5E9620", Offset = "0x5E8420", VA = "0x105E9620")]
    public void RemoveItem()
    {
    }

    [Token(Token = "0x6009A84")]
    [Address(RVA = "0x5E95F0", Offset = "0x5E83F0", VA = "0x105E95F0")]
    private void OnClick()
    {
    }

    [Token(Token = "0x6009A85")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ExternalLinkWindowItem()
    {
    }
  }
}

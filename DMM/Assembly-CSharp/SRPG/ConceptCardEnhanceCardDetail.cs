// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEnhanceCardDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002203")]
  [FlowNode.Pin(100, "イメージ拡大設定完了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/ConceptCardEnhanceCardDetail")]
  [FlowNode.Pin(0, "イメージ拡大", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "イメージが閉じられた", FlowNode.PinTypes.Input, 1)]
  public class ConceptCardEnhanceCardDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40095DF")]
    public const int PIN_OPEN_IN_IMAGE = 0;
    [Token(Token = "0x40095E0")]
    public const int PIN_CLOSE_IMAGE = 1;
    [Token(Token = "0x40095E1")]
    public const int PIN_OPEN_OUT_IMAGE = 100;
    [Token(Token = "0x40095E2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mIllustImage;
    [Token(Token = "0x40095E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mIllustFrame;
    [Token(Token = "0x40095E4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mCardNameText;
    [Token(Token = "0x40095E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mFlavorText;
    [Token(Token = "0x40095E6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StarGauge mStarGauge;
    [Token(Token = "0x40095E7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mMessage;
    [Token(Token = "0x40095E8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mMessageText;
    [Token(Token = "0x40095E9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mOverlayImageTemplate;
    [Token(Token = "0x40095EA")]
    [FieldOffset(Offset = "0x2C")]
    private ConceptCardData mConceptCardData;

    [Token(Token = "0x6008FE9")]
    [Address(RVA = "0x52DBE0", Offset = "0x52C9E0", VA = "0x1052DBE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008FEA")]
    [Address(RVA = "0x52DDB0", Offset = "0x52CBB0", VA = "0x1052DDB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008FEB")]
    [Address(RVA = "0x52DCB0", Offset = "0x52CAB0", VA = "0x1052DCB0")]
    private void SetFlavorTextText()
    {
    }

    [Token(Token = "0x6008FEC")]
    [Address(RVA = "0x52DD40", Offset = "0x52CB40", VA = "0x1052DD40")]
    private void SetText(Text text, string str)
    {
    }

    [Token(Token = "0x6008FED")]
    [Address(RVA = "0x52DA10", Offset = "0x52C810", VA = "0x1052DA10", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008FEE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardEnhanceCardDetail()
    {
    }
  }
}

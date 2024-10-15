// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022FD")]
  [AddComponentMenu("UI/DrawCard/DrawCardObject")]
  [FlowNode.Pin(151, "Reset", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(141, "Selectable", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(131, "Miss", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(101, "Open", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "Close", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(11, "OnClick", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(121, "Draw", FlowNode.PinTypes.Output, 121)]
  public class DrawCardObject : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009C23")]
    private const int INPUT_PIN_INITIALIZE = 1;
    [Token(Token = "0x4009C24")]
    private const int INPUT_PIN_ONCLICK = 11;
    [Token(Token = "0x4009C25")]
    private const int OUTPUT_PIN_OPEN = 101;
    [Token(Token = "0x4009C26")]
    private const int OUTPUT_PIN_CLOSE = 111;
    [Token(Token = "0x4009C27")]
    private const int OUTPUT_PIN_DRAW = 121;
    [Token(Token = "0x4009C28")]
    private const int OUTPUT_PIN_MISS = 131;
    [Token(Token = "0x4009C29")]
    private const int OUTPUT_PIN_SELECTABLE = 141;
    [Token(Token = "0x4009C2A")]
    private const int OUTPUT_PIN_RESET = 151;
    [Token(Token = "0x4009C2B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject SelectCursor;
    [Token(Token = "0x4009C2C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private DrawCardGetItem Item;
    [Token(Token = "0x4009C2D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button Button;
    [Token(Token = "0x4009C2E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mMask;
    [Token(Token = "0x4009C2F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mMoveObject;
    [Token(Token = "0x4009C30")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mRootObject;
    [Token(Token = "0x4009C31")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private AnimationCurve mCurve;
    [Token(Token = "0x4009C32")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray CardBackImage;
    [Token(Token = "0x4009C33")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ImageArray CardFowardImage;
    [Token(Token = "0x4009C34")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray CardJokerImage;
    [Token(Token = "0x4009C35")]
    [FieldOffset(Offset = "0x34")]
    private bool mSelected;
    [Token(Token = "0x4009C36")]
    [FieldOffset(Offset = "0x38")]
    private DrawCardContent mContent;
    [Token(Token = "0x4009C37")]
    [FieldOffset(Offset = "0x3C")]
    private DrawCardParam.CardData mCardData;

    [Token(Token = "0x6009675")]
    [Address(RVA = "0x593DE0", Offset = "0x592BE0", VA = "0x10593DE0")]
    public void Initialize(DrawCardContent content)
    {
    }

    [Token(Token = "0x6009676")]
    [Address(RVA = "0x594130", Offset = "0x592F30", VA = "0x10594130")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009677")]
    [Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")]
    public void SetCardData(DrawCardParam.CardData card_data)
    {
    }

    [Token(Token = "0x6009678")]
    [Address(RVA = "0x593C60", Offset = "0x592A60", VA = "0x10593C60")]
    public void CardItemActive(bool enable)
    {
    }

    [Token(Token = "0x6009679")]
    [Address(RVA = "0x5941F0", Offset = "0x592FF0", VA = "0x105941F0")]
    public void Select(bool select)
    {
    }

    [Token(Token = "0x600967A")]
    [Address(RVA = "0x593FB0", Offset = "0x592DB0", VA = "0x10593FB0")]
    public void Mask(bool mask)
    {
    }

    [Token(Token = "0x600967B")]
    [Address(RVA = "0x593BF0", Offset = "0x5929F0", VA = "0x10593BF0")]
    public void ButtonActive(bool select)
    {
    }

    [Token(Token = "0x600967C")]
    [Address(RVA = "0x593B70", Offset = "0x592970", VA = "0x10593B70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600967D")]
    [Address(RVA = "0x5944E0", Offset = "0x5932E0", VA = "0x105944E0")]
    public void SetStartPosition(Vector3 position)
    {
    }

    [Token(Token = "0x600967E")]
    [Address(RVA = "0x593DA0", Offset = "0x592BA0", VA = "0x10593DA0")]
    public Vector3 GetRootPosition() => new Vector3();

    [Token(Token = "0x600967F")]
    [Address(RVA = "0x593D70", Offset = "0x592B70", VA = "0x10593D70")]
    public GameObject GetMoveObject() => (GameObject) null;

    [Token(Token = "0x6009680")]
    [Address(RVA = "0x5942B0", Offset = "0x5930B0", VA = "0x105942B0")]
    public void SetPosition(
      Vector3 start_position,
      Vector3 target_position,
      float start_scale,
      float target_scale,
      float start_rotate,
      float target_rotate,
      float time)
    {
    }

    [Token(Token = "0x6009681")]
    [Address(RVA = "0x594050", Offset = "0x592E50", VA = "0x10594050")]
    public IEnumerator Move(
      Vector3 start_position,
      Vector3 target_position,
      float start_scale,
      float target_scale,
      float start_rotate,
      float target_rotate,
      float target_time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6009682")]
    [Address(RVA = "0x593CE0", Offset = "0x592AE0", VA = "0x10593CE0")]
    public void CardReset()
    {
    }

    [Token(Token = "0x6009683")]
    [Address(RVA = "0x594110", Offset = "0x592F10", VA = "0x10594110")]
    public void Open()
    {
    }

    [Token(Token = "0x6009684")]
    [Address(RVA = "0x593D50", Offset = "0x592B50", VA = "0x10593D50")]
    public void Draw()
    {
    }

    [Token(Token = "0x6009685")]
    [Address(RVA = "0x594270", Offset = "0x593070", VA = "0x10594270")]
    public void Selectable()
    {
    }

    [Token(Token = "0x6009686")]
    [Address(RVA = "0x594020", Offset = "0x592E20", VA = "0x10594020")]
    public void Miss()
    {
    }

    [Token(Token = "0x6009687")]
    [Address(RVA = "0x593D10", Offset = "0x592B10", VA = "0x10593D10")]
    public void Close()
    {
    }

    [Token(Token = "0x6009688")]
    [Address(RVA = "0x594560", Offset = "0x593360", VA = "0x10594560")]
    public DrawCardObject()
    {
    }
  }
}

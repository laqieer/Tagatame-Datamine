// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardContent
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
  [Token(Token = "0x20022F6")]
  [AddComponentMenu("UI/DrawCard/DrawCardContent")]
  [FlowNode.Pin(171, "Continued", FlowNode.PinTypes.Output, 171)]
  [FlowNode.Pin(161, "End", FlowNode.PinTypes.Output, 161)]
  [FlowNode.Pin(151, "Next", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(131, "Decided", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(121, "Choice", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(51, "Continue", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(41, "Draw", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(31, "Decide", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(21, "Ready", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "Shuffle", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "Shuffled", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(141, "Win", FlowNode.PinTypes.Output, 141)]
  public class DrawCardContent : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009BD4")]
    private const int INPUT_PIN_INITIALIZE = 1;
    [Token(Token = "0x4009BD5")]
    private const int INPUT_PIN_SHUFFLE = 11;
    [Token(Token = "0x4009BD6")]
    private const int INPUT_PIN_READY = 21;
    [Token(Token = "0x4009BD7")]
    private const int INPUT_PIN_DECIDE = 31;
    [Token(Token = "0x4009BD8")]
    private const int INPUT_PIN_DRAW = 41;
    [Token(Token = "0x4009BD9")]
    private const int INPUT_PIN_CONTINUE = 51;
    [Token(Token = "0x4009BDA")]
    private const int OUTPUT_PIN_INITIALIZED = 101;
    [Token(Token = "0x4009BDB")]
    private const int OUTPUT_PIN_SHUFFLED = 111;
    [Token(Token = "0x4009BDC")]
    private const int OUTPUT_PIN_CHOICE = 121;
    [Token(Token = "0x4009BDD")]
    private const int OUTPUT_PIN_DECIDED = 131;
    [Token(Token = "0x4009BDE")]
    private const int OUTPUT_PIN_WIN = 141;
    [Token(Token = "0x4009BDF")]
    private const int OUTPUT_PIN_NEXT = 151;
    [Token(Token = "0x4009BE0")]
    private const int OUTPUT_PIN_END = 161;
    [Token(Token = "0x4009BE1")]
    private const int OUTPUT_PIN_CONTINUED = 171;
    [Token(Token = "0x4009BE2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private DrawCardObject CardPrefabTemplate;
    [Token(Token = "0x4009BE3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text GetItemText;
    [Token(Token = "0x4009BE4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform VerticalParent;
    [Token(Token = "0x4009BE5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform HorizontalParentTemplate;
    [Token(Token = "0x4009BE6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int HorizontalItemMax;
    [Token(Token = "0x4009BE7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform MagnusPosition;
    [Token(Token = "0x4009BE8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform ShufflePosition;
    [Token(Token = "0x4009BE9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject DrawMaskObject;
    [Token(Token = "0x4009BEA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private DrawCardRewardTable DrawCardRewardTable;
    [Token(Token = "0x4009BEB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private DrawCardObject ResultCardObject;
    [Token(Token = "0x4009BEC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool TapWaitEnable;
    [Token(Token = "0x4009BED")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CustomSound SE_CardDealMove;
    [Token(Token = "0x4009BEE")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private CustomSound SE_CardShuffleMove;
    [Token(Token = "0x4009BEF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CustomSound SE_CardLineUpMove;
    [Token(Token = "0x4009BF0")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private CustomSound SE_CardGetMove;
    [Token(Token = "0x4009BF1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CustomSound SE_CardGetMoveEnd;
    [Token(Token = "0x4009BF2")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private float CardDealMoveSec;
    [Token(Token = "0x4009BF3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float CardDealDelaySec;
    [Token(Token = "0x4009BF4")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private float CardDealEndWaitSec;
    [Token(Token = "0x4009BF5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float CardOpenDelaySec;
    [Token(Token = "0x4009BF6")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private float CardOpenEndWaitSec;
    [Token(Token = "0x4009BF7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private float CardFaceDownDelaySec;
    [Token(Token = "0x4009BF8")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private float CardFaceDownEndWaitSec;
    [Token(Token = "0x4009BF9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float CardShuffleMoveDelaySec;
    [Token(Token = "0x4009BFA")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float CardShuffleMoveSec;
    [Token(Token = "0x4009BFB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private float CardShuffleMoveEndWaitSec;
    [Token(Token = "0x4009BFC")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private float CardLineUpMoveSec;
    [Token(Token = "0x4009BFD")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float CardLineUpDelaySec;
    [Token(Token = "0x4009BFE")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private float CardDrawEndWaitSec;
    [Token(Token = "0x4009BFF")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private float GetItemMoveSec;
    [Token(Token = "0x4009C00")]
    [FieldOffset(Offset = "0x84")]
    private List<Transform> mHolizontalParents;
    [Token(Token = "0x4009C01")]
    [FieldOffset(Offset = "0x88")]
    private List<DrawCardObject> mDrawCardObjects;
    [Token(Token = "0x4009C02")]
    [FieldOffset(Offset = "0x8C")]
    private DrawCardObject mSelectCardObject;
    [Token(Token = "0x4009C03")]
    [FieldOffset(Offset = "0x90")]
    private List<DrawCardRewardParam.Data> mRewardList;

    [Token(Token = "0x6009649")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600964A")]
    [Address(RVA = "0x5904C0", Offset = "0x58F2C0", VA = "0x105904C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600964B")]
    [Address(RVA = "0x5908A0", Offset = "0x58F6A0", VA = "0x105908A0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600964C")]
    [Address(RVA = "0x5905C0", Offset = "0x58F3C0", VA = "0x105905C0")]
    private void Continue()
    {
    }

    [Token(Token = "0x600964D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Ready()
    {
    }

    [Token(Token = "0x600964E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Deal()
    {
    }

    [Token(Token = "0x600964F")]
    [Address(RVA = "0x590EF0", Offset = "0x58FCF0", VA = "0x10590EF0")]
    private void PlaySE(CustomSound se_object)
    {
    }

    [Token(Token = "0x6009650")]
    [Address(RVA = "0x591330", Offset = "0x590130", VA = "0x10591330")]
    private IEnumerator ShuffleCroutine() => (IEnumerator) null;

    [Token(Token = "0x6009651")]
    [Address(RVA = "0x591390", Offset = "0x590190", VA = "0x10591390")]
    public void Shuffle()
    {
    }

    [Token(Token = "0x6009652")]
    [Address(RVA = "0x590F70", Offset = "0x58FD70", VA = "0x10590F70")]
    public void SelectCard(DrawCardObject card)
    {
    }

    [Token(Token = "0x6009653")]
    [Address(RVA = "0x5905E0", Offset = "0x58F3E0", VA = "0x105905E0")]
    private void Decide()
    {
    }

    [Token(Token = "0x6009654")]
    [Address(RVA = "0x5907D0", Offset = "0x58F5D0", VA = "0x105907D0")]
    private IEnumerator DrawCroutine() => (IEnumerator) null;

    [Token(Token = "0x6009655")]
    [Address(RVA = "0x591040", Offset = "0x58FE40", VA = "0x10591040")]
    private void SetDrawItemText(DrawCardParam.CardData card)
    {
    }

    [Token(Token = "0x6009656")]
    [Address(RVA = "0x590830", Offset = "0x58F630", VA = "0x10590830")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009657")]
    [Address(RVA = "0x591400", Offset = "0x590200", VA = "0x10591400")]
    public DrawCardContent()
    {
    }
  }
}

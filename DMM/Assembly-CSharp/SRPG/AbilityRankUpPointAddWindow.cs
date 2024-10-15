// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityRankUpPointAddWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F32")]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/AbilityRankUpPointAddWindow")]
  public class AbilityRankUpPointAddWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400833E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text ConfirmText;
    [Token(Token = "0x400833F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text FreeCoin;
    [Token(Token = "0x4008340")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text PaidCoin;
    [Token(Token = "0x4008341")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text CurrentAmountCoin;
    [Token(Token = "0x4008342")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button CancelButton;
    [Token(Token = "0x4008343")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x4008344")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Slider SelectSlider;
    [Token(Token = "0x4008345")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button PlusButton;
    [Token(Token = "0x4008346")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button MinusButton;
    [Token(Token = "0x4008347")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text SelectTotalNum;
    [Token(Token = "0x4008348")]
    [FieldOffset(Offset = "0x34")]
    public AbilityRankUpPointAddWindow.DecideEvent OnDecide;
    [Token(Token = "0x4008349")]
    [FieldOffset(Offset = "0x38")]
    public AbilityRankUpPointAddWindow.CancelEvent OnCancel;
    [Token(Token = "0x400834A")]
    [FieldOffset(Offset = "0x3C")]
    private GameManager gm;

    [Token(Token = "0x6007FBC")]
    [Address(RVA = "0x404400", Offset = "0x403200", VA = "0x10404400")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FBD")]
    [Address(RVA = "0x403F90", Offset = "0x402D90", VA = "0x10403F90")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6007FBE")]
    [Address(RVA = "0x403BB0", Offset = "0x4029B0", VA = "0x10403BB0")]
    private void OnAdd()
    {
    }

    [Token(Token = "0x6007FBF")]
    [Address(RVA = "0x403C70", Offset = "0x402A70", VA = "0x10403C70")]
    private void OnRemove()
    {
    }

    [Token(Token = "0x6007FC0")]
    [Address(RVA = "0x403B20", Offset = "0x402920", VA = "0x10403B20")]
    private void Cancel()
    {
    }

    [Token(Token = "0x6007FC1")]
    [Address(RVA = "0x403B50", Offset = "0x402950", VA = "0x10403B50")]
    private void Decide()
    {
    }

    [Token(Token = "0x6007FC2")]
    [Address(RVA = "0x403D30", Offset = "0x402B30", VA = "0x10403D30")]
    private void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x6007FC3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007FC4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AbilityRankUpPointAddWindow()
    {
    }

    [Token(Token = "0x2001F33")]
    public delegate void DecideEvent(int value);

    [Token(Token = "0x2001F34")]
    public delegate void CancelEvent();
  }
}

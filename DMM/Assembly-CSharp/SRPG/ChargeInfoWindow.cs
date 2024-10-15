// Decompiled with JetBrains decompiler
// Type: SRPG.ChargeInfoWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200214D")]
  [FlowNode.Pin(0, "ClickBuyCoin", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "ClickResult", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "ToBuyCoin", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "ToResult", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/ChargeInfoWindow")]
  public class ChargeInfoWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400910D")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string SPRITE_SHEET_PATH;
    [Token(Token = "0x400910E")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string CHARGERESULT_PATH;
    [Token(Token = "0x400910F")]
    private const int INPUT_CLICK_BUYCOIN = 0;
    [Token(Token = "0x4009110")]
    private const int INPUT_CLICK_RESULT = 1;
    [Token(Token = "0x4009111")]
    private const int OUTPUT_TO_BUYCOIN = 10;
    [Token(Token = "0x4009112")]
    private const int OUTPUT_TO_RESULT = 11;
    [Token(Token = "0x4009113")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AppealObject;
    [Token(Token = "0x4009114")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject MoveBuyButton;
    [Token(Token = "0x4009115")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject MoveResultButton;
    [Token(Token = "0x4009116")]
    [FieldOffset(Offset = "0x18")]
    private string m_CurrentAppealImg;
    [Token(Token = "0x4009117")]
    [FieldOffset(Offset = "0x1C")]
    private bool m_loaded;
    [Token(Token = "0x4009118")]
    [FieldOffset(Offset = "0x1D")]
    private bool m_Refresh;
    [Token(Token = "0x4009119")]
    [FieldOffset(Offset = "0x20")]
    private Sprite m_CacheAppealSprite;

    [Token(Token = "0x6008BD4")]
    [Address(RVA = "0x4FA640", Offset = "0x4F9440", VA = "0x104FA640", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008BD5")]
    [Address(RVA = "0x4FAA30", Offset = "0x4F9830", VA = "0x104FAA30")]
    private void Start()
    {
    }

    [Token(Token = "0x6008BD6")]
    [Address(RVA = "0x4FAAE0", Offset = "0x4F98E0", VA = "0x104FAAE0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008BD7")]
    [Address(RVA = "0x4FA930", Offset = "0x4F9730", VA = "0x104FA930")]
    public void Setup(string _img_id)
    {
    }

    [Token(Token = "0x6008BD8")]
    [Address(RVA = "0x4FA6D0", Offset = "0x4F94D0", VA = "0x104FA6D0")]
    private IEnumerator CreateResultView() => (IEnumerator) null;

    [Token(Token = "0x6008BD9")]
    [Address(RVA = "0x4FA7B0", Offset = "0x4F95B0", VA = "0x104FA7B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008BDA")]
    [Address(RVA = "0x4FA740", Offset = "0x4F9540", VA = "0x104FA740")]
    private IEnumerator LoadImages(string _path) => (IEnumerator) null;

    [Token(Token = "0x6008BDB")]
    [Address(RVA = "0x4FAB90", Offset = "0x4F9990", VA = "0x104FAB90")]
    public ChargeInfoWindow()
    {
    }

    [Token(Token = "0x6008BDC")]
    [Address(RVA = "0x4FAB10", Offset = "0x4F9910", VA = "0x104FAB10")]
    static ChargeInfoWindow()
    {
    }
  }
}

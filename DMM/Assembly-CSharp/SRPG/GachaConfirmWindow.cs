// Decompiled with JetBrains decompiler
// Type: SRPG.GachaConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002423")]
  [AddComponentMenu("UI/GachaConfirmWindow")]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "BuyCoin", FlowNode.PinTypes.Output, 11)]
  public class GachaConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A39F")]
    [FieldOffset(Offset = "0xC")]
    private readonly string PERIOD_END_TEXT;
    [Token(Token = "0x400A3A0")]
    [FieldOffset(Offset = "0x10")]
    private readonly string PERIOD_TEMP_TEXT;
    [Token(Token = "0x400A3A1")]
    [FieldOffset(Offset = "0x14")]
    private readonly string PERIOD_STARTEND_TEXT;
    [Token(Token = "0x400A3A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text Confirm;
    [Token(Token = "0x400A3A3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text FreeCoin;
    [Token(Token = "0x400A3A4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text PaidCoin;
    [Token(Token = "0x400A3A5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text CurrentAmountCoin;
    [Token(Token = "0x400A3A6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button CancelButton;
    [Token(Token = "0x400A3A7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x400A3A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button BuyCoinButton;
    [Token(Token = "0x400A3A9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject CautionBox;
    [Token(Token = "0x400A3AA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject AmountBox;
    [Token(Token = "0x400A3AB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject AmountTicketBox;
    [Token(Token = "0x400A3AC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text CurrentAmountTicket;
    [Token(Token = "0x400A3AD")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text ConfirmTicket;
    [Token(Token = "0x400A3AE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject CautionRedrawText;
    [Token(Token = "0x400A3AF")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject ConfirmItemObj;
    [Token(Token = "0x400A3B0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text ConfirmItemText;
    [Token(Token = "0x400A3B1")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mPeriodEndText;
    [Token(Token = "0x400A3B2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mPeriodStartEndText;
    [Token(Token = "0x400A3B3")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text mSpecialCommercialCodeText;
    [Token(Token = "0x400A3B4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text mSpecialCommercialCodeText2;
    [Token(Token = "0x400A3B5")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mPeriodBox;
    [Token(Token = "0x400A3B6")]
    [FieldOffset(Offset = "0x68")]
    private string mConfirmText;
    [Token(Token = "0x400A3B7")]
    [FieldOffset(Offset = "0x6C")]
    private int mCost;
    [Token(Token = "0x400A3B8")]
    [FieldOffset(Offset = "0x70")]
    private bool mIsShowCoinStatus;
    [Token(Token = "0x400A3B9")]
    [FieldOffset(Offset = "0x74")]
    private GachaCostType mGachaCostTtype;
    [Token(Token = "0x400A3BA")]
    [FieldOffset(Offset = "0x78")]
    private string mUseTicket;
    [Token(Token = "0x400A3BB")]
    [FieldOffset(Offset = "0x7C")]
    public GachaConfirmWindow.DecideEvent OnDecide;
    [Token(Token = "0x400A3BC")]
    [FieldOffset(Offset = "0x80")]
    public GachaConfirmWindow.CancelEvent OnCancel;
    [Token(Token = "0x400A3BD")]
    [FieldOffset(Offset = "0x84")]
    private GachaRequestParam m_request;
    [Token(Token = "0x400A3BE")]
    [FieldOffset(Offset = "0x88")]
    private Text RedrawText;
    [Token(Token = "0x400A3BF")]
    [FieldOffset(Offset = "0x8C")]
    private GameObject m_Default;
    [Token(Token = "0x400A3C0")]
    [FieldOffset(Offset = "0x90")]
    private GameObject m_Redraw;

    [Token(Token = "0x1700160D")]
    public string ConfirmText
    {
      [Token(Token = "0x6009D8C"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D8D"), Address(RVA = "0x5501B0", Offset = "0x54EFB0", VA = "0x105501B0")] set
      {
      }
    }

    [Token(Token = "0x1700160E")]
    public int Cost
    {
      [Token(Token = "0x6009D8E"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D8F"), Address(RVA = "0x55F7A0", Offset = "0x55E5A0", VA = "0x1055F7A0")] set
      {
      }
    }

    [Token(Token = "0x1700160F")]
    public bool IsShowCoinStatus
    {
      [Token(Token = "0x6009D90"), Address(RVA = "0x5FE310", Offset = "0x5FD110", VA = "0x105FE310")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009D91"), Address(RVA = "0x5FE330", Offset = "0x5FD130", VA = "0x105FE330")] set
      {
      }
    }

    [Token(Token = "0x17001610")]
    public GachaCostType GachaCostType
    {
      [Token(Token = "0x6009D92"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return new GachaCostType();
      }
      [Token(Token = "0x6009D93"), Address(RVA = "0x5FE320", Offset = "0x5FD120", VA = "0x105FE320")] set
      {
      }
    }

    [Token(Token = "0x17001611")]
    public string UseTicket
    {
      [Token(Token = "0x6009D94"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D95"), Address(RVA = "0x550160", Offset = "0x54EF60", VA = "0x10550160")] set
      {
      }
    }

    [Token(Token = "0x6009D96")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009D97")]
    [Address(RVA = "0x5FDBA0", Offset = "0x5FC9A0", VA = "0x105FDBA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009D98")]
    [Address(RVA = "0x5FD1C0", Offset = "0x5FBFC0", VA = "0x105FD1C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009D99")]
    [Address(RVA = "0x5FC650", Offset = "0x5FB450", VA = "0x105FC650")]
    private void ItemRefresh()
    {
    }

    [Token(Token = "0x6009D9A")]
    [Address(RVA = "0x5FCEA0", Offset = "0x5FBCA0", VA = "0x105FCEA0")]
    private void RefreshPeriodUI()
    {
    }

    [Token(Token = "0x6009D9B")]
    [Address(RVA = "0x5FCE70", Offset = "0x5FBC70", VA = "0x105FCE70")]
    private void OnClickDecide()
    {
    }

    [Token(Token = "0x6009D9C")]
    [Address(RVA = "0x5FCE40", Offset = "0x5FBC40", VA = "0x105FCE40")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x6009D9D")]
    [Address(RVA = "0x5FCE10", Offset = "0x5FBC10", VA = "0x105FCE10")]
    private void OnClickBuyCoin()
    {
    }

    [Token(Token = "0x6009D9E")]
    [Address(RVA = "0x5FDB80", Offset = "0x5FC980", VA = "0x105FDB80")]
    public void Set(GachaRequestParam _param)
    {
    }

    [Token(Token = "0x6009D9F")]
    [Address(RVA = "0x5FE240", Offset = "0x5FD040", VA = "0x105FE240")]
    public GachaConfirmWindow()
    {
    }

    [Token(Token = "0x2002424")]
    public delegate void DecideEvent();

    [Token(Token = "0x2002425")]
    public delegate void CancelEvent();
  }
}

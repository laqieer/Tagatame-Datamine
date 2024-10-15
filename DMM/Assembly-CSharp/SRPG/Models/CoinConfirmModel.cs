// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CoinConfirmModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003311")]
  public class CoinConfirmModel
  {
    [Token(Token = "0x400F0BB")]
    [FieldOffset(Offset = "0x8")]
    private string _titleText;
    [Token(Token = "0x400F0BC")]
    [FieldOffset(Offset = "0xC")]
    private string _mainText;
    [Token(Token = "0x400F0BD")]
    [FieldOffset(Offset = "0x10")]
    private string _subText;
    [Token(Token = "0x400F0BE")]
    [FieldOffset(Offset = "0x14")]
    private int _paidCoin;
    [Token(Token = "0x400F0BF")]
    [FieldOffset(Offset = "0x18")]
    private int _freeCoin;
    [Token(Token = "0x400F0C0")]
    [FieldOffset(Offset = "0x1C")]
    private string _yesButtonText;
    [Token(Token = "0x400F0C1")]
    [FieldOffset(Offset = "0x20")]
    private string _noButtonText;
    [Token(Token = "0x400F0C2")]
    [FieldOffset(Offset = "0x24")]
    private bool _isDisplayCoin;
    [Token(Token = "0x400F0C3")]
    [FieldOffset(Offset = "0x28")]
    private string _periodText;
    [Token(Token = "0x400F0C4")]
    [FieldOffset(Offset = "0x2C")]
    private UIUtility.EventListener _okEventListener;
    [Token(Token = "0x400F0C5")]
    [FieldOffset(Offset = "0x30")]
    private UIUtility.EventListener _cancelEventListener;

    [Token(Token = "0x17001D7F")]
    public string Title
    {
      [Token(Token = "0x600E0AF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D80")]
    public string MainText
    {
      [Token(Token = "0x600E0B0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D81")]
    public string SubText
    {
      [Token(Token = "0x600E0B1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D82")]
    public int PaidCoin
    {
      [Token(Token = "0x600E0B2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D83")]
    public int FreeCoin
    {
      [Token(Token = "0x600E0B3"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D84")]
    public string YesBtnText
    {
      [Token(Token = "0x600E0B4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D85")]
    public string NoBtnText
    {
      [Token(Token = "0x600E0B5"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D86")]
    public bool IsDisplayCoin
    {
      [Token(Token = "0x600E0B6"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D87")]
    public string PeriodText
    {
      [Token(Token = "0x600E0B7"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D88")]
    public UIUtility.EventListener OkEvent
    {
      [Token(Token = "0x600E0B8"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (UIUtility.EventListener) null;
      }
    }

    [Token(Token = "0x17001D89")]
    public UIUtility.EventListener CancelEvent
    {
      [Token(Token = "0x600E0B9"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (UIUtility.EventListener) null;
      }
    }

    [Token(Token = "0x600E0BA")]
    [Address(RVA = "0xAAAA50", Offset = "0xAA9850", VA = "0x10AAAA50")]
    public void Initialize(
      string title,
      string main,
      string sub,
      UIUtility.EventListener okEventListener,
      UIUtility.EventListener cancelEventListener,
      string yesText,
      string noText,
      bool isDisplayCoin,
      string period)
    {
    }

    [Token(Token = "0x600E0BB")]
    [Address(RVA = "0xAAABE0", Offset = "0xAA99E0", VA = "0x10AAABE0")]
    public bool IsSubText() => new bool();

    [Token(Token = "0x600E0BC")]
    [Address(RVA = "0x3A8970", Offset = "0x3A7770", VA = "0x103A8970")]
    public bool IsPeriodText() => new bool();

    [Token(Token = "0x600E0BD")]
    [Address(RVA = "0xAAABC0", Offset = "0xAA99C0", VA = "0x10AAABC0")]
    public bool IsCautionDisplay() => new bool();

    [Token(Token = "0x600E0BE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinConfirmModel()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ExpansionPurchaseConfirmModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200337C")]
  public class ExpansionPurchaseConfirmModel
  {
    [Token(Token = "0x400F38E")]
    [FieldOffset(Offset = "0x8")]
    private string _titleText;
    [Token(Token = "0x400F38F")]
    [FieldOffset(Offset = "0xC")]
    private string _mainText;
    [Token(Token = "0x400F390")]
    [FieldOffset(Offset = "0x10")]
    private string _yesButtonText;
    [Token(Token = "0x400F391")]
    [FieldOffset(Offset = "0x14")]
    private string _noButtonText;
    [Token(Token = "0x400F392")]
    [FieldOffset(Offset = "0x18")]
    private string _priceText;
    [Token(Token = "0x400F393")]
    [FieldOffset(Offset = "0x1C")]
    private string _periodText;
    [Token(Token = "0x400F394")]
    [FieldOffset(Offset = "0x20")]
    private UIUtility.EventListener _okEventListener;
    [Token(Token = "0x400F395")]
    [FieldOffset(Offset = "0x24")]
    private UIUtility.EventListener _cancelEventlistener;

    [Token(Token = "0x17001F89")]
    public string Title
    {
      [Token(Token = "0x600E4E9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F8A")]
    public string MainText
    {
      [Token(Token = "0x600E4EA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F8B")]
    public string YesBtnText
    {
      [Token(Token = "0x600E4EB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F8C")]
    public string NoBtnText
    {
      [Token(Token = "0x600E4EC"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F8D")]
    public string Period
    {
      [Token(Token = "0x600E4ED"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F8E")]
    public bool IsPeriodEmpty
    {
      [Token(Token = "0x600E4EE"), Address(RVA = "0xAB3D70", Offset = "0xAB2B70", VA = "0x10AB3D70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F8F")]
    public string Price
    {
      [Token(Token = "0x600E4EF"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F90")]
    public UIUtility.EventListener OkEvent
    {
      [Token(Token = "0x600E4F0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (UIUtility.EventListener) null;
      }
    }

    [Token(Token = "0x17001F91")]
    public UIUtility.EventListener CancelEvent
    {
      [Token(Token = "0x600E4F1"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (UIUtility.EventListener) null;
      }
    }

    [Token(Token = "0x600E4F2")]
    [Address(RVA = "0xAB3CE0", Offset = "0xAB2AE0", VA = "0x10AB3CE0")]
    public void Initialize(
      string title,
      string main,
      UIUtility.EventListener okEventListener,
      UIUtility.EventListener cancelEventListener,
      string yesText,
      string noText,
      string period,
      string price)
    {
    }

    [Token(Token = "0x600E4F3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseConfirmModel()
    {
    }
  }
}

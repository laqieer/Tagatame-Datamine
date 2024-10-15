// Decompiled with JetBrains decompiler
// Type: SRPG.PaymentInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001048")]
  public class PaymentInfo
  {
    [Token(Token = "0x4003A1A")]
    [FieldOffset(Offset = "0x8")]
    public string productId;
    [Token(Token = "0x4003A1B")]
    [FieldOffset(Offset = "0x10")]
    public long at;
    [Token(Token = "0x4003A1C")]
    [FieldOffset(Offset = "0x18")]
    private int _numMonghly;

    [Token(Token = "0x17000625")]
    public int numMonthly
    {
      [Token(Token = "0x60042D2"), Address(RVA = "0x11DFD30", Offset = "0x11DEB30", VA = "0x111DFD30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60042D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PaymentInfo()
    {
    }

    [Token(Token = "0x60042D4")]
    [Address(RVA = "0x11DFCC0", Offset = "0x11DEAC0", VA = "0x111DFCC0")]
    public PaymentInfo(string productId_, int numMonthly_)
    {
    }

    [Token(Token = "0x60042D5")]
    [Address(RVA = "0x11DFB20", Offset = "0x11DE920", VA = "0x111DFB20")]
    public void AddNum(int num = 1)
    {
    }

    [Token(Token = "0x60042D6")]
    [Address(RVA = "0x11DFC80", Offset = "0x11DEA80", VA = "0x111DFC80")]
    public bool Deserialize(Json_PaymentInfo json) => new bool();
  }
}

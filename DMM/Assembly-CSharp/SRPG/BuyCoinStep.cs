// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinStep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002114")]
  public class BuyCoinStep
  {
    [Token(Token = "0x170013A5")]
    public string Id
    {
      [Token(Token = "0x6008A88"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A89"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x170013A6")]
    public string ProductId
    {
      [Token(Token = "0x6008A8A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A8B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x170013A7")]
    public int Step
    {
      [Token(Token = "0x6008A8C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A8D"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170013A8")]
    public int Loop
    {
      [Token(Token = "0x6008A8E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A8F"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x170013A9")]
    public bool Soldout
    {
      [Token(Token = "0x6008A90"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008A91"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] private set
      {
      }
    }

    [Token(Token = "0x6008A92")]
    [Address(RVA = "0x4E4C90", Offset = "0x4E3A90", VA = "0x104E4C90")]
    public void Deserialize(Json_BuyCoinSteps json)
    {
    }

    [Token(Token = "0x6008A93")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinStep()
    {
    }
  }
}

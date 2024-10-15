// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustPurchaseVerificationInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036DF")]
  public class AdjustPurchaseVerificationInfo
  {
    [Token(Token = "0x170023D0")]
    public int code
    {
      [Token(Token = "0x600F915"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F916"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
      {
      }
    }

    [Token(Token = "0x170023D1")]
    public string message
    {
      [Token(Token = "0x600F917"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F918"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170023D2")]
    public string verificationStatus
    {
      [Token(Token = "0x600F919"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F91A"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x600F91B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustPurchaseVerificationInfo()
    {
    }

    [Token(Token = "0x600F91C")]
    [Address(RVA = "0xB68000", Offset = "0xB66E00", VA = "0x10B68000")]
    public AdjustPurchaseVerificationInfo(string jsonString)
    {
    }
  }
}

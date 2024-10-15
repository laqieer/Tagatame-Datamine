// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustSessionSuccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036E1")]
  public class AdjustSessionSuccess
  {
    [Token(Token = "0x170023D8")]
    public string Adid
    {
      [Token(Token = "0x600F92C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F92D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170023D9")]
    public string Message
    {
      [Token(Token = "0x600F92E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F92F"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170023DA")]
    public string Timestamp
    {
      [Token(Token = "0x600F930"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F931"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170023DB")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x600F932"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x600F933"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x600F934")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustSessionSuccess()
    {
    }

    [Token(Token = "0x600F935")]
    [Address(RVA = "0xB68AE0", Offset = "0xB678E0", VA = "0x10B68AE0")]
    public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap)
    {
    }

    [Token(Token = "0x600F936")]
    [Address(RVA = "0xB68E70", Offset = "0xB67C70", VA = "0x10B68E70")]
    public AdjustSessionSuccess(string jsonString)
    {
    }

    [Token(Token = "0x600F937")]
    [Address(RVA = "0xB68980", Offset = "0xB67780", VA = "0x10B68980")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x600F938")]
    [Address(RVA = "0xB68A90", Offset = "0xB67890", VA = "0x10B68A90")]
    public string GetJsonResponse() => (string) null;
  }
}

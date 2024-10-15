// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustSessionFailure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036E0")]
  public class AdjustSessionFailure
  {
    [Token(Token = "0x170023D3")]
    public string Adid
    {
      [Token(Token = "0x600F91D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F91E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170023D4")]
    public string Message
    {
      [Token(Token = "0x600F91F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F920"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170023D5")]
    public string Timestamp
    {
      [Token(Token = "0x600F921"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F922"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170023D6")]
    public bool WillRetry
    {
      [Token(Token = "0x600F923"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F924"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] set
      {
      }
    }

    [Token(Token = "0x170023D7")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x600F925"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x600F926"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x600F927")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustSessionFailure()
    {
    }

    [Token(Token = "0x600F928")]
    [Address(RVA = "0xB68260", Offset = "0xB67060", VA = "0x10B68260")]
    public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap)
    {
    }

    [Token(Token = "0x600F929")]
    [Address(RVA = "0xB686C0", Offset = "0xB674C0", VA = "0x10B686C0")]
    public AdjustSessionFailure(string jsonString)
    {
    }

    [Token(Token = "0x600F92A")]
    [Address(RVA = "0xB68100", Offset = "0xB66F00", VA = "0x10B68100")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x600F92B")]
    [Address(RVA = "0xB68210", Offset = "0xB67010", VA = "0x10B68210")]
    public string GetJsonResponse() => (string) null;
  }
}

// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Json.Document
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.DOM.Json
{
  [Token(Token = "0x20035BE")]
  public class Document : IDocument, IDisposable
  {
    [Token(Token = "0x400FDCB")]
    [FieldOffset(Offset = "0x8")]
    private Value root;

    [Token(Token = "0x600EEB4")]
    [Address(RVA = "0xB05970", Offset = "0xB04770", VA = "0x10B05970")]
    public static Document Parse(byte[] bytes) => (Document) null;

    [Token(Token = "0x600EEB5")]
    [Address(RVA = "0xB05810", Offset = "0xB04610", VA = "0x10B05810")]
    public static Document Parse(string text) => (Document) null;

    [Token(Token = "0x600EEB6")]
    [Address(RVA = "0xB057F0", Offset = "0xB045F0", VA = "0x10B057F0")]
    public static Document ParseFromFile(string filepath) => (Document) null;

    [Token(Token = "0x600EEB7")]
    [Address(RVA = "0xB059B0", Offset = "0xB047B0", VA = "0x10B059B0")]
    public void SetRoot(Value root)
    {
    }

    [Token(Token = "0x17002219")]
    public Value Root
    {
      [Token(Token = "0x600EEB8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x1700221A")]
    private IValue Gsc\u002EDOM\u002EIDocument\u002ERoot
    {
      [Token(Token = "0x600EEB9"), Address(RVA = "0xB05760", Offset = "0xB04560", VA = "0x10B05760", Slot = "4")] get
      {
        return (IValue) null;
      }
    }

    [Token(Token = "0x600EEBA")]
    [Address(RVA = "0xB05A10", Offset = "0xB04810", VA = "0x10B05A10")]
    public Document(Document document, ref Value root)
    {
    }

    [Token(Token = "0x600EEBB")]
    [Address(RVA = "0xB059D0", Offset = "0xB047D0", VA = "0x10B059D0")]
    private Document(object node)
    {
    }

    [Token(Token = "0x600EEBC")]
    [Address(RVA = "0xB056E0", Offset = "0xB044E0", VA = "0x10B056E0", Slot = "1")]
    ~Document()
    {
    }

    [Token(Token = "0x600EEBD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Dispose()
    {
    }
  }
}

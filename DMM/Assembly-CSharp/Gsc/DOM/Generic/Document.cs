// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Generic.Document
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.DOM.Generic
{
  [Token(Token = "0x20035D0")]
  public class Document : IDocument, IDisposable
  {
    [Token(Token = "0x400FDEE")]
    [FieldOffset(Offset = "0x8")]
    private readonly Value root;

    [Token(Token = "0x17002237")]
    public Value Root
    {
      [Token(Token = "0x600EF50"), Address(RVA = "0xB05A70", Offset = "0xB04870", VA = "0x10B05A70")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x17002238")]
    private IValue Gsc\u002EDOM\u002EIDocument\u002ERoot
    {
      [Token(Token = "0x600EF51"), Address(RVA = "0xB057A0", Offset = "0xB045A0", VA = "0x10B057A0", Slot = "4")] get
      {
        return (IValue) null;
      }
    }

    [Token(Token = "0x600EF52")]
    [Address(RVA = "0xB05A40", Offset = "0xB04840", VA = "0x10B05A40")]
    public Document(Document document, ref Value root)
    {
    }

    [Token(Token = "0x600EF53")]
    [Address(RVA = "0xB056E0", Offset = "0xB044E0", VA = "0x10B056E0", Slot = "1")]
    ~Document()
    {
    }

    [Token(Token = "0x600EF54")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Dispose()
    {
    }
  }
}

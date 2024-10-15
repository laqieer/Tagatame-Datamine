// Decompiled with JetBrains decompiler
// Type: rapidjson.Document
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace rapidjson
{
  [Token(Token = "0x2003513")]
  public class Document : IDisposable
  {
    [Token(Token = "0x400FBFF")]
    [FieldOffset(Offset = "0x8")]
    private IntPtr ptr;
    [Token(Token = "0x400FC00")]
    [FieldOffset(Offset = "0xC")]
    private bool disposed;
    [Token(Token = "0x400FC01")]
    [FieldOffset(Offset = "0x10")]
    public readonly Value Root;

    [Token(Token = "0x600EA8E")]
    [Address(RVA = "0xAE8CB0", Offset = "0xAE7AB0", VA = "0x10AE8CB0")]
    public static Document Parse(byte[] bytes) => (Document) null;

    [Token(Token = "0x600EA8F")]
    [Address(RVA = "0xAE8DE0", Offset = "0xAE7BE0", VA = "0x10AE8DE0")]
    public static Document Parse(string text) => (Document) null;

    [Token(Token = "0x600EA90")]
    [Address(RVA = "0xAE8B70", Offset = "0xAE7970", VA = "0x10AE8B70")]
    public static Document ParseFromFile(string filepath) => (Document) null;

    [Token(Token = "0x600EA91")]
    [Address(RVA = "0xAE8F20", Offset = "0xAE7D20", VA = "0x10AE8F20")]
    private Document(IntPtr ptr)
    {
    }

    [Token(Token = "0x600EA92")]
    [Address(RVA = "0xAE8A50", Offset = "0xAE7850", VA = "0x10AE8A50", Slot = "1")]
    ~Document()
    {
    }

    [Token(Token = "0x600EA93")]
    [Address(RVA = "0xAE89B0", Offset = "0xAE77B0", VA = "0x10AE89B0", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600EA94")]
    [Address(RVA = "0xAE8960", Offset = "0xAE7760", VA = "0x10AE8960")]
    public void CheckDisposed()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MessagePack.TinyJsonReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;
using System.Text;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000355")]
  internal class TinyJsonReader : IDisposable
  {
    [Token(Token = "0x4000D46")]
    [FieldOffset(Offset = "0x8")]
    private readonly TextReader reader;
    [Token(Token = "0x4000D47")]
    [FieldOffset(Offset = "0xC")]
    private readonly bool disposeInnerReader;
    [Token(Token = "0x4000D48")]
    [FieldOffset(Offset = "0x10")]
    private StringBuilder reusableBuilder;

    [Token(Token = "0x170001FA")]
    public TinyJsonToken TokenType
    {
      [Token(Token = "0x6001194"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new TinyJsonToken();
      }
      [Token(Token = "0x6001195"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x170001FB")]
    public ValueType ValueType
    {
      [Token(Token = "0x6001196"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new ValueType();
      }
      [Token(Token = "0x6001197"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] private set
      {
      }
    }

    [Token(Token = "0x170001FC")]
    public double DoubleValue
    {
      [Token(Token = "0x6001198"), Address(RVA = "0x3057B0", Offset = "0x3045B0", VA = "0x103057B0")] get
      {
        return new double();
      }
      [Token(Token = "0x6001199"), Address(RVA = "0x305800", Offset = "0x304600", VA = "0x10305800")] private set
      {
      }
    }

    [Token(Token = "0x170001FD")]
    public long LongValue
    {
      [Token(Token = "0x600119A"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
      [Token(Token = "0x600119B"), Address(RVA = "0x305820", Offset = "0x304620", VA = "0x10305820")] private set
      {
      }
    }

    [Token(Token = "0x170001FE")]
    public ulong ULongValue
    {
      [Token(Token = "0x600119C"), Address(RVA = "0x3057D0", Offset = "0x3045D0", VA = "0x103057D0")] get
      {
        return new ulong();
      }
      [Token(Token = "0x600119D"), Address(RVA = "0x305850", Offset = "0x304650", VA = "0x10305850")] private set
      {
      }
    }

    [Token(Token = "0x170001FF")]
    public Decimal DecimalValue
    {
      [Token(Token = "0x600119E"), Address(RVA = "0x305790", Offset = "0x304590", VA = "0x10305790")] get
      {
        return 0M;
      }
      [Token(Token = "0x600119F"), Address(RVA = "0x3057F0", Offset = "0x3045F0", VA = "0x103057F0")] private set
      {
      }
    }

    [Token(Token = "0x17000200")]
    public string StringValue
    {
      [Token(Token = "0x60011A0"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60011A1"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] private set
      {
      }
    }

    [Token(Token = "0x60011A2")]
    [Address(RVA = "0x305760", Offset = "0x304560", VA = "0x10305760")]
    public TinyJsonReader(TextReader reader, bool disposeInnerReader = true)
    {
    }

    [Token(Token = "0x60011A3")]
    [Address(RVA = "0x305670", Offset = "0x304470", VA = "0x10305670")]
    public bool Read() => new bool();

    [Token(Token = "0x60011A4")]
    [Address(RVA = "0x304A30", Offset = "0x303830", VA = "0x10304A30", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60011A5")]
    [Address(RVA = "0x3056A0", Offset = "0x3044A0", VA = "0x103056A0")]
    private void SkipWhiteSpace()
    {
    }

    [Token(Token = "0x60011A6")]
    [Address(RVA = "0x304AC0", Offset = "0x3038C0", VA = "0x10304AC0")]
    private char ReadChar() => new char();

    [Token(Token = "0x60011A7")]
    [Address(RVA = "0x304A60", Offset = "0x303860", VA = "0x10304A60")]
    private static bool IsWordBreak(char c) => new bool();

    [Token(Token = "0x60011A8")]
    [Address(RVA = "0x304AF0", Offset = "0x3038F0", VA = "0x10304AF0")]
    private void ReadNextToken()
    {
    }

    [Token(Token = "0x60011A9")]
    [Address(RVA = "0x3053E0", Offset = "0x3041E0", VA = "0x103053E0")]
    private void ReadValue()
    {
    }

    [Token(Token = "0x60011AA")]
    [Address(RVA = "0x304D70", Offset = "0x303B70", VA = "0x10304D70")]
    private void ReadNumber()
    {
    }

    [Token(Token = "0x60011AB")]
    [Address(RVA = "0x305050", Offset = "0x303E50", VA = "0x10305050")]
    private void ReadString()
    {
    }
  }
}

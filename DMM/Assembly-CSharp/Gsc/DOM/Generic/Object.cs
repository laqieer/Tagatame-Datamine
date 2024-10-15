// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Generic.Object
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM.Generic
{
  [Token(Token = "0x20035D2")]
  public class Object : IObject, IEnumerable<IMember>, IEnumerable, IEnumerable<Member>
  {
    [Token(Token = "0x400FDF1")]
    [FieldOffset(Offset = "0x8")]
    private readonly List<Member> members;

    [Token(Token = "0x1700223C")]
    public int MemberCount
    {
      [Token(Token = "0x600EF59"), Address(RVA = "0xB0DAA0", Offset = "0xB0C8A0", VA = "0x10B0DAA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EF5A")]
    [Address(RVA = "0xB0D970", Offset = "0xB0C770", VA = "0x10B0D970")]
    public Object()
    {
    }

    [Token(Token = "0x600EF5B")]
    [Address(RVA = "0xB0D6A0", Offset = "0xB0C4A0", VA = "0x10B0D6A0")]
    private int IndexOf(string name) => new int();

    [Token(Token = "0x600EF5C")]
    [Address(RVA = "0xB0D680", Offset = "0xB0C480", VA = "0x10B0D680", Slot = "5")]
    public bool HasMember(string name) => new bool();

    [Token(Token = "0x600EF5D")]
    [Address(RVA = "0xB0D8D0", Offset = "0xB0C6D0", VA = "0x10B0D8D0")]
    public bool TryGetValue(string name, out Value value) => new bool();

    [Token(Token = "0x600EF5E")]
    [Address(RVA = "0xB0D3A0", Offset = "0xB0C1A0", VA = "0x10B0D3A0", Slot = "6")]
    private bool Gsc\u002EDOM\u002EIObject\u002ETryGetValue(string name, out IValue value)
    {
      return new bool();
    }

    [Token(Token = "0x600EF5F")]
    [Address(RVA = "0xB0D2C0", Offset = "0xB0C0C0", VA = "0x10B0D2C0", Slot = "10")]
    public IEnumerator<Member> GetEnumerator() => (IEnumerator<Member>) null;

    [Token(Token = "0x600EF60")]
    [Address(RVA = "0xB0D760", Offset = "0xB0C560", VA = "0x10B0D760", Slot = "8")]
    private IEnumerator<IMember> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CGsc\u002EDOM\u002EIMember\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<IMember>) null;
    }

    [Token(Token = "0x600EF61")]
    [Address(RVA = "0xB0D2C0", Offset = "0xB0C0C0", VA = "0x10B0D2C0", Slot = "9")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600EF62")]
    [Address(RVA = "0xB0D1E0", Offset = "0xB0BFE0", VA = "0x10B0D1E0")]
    public void Add(string name, Value value)
    {
    }

    [Token(Token = "0x1700223D")]
    public Value this[string name]
    {
      [Token(Token = "0x600EF63"), Address(RVA = "0xB0D9E0", Offset = "0xB0C7E0", VA = "0x10B0D9E0")] get
      {
        return new Value();
      }
      [Token(Token = "0x600EF64"), Address(RVA = "0xB0DB30", Offset = "0xB0C930", VA = "0x10B0DB30")] set
      {
      }
    }

    [Token(Token = "0x600EF65")]
    [Address(RVA = "0xB0D540", Offset = "0xB0C340", VA = "0x10B0D540", Slot = "7")]
    private IValue Gsc\u002EDOM\u002EIObject\u002Eget_Item(string name) => (IValue) null;
  }
}

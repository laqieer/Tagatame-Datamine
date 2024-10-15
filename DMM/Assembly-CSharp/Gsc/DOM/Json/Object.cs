// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Json.Object
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM.Json
{
  [Token(Token = "0x20035C5")]
  public struct Object : IObject, IEnumerable<IMember>, IEnumerable, IEnumerable<Member>
  {
    [Token(Token = "0x400FDD3")]
    [FieldOffset(Offset = "0x0")]
    private readonly IDictionary<string, object> value;

    [Token(Token = "0x17002222")]
    public int MemberCount
    {
      [Token(Token = "0x600EEFD"), Address(RVA = "0xB0DAE0", Offset = "0xB0C8E0", VA = "0x10B0DAE0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EEFE")]
    [Address(RVA = "0xB01110", Offset = "0xAFFF10", VA = "0x10B01110")]
    public Object(IDictionary<string, object> value)
    {
    }

    [Token(Token = "0x600EEFF")]
    [Address(RVA = "0xB0D5E0", Offset = "0xB0C3E0", VA = "0x10B0D5E0", Slot = "5")]
    public bool HasMember(string name) => new bool();

    [Token(Token = "0x600EF00")]
    [Address(RVA = "0xB0D850", Offset = "0xB0C650", VA = "0x10B0D850")]
    public bool TryGetValue(string name, out Value value) => new bool();

    [Token(Token = "0x600EF01")]
    [Address(RVA = "0xB0D410", Offset = "0xB0C210", VA = "0x10B0D410", Slot = "6")]
    private bool Gsc\u002EDOM\u002EIObject\u002ETryGetValue(string name, out IValue value)
    {
      return new bool();
    }

    [Token(Token = "0x600EF02")]
    [Address(RVA = "0xB0D330", Offset = "0xB0C130", VA = "0x10B0D330", Slot = "10")]
    public IEnumerator<Member> GetEnumerator() => (IEnumerator<Member>) null;

    [Token(Token = "0x600EF03")]
    [Address(RVA = "0xB0D7D0", Offset = "0xB0C5D0", VA = "0x10B0D7D0", Slot = "8")]
    private IEnumerator<IMember> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CGsc\u002EDOM\u002EIMember\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<IMember>) null;
    }

    [Token(Token = "0x600EF04")]
    [Address(RVA = "0xB0D840", Offset = "0xB0C640", VA = "0x10B0D840", Slot = "9")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17002223")]
    public Value this[string name]
    {
      [Token(Token = "0x600EF05"), Address(RVA = "0xB0DA40", Offset = "0xB0C840", VA = "0x10B0DA40")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EF06")]
    [Address(RVA = "0xB0D4B0", Offset = "0xB0C2B0", VA = "0x10B0D4B0", Slot = "7")]
    private IValue Gsc\u002EDOM\u002EIObject\u002Eget_Item(string name) => (IValue) null;
  }
}

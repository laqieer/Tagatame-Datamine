// Decompiled with JetBrains decompiler
// Type: rapidjson.Object
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace rapidjson
{
  [Token(Token = "0x2003517")]
  public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable
  {
    [Token(Token = "0x400FC0D")]
    [FieldOffset(Offset = "0x8")]
    private IntPtr root;
    [Token(Token = "0x400FC0E")]
    [FieldOffset(Offset = "0xC")]
    private readonly Document doc;
    [Token(Token = "0x400FC0F")]
    [FieldOffset(Offset = "0x10")]
    private readonly uint size;

    [Token(Token = "0x17002177")]
    public int MemberCount
    {
      [Token(Token = "0x600EACA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EACB")]
    [Address(RVA = "0xAEC550", Offset = "0xAEB350", VA = "0x10AEC550")]
    public Object(Document doc, ref IntPtr ptr)
    {
    }

    [Token(Token = "0x600EACC")]
    [Address(RVA = "0xAEC360", Offset = "0xAEB160", VA = "0x10AEC360", Slot = "4")]
    public IEnumerator<KeyValuePair<string, Value>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, Value>>) null;
    }

    [Token(Token = "0x600EACD")]
    [Address(RVA = "0xAEC360", Offset = "0xAEB160", VA = "0x10AEC360", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17002178")]
    public Value this[string name]
    {
      [Token(Token = "0x600EACE"), Address(RVA = "0xAEC680", Offset = "0xAEB480", VA = "0x10AEC680")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EACF")]
    [Address(RVA = "0xAEC470", Offset = "0xAEB270", VA = "0x10AEC470")]
    public bool TryGetValue(string name, out Value value) => new bool();

    [Token(Token = "0x600EAD0")]
    [Address(RVA = "0xAEC3D0", Offset = "0xAEB1D0", VA = "0x10AEC3D0")]
    public bool HasMember(string name) => new bool();
  }
}

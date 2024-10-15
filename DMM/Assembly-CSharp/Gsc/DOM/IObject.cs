// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.IObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM
{
  [Token(Token = "0x20035BA")]
  public interface IObject : IEnumerable<IMember>, IEnumerable
  {
    [Token(Token = "0x17002215")]
    int MemberCount { [Token(Token = "0x600EEAB")] get; }

    [Token(Token = "0x600EEAC")]
    bool HasMember(string name);

    [Token(Token = "0x600EEAD")]
    bool TryGetValue(string name, out IValue value);

    [Token(Token = "0x17002216")]
    IValue this[string name] { [Token(Token = "0x600EEAE")] get; }
  }
}

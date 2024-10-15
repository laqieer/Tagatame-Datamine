// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.IArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM
{
  [Token(Token = "0x20035BB")]
  public interface IArray : IEnumerable<IValue>, IEnumerable
  {
    [Token(Token = "0x17002217")]
    int Length { [Token(Token = "0x600EEAF")] get; }

    [Token(Token = "0x17002218")]
    IValue this[int index] { [Token(Token = "0x600EEB0")] get; }
  }
}

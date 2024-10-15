// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Json.Member
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.DOM.Json
{
  [Token(Token = "0x20035C4")]
  public struct Member : IMember
  {
    [Token(Token = "0x400FDD1")]
    [FieldOffset(Offset = "0x0")]
    private readonly string name;
    [Token(Token = "0x400FDD2")]
    [FieldOffset(Offset = "0x4")]
    private readonly Value value;

    [Token(Token = "0x1700221F")]
    public string Name
    {
      [Token(Token = "0x600EEF9"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002220")]
    public Value Value
    {
      [Token(Token = "0x600EEFA"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x17002221")]
    private IValue Gsc\u002EDOM\u002EIMember\u002EValue
    {
      [Token(Token = "0x600EEFB"), Address(RVA = "0xB0CB00", Offset = "0xB0B900", VA = "0x10B0CB00", Slot = "5")] get
      {
        return (IValue) null;
      }
    }

    [Token(Token = "0x600EEFC")]
    [Address(RVA = "0xB0CB40", Offset = "0xB0B940", VA = "0x10B0CB40")]
    public Member(string name, Value value)
    {
    }
  }
}

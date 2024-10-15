// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Generic.Member
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.DOM.Generic
{
  [Token(Token = "0x20035D1")]
  public struct Member : IMember
  {
    [Token(Token = "0x400FDEF")]
    [FieldOffset(Offset = "0x0")]
    private readonly string name;
    [Token(Token = "0x400FDF0")]
    [FieldOffset(Offset = "0x8")]
    private readonly Value value;

    [Token(Token = "0x17002239")]
    public string Name
    {
      [Token(Token = "0x600EF55"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700223A")]
    public Value Value
    {
      [Token(Token = "0x600EF56"), Address(RVA = "0xB05A70", Offset = "0xB04870", VA = "0x10B05A70")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x1700223B")]
    private IValue Gsc\u002EDOM\u002EIMember\u002EValue
    {
      [Token(Token = "0x600EF57"), Address(RVA = "0xB0CAB0", Offset = "0xB0B8B0", VA = "0x10B0CAB0", Slot = "5")] get
      {
        return (IValue) null;
      }
    }

    [Token(Token = "0x600EF58")]
    [Address(RVA = "0xB0CB70", Offset = "0xB0B970", VA = "0x10B0CB70")]
    public Member(string name, Value value)
    {
    }
  }
}

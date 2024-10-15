// Decompiled with JetBrains decompiler
// Type: SRPG.State`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F22")]
  public class State<T>
  {
    [Token(Token = "0x400830B")]
    [FieldOffset(Offset = "0x0")]
    public T self;

    [Token(Token = "0x6007F5E")]
    public virtual void Begin(T self)
    {
    }

    [Token(Token = "0x6007F5F")]
    public virtual void Update(T self)
    {
    }

    [Token(Token = "0x6007F60")]
    public virtual void End(T self)
    {
    }

    [Token(Token = "0x6007F61")]
    public virtual void Command(T self, string cmd)
    {
    }

    [Token(Token = "0x6007F62")]
    public State()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.StateMachine`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F23")]
  public class StateMachine<T>
  {
    [Token(Token = "0x400830C")]
    [FieldOffset(Offset = "0x0")]
    private T mOwner;
    [Token(Token = "0x400830D")]
    [FieldOffset(Offset = "0x0")]
    private SRPG.State<T> mState;

    [Token(Token = "0x17001248")]
    public SRPG.State<T> State
    {
      [Token(Token = "0x6007F63")] get => (SRPG.State<T>) null;
    }

    [Token(Token = "0x17001249")]
    public string StateName
    {
      [Token(Token = "0x6007F64")] get => (string) null;
    }

    [Token(Token = "0x1700124A")]
    public System.Type CurrentState
    {
      [Token(Token = "0x6007F65")] get => (System.Type) null;
    }

    [Token(Token = "0x6007F66")]
    public StateMachine(T owner)
    {
    }

    [Token(Token = "0x6007F67")]
    public void Update()
    {
    }

    [Token(Token = "0x6007F68")]
    public void GotoState(System.Type stateType)
    {
    }

    [Token(Token = "0x6007F69")]
    public void GotoState<StateType>() where StateType : SRPG.State<T>, new()
    {
    }

    [Token(Token = "0x6007F6A")]
    public bool IsInState<StateType>() where StateType : SRPG.State<T> => new bool();

    [Token(Token = "0x6007F6B")]
    public bool IsInKindOfState<StateType>() where StateType : SRPG.State<T> => new bool();

    [Token(Token = "0x6007F6C")]
    public void Command(string cmd)
    {
    }
  }
}

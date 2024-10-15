// Decompiled with JetBrains decompiler
// Type: SRPG.BaseObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D7B")]
  public abstract class BaseObject
  {
    [Token(Token = "0x400E2FE")]
    [FieldOffset(Offset = "0x8")]
    private bool mInitialized;
    [Token(Token = "0x400E2FF")]
    [FieldOffset(Offset = "0x9")]
    private bool mPaused;

    [Token(Token = "0x17001BBF")]
    public bool IsInitialized
    {
      [Token(Token = "0x600D41D"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
      {
      }
      [Token(Token = "0x600D41E"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BC0")]
    public bool IsPaused
    {
      [Token(Token = "0x600D41F"), Address(RVA = "0x3FA400", Offset = "0x3F9200", VA = "0x103FA400")] set
      {
      }
      [Token(Token = "0x600D420"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D421")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")]
    public virtual bool Load() => new bool();

    [Token(Token = "0x600D422")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x600D423")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x600D424")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    protected BaseObject()
    {
    }
  }
}

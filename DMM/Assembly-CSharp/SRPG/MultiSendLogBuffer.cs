// Decompiled with JetBrains decompiler
// Type: SRPG.MultiSendLogBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D88")]
  public class MultiSendLogBuffer
  {
    [Token(Token = "0x4002676")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int BUFFER_DIGIT;
    [Token(Token = "0x4002677")]
    [FieldOffset(Offset = "0x8")]
    private readonly int CAPACITY;
    [Token(Token = "0x4002678")]
    [FieldOffset(Offset = "0xC")]
    private readonly int MASK;
    [Token(Token = "0x4002679")]
    [FieldOffset(Offset = "0x10")]
    private SceneBattle.MultiPlayRecvData[] mData;
    [Token(Token = "0x400267A")]
    [FieldOffset(Offset = "0x14")]
    private int mTop;
    [Token(Token = "0x400267B")]
    [FieldOffset(Offset = "0x18")]
    private int mBottom;
    [Token(Token = "0x400267C")]
    [FieldOffset(Offset = "0x1C")]
    private int mCount;

    [Token(Token = "0x170003BE")]
    public bool isEmpty
    {
      [Token(Token = "0x600371A"), Address(RVA = "0x37ACE0", Offset = "0x379AE0", VA = "0x1037ACE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003BF")]
    public int Count
    {
      [Token(Token = "0x600371B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170003C0")]
    public int Capacity
    {
      [Token(Token = "0x600371C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600371D")]
    [Address(RVA = "0x10A2A10", Offset = "0x10A1810", VA = "0x110A2A10")]
    public MultiSendLogBuffer()
    {
    }

    [Token(Token = "0x600371E")]
    [Address(RVA = "0x10A28A0", Offset = "0x10A16A0", VA = "0x110A28A0")]
    public void Add(SceneBattle.MultiPlayRecvData recv)
    {
    }

    [Token(Token = "0x600371F")]
    [Address(RVA = "0x10A2990", Offset = "0x10A1790", VA = "0x110A2990")]
    public SceneBattle.MultiPlayRecvData Get() => (SceneBattle.MultiPlayRecvData) null;

    [Token(Token = "0x6003720")]
    [Address(RVA = "0x10A2930", Offset = "0x10A1730", VA = "0x110A2930")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003721")]
    [Address(RVA = "0x10A29E0", Offset = "0x10A17E0", VA = "0x110A29E0")]
    static MultiSendLogBuffer()
    {
    }
  }
}

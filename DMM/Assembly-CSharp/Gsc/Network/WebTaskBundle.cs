// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebTaskBundle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200359B")]
  public class WebTaskBundle : IEnumerable<IWebTask>, IEnumerable, IEnumerator
  {
    [Token(Token = "0x400FD78")]
    [FieldOffset(Offset = "0x8")]
    private readonly List<IWebTask> Tasks;

    [Token(Token = "0x17002206")]
    public bool isDone
    {
      [Token(Token = "0x600EDBD"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EDBE"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] protected set
      {
      }
    }

    [Token(Token = "0x14000013")]
    public event Action OnFinish
    {
      [Token(Token = "0x600EDBF"), Address(RVA = "0xB1BC30", Offset = "0xB1AA30", VA = "0x10B1BC30")] add
      {
      }
      [Token(Token = "0x600EDC0"), Address(RVA = "0xB1BCB0", Offset = "0xB1AAB0", VA = "0x10B1BCB0")] remove
      {
      }
    }

    [Token(Token = "0x600EDC1")]
    [Address(RVA = "0xB1BB40", Offset = "0xB1A940", VA = "0x10B1BB40")]
    public WebTaskBundle()
    {
    }

    [Token(Token = "0x600EDC2")]
    [Address(RVA = "0xB1BBB0", Offset = "0xB1A9B0", VA = "0x10B1BBB0")]
    public WebTaskBundle(IEnumerable<IWebTask> tasks)
    {
    }

    [Token(Token = "0x600EDC3")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public WebTaskBundle(List<IWebTask> tasks)
    {
    }

    [Token(Token = "0x600EDC4")]
    public T Add<T>(T task) where T : IWebTask => (T) null;

    [Token(Token = "0x600EDC5")]
    [Address(RVA = "0xB1BA40", Offset = "0xB1A840", VA = "0x10B1BA40")]
    public void Retry()
    {
    }

    [Token(Token = "0x600EDC6")]
    [Address(RVA = "0xB1B8D0", Offset = "0xB1A6D0", VA = "0x10B1B8D0")]
    public bool HasResult(WebTaskResult result) => new bool();

    [Token(Token = "0x600EDC7")]
    [Address(RVA = "0xB1B860", Offset = "0xB1A660", VA = "0x10B1B860", Slot = "4")]
    public IEnumerator<IWebTask> GetEnumerator() => (IEnumerator<IWebTask>) null;

    [Token(Token = "0x600EDC8")]
    [Address(RVA = "0xB1BB30", Offset = "0xB1A930", VA = "0x10B1BB30", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17002207")]
    public object Current
    {
      [Token(Token = "0x600EDC9"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "7")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600EDCA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    public void Reset()
    {
    }

    [Token(Token = "0x600EDCB")]
    [Address(RVA = "0xB1B980", Offset = "0xB1A780", VA = "0x10B1B980", Slot = "6")]
    public bool MoveNext() => new bool();
  }
}

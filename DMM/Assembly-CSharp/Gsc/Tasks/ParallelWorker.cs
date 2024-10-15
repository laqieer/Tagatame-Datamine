// Decompiled with JetBrains decompiler
// Type: Gsc.Tasks.ParallelWorker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gsc.Tasks
{
  [Token(Token = "0x2003550")]
  public class ParallelWorker : MonoBehaviour
  {
    [Token(Token = "0x400FCD1")]
    [FieldOffset(Offset = "0xC")]
    private List<IEnumerator> tasks;

    [Token(Token = "0x170021CE")]
    public int TaskCount
    {
      [Token(Token = "0x600EC4E"), Address(RVA = "0xB0EF00", Offset = "0xB0DD00", VA = "0x10B0EF00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EC4F")]
    [Address(RVA = "0xB0EC50", Offset = "0xB0DA50", VA = "0x10B0EC50")]
    public void AddTask(ITask task)
    {
    }

    [Token(Token = "0x600EC50")]
    [Address(RVA = "0xB0ECF0", Offset = "0xB0DAF0", VA = "0x10B0ECF0")]
    public void AddTask(IEnumerator task)
    {
    }

    [Token(Token = "0x600EC51")]
    [Address(RVA = "0xB0EE20", Offset = "0xB0DC20", VA = "0x10B0EE20")]
    private static IEnumerator _AddTask(ITask task) => (IEnumerator) null;

    [Token(Token = "0x600EC52")]
    [Address(RVA = "0xB0EDB0", Offset = "0xB0DBB0", VA = "0x10B0EDB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600EC53")]
    [Address(RVA = "0xB0ED40", Offset = "0xB0DB40", VA = "0x10B0ED40")]
    private IEnumerator Run() => (IEnumerator) null;

    [Token(Token = "0x600EC54")]
    [Address(RVA = "0xB0EE90", Offset = "0xB0DC90", VA = "0x10B0EE90")]
    public ParallelWorker()
    {
    }
  }
}

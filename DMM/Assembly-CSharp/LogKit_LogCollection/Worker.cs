// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Worker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x2003520")]
  public class Worker : MonoBehaviour
  {
    [Token(Token = "0x400FC2D")]
    [FieldOffset(Offset = "0xC")]
    private Thread workerThread;
    [Token(Token = "0x400FC2E")]
    [FieldOffset(Offset = "0x10")]
    private List<Logger> loggers;
    [Token(Token = "0x400FC2F")]
    [FieldOffset(Offset = "0x14")]
    private bool destoried;

    [Token(Token = "0x600EB1D")]
    [Address(RVA = "0xAFE000", Offset = "0xAFCE00", VA = "0x10AFE000")]
    public static void LaunchWorker(List<Logger> loggers, GameObject node = null)
    {
    }

    [Token(Token = "0x600EB1E")]
    [Address(RVA = "0xAFDF60", Offset = "0xAFCD60", VA = "0x10AFDF60")]
    private void Awake()
    {
    }

    [Token(Token = "0x600EB1F")]
    [Address(RVA = "0xAFE1D0", Offset = "0xAFCFD0", VA = "0x10AFE1D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600EB20")]
    [Address(RVA = "0xAFE1F0", Offset = "0xAFCFF0", VA = "0x10AFE1F0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600EB21")]
    [Address(RVA = "0xAFE130", Offset = "0xAFCF30", VA = "0x10AFE130")]
    private void OnApplicationFocus(bool focusState)
    {
    }

    [Token(Token = "0x600EB22")]
    [Address(RVA = "0xAFE260", Offset = "0xAFD060", VA = "0x10AFE260")]
    private void WorkingThreadStart()
    {
    }

    [Token(Token = "0x600EB23")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public Worker()
    {
    }
  }
}

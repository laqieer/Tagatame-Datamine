// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Worker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x200352C")]
  public class Worker : MonoBehaviour
  {
    [Token(Token = "0x400FC5D")]
    [FieldOffset(Offset = "0xC")]
    private Thread workerThread;
    [Token(Token = "0x400FC5E")]
    [FieldOffset(Offset = "0x10")]
    private List<Logger> loggers;
    [Token(Token = "0x400FC5F")]
    [FieldOffset(Offset = "0x14")]
    private bool destoried;

    [Token(Token = "0x600EB71")]
    [Address(RVA = "0xB1BDD0", Offset = "0xB1ABD0", VA = "0x10B1BDD0")]
    public static void LaunchWorker(List<Logger> loggers, GameObject node = null)
    {
    }

    [Token(Token = "0x600EB72")]
    [Address(RVA = "0xB1BD30", Offset = "0xB1AB30", VA = "0x10B1BD30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600EB73")]
    [Address(RVA = "0xAFE1D0", Offset = "0xAFCFD0", VA = "0x10AFE1D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600EB74")]
    [Address(RVA = "0xB1BF90", Offset = "0xB1AD90", VA = "0x10B1BF90")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600EB75")]
    [Address(RVA = "0xB1BF00", Offset = "0xB1AD00", VA = "0x10B1BF00")]
    private void OnApplicationFocus(bool focusState)
    {
    }

    [Token(Token = "0x600EB76")]
    [Address(RVA = "0xB1C000", Offset = "0xB1AE00", VA = "0x10B1C000")]
    private void WorkingThreadStart()
    {
    }

    [Token(Token = "0x600EB77")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public Worker()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ExceptionMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000DD")]
[AddComponentMenu("")]
public class ExceptionMonitor : MonoBehaviour
{
  [Token(Token = "0x40003D6")]
  [FieldOffset(Offset = "0x0")]
  private static bool mExceptionStop;
  [Token(Token = "0x40003D7")]
  [FieldOffset(Offset = "0x4")]
  private static ExceptionMonitor mInstnace;
  [Token(Token = "0x40003D8")]
  [FieldOffset(Offset = "0xC")]
  private bool bMessageDraw;
  [Token(Token = "0x40003D9")]
  [FieldOffset(Offset = "0x10")]
  private Coroutine m_OutputRoutine;

  [Token(Token = "0x170000D7")]
  public static bool IsExceptionStop
  {
    [Token(Token = "0x6000534"), Address(RVA = "0xC6F620", Offset = "0xC6E420", VA = "0x10C6F620")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000D8")]
  private static string CrashLogTextPath
  {
    [Token(Token = "0x6000535"), Address(RVA = "0xC6F5E0", Offset = "0xC6E3E0", VA = "0x10C6F5E0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000536")]
  [Address(RVA = "0xC6F490", Offset = "0xC6E290", VA = "0x10C6F490")]
  public static void Start()
  {
  }

  [Token(Token = "0x6000537")]
  [Address(RVA = "0xC6EE20", Offset = "0xC6DC20", VA = "0x10C6EE20")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000538")]
  [Address(RVA = "0xC6EED0", Offset = "0xC6DCD0", VA = "0x10C6EED0")]
  private void HandleLog(string logString, string stackTrace, LogType type)
  {
  }

  [Token(Token = "0x6000539")]
  [Address(RVA = "0xC6F3D0", Offset = "0xC6E1D0", VA = "0x10C6F3D0")]
  private void SendLogMessage(string logString, string stackTrace)
  {
  }

  [Token(Token = "0x600053A")]
  [Address(RVA = "0xC6F250", Offset = "0xC6E050", VA = "0x10C6F250")]
  private void MessageBoxDefault()
  {
  }

  [Token(Token = "0x600053B")]
  [Address(RVA = "0xC6F090", Offset = "0xC6DE90", VA = "0x10C6F090")]
  private void MessageBoxDLL()
  {
  }

  [Token(Token = "0x600053C")]
  [Address(RVA = "0xC6F340", Offset = "0xC6E140", VA = "0x10C6F340")]
  private IEnumerator OutputCrashInfo(string logString, string stackTrace, Action onComplete)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x600053D")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ExceptionMonitor()
  {
  }
}

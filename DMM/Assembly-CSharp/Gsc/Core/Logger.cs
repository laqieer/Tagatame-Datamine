// Decompiled with JetBrains decompiler
// Type: Gsc.Core.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gsc.Core
{
  [Token(Token = "0x20035E1")]
  public class Logger
  {
    [Token(Token = "0x400FE14")]
    [FieldOffset(Offset = "0x4")]
    private static bool initialized;

    [Token(Token = "0x14000014")]
    public static event Application.LogCallback Callback
    {
      [Token(Token = "0x600F01D"), Address(RVA = "0xB0C990", Offset = "0xB0B790", VA = "0x10B0C990")] add
      {
      }
      [Token(Token = "0x600F01E"), Address(RVA = "0xB0CA20", Offset = "0xB0B820", VA = "0x10B0CA20")] remove
      {
      }
    }

    [Token(Token = "0x600F01F")]
    [Address(RVA = "0xB0C250", Offset = "0xB0B050", VA = "0x10B0C250")]
    public static void Init()
    {
    }

    [Token(Token = "0x600F020")]
    [Address(RVA = "0xB0C060", Offset = "0xB0AE60", VA = "0x10B0C060")]
    public static void HandleLog(string logMessage, string stackTrace, LogType logType)
    {
    }

    [Token(Token = "0x600F021")]
    [Address(RVA = "0xB0C740", Offset = "0xB0B540", VA = "0x10B0C740")]
    private static void _HandleLog(string logMessage, string stackTrace, LogType logType)
    {
    }

    [Token(Token = "0x600F022")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Logger()
    {
    }
  }
}

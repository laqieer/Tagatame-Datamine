// Decompiled with JetBrains decompiler
// Type: SRPG.CriticalSections
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000ED7")]
  [Flags]
  public enum CriticalSections
  {
    [Token(Token = "0x4002DA4")] Default = 1,
    [Token(Token = "0x4002DA5")] Network = 2,
    [Token(Token = "0x4002DA6")] SceneChange = 4,
    [Token(Token = "0x4002DA7")] ExDownload = 8,
  }
}

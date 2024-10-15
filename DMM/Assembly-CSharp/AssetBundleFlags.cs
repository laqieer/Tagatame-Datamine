// Decompiled with JetBrains decompiler
// Type: AssetBundleFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007C")]
[Flags]
public enum AssetBundleFlags
{
  [Token(Token = "0x400026A")] Compressed = 1,
  [Token(Token = "0x400026B")] RawData = 2,
  [Token(Token = "0x400026C")] Required = 4,
  [Token(Token = "0x400026D")] Scene = 8,
  [Token(Token = "0x400026E")] Tutorial = 16, // 0x00000010
  [Token(Token = "0x400026F")] Multiplay = 32, // 0x00000020
  [Token(Token = "0x4000270")] StreamingAsset = 64, // 0x00000040
  [Token(Token = "0x4000271")] TutorialMovie = 128, // 0x00000080
  [Token(Token = "0x4000272")] Persistent = 256, // 0x00000100
  [Token(Token = "0x4000273")] DiffAsset = 512, // 0x00000200
  [Token(Token = "0x4000274")] iOSRequire = 1024, // 0x00000400
  [Token(Token = "0x4000275")] Home = 2048, // 0x00000800
  [Token(Token = "0x4000276")] PackLarge = 4096, // 0x00001000
}

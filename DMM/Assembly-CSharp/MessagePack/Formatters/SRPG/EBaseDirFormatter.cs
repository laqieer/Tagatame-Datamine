﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EBaseDirFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000576")]
  public sealed class EBaseDirFormatter : 
    IMessagePackFormatter<SkillReactionCondParam.EBaseDir>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019B0")]
    [Address(RVA = "0x69B360", Offset = "0x69A160", VA = "0x1069B360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillReactionCondParam.EBaseDir value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019B1")]
    [Address(RVA = "0x69B310", Offset = "0x69A110", VA = "0x1069B310", Slot = "5")]
    public SkillReactionCondParam.EBaseDir Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillReactionCondParam.EBaseDir();
    }

    [Token(Token = "0x60019B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EBaseDirFormatter()
    {
    }
  }
}
// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidBpHealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EFC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidBpHealParam
  {
    [Token(Token = "0x400827D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400827E")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidBpHealParam.HealInfo[] heal_infos;

    [Token(Token = "0x6007EB1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidBpHealParam()
    {
    }

    [Token(Token = "0x2001EFD")]
    [MessagePackObject(true)]
    [Serializable]
    public class HealInfo
    {
      [Token(Token = "0x400827F")]
      [FieldOffset(Offset = "0x8")]
      public int min_count;
      [Token(Token = "0x4008280")]
      [FieldOffset(Offset = "0xC")]
      public int max_count;
      [Token(Token = "0x4008281")]
      [FieldOffset(Offset = "0x10")]
      public int need_coin;

      [Token(Token = "0x6007EB2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public HealInfo()
      {
      }
    }
  }
}
